// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;
using DL;
using BL;
using Modelsa;
using Client;


namespace Client
{


    internal class Program
    {
        static void Main(string[] args)
        {

            //    sqlDBKpop.Connect();

            //      GroupInfo groupList = new GroupInfo();
            Console.WriteLine("Welcome to Magic Shop WIKIGroup Informatiion Site!");
            Console.WriteLine();


            List<Group> groupFromDB = sqlDBKpop.GetGroups();



            Console.WriteLine("Choice The Number");
            Console.WriteLine();
            while (true)
            {
                Console.WriteLine("Select The Process");
                Console.WriteLine();
                Console.WriteLine("1. Kpop GroupList");
                Console.WriteLine("2. Add Kpop Group Information");
                Console.WriteLine("3. Exit");
                Console.WriteLine("Please a Number Choice:");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":


                        //  var group = new g.GetGroup();

                        foreach (var item in groupFromDB)
                        {
                            Console.WriteLine(item.ID);
                            Console.WriteLine(item.Name);

                        }


                        break;
                    case "2":
                        Console.WriteLine("No. of Group");
                        string ID = Console.ReadLine();

                        Console.WriteLine("Input a KPOP Group Name: ");
                        string Kpop_Name = Console.ReadLine();

                        Console.WriteLine("Successful Added");
                        Console.WriteLine();
                        break;

                    case "3":
                        Console.WriteLine();
                        Console.WriteLine("THANKYOU");
                        return;

                    default:
                        Console.WriteLine();
                        Console.WriteLine("SELECT ONLY IN THREE OPTION");
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            }
        }
    }
}
