using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    public class Subway
    {
        private string _serialNumber { get; set;}
        // fields
        public int ID { get; set;}
        public bool isSubway = true;
        public string name { get; set;}
        public string quaie { get; set;}
        public string destination { get; set;}


        public Subway(int id, string name, string destination, string quaie) 
        {
            this.ID = id;
            this.name = name;
            this.destination = destination;
            this.quaie = quaie;
        }

        public string getSubway() => $"Name: {name} \nID: {ID}";

        // public string getDestinationByName(string dest) 
        // {
        //    //
        // } 
    }
}