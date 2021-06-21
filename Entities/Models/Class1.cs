using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class DataXd
    {
        public bool TestConn()
        {
            using (RRHHContext ctx = new RRHHContext())
            {
                try
                {
                    ctx.Database.Connection.Open();
                    ctx.Database.Connection.Close();
                    return true;
                }
                catch (Exception ex)
                {
                    throw ex;
                }


            }
        }
    }
}
