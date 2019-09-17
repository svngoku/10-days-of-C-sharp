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
        public int ID { get; set;}
        public isSubway = true;
        public string name { get; set;}


        public Subway(int id, string name) 
        {
            this.ID = id;
            this.name = name;
        }

        public string getSubway() 
        {
            return $"Name: {name} \nID: {ID}";
        }      
    }
}