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
    public partial class profil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["username"]==null)
            {
                Response.Redirect("login.aspx");
            }
        }

        protected void sendbutton_Click(object sender, EventArgs e)
        {


            
            MySqlConnection con = new MySqlConnection("server=localhost;user id=root;password=7Miyemedimi;database=testing_mysql");

            MySqlCommand cmd = new MySqlCommand("get_all_user", con);


            cmd.CommandType = CommandType.StoredProcedure;

            con.Open();
            cmd.ExecuteNonQuery();


            DataSet ds = new DataSet();
            using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
            {
                da.Fill(ds);

                info.DataSource = ds;
                info.DataBind();
            }
            con.Close();
        }


        protected void message_TextChanged(object sender, EventArgs e)
        {
            MessageBox(message.Text);
            
        }
        private void MessageBox(string msg)
        {
            Label lbl = new Label();
            lbl.Text = "<script language='javascript'>" + Environment.NewLine + "window.alert('" + msg + "')</script>";
            Page.Controls.Add(lbl);
        }

        protected void logout_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("server=localhost;user id=root;password=7Miyemedimi;database=testing_mysql");
            MySqlCommand cmd0 = new MySqlCommand("Set_Ofline", con);
            cmd0.CommandType = CommandType.StoredProcedure;
            cmd0.Parameters.Add("@u", MySqlDbType.VarChar).Value = Session["username"].ToString();
            cmd0.Connection.Open();
            cmd0.ExecuteNonQuery();
            Session.Abandon();
            Response.Redirect("login.aspx");
        }
    }
}