using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{

    public class ClsDataLayer : IDataAccess
    {
       
        SqlConnection con=new SqlConnection(@"Data Source=(LocalDb)\MSSQLLocalDB;Initial Catalog=newDB;Integrated Security=True");

        public void InsertData(string _name, string _gender, string _dob)
        {
            SqlDataAdapter ad=new SqlDataAdapter("insert into Student values('"+_name+"','"+_gender+"','"+_dob+"')", con);
            DataTable dt=new DataTable();
            ad.Fill(dt);
        }

        public void UpdateData(string _name, string _gender, string _dob)
        {
            SqlDataAdapter ad = new SqlDataAdapter("update Student set sname='" + _name + "',gender='" + _gender + "',dob='" + _name + "' where id=5011", con);
            DataTable dt = new DataTable();
            ad.Fill(dt);
        }

        public void DeleteData(string _name)
        {
            SqlDataAdapter ad = new SqlDataAdapter("delete from Student where sname='" + _name + "'", con);
            DataTable dt = new DataTable();
            ad.Fill(dt);
        }


        public object SelectData()
        {
            SqlDataAdapter ad = new SqlDataAdapter("select * from Student", con);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            return dt;
        }
    }
}
