using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    // This will be the MainMenu where we will be adding new features if necessary
    public class MainMenu
    {
        // Global variables for storing information so that it may be easily accessed 
        private List<Member> members = new List<Member>();
        private List<Project> projects = new List<Project>();

        static void Main(string[] args)
        {
            // Main Method is called from MainMenu.cs
            
            MainMenu menu = new MainMenu();

            // This is the "UI" of our code from Show() method
            menu.Show();

        }



        public void Show()
        {
            Console.Clear();
            // IF new feature added, add below code like this

            Console.WriteLine("Choose an option:");
            Console.WriteLine("1) Create Project");
            Console.WriteLine("2) List Projects (" + this.projects.Count + ")");
            Console.WriteLine("3) List Members (" +  this.members.Count + ")");
            Console.WriteLine("4) Add Member");
            // Console.WriteLine("5) New Feature");
            Console.Write("\r\nSelect an option: ");


            //Switch is the logic behind the menu, this is where you call new features
            switch (Console.ReadLine())
            {
                case "1":
                    Project project = new Project(ref members);
                    this.projects.Add(project);

                    project.Save();

                    break;
                case "2":
                    this.printItems<Project>("Projects", this.projects);

                    break;

                case "3":
                    this.printItems<Member>("Members", this.members);

                    break;

                case "4":
                    this.members.Add(new Member(Member.addMemberMenu()));

                    break;
                
                default:
                    break;

            }

            this.Show();
        }
        // In case there should be a feature to edit or remove members
        public void showMemberMenu()
        {

        }

        // This is a Generic method that prints anything that will be fed to it
        
        public void printItems<T>(string heading, List<T> items)
        {
            Console.WriteLine("-----");
            Console.WriteLine(heading +":");

            foreach (T item in items)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine("-----");
            Console.WriteLine("Press enter to return to main menu");
            Console.ReadKey();
        }
    }
}