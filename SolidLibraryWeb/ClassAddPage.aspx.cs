using ConnectionDatabase;
using SolidLibiary;
using SolidLibiaryDataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ClassAddPage : System.Web.UI.Page
{
    string UserName;
    Guid Id;
    ConnectionClass ObjConetion = new ConnectionClass();
    

    List<ELProject> ProjectList = new List<ELProject>();
    List<ELCustomer> CustomerList = new List<ELCustomer>();
    DLProject dLProject = new DLProject();
    DLCustomer dLCustomer = new DLCustomer();
    protected void Page_Load(object sender, EventArgs e)
    {
        UserName = Session["UserName"].ToString();
        Id = Guid.Parse(Session["UserId"].ToString());
        IdUserName.Text = UserName;
        IdUserId.Text = Id.ToString();
        ProjectList = dLProject.SelectAllProject(ObjConetion.connectionstring);
        CustomerList = dLCustomer.SelectAllCustomer(ObjConetion.connectionstring);
        if (!IsPostBack)
        {
            
            DropDownListProjectName.DataSource = ProjectList;
            DropDownListProjectName.DataTextField = "Name";
            DropDownListProjectName.DataValueField = "Id";
            DropDownListProjectName.DataBind();
            DropDownListProjectName.Items.Insert(0, new ListItem("--Select Project Name--", "0"));
        
            
            //DropDownListCustomerName.DataSource = CustomerList;
            //DropDownListCustomerName.DataTextField = "Name";
            //DropDownListCustomerName.DataValueField = "Id";
            //DropDownListCustomerName.DataBind();
            DropDownListCustomerName.Items.Insert(0, new ListItem("--Select CustomerName Name--", "00000000-0000-0000-0000-000000000000"));
            

        }

    }

    protected void DropDownListProjectName_SelectedIndexChanged(object sender, EventArgs e)
    {
        //Response.Write(DropDownListProjectName.Text);
        
        DropDownListCustomerName.Items.Clear();
        DropDownListCustomerName.Items.Insert(0, new ListItem("--Select CustomerName Name--", "00000000-0000-0000-0000-000000000000"));
        foreach (var item in CustomerList)
        {

            if (item.projectId.ToString() == DropDownListProjectName.Text)
            {
            
                DropDownListCustomerName.Items.Add(new ListItem(item.Name, item.Id.ToString()));
            }
            

        }
    }

    protected void DropDownListCustomerName_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void AddClassSubmit_Click(object sender, EventArgs e)
    {
        ELClass classObject = new ELClass();

        classObject.Name = TextBoxClassName.Text;
        classObject.projectId = Guid.Parse(DropDownListProjectName.Text);
        classObject.customerId = Guid.Parse(DropDownListCustomerName.Text);
        classObject.Description = TextBoxDescription.Text;
        classObject.ClassScope = DDClassScope.Text;
        classObject.ClassPublicVairables = TextBoxClassPublicVariable.Text;
        classObject.Creator = Id;
        classObject.CreatedAt = DateTime.Now;
        classObject.Modifier = classObject.Creator;
        classObject.ModifiedAt = classObject.CreatedAt;

        DLClass dLClass = new DLClass();
        try
        {
            dLClass.AddClass(classObject, ObjConetion.connectionstring);
            Response.Redirect("ClassMenuPage.aspx?result="+1);
        }
        catch (Exception)
        {
            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('You can not add the class')", true);
        }
        

    }

    protected void ViewClass_Click(object sender, EventArgs e)
    {
        Response.Redirect("ClassMenuPage.aspx");
    }
}