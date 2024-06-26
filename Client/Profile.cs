using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelsa;
using Client;



namespace Client
{
    public class Profile
    {
        public void DisplayGroup(Group group)
        {
            Console.WriteLine("Group Name: " + group.Name);
            Console.WriteLine("Group Members: " + group.Members);
            Console.WriteLine("Fandom Name: " + group.FandomName);
            Console.WriteLine("Debut Date: " + group.DebutDate);
            Console.WriteLine("Company: " + group.Company);
        }
    }

}