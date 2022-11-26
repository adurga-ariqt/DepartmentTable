using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepartmentTable
{
    internal class Dept_DB_Connection 
    {
        string connetionString = "";
        SqlCommand cmd;
        SqlConnection SqlCon;
        string query = "";
        public void Method1()
        {
            connetionString = "Server=LAPTOP-4UV87UTN;Database=Durgabhavani;Trusted_Connection=true;";
            query = "Insert into Department  Values()";
            SqlCon.Open();
            SqlCon.Close();
        }
    }
}
