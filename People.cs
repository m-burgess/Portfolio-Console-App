using System;
using System.Collections.Generic;

namespace PotfolioConsoleApp
{
    public class People
    {

        public static List<Person> PeopleList { get; set; }

        public People(List<Person> peopleList)
        {
            PeopleList=peopleList;
        }




        public void AddPerson(Person person)
        {

        PeopleList.Add(person);

        }

        public static int GenerateId()
        {
            int newId = 0;

            for(int i=0; i<PeopleList.Count;i++)
            {
                newId = i;

            }
            
            return newId + 1;
        }

    }
}