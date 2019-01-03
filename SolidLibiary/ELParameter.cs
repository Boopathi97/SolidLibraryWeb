using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidLibiary
{
    public class ELParameter
    {
        public Guid Id { get; set; }
        //public ELMethods objMethods = new ELMethods();
        public Guid MethodId { get; set; }
        public string Name { get; set; }
        public string Scope { get; set; }
        public string ReturnType { get; set; }
        public string InputOrOutput { get; set; }
        public Guid Creator { get; set; }
        public DateTime CreatedAt { get; set; }
        public Guid Modifier { get; set; }
        public DateTime ModifiedAt { get; set; }

    }
}
