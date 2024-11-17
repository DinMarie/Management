using DL;
using Modelsa;
using KpopBL;


namespace Client
{
    internal class Program
    { //
        static void Main(string[] args)
        {
            UserGetServices getServices = new UserGetServices();

            var groups = getServices.GetAllGroups();

            foreach (var item in groups)
            {
                Console.WriteLine(item.GroupID);
                Console.WriteLine(item.Name);
                Console.WriteLine();
            }

            //SqlDbData.Connect();
        }
    }
}