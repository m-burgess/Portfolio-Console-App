using System;
using System.Collections.Generic;

namespace PotfolioConsoleApp
{
    public class Jobs
    {
        public List<Job> JobList { get; set; }

        public Jobs(List<Job> jobList)
        {
            JobList=jobList;

        }

        public void AddJob(Job job)
        {
            JobList.Add(job);
        }


                    


        public int GenerateId()
        {
            int newId = 0;

            for(int i=0; i<JobList.Count;i++)
            {
                newId = i;

            }
            
            return newId + 1;
        }
    }
}