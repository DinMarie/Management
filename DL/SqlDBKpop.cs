using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Modelsa;
using DL;

namespace DL
{
    public class sqlDBKpop
    {
        static string connectionString
           = "Data Source =DESKTOP-UE2RTA0; Initial Catalog = KPOP_DB; Integrated Security = True;";

        //SQLEXPRESS


        static SqlConnection sqlConnection = new SqlConnection(connectionString);

        public static void Connect()
        {
            sqlConnection.Open();
        }


        public static List<Group> GetGroups()
        {
            string selectStatement = "SELECT ID, Kpop_Name FROM Kpop_GroupName";

            SqlCommand selectCommand = new SqlCommand(selectStatement, sqlConnection);
            sqlConnection.Open();
            SqlDataReader reader = selectCommand.ExecuteReader();

            List<Group> group = new List<Group>();
            while (reader.Read())
            {
                string ID = reader["ID"].ToString();
                string Name = reader["Kpop_Name"].ToString();


                Group readGroup = new Group();
                readGroup.ID = ID;
                readGroup.Name = Name;

                group.Add(readGroup);
            }
            sqlConnection.Close();

            return group;

        }


        public static int AddGroup(string ID, string Kpop_Name)

        {
            int success;

            string insertStatement = "INSERT INTO Kpop_GroupName VALUES (@ID, @Kpop_Name)";
            sqlConnection.Open();
            SqlCommand insertCommand = new SqlCommand(insertStatement, sqlConnection);

            insertCommand.Parameters.AddWithValue("@ID", ID);
            insertCommand.Parameters.AddWithValue("@Kpop_Name", Kpop_Name);


            success = insertCommand.ExecuteNonQuery();
            sqlConnection.Close();
            return success;




        }

        public int UpdateGroup(string ID, string Kpop_Name)
        {
            int success;

            sqlConnection.Open();
            string UPDATE = $"UPDATE Kpop_GroupName SET KpopName = @ID, @KpopName ";
            SqlCommand updateCommand = new SqlCommand(@UPDATE, sqlConnection);

            updateCommand.Parameters.AddWithValue("@ID", ID);
            updateCommand.Parameters.AddWithValue("@Kpop_Name", Kpop_Name);

            success = updateCommand.ExecuteNonQuery();
            sqlConnection.Close();



            return success;
        }

        public int DeleteGroup(string ID, string Kpop_Name)
        {
            int success;
            sqlConnection.Open();

            string DELETE = $"DELETE FROM Kpop_Group WHERE ID, Kpop_Name = @ID, @Kpop_Name";
            SqlCommand delcom = new SqlCommand(@DELETE, sqlConnection);

            delcom.Parameters.AddWithValue("@ID", ID);
            delcom.Parameters.AddWithValue("@KpopName", Kpop_Name);

            success = delcom.ExecuteNonQuery();

            sqlConnection.Close();

            return success;


        }

    }
}
