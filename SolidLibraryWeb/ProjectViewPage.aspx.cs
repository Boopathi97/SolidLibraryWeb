using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SolidLibiaryDataLayer;
using SolidLibiary;
using ConnectionDatabase;
using System.Data;

public partial class ProjectViewPage : System.Web.UI.Page
{
    ConnectionClass ObjConetion = new ConnectionClass();
    List<ELProject> ElList = new List<ELProject>();
    DLProject dLProject = new DLProject();
    protected void Page_Load(object sender, EventArgs e)
    {

        if (!IsPostBack)
        {
            ViewPorjectData();
            BindGridList();
        }

        
    }
    protected void BindGridList()
    {
        GridPageView.DataSource = ElList;
        GridPageView.DataBind();
        GridPageView.HeaderRow.TableSection = TableRowSection.TableHeader;



    }

   
  
   
    protected void ViewPorjectData()
    {
      
        ElList = dLProject.SelectAllProject(ObjConetion.connectionstring);
    }

    protected void GridPageView_SelectedIndexChanged(object sender, GridViewSelectEventArgs e)
    {

        Response.Write(GridPageView.Rows[e.NewSelectedIndex].Cells[2].Text);

        Response.Redirect("ProjectUpadatePage.aspx?projectId=" + GridPageView.Rows[e.NewSelectedIndex].Cells[2].Text);

    }
    
    protected void GridPageView_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        //Response.Write(GridPageView.Rows[e.RowIndex].Cells[2].Text);
        var proId = GridPageView.Rows[e.RowIndex].Cells[2].Text;
        ELProject ObjElProjectDelete = new ELProject();
        ObjElProjectDelete.Id = Guid.Parse(proId);
        try
        {
            dLProject.DeleteProject(ObjElProjectDelete, ObjConetion.connectionstring);
        }
        catch (Exception)
        {
            

            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('You Cant Delete Project because Its Refernce of Customer')", true);
        }
        ViewPorjectData();
        BindGridList();
       
    }

    protected void ProjectBack_Click(object sender, EventArgs e)
    {
        Response.Redirect("ManuPage.aspx");
    }

    //protected void GridPageView_OnPageIndexChanging(object sender, GridViewPageEventArgs e)
    //{
    //    GridPageView.PageIndex = e.NewPageIndex;
    //    ViewPorjectData();
    //    BindGridList();
    //}
}