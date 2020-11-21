using System;

namespace ConsoleApp1
{
    class Program
    {
        string[] projectMembers;
        static void Main(string[] args)
        {
            string[] projectNames;
            string[] projectMembers;
            int codingHours, designHours, 
                testingHours, projectManagementHours, requirementsAnalysisHours;

            CreateTeamMember();
          
        }

        public static void CreateTeamMember()
        {
            Console.WriteLine("Enter Number of Team Members in Project");
            int numberOfMembers = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < numberOfMembers; i++)
            {
                Console.WriteLine("Enter Team Member Name");
                projectMembers [i] = Console.ReadLine();
            }
        }

        static void ManageTeamMembers()
        {

        }

        static void MemberProject()
        {

        }

        static void HoursExpended()
        {

        }

    }
}
