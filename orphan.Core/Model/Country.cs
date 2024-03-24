using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace orphan.Core.Model
{
    public class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }
        
        public List<NewOrphan>newOrphan { get; set; }

    }
}
