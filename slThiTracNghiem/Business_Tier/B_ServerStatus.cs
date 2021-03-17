using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Data_Tier;
using System.Data;

namespace Business_Tier
{
    public class B_ServerStatus
    {
        D_ServerStatus stt = new D_ServerStatus();

        public DataTable B_getStatusOfServer(int idStatus)
        {
            return stt.D_getStatusOfServer(idStatus).Tables["ServerStatus"];
        }

        public int B_ServerStatusIs(string status, int idStatus)
        {
            return stt.D_ServerStatusIs(status, idStatus);
        }
    }
}
