using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidLibiary
{
    public class ELClass
    {

        public Guid Id { get; set; }
        public string Name { get; set; }
        //public ELProject objProject = new ELProject();
        //public ELCustomer objCustomer = new ELCustomer();
        public Guid projectId{ get; set; }
        public Guid customerId { get; set; }
        public string Description { get; set; }
        public string ClassScope { get; set; }
        public string ClassPublicVairables { get; set; }
        public Guid Creator { get; set; }
        public DateTime CreatedAt { get; set; }
        public Guid Modifier { get; set; }
        public DateTime ModifiedAt { get; set; }

    }
}
