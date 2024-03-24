using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace orphan.Core.Model
{
    public class User
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Validity { get; set; }
        public DateTime EntryDate { get; set; }
        public List<DataReview> DataReviews { get; set; }
    }
}






