using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Application.Entities;
using Application.DataAccess;


namespace WebFormsProject
{
    public partial class SearchEmpployees : System.Web.UI.Page
    {
        IDataAccess<Department, int> deptDbAccess;
        IDataAccess<Employee, int> EmpDbAccess;
        protected void Page_Load(object sender, EventArgs e)
        {
            deptDbAccess = new DepartmentDataAccess();
            EmpDbAccess= new EmployeeDataAccess();
            if (!IsPostBack)
            {
                foreach( var dpt in deptDbAccess.Get())
                {
                    ListItem li = new ListItem(dpt.DeptName, dpt.DeptNo.ToString());
                    ddlDepart.Items.Add(li);
                }

                List<Employee> filteredEmployeees = new List<Employee>();
                foreach (var emp in EmpDbAccess.Get())
                {
                    if (emp.DeptNo.ToString() == ddlDepart.SelectedValue)
                    {
                        filteredEmployeees.Add(emp);
                    }
                }
                gvEmployees.DataSource = filteredEmployeees;
                gvEmployees.DataBind();

            }
        }

        protected void ddlDepart_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Employee> filteredEmployeees = new List<Employee>();
            foreach(var emp in EmpDbAccess.Get())
            {
                if(emp.DeptNo.ToString() == ddlDepart.SelectedValue)
                {
                    filteredEmployeees.Add(emp);
                }
            }
            gvEmployees.DataSource = filteredEmployeees;
            gvEmployees.DataBind(); 
        }
    }
}