using System;

namespace PotfolioConsoleApp
{
    public class Job
    {
        public int Id { get; set; }
        public string JobName { get; set; }
        public string JobTitle { get; set; }
        public string EmploymentRange { get; set; }

        public Job(int id, string name, string title, string startDate, string endDate)
        {
            Id=id;
            JobName=name;
            JobTitle=title;
            EmploymentRange=startDate + " to " + endDate;  
        }
    }
}