using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SolidLibiaryDataLayer;
using SolidLibiary;
using ConnectionDatabase;

public partial class MethodsUpdatePage : System.Web.UI.Page
{
   
    DLMethods ObjDlMethod = new DLMethods();
    ConnectionClass ObjConetion = new ConnectionClass();
    string UserName, Id,MethodId;
    protected void Page_Load(object sender, EventArgs e)
    {
        UserName = Session["UserName"].ToString();
        Id = Session["UserId"].ToString();
        IdUserName.Text = UserName;
        IdUserId.Text = Id;


       
        Response.Write(MethodId);

        ELMethods ObjElMethod = new ELMethods();
        MethodId = Request.QueryString["MethodId"];
        LebelMethodId.Text = MethodId;
        ObjElMethod.Id = Guid.Parse(MethodId);
        ObjElMethod = ObjDlMethod.SelectMethods(ObjElMethod, ObjConetion.connectionstring);
        if (!IsPostBack)
        {
            TextBoxMethodName.Text = ObjElMethod.Name;
            DropDownListMethodScope.Text = ObjElMethod.Scope;
            DropDownListMethodReturnType.Text = ObjElMethod.ReturnType;
            TextBoxDescription.Text = ObjElMethod.Description;
        }
        ClassId.Text = ObjElMethod.ClasssId.ToString();
        MethodCreator.Text = ObjElMethod.Creator.ToString();
        MethodCreatedAt.Text = ObjElMethod.CreatedAt.ToString();
        MethodModifiedAt.Text = ObjElMethod.ModifiedAt.ToString();
        MethodModifier.Text = ObjElMethod.Modifier.ToString();
       
       


    }

    protected void UpdateMethodSubmit_Click(object sender, EventArgs e)
    {
        ELMethods ObjElMethodUpdate = new ELMethods();
        ObjElMethodUpdate.Id= Guid.Parse(MethodId);
        ObjElMethodUpdate.Name = TextBoxMethodName.Text;
        ObjElMethodUpdate.Scope = DropDownListMethodScope.Text;
        ObjElMethodUpdate.ReturnType = DropDownListMethodReturnType.Text;
        ObjElMethodUpdate.Description = TextBoxDescription.Text;
        ObjElMethodUpdate.Modifier = Guid.Parse(Id);
        ObjElMethodUpdate.ModifiedAt = DateTime.Now;
        ObjDlMethod.UpdateMethods(ObjElMethodUpdate, ObjConetion.connectionstring);

    }

    protected void DropDownListMethodReturnType_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void DropDownListMethodScope_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}