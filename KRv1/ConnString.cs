using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KRv1
{
    class ConnString
    {
        public static string GetConnString()
        {
            //string connStr = "Data Source=DESKTOP-GE38GRV;Initial Catalog=KRv1;Integrated Security=True";
            string connStr = "Data Source=GUK903-3-PCWIN0;Initial Catalog=KRv4;User ID=sa;Password=1234";
            return connStr;
        }
    }
}
