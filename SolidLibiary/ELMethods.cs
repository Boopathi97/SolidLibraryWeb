using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SolidLibiaryDataLayer;
namespace SolidLibiary
{
    public class ELMethods
    {
        public Guid Id { get; set; }
        //public ELClass objClass = new ELClass();
        public Guid ClasssId { get; set; }
        public string Name { get; set; }
        public string Scope { get; set; }
        public string ReturnType { get; set; }
        public string Description { get; set; }
        public Guid Creator { get; set; }
        public DateTime CreatedAt { get; set; }
        public Guid Modifier { get; set; }
        public DateTime ModifiedAt { get; set; }


    }
        
    
}
