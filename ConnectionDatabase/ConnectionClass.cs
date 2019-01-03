using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectionDatabase
{
    public class ConnectionClass
    {
        public string connectionstring
        {
            get
            {
                return System.Configuration.ConfigurationSettings.AppSettings["ConnectionString"];
            }
        }
    }
}
