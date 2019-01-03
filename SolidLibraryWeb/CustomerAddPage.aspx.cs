using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SolidLibiaryDataLayer;
using SolidLibiary;
using ConnectionDatabase;
using System.Data.SqlClient;
using System.Data;

public partial class CustomerAddPage : System.Web.UI.Page
{
    string UserName;
    Guid Id;
    ConnectionClass ObjConetion = new ConnectionClass();
    DataTable dt = new DataTable();
   
    List<ELProject> ElList = new List<ELProject>();
    DLProject dLProject = new DLProject();
   
    protected void Page_Load(object sender, EventArgs e)
    {
        UserName = Session["UserName"].ToString();
        Id = Guid.Parse(Session["UserId"].ToString());
        IdUserName.Text = UserName;
        IdUserId.Text = Id.ToString();

        //Session["ProjectIDC"]=
        ElList = dLProject.SelectAllProject(ObjConetion.connectionstring);
        DropDownListProjectName.DataSource = ElList;
        DropDownListProjectName.DataTextField = "Name";
        DropDownListProjectName.DataValueField = "Id";
        DropDownListProjectName.DataBind();
        DropDownListProjectName.Items.Insert(0, new ListItem("--Select Project Name--", "0"));
        
    }
    protected void BindGridList()
    {
        DropDownListProjectName.DataSource = dt;
        DropDownListProjectName.DataBind();
    }

    protected void AddCustomerSubmit_Click(object sender, EventArgs e)
    {
        //DropDownListProjectName
        DLCustomer ObjDLCustomer = new DLCustomer();
        ELCustomer ObjElCustomer = new ELCustomer();
        ObjElCustomer.Name = TextBoxCustomerName.Text;
        ObjElCustomer.projectId = Guid.Parse(DropDownListProjectName.Text);

        ObjElCustomer.Creator = Id;
        ObjElCustomer.CreatedAt = DateTime.Now;
        ObjElCustomer.Modifier = ObjElCustomer.Creator;
        ObjElCustomer.ModifiedAt = ObjElCustomer.CreatedAt; 

        ObjDLCustomer.AddCustomer(ObjElCustomer,ObjConetion.connectionstring);
       // ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Inserted Customer Successfully');Window.location ='CustomerViewPage.aspx';", true);
        ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Inserted Customer Successfully');window.location ='CustomerViewPage.aspx';", true);

    }

    protected void DropDownListProjectName_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}