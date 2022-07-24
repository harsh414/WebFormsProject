using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebFormsProject.Models;

namespace WebFormsProject
{
    public partial class CascadeInfo : System.Web.UI.Page
    {
        Cities citiesDb;
        protected void Page_Load(object sender, EventArgs e)
        {
            citiesDb = new Cities();
            if (!IsPostBack)
            {
                List<City> filteredCities = new List<City>();
                foreach (var city in citiesDb)
                {
                    if (city.StateId.ToString() == ddlStates.SelectedValue)
                    {
                        filteredCities.Add(city);
                    }
                }
                gvCities.DataSource = filteredCities;
                gvCities.DataBind();
            }
        }

        protected void ddlStates_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<City> filteredCities = new List<City>();
            foreach(var city in citiesDb)
            {
                if(city.StateId.ToString() == ddlStates.SelectedValue)
                {
                    filteredCities.Add(city);
                }
            }
            gvCities.DataSource= filteredCities;
            gvCities.DataBind();
        }
    }
}