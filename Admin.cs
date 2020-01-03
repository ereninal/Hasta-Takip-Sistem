using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaglikOcagiSistem
{
    class Admin
    {
        private static string _admin;
        public static string admin
        {
            get
            {
                return _admin;
            }
        }
        public  Admin(string ad)
        {
            _admin = ad;
        }
        
    }
}
