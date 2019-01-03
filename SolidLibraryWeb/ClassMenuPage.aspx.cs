using ConnectionDatabase;
using SolidLibiary;
using SolidLibiaryDataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ClassMenuPage : System.Web.UI.Page
{
    string UserName;
    Guid Id;
    ConnectionClass ObjConetion = new ConnectionClass();
    List<ELClass> ELClassList = new List<ELClass>();
    DLClass ObjDlClass = new DLClass();
    protected void ViewClassData()
    {

        ELClassList = ObjDlClass.SelectAllClass(ObjConetion.connectionstring);

    }
    protected void BindGridList()
    {
        GridViewClass.DataSource = ELClassList;
        GridViewClass.DataBind();
        GridViewClass.HeaderRow.TableSection = TableRowSection.TableHeader;

    }




    protected void GridViewClass_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
    {
        Response.Write(GridViewClass.Rows[e.NewSelectedIndex].Cells[2].Text);

        Response.Redirect("ClassUpdatePage.aspx?classId=" + GridViewClass.Rows[e.NewSelectedIndex].Cells[2].Text);
    }

    protected void GridViewClass_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        Response.Write(GridViewClass.Rows[e.RowIndex].Cells[2].Text);
        var classId = GridViewClass.Rows[e.RowIndex].Cells[2].Text;
        ELClass ObjElClassDelete = new ELClass();
        ObjElClassDelete.Id = Guid.Parse(classId);
        try
        {
            ObjDlClass.DeleteClass(ObjElClassDelete, ObjConetion.connectionstring);
        }
        catch (Exception)
        {


            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('You Cant Delete the class because Its Refernces the Methods')", true);
        }
        ViewClassData();
        BindGridList();
        Response.Redirect("ClassMenuPage.aspx?result=-1");
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        UserName = Session["UserName"].ToString();
        Id = Guid.Parse(Session["UserId"].ToString());
        IdUserName.Text = UserName;
        IdUserId.Text = Id.ToString();

        if (!IsPostBack)
        {
            ViewClassData();
            BindGridList();
        }
        if (Request.QueryString["result"] == "1")
        {
            Msg.Text = "Record inserted Successfully";
        }
        else if (Request.QueryString["result"] == "-1")
        {
            Msg.Text = "Record Deleted Successfully";
        }
        else
        {
            Msg.Text = "";
        }
    }

    protected void IdClassView_Click(object sender, EventArgs e)
    {

    }

    protected void IdClassAdd_Click(object sender, EventArgs e)
    {
        Response.Redirect("ClassAddPage.aspx");
    }
}