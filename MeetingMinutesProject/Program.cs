 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MeetingMinutesProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Header();
            Spacer();

            Menu();

        }

        static void Header()
        {
            Console.WriteLine("Meeting Minutes Management Software");
        }

        static void Meeting()
        {
            Spacer();
            

            Console.WriteLine("Enter Team Member Recording Meeting Minutes: ");
            string minuteRecorder = Console.ReadLine();
            
            Spacer();
            Console.WriteLine("Enter Team Member Leading Meeting: ");
            string meetingLeader = Console.ReadLine();
            Spacer();
            Console.WriteLine("Enter Date of Team Meeting (Enter Date in \"MMDDYY\" format): ");
            string meetingDate = Console.ReadLine();
            string meetingName = ("Minutes" + meetingDate );

            //meeting list
            List<string> meetingType = new List<string>();
            meetingType.Add("Development");
            meetingType.Add("Marketing");
            meetingType.Add("Production");
            meetingType.Add("Distribution");
            meetingType.Add("Legal");
            meetingType.Add("All");


            Spacer();
            Console.WriteLine("Please Select a Meeting Type from the options below.");
            Console.WriteLine("1 | Development");
            Console.WriteLine("2 | Marketing");
            Console.WriteLine("3 | Production");
            Console.WriteLine("4 | Distribution");
            Console.WriteLine("5 | Legal");
            Console.WriteLine("6 | All");
            int meetingOption = int.Parse(Console.ReadLine());
            Spacer();
            string meetType = "";
            switch (meetingOption)
            {
                case 1:
                    meetType = meetingType[0];
                    break;
                case 2:
                    meetType = meetingType[1];
                    break;
                case 3:
                    meetType = meetingType[2];
                    break;
                case 4:
                    meetType = meetingType[3];
                    break;
                case 5:
                    meetType = meetingType[4];
                    break;
                case 6:
                    meetType =meetingType[5];
                    break;
                default:
                    break;
            }

          
            string topAnswer = "N";
            string meetingTopic;
            string meetingNotes;
            string txtName = meetingName + ".txt";
            
           

                do
            {
                Console.WriteLine("Enter Meeting Topic: ");
                meetingTopic = Console.ReadLine();
                
                Spacer();
                Console.WriteLine("Enter Meeting Notes for {0}: ", meetingTopic);
                meetingNotes = Console.ReadLine();
                Spacer();

                

                Console.WriteLine("Would you like to enter notes for another topic? (\"Y\" or \"N\") ");
                topAnswer = Console.ReadLine().ToUpper();
                Spacer();
                
                if (topAnswer == "N")
                {
                    
                    Spacer();
                    Console.WriteLine("Recorder: " +minuteRecorder);
                    Console.WriteLine("Leader: " +meetingLeader);                    
                    Console.WriteLine("Meeting Type: " +meetType);
                    Spacer();
                    Console.WriteLine("Meeting Topic: " + meetingTopic);
                    Console.WriteLine("Meeting Notes: " + meetingNotes);
                    Spacer2();

                    Console.WriteLine("Enter number from options below");
                    Console.WriteLine("1 | Main Menu");
                    Console.WriteLine("2 | Exit");
                    int ender = int.Parse(Console.ReadLine());

                    if (ender == 1)
                    {
                        Console.Clear();
                        Header();
                        Spacer();
                        Menu();
                    }
                    else if (ender == 2)
                    {
                        Spacer();
                        Console.WriteLine("Goodbye");                    
                    }
                


                  
                }
                else if (topAnswer == "Y")
                {
                   
                }
            }
            while (topAnswer == "Y");

            StreamWriter write = new StreamWriter(txtName);

            using (write)
            {
                write.WriteLine("Muse Media Group");
                write.WriteLine("456 Dream Street \nCleveland, OH 44118");
                write.WriteLine("\r\n");

                write.WriteLine("Meeting Minutes");
                write.WriteLine("\r\n");
           
            
                write.WriteLine("Recorder: " + minuteRecorder);
                write.WriteLine("Leader: " + meetingLeader);

                write.WriteLine("Meeting Type: " + meetType);
                write.WriteLine("\r\n");

                write.WriteLine("Meeting Topic: " + meetingTopic);
                write.WriteLine("Meeting Notes: " + meetingNotes);
                write.WriteLine("\r\n");
            }

        }


        static void TeamMembers()
        {
            
            Console.WriteLine("View Team");
            Console.WriteLine("Choose a team from the options below");
            Spacer();
            Console.WriteLine("1 | Development Team");
            Console.WriteLine("2 | Marketing Team");
            Console.WriteLine("3 | Production Team");
            Console.WriteLine("4 | Distribution Team");
            Console.WriteLine("5 | Legal Team");
            Console.WriteLine("6 | All");

            int teamOptions = int.Parse(Console.ReadLine());
            Spacer2();

            
            Dictionary<string, string> members = new Dictionary<string, string>();
            members.Add("Penelope Santos", "Marketing");
            members.Add("Janet Smith", "Marketing");
            members.Add("Thomas Dent", "Marketing");
            members.Add("Leonardo Collins", "Distribution");
            members.Add("William White", "Distribution");
            members.Add("Kate Poppin", "Distribution");
            members.Add("Nicole Zurich", "Legal");
            members.Add("Jennifer McBride", "Legal");
            members.Add("Claire Huxtable", "Legal");
            members.Add("Ronald Grant", "Development");
            members.Add("Lia Donato", "Development");
            members.Add("Kenneth Harris", "Development");
            members.Add("Anthony Hill", "Production");
            members.Add("Marcus Payne", "Production");
            members.Add("Matthew Colby", "Production");
          


            switch (teamOptions)
            {
                case 1:
                    Console.WriteLine("Development Team");
                    Spacer();

                    foreach (KeyValuePair<String, string> member in members)
                    {
                        if (member.Value == "Development")
                        {
                            Console.WriteLine(member.Key);
                        }                      
                    }
                    Spacer2();
                    break;
                case 2:
                    Console.WriteLine("Marketing Team");
                    Spacer();

                    foreach (KeyValuePair<String, string> member in members)
                    {
                        if (member.Value == "Marketing")
                        {
                            Console.WriteLine(member.Key);
                        }                      
                    }
                    Spacer2();
                    break;
                case 3:
                    Console.WriteLine("Production Team");
                    Spacer();
                    foreach (KeyValuePair<String, string> member in members)
                    {
                        if (member.Value == "Production")
                        {
                            Console.WriteLine(member.Key);
                        }                      
                    }
                    Spacer2();
                    break;
                case 4:
                    Console.WriteLine("Distribution Team");
                    Spacer();
                    foreach (KeyValuePair<String, string> member in members)
                    {
                        if (member.Value == "Distribution")
                        {
                            Console.WriteLine(member.Key);
                        }                      
                    }
                    Spacer2();
                    break;
                case 5:
                    Console.WriteLine("Legal Team");
                    Spacer();
                    foreach (KeyValuePair<String, string> member in members)
                    {
                        if (member.Value == "Legal")
                        {
                            Console.WriteLine(member.Key);
                        }                       
                    }
                    Spacer2();
                    break;
                case 6:
                    Console.WriteLine("All Teams");
                    Spacer();

                    foreach (KeyValuePair<string, string> member in members)
                    {
                        Console.WriteLine(member.Key + " (" +member.Value + ")");
                    }
                    Spacer2();
                    break;
                default:
                    Console.WriteLine("Please select a number option provided in the Team Menu.");
                    teamOptions = int.Parse(Console.ReadLine());
                    break;

            }


            Console.WriteLine("Enter number from options below");
            Console.WriteLine("1 | Main Menu");
            Console.WriteLine("2 | Exit");
            int ender = int.Parse(Console.ReadLine());

            if (ender == 1)
            {
                Console.Clear();
                Header();
                Spacer();
                Menu();
            }
            else if (ender == 2)
            {
                Spacer();
                Console.WriteLine("Goodbye");
            }

        }

       
        static void Menu()
        {
            
            Console.WriteLine("Menu");
            Console.WriteLine("Choose a number from the options below.");
            Spacer();
            Console.WriteLine("1 | Create Meeting");
            Console.WriteLine("2 | View Team");
            Console.WriteLine("3 | Exit");

            int menuOptions = int.Parse(Console.ReadLine());
            Spacer();
            switch (menuOptions)
            {
                case 1:
                    Console.Clear();
                    Header();
                    Spacer();
                    Meeting();
                    break;
                case 2:
                    Console.Clear();
                    Header();
                    Spacer();
                    TeamMembers();
                    break;
                case 3:
                    Console.WriteLine("Goodbye.");
                    break;
                default:
                    Console.WriteLine("Please select a number option provided in the Meeting Minutes Menu.");
                    menuOptions = int.Parse(Console.ReadLine());
                    break;
            }

            
        }

        static void Spacer()
        {
            Console.WriteLine();
        }

        static void Spacer2()
        {
            Console.WriteLine();
            Console.WriteLine();
        }

        static void Spacer3()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
        }
    }

    
}
