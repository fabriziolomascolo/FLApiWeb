using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace FLApiWeb.Models
{
    public class DAL
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["FLDbContext"].ConnectionString);
        SqlDataAdapter da = null;
        DataTable dt = null;

        public string GetLogin(Login login)
        {
            da = new SqlDataAdapter("select * from utenti where username = '" + login.UserName + "' and password = '" + login.Password + "' ", con);
            dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
                return "Logged In";
            else
                return "L'utente o la password digitati non esistono";
        }   
    }
}