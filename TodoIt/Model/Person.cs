using System;
using System.Collections.Generic;
using System.Text;


namespace TodoIt.Model
{

    public class Person
    {
        public readonly int personId;
        //public readonly int personId { get;}
        //private static personIdCounter = 0;
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public void Introduce()
        {
            Console.WriteLine(" Namn is: " + FirstName + " " + LastName + " " + personId);


        }

        public Person(string firstName, string lastName, int personId);
        { 

            Id = personIdCounter
        personId = personId

    }

}


}
