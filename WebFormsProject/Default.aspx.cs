using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebFormsProject.Models;

namespace WebFormsProject
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                foreach (var dept in Constants.Departments)
                {
                    ddlDname.Items.Add(dept);
                }

                foreach (var desig in Constants.Designations)
                {
                    ddlDesig.Items.Add(desig);
                }
            }
        }

        protected void ddlDesig_SelectedIndexChanged(object sender, EventArgs e)
        {
            var edsignation = ddlDesig.Text;
            Response.Write(edsignation);
        }

        protected void btnNew_Click(object sender, EventArgs e)
        {
            txteno.Text = 0.ToString();
            txtename.Text = "";
            txtsal.Text = 0.ToString();
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            lbldata.Text = $"<br/> {txteno.Text} {txtename.Text} {txtsal.Text} {ddlDname.Text} {ddlDesig.Text}";
        }
    }
}