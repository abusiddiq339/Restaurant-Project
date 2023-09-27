using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace WAMicroProject
{
    public class GlobalData
    {
        public static string Username;
        public static string Password;
        public static string TotalPrice;
        public static string Table;
        public static string BillNumber;
        public static string BTTotal;
        public static SqlDataAdapter DA = new SqlDataAdapter();
        public static DataSet DS = new DataSet();
        public static SqlDataReader DR;
        public static SqlCommandBuilder CB = new SqlCommandBuilder();
    }
}
