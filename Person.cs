using System;

namespace PotfolioConsoleApp
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string PhoneNumber { get; set; }
        public string Relationship { get; set; }
        public string JobTitle  { get; set; }

        

        public Person(int id, string firstName, string lastName, string relationship, string jobTitle, string phoneNumber)
        {
            Id=id;
            
            FirstName=firstName;
            
            LastName=lastName;

            Relationship=relationship;

            JobTitle=jobTitle;

            PhoneNumber=phoneNumber;

        }
    }
}