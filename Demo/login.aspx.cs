using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using System.Data;
namespace Demo
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["username"]!=null)
            {
                Response.Redirect("profil.aspx");

            }
        }

        protected void login_Button_Click(object sender, EventArgs e)
        {

            
            MySqlConnection con = new MySqlConnection("server=localhost;user id=root;password=7Miyemedimi;database=testing_mysql");



            MySqlCommand cmd = new MySqlCommand("login", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@u", MySqlDbType.VarChar).Value = username.Text;
            cmd.Parameters.Add("@p", MySqlDbType.VarChar).Value = password.Text;
            cmd.Connection.Open();
            MySqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
           

            while (dr.Read())
            {
                Session["online"]=Convert.ToString(dr["online"]);
            }
            dr.Close();
            if (Session["online"] == null)
            {
                warning_label.Text = "Dont such a user";
            }else if (Session["online"].ToString() == "1")
            {
                warning_label.Text = "Online in another device.";
            }
            else
            {
                Session["username"] = username.Text;
                MySqlCommand cmd0 = new MySqlCommand("Set_Online", con);
                cmd0.CommandType = CommandType.StoredProcedure;
                cmd0.Parameters.Add("@u", MySqlDbType.VarChar).Value = Session["username"].ToString();
                cmd0.Connection.Open();
                cmd0.ExecuteNonQuery();

                Response.Redirect("profil.aspx");
            }
        }

      
    }
}