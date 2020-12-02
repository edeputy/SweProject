using System;
namespace ConsoleApp1
{
    // Adding a Member class
    public class Member
    {

        private string name;

        //method to add a global member
        public static string addMemberMenu()
        {
            Console.WriteLine("Enter a Member:");

            string name = Console.ReadLine();

            return name;

        }
        //method
        public static string removeMemberMenu()
        {
            return "nothing";
        }

        public Member(string name)
        {
            this.name = name;
        }

        public override string ToString()
        {
            return name;
        }
    }
}
