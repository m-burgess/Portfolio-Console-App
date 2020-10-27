using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PotfolioConsoleApp
{
    public class Program
    {
        
        public static void Main(string[] args)
        {
            
            //While loop ot keep program open.
            bool showMenu = true;
            while (showMenu)
            {
                //As long as true, app will stay open. if false, app will close.
                showMenu = MainMenu.WriteMainMenu();
            }
            
           
            
        }
    }

    internal class Me
    {
        
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public List<string> WorkHistory = new List<string>();

         public List<string> References = new List<string>();

        //Create a me object
        public Me(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;

            WorkHistory.Add("2004-2005: Mcdonalds - Kitchen Staff");
            WorkHistory.Add("2006-2008: Conklin's Barn II Dinner Theatre - Kitchen Staff");
            WorkHistory.Add("2008-Present: Advanced Technology Services - Repair/Calibration Technician II");

            References.Add("Cory Vance - Youth Pastor at Rockchurch - Friend: 309-669-7767 ");
            References.Add("Geoff Bricka - CSE software - Developer - Former co worker: 309-6484277 ");
            References.Add("Amanda Rios - State Farm - Developer - Friend: 309-453-8254 ");

        }

        //used override on ToString method to return Id - Name;
        public override string ToString()
        {
            return FirstName + " - " + LastName;
        }
 
    }

    

    //MainMenu class to hold the functions to build the menu.
    public class MainMenu
    {
        public static bool WriteMainMenu()
        {
            Me me = new Me("Michael","Burgess");
            
            //Create Strings for the menu
            string introduction = "Hi, my name is Michael Burgess. I am looking for a career change into development. \nI have a strong desire to learn and grow in this field. Please select a number to view my resume. \nThank you for your time!";
            string workHistory = "\n1. Work History";
            string references = "2. References";
            string experience = "3. Experience";
            string exit = "4. Exit";
            string makeSelection = "\r\nPlease make a selection:";

            //Displaye the menu using Console.Writeline.
            Console.WriteLine(introduction);
            Console.WriteLine(workHistory);
            Console.WriteLine(references);
            Console.WriteLine(experience);
            Console.WriteLine(exit);

            Console.WriteLine(makeSelection);

                //Use a switch with cases to perform requested functions. Return true to go back to the main menu, false to exit.
                switch (Console.ReadLine())
                {
                    case "1":

                    Console.Clear();

                    foreach (string job in me.WorkHistory)
                    {
                        Console.WriteLine("\n"+job);

                    }

                    Console.WriteLine("\nPress enter to continue...");
                    Console.ReadLine();
                    Console.Clear();

                    return true;


                    case "2":
                        
                         foreach (string reference in me.References)
                    {
                        Console.WriteLine("\n"+reference);

                    }

                    Console.WriteLine("\nPress enter to continue...");
                    Console.ReadLine();
                    Console.Clear();
                        return true;

                    //Experience
                    case "3":
                    
                    Console.Clear();

                    Console.WriteLine("\n-Built an application for work to extract specific data from up to 26 pdf files and saved the data to an excel sheet. Originally built in java, then JavaFx, then C#. Caterpillar was dropping support for java which is why i rebuilt it in C#. Each build is on my github page. you can see how i improved on each build.");
                    Console.WriteLine("\n-Built a basic java application to convert pdf files to text files. This was a backup for church when the online service went down that provides lyrics for songs.");
                    Console.WriteLine("\n-Built a tool in C# that will rename 5 test result files with a specific format, move them to the correct network location, check the first point and display a message saying what it was. This was needed due to excel spreadsheets not catching the error, Write in reference points for one of the test. this was done manually every week, then opens the global template to finish the paperwork.");
                    Console.WriteLine("\n-Built a tool in C# that displays the current system time in real time, takes calibraiton information in textboxes, gives you the needed setpoints depending on which radio button is selected(Winter months or summer months), gives you a time stamp + 1 minutes for each setpoint. In our process, this tells us when to collect the setpoint and is referred to in later paperwork.");
                    Console.WriteLine("\n-Built my first .NET core app on linux using visual studio code. It is this console application.");
    

                    Console.WriteLine("\nPress enter to continue...");

                    Console.ReadLine();
                    
                    Console.Clear();
                        
                        return true;

                    //exit the application
                    case "4":

                        return false;


                    default:
                        //If number entered outside of range, go back to the main menu.
                        Console.WriteLine("Please enter a number 1-4.");
                        Console.WriteLine("Press enter to continue...");
                        Console.ReadLine();
                        Console.Clear();
                        return true;

                }
            
            
           
        }
    }


}
