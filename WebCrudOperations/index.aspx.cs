using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebCrudOperations
{
    public partial class index : System.Web.UI.Page

    {
        DataTable data= new DataTable();
        DALC command = new DALC();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                GetData();
            }
        }

        protected void Updated(object sender, GridViewUpdateEventArgs e)
        {
            TextBox id = (TextBox)GridShow.Rows[e.RowIndex].Cells[0].Controls[0];
            TextBox CompanyName = (TextBox)GridShow.Rows[e.RowIndex].Cells[1].Controls[0];
            TextBox ContactName = (TextBox)GridShow.Rows[e.RowIndex].Cells[2].Controls[0];
            TextBox ContactTitle = (TextBox)GridShow.Rows[e.RowIndex].Cells[3].Controls[0];
            TextBox Adress = (TextBox)GridShow.Rows[e.RowIndex].Cells[4].Controls[0];
            TextBox City = (TextBox)GridShow.Rows[e.RowIndex].Cells[5].Controls[0];


            command.Update(id.Text, CompanyName.Text, ContactName.Text, ContactTitle.Text, Adress.Text, City.Text);
            GridShow.EditIndex = -1;
            GetData();
        }

        protected void Delete(object sender, GridViewDeleteEventArgs e)
        {
            GridViewRow row = GridShow.Rows[e.RowIndex];
            int id = int.Parse(row.Cells[0].Text);
            command.Delete(id);
            GetData();
        }

        protected void Edit(object sender, GridViewEditEventArgs e)
        {
            GridShow.EditIndex = e.NewEditIndex;
            GetData();
        }
        protected void cancel(object sender, GridViewCancelEditEventArgs e)
        {
            GridShow.EditIndex = -1;
            GetData();
        }

        protected void GetData()
        {
            command.GetData().Fill(data);
            GridShow.DataSource = data;
            GridShow.DataBind();
        }

       
    }
}