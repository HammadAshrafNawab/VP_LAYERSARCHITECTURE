using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AppProps;
using BLL;

namespace architecture
{
    public partial class users : System.Web.UI.Page
    {
        UserBLL uBll = new UserBLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadGridView();
            }
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            User U = new User();
            U.NAME1 = txtName.Text;
            U.EMAIL1 = txtEmail.Text;
            if (uBll.adduserBll(U))
            {
                Response.Write("<script>alert('User Added');</script>");
                LoadGridView();
            }
            else
            {
                Response.Write("<script>alert('User not Added');</script>");
            }
        }

        private void LoadGridView()
        {
            GridView1.DataSource = uBll.allusersbll();
            GridView1.DataBind();
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            User U = new User();
            U.ID1 = Int32.Parse(txtId.Text);
            DataTable dt = uBll.searchuserbll(U);
            if (dt != null)
            {
                txtName.Text = dt.Rows[0]["NAME"].ToString();
                txtEmail.Text = dt.Rows[0]["EMAIL"].ToString();
            }
            else
            {
                Response.Write("<script>alert('No Record Found');</script>");
            }
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            User U = new User();
            U.ID1 = Int32.Parse(txtId.Text); 
            U.NAME1 = txtName.Text;
            U.EMAIL1 = txtEmail.Text;
            if (uBll.updateUserbll(U))
            {
                Response.Write("<script>alert('User Updated');</script>");
                LoadGridView();
            }
            else
            {
                Response.Write("<script>alert('User not Updated');</script>");
            }
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            User U = new User();
            U.ID1 = Int32.Parse(txtId.Text); 
            if (uBll.deleteUserbll(U))
            {
                Response.Write("<script>alert('User Deleted');</script>");
                LoadGridView();
            }
            else
            {
                Response.Write("<script>alert('User not Deleted');</script>");
            }
        }
    }
}