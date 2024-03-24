using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace orphan.Core.Model
{
    public class DataReview
    {
        public int Id { get; set; }
        public string OrderStatus { get; set; }
        public string Reason { get; set; }
        public string Remarks { get; set; }
        public string Side { get; set; }
        public string Date { get; set; }

        public int NewOrphanId { get; set; }
        public NewOrphan NewOrphan { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }


    }
}









