using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace Data_Tier
{
    public class D_ServerStatus : General_Data
    {

        public DataSet D_getStatusOfServer(int idStatus)
        {
            ds = new DataSet();
            CMD = new SqlCommand("select * from ServerStatus where ID=@idStatus", con);
            CMD.Parameters.Add("@idStatus", SqlDbType.Char).Value = idStatus;
            DA = new SqlDataAdapter(CMD);
            DA.Fill(ds, "ServerStatus");
            return ds;
        }

        public int D_ServerStatusIs(string status, int idStatus)
        {
            string sql = "update ServerStatus set STATUS='" + status + "' where ID='" + idStatus + "'";
            con.Open();
            CMD = new SqlCommand(sql, con);
            int n = CMD.ExecuteNonQuery();
            con.Close();
            return n;
        }
    }
}
