using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    // This is the logic for "Create Project" in the MainMenu
    public class Project
    {
        //if Risk feature will be added, it should have a property right here
        public Member owner;
        public string name;
        public string description;
        private List<Member> projectMembers = new List<Member>();
        private List<Member> globalMembers = new List<Member>();
        private List<string> requirements = new List<string>();


        public Project(ref List<Member> globalMembers)
        {
            Console.WriteLine("Owner of the Project");
            this.owner = new Member(Console.ReadLine());

            Console.WriteLine("Name of the Project");
            this.name = Console.ReadLine();

            Console.WriteLine("Enter description of the Project");
            this.description = Console.ReadLine();

            Console.WriteLine("Enter project requirements");
            this.requirements.AddRange(Console.ReadLine().Split(","));

            // Adding a member to project from the member list that you add from MainMenu
            Console.WriteLine("Add members to project");
            int index = 1;
            foreach (Member item in globalMembers)
            {
                Console.WriteLine(index+"."+item.ToString() + "\n");
                index++;
               
            }
            string selection = Console.ReadLine();
            Member selectmember = globalMembers[Int32.Parse(selection) - 1];
            projectMembers.Add(selectmember);
            // Removing a member from a project should be added below if necessary
            // should be similiar to adding


        }
        //function for saving information in a file or database
        public void Save()
        {
               
        }
        //ading requirement to project functions
        public void addRequirement(String requirement)
        {
            this.requirements.Add(requirement);
        }
        
        public void addMember(Member member)
        {
            this.projectMembers.Add(member);
        }

        public override string ToString()
        {
            return (
                "\t"+this.name + "\n" +
                "\tOwner: " + owner + "\n" +
                "\tDescription: " + description + "\n" +
                "\tMembers (" +projectMembers.Count+"): \n" + GetPrintableList<Member>(projectMembers) + "\n"+
                "\tRequirements: (" + requirements.Count + "): \n" + GetPrintableList<string>(requirements) + "\n"
            );
        }
        // method for printing generic information
        public string GetPrintableList<T>(List<T> list)
        {
            string res = "";

            foreach(T item in list)
            {
                res += "\t\t" + item.ToString() + "\n";
            }

            return res;
        }
    }


}
