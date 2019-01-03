using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SolidLibiaryDataLayer;
using SolidLibiary;
using ConnectionDatabase;


public partial class MethodsAddPage : System.Web.UI.Page
{
    string UserName;
    Guid Id;
    ConnectionClass ObjConetion = new ConnectionClass();
    List<ELClass> ListMothods = new List<ELClass>();
    protected void Page_Load(object sender, EventArgs e)
    {
        UserName = Session["UserName"].ToString();
        Id = Guid.Parse(Session["UserId"].ToString());
        IdUserName.Text = UserName;
        IdUserId.Text = Id.ToString();
        DLMethods ObjDlMethods = new DLMethods();
        DLClass dLClass = new DLClass(); 
        if (!IsPostBack)
        {
          
            ListMothods = dLClass.SelectAllClass(ObjConetion.connectionstring);
            DropDownListClassId.DataSource = ListMothods;
            DropDownListClassId.DataTextField = "Name";
            DropDownListClassId.DataValueField = "Id";
            DropDownListClassId.DataBind();
            DropDownListClassId.Items.Insert(0, new ListItem("--Select Class Name--", "0"));

        }



    }

    protected void AddMethodSubmit_Click(object sender, EventArgs e)
    {
        Guid MethodId;
        MethodId = new Guid();
        ELMethods ObjELMethod = new ELMethods();
        ObjELMethod.Id = MethodId;
        ObjELMethod.Name = TextBoxMethodName.Text;
        ObjELMethod.ClasssId =Guid.Parse(DropDownListClassId.Text);
        ObjELMethod.Scope = DropDownListMethodScope.Text;
        ObjELMethod.ReturnType = DropDownListMethodReturnType.Text;
        ObjELMethod.Description = TextBoxDescription.Text;
        ObjELMethod.Creator = Id;
        ObjELMethod.CreatedAt = DateTime.Now;
        ObjELMethod.Modifier = Id;
        ObjELMethod.ModifiedAt = ObjELMethod.CreatedAt;
        DLMethods ObjDlMethods = new DLMethods();
        ObjDlMethods.AddMethods(ObjELMethod, ObjConetion.connectionstring);
        ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert( '" + TextBoxMethodName.Text + " ' );window.location ='MethodsViewPage.aspx';", true);

    }
}