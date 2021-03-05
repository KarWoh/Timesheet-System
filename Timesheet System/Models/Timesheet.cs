using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Timesheet_System.Models
{
    public class Timesheet
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int MobileNumber { get; set; }
        public string Email { get; set; }
        public string Occupation { get; set; }
        public string DescriptionOfYourself { get; set;  }
        public string UserName { get; set; }

        public Timesheet()
        {

        }
    }
}