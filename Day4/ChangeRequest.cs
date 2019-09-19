using System;
using System.Collections.Generic;
using System.Text;

namespace Day4
{
    class ChangeRequest : WorkItem
    {
        protected int originalItemID { get; set; }
        public ChangeRequest() {}
        public ChangeRequest(string title, string desc, TimeSpan jobLen, int originID)
        {
            this.Title = title;
            this.Description = Description;
            this.jobLength = jobLen;
            this.originalItemID = originID;
        }
    }
}
