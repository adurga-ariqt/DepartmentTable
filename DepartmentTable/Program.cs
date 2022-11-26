// See https://aka.ms/new-console-template for more information
using DepartmentTable;
using System.Data.SqlClient;
using System.Reflection;

Dept_List departmentListobj = new Dept_List();
var departmentList = departmentListobj.Method();
SqlConnection connectionstring = new SqlConnection("Server=LAPTOP-4UV87UTN;Database=Durgabhavani;Trusted_Connection=true;");
string query = "Insert Into Department (DeptName, DeptShortName) " +
                   "VALUES (@FN, @LN) ";
foreach (var dept in departmentList)
{
    using (SqlCommand cmd = new SqlCommand(query, connectionstring))
    {
        // add parameters and their values
        cmd.Parameters.Add("@FN", System.Data.SqlDbType.NVarChar, 100).Value = dept.DeptName;
        cmd.Parameters.Add("@LN", System.Data.SqlDbType.NVarChar, 100).Value = dept.DeptShortName;

        connectionstring.Open();
        cmd.ExecuteNonQuery();
        connectionstring.Close();
    }
}