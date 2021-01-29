using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Majorproject.Models
{
    public class Customer
    {
        public int ID { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public string Gender { get; set; }
        public string Email_Id { get; set; }
        public DateTime DOB { get; set; }
    }
}
