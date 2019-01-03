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


public partial class MethodsViewPage : System.Web.UI.Page
{
    ELMethods ObjElMethod = new ELMethods();
    DLMethods ObjDlMethod = new DLMethods();
    List<ELMethods> MethodLists = new List<ELMethods>();
    ConnectionClass ObjConetion = new ConnectionClass();

    string UserName, Id;
    protected void Page_Load(object sender, EventArgs e)
    {
        UserName = Session["UserName"].ToString();
        Id = Session["UserId"].ToString();
        IdUserName.Text = UserName;
        IdUserId.Text = Id;
        if (!IsPostBack)
        {
            ViewMethod();
            BindDataList();
        }
       
    }
    protected void ViewMethod()
    {
        MethodLists = ObjDlMethod.SelectAllMethods(ObjConetion.connectionstring);
    }
    protected void BindDataList()
    {
        GridViewMethodsView.DataSource = MethodLists;
        GridViewMethodsView.DataBind();
        GridViewMethodsView.HeaderRow.TableSection = TableRowSection.TableHeader;
    }

    protected void GridViewMethodsView_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
    {
       // Response.Write(GridViewMethodsView.Rows[e.NewSelectedIndex].Cells[2].Text);
        Response.Redirect("MethodsUpdatePage.aspx?MethodId="+GridViewMethodsView.Rows[e.NewSelectedIndex].Cells[2].Text);
    }

    protected void GridViewMethodsView_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        Response.Write(GridViewMethodsView.Rows[e.RowIndex].Cells[2].Text);

        var methodId = GridViewMethodsView.Rows[e.RowIndex].Cells[2].Text;
        ELMethods ObjElMethodDelete = new ELMethods();
        ObjElMethodDelete.Id = Guid.Parse(methodId);
        try
        {
            ObjDlMethod.DeleteMethods(ObjElMethodDelete, ObjConetion.connectionstring);
        }
        catch (Exception)
        {


            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('You Cant Delete Method because Its Refernce of Perameter')", true);
        }
        ViewMethod();
        BindDataList();

    }
    protected void ProjectBack_Click(object sender, EventArgs e)
    {
        Response.Redirect("ManuPage.aspx");
    }
}