using System;

namespace ConsoleApp1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string[] projectNames;                          //Name of the project(s)
            string[] projectMembers;                        //Name of team member(s)

            int codingHours = 0;                            //
            int designHours = 0;                            //Number of hours in each part of project
            int testingHours = 0;                           //
            int projectManagementHours = 0;                 //
            int requirementsAnalysisHours = 0;              //

            projectNames = ProjectInfo();
            projectMembers = CreateTeamMember();
            PrintTeamMembers(projectNames,projectMembers);
            HoursExpended();
          
        }

        /*
         * Currently just displays the name of the project. Might
         * need more information. WIP
         */
        static string [] ProjectInfo()
        {
            Console.WriteLine("How many projects will the current group be involved in?");
            int numberOfProjects = Convert.ToInt32(Console.ReadLine());
            string[] _projectNames = new string[numberOfProjects];
            Console.WriteLine("Enter Project Names");
            for (int i = 0; i < numberOfProjects; i++)
            {
                _projectNames[i] = Console.ReadLine();
            }
            return _projectNames;
        }

        /*
         * Asks for the number of team members for a project and returns their
         * names. 
         */
        static string [] CreateTeamMember()
        {
            
            Console.WriteLine("Enter Number of Team Members in Project");
            int _numberOfMembers = Convert.ToInt32(Console.ReadLine());
            string[] _projectMembers = new string[_numberOfMembers];
            Console.WriteLine("Enter Team Member Name");
            for (int i = 0; i < _projectMembers.Length; i++)
            {
                _projectMembers[i] = Console.ReadLine();
            }
            return _projectMembers;
            
        }

        /*
         * Displays hours worked in for each team member
         * for each part of the project. Not sure what to do with
         * fully yet.
         */
        static void HoursExpended()
        {
            int _codingHours = 0;
            Console.WriteLine(_codingHours);
            int _designHours = 0;
            Console.WriteLine(_designHours);
            int _testingHours = 0;
            Console.WriteLine(_testingHours);
            int _managingHours = 0;
            Console.WriteLine(_managingHours);
            int _analysisHours = 0;
            Console.WriteLine(_analysisHours);

        }

        /*
         * Prints out a list of project names and team members from
         * an array of strings. 
         */
        static void PrintTeamMembers(string[] _projectNames,string[] _projectMembers)
        {
            Console.WriteLine("Current projects:");
            for (int i = 0; i < _projectNames.Length; i++)
            {
                Console.WriteLine(_projectNames[i] + " ");
            }

            Console.WriteLine("Members on current project:");
            for (int i = 0; i < _projectMembers.Length; i++)
            {
                Console.Write(_projectMembers[i] + " ");
            }
        }

    }
}
