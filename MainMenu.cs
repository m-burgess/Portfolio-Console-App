using System;
using System.Collections.Generic;

namespace PotfolioConsoleApp
{
    //MainMenu class to hold the functions to build the menu.
    public class MainMenu
    {

        
        public static bool WriteMainMenu()
        {
            
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

                    List<Job> jobList = new List<Job>();

                    Jobs jobs = new Jobs(jobList);

                     Job job1 = new Job(1,"Mcdonalds","Kitchen Staff","2004","2005");
                     Job job2 = new Job(2,"Conklin's Barn II Dinner Theatre","Kitchen Staff","2006","2008");
                     Job job3 = new Job(3,"Advanced Technology Services","Repair/Calibration technician II","2008","Present");

                     jobs.AddJob(job1);
                     jobs.AddJob(job2);
                     jobs.AddJob(job3);

                     

                    Console.Clear();

                    foreach (Job job in jobs.JobList)
                    {
                        Console.WriteLine("\n"+job.Id + " - " + job.JobName + " - " + job.JobTitle + " - " + job.EmploymentRange);

                    }

                    Console.WriteLine("\nPress enter to continue...");
                    Console.ReadLine();
                    Console.Clear();

                    return true;


                    case "2":

                    List<Person> peopleList = new List<Person>();

                    People people = new People(peopleList);

                     Person reference1 = new Person(1,"Cory","Vance","Friend","Youth Pastor/Volunteer at RockChurch","309-669-7767");
                     Person reference2 = new Person(2,"Geoff","Bricka","Former Co-Worker/Team Lead","Developer at CSE Software","309-648-4277");
                     Person reference3 = new Person(3,"Amanda","Rios","Friend","Developer at State Farm","309-453-8254");
                     
                     

                     People.PeopleList.Add(reference1);
                     People.PeopleList.Add(reference2);
                     People.PeopleList.Add(reference3);
                    
                        
                    foreach (Person reference in People.PeopleList)
                    {
                        Console.WriteLine("\n"+reference.Id + " - " + reference.FirstName + "  " + reference.LastName + " - " + reference.Relationship + " - " + reference.JobTitle + " - " + reference.PhoneNumber);

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