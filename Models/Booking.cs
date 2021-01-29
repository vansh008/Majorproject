using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Majorproject.Models
{
    public class Booking
    {
        public int ID { get; set; }
        public int CustomerID { get; set; }
        public Customer Customer { get; set; }
        public int StaffID { get; set; }
        public Staff Staff { get; set; }
        public int RoomID { get; set; }
        public Room Room { get; set; }
        public int BranchID { get; set; }
        public Branch Branch { get; set; }
    }
}
