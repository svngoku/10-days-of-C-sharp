using System;
using System.Collections.Generic;
using System.Text;

namespace Day4
{
    class WorkItem
    {
        private static int currentID;
        protected int ID { get; set; }
        protected string Title { get; set; }
        protected string Description { get; set; }
        protected TimeSpan jobLength { get; set; }

        public WorkItem()
        {
            ID = 0;
            Title = "Titre par défaut";
            Description = "Description par défaut";
            jobLength = new TimeSpan();
        }

        public WorkItem(string title, string description, TimeSpan joblen)
        {
            this.ID = GetNextID();
            this.Title = title;
            this.Description = description;
            this.jobLength = joblen;
        }

        static WorkItem()
        {
            currentID = 0;
        }

        protected int GetNextID() => ++currentID;

        public void Update(string title, TimeSpan joblen)
        {
            this.Title = title;
            this.jobLength = joblen;
        }

        public override string ToString() => $"{this.ID} - {this.Title} : Time to resolution : {this.jobLength.Days} jours";

    }
}
