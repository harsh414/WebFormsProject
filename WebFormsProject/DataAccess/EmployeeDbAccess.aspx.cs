using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Application.DataAccess;
using Application.Entities;

namespace WebFormsProject.DataAccess
{
    public partial class EmployeeDbAccess : System.Web.UI.Page
    {
        IDataAccess<Employee, int> EmpDbAccess;
        IDataAccess<Department, int> deptDbAccess;
        protected void Page_Load(object sender, EventArgs e)
        {
            EmpDbAccess = new EmployeeDataAccess();
            deptDbAccess = new DepartmentDataAccess();
            if (!IsPostBack)
            {
                foreach (var dpt in deptDbAccess.Get())
                {
                    ListItem li = new ListItem(dpt.DeptName, dpt.DeptNo.ToString());
                    ddlDepart.Items.Add(li);
                }
                txtdno.Text = ddlDepart.SelectedValue;
                EmpDbAccess.Get();
                LoadData();
            }
        }

        protected void btnNew_Click(object sender, EventArgs e)
        {
            txteno.Text = 0.ToString();
            txtename.Text = String.Empty;
            txtdesignation.Text = String.Empty;
            txtsalary.Text = 0.ToString();
            txtdno.Text = 0.ToString();
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Employee emp = new Employee()
                {
                    EmpNo = Convert.ToInt32(txteno.Text),
                    EmpName = txtename.Text,
                    Designation = txtdesignation.Text,
                    Salary = Convert.ToInt32(txtsalary.Text),
                    DeptNo = Convert.ToInt32(txtdno.Text)
                };

                EmpDbAccess.Create(emp);
                LoadData();
                lblstatus.Text = "New Employee is Created Successfully...";

            }
            catch (Exception ex)
            {
                lblstatus.Text = ex.Message;
            }
        }

        private void LoadData()
        {
            gvEmp.DataSource = EmpDbAccess.Get();
            gvEmp.DataBind();
        }

        protected void gvEmp_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            gvEmp.EditIndex = -1;
            LoadData();
        }

        protected void gvEmp_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            try
            {
                var eno = Convert.ToInt32(gvEmp.Rows[e.RowIndex].Cells[0].Text);
                EmpDbAccess.Delete(eno);
                LoadData();
            }
            catch(Exception ex)
            {
                lblstatus.Text = ex.Message;
            }
        }

        protected void gvEmp_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            try
            {

                Employee emp = new Employee();
                emp.EmpNo = Convert.ToInt32(gvEmp.Rows[e.RowIndex].Cells[0].Text);
                emp.EmpName = (gvEmp.Rows[e.RowIndex].Cells[1].Controls[0] as TextBox).Text;
                emp.Designation = (gvEmp.Rows[e.RowIndex].Cells[2].Controls[0] as TextBox).Text;
                emp.Salary = Convert.ToInt32((gvEmp.Rows[e.RowIndex].Cells[3].Controls[0] as TextBox).Text);
                emp.DeptNo = Convert.ToInt32((gvEmp.Rows[e.RowIndex].Cells[4].Controls[0] as TextBox).Text);

                // 2. Update
                EmpDbAccess.Update(emp.EmpNo, emp);
                // 3. Remove the Edit effect
                gvEmp.EditIndex = -1;
                LoadData();
            }
            catch (Exception ex)
            {
                lblstatus.Text = ex.Message;
            }
        }

        protected void gvEmp_RowEditing(object sender, GridViewEditEventArgs e)
        {
            gvEmp.EditIndex = e.NewEditIndex;


            // read the cells collection for a selected row
            var cells = gvEmp.Rows[e.NewEditIndex].Cells;
            // show data in text boxes
            txteno.Text = cells[0].Text;
            txtename.Text = cells[1].Text;
            txtdesignation.Text = cells[2].Text;
            txtsalary.Text = cells[3].Text;
            txtdno.Text = cells[4].Text;
            LoadData();
        }

        protected void gvEmp_SelectedIndexChanged(object sender, EventArgs e)
        {
            var cells = gvEmp.SelectedRow.Cells;
            txteno.Text = cells[0].Text;
            txtename.Text = cells[1].Text;
            txtdesignation.Text = cells[2].Text;
            txtsalary.Text = cells[3].Text;
            txtdno.Text = cells[4].Text;
        }


        protected void ddlDepart_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtdno.Text= ddlDepart.SelectedValue;
        }
    }
}