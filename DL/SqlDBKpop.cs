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
    public class SqlDBKpop
    {
        static string connectionString
           = "Data Source =LAPTOP-GSQAHJBR; Initial Catalog = KPOP_DB; Integrated Security = True;";


        SqlConnection sqlConnection;

        public SqlDBKpop()
        {
            sqlConnection = new SqlConnection(connectionString);
        }
        
        public List<Group> GetGroups()
        {
            string selectStatement = "SELECT GroupID, Name FROM Kpop_GroupName";

            SqlCommand selectCommand = new SqlCommand(selectStatement, sqlConnection);

            sqlConnection.Open();
            List<Group> group = new List<Group>();

            SqlDataReader reader = selectCommand.ExecuteReader();

            
            while (reader.Read())
            {
                string GroupID = reader["GroupID"].ToString();
                string Name = reader["Name"].ToString();


                Group readGroup = new Group();
                readGroup.GroupID = GroupID;
                readGroup.Name = Name;

                group.Add(readGroup);
            }
            sqlConnection.Close();

            return group;

        }


        public int AddGroup(string GroupID, string Name)

        {
            int success;

            string insertStatement = "INSERT INTO Kpop_GroupName VALUES (@GroupID, @Name)";
            
            SqlCommand insertCommand = new SqlCommand(insertStatement, sqlConnection);

            insertCommand.Parameters.AddWithValue("@GroupID", GroupID);
            insertCommand.Parameters.AddWithValue("@Name", Name);
            sqlConnection.Open();

            success = insertCommand.ExecuteNonQuery();
            sqlConnection.Close();
            return success;




        }

        public int UpdateGroup(string GroupID, string Name)
        {
            int success;

            
            string UPDATE = $"UPDATE Kpop_GroupName SET Name = @Name WHERE GroupID = @GroupID";
            SqlCommand updateCommand = new SqlCommand(UPDATE, sqlConnection);
            sqlConnection.Open();

            updateCommand.Parameters.AddWithValue("@GroupID", GroupID);
            updateCommand.Parameters.AddWithValue("@Name", Name);

            success = updateCommand.ExecuteNonQuery();
            sqlConnection.Close();



            return success;
        }

        public int DeleteGroup(string GroupID)
        {
            int success;
            

            string DELETE = $"DELETE FROM Kpop_GroupName WHERE GroupID = @GroupID";
            SqlCommand delcom = new SqlCommand(DELETE, sqlConnection);
            sqlConnection.Open();

            delcom.Parameters.AddWithValue("@GroupID", GroupID);

            success = delcom.ExecuteNonQuery();

            sqlConnection.Close();

            return success;


        }

    }
}
