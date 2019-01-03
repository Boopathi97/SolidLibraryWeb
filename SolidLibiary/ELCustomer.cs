using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidLibiary
{
    public class ELCustomer
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        //public ELProject objProject  = new ELProject();
        public Guid projectId { get; set; }
        public Guid Creator { get; set; }
        public DateTime CreatedAt { get; set; }
        public Guid Modifier { get; set; }
        public DateTime ModifiedAt { get; set; }

    }
}

