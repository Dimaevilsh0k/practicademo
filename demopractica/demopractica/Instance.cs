using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demopractica
{
    internal class Instance
    {
        private static demotranningEntities _db;
        public static demotranningEntities db
        {
            get
            {
                if (_db == null)
                    _db = new demotranningEntities();
                return _db;
            }

        }
    }
}
