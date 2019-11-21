using System;
using System.Collections.Generic;
using System.Text;


namespace TodoIt.Model
{

    public class Person
    {
       
        //public readonly int personId { get;}
        //private static personIdCounter = 0;
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public readonly int personId;

        public void Introduce()
        {
            Console.WriteLine(" Namn is: " + FirstName + " " + LastName + " " + personId);
            

        }

        
        //public Person(string firstname, string lastname, int personid)
        //{
        //    this.FirstName = firstname;
        //    this.LastName = lastname;

        //    this.personId = personid;

        //}

        //public Person(string v1, string v2)
        //{
        //}
    }


        
}
             //   Id = personIdCounter
               //personId = personId


 






