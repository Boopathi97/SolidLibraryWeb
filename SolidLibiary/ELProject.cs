using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SolidLibiaryDataLayer;
namespace SolidLibiary
{
    public class ELProject
    {
        public Guid Id{ get; set; }
        public string Name { get; set; }
        public Guid Creator { get; set; }
        public DateTime CreatedAt { get; set; }
        public Guid Modifier { get; set; }
        public DateTime ModifiedAt { get; set; }
    }
}
