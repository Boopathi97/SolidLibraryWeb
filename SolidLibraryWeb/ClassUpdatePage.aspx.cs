    using ConnectionDatabase;
using SolidLibiary;
using SolidLibiaryDataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ClassUpdatePage : System.Web.UI.Page
{
    ConnectionClass ObjConetion = new ConnectionClass();
    DLClass dLClass = new DLClass();

    string ClassId;
    protected void Page_Load(object sender, EventArgs e)
    {
        ELClass obj = new ELClass();
        ClassId = Request.QueryString["classId"];
        
        obj.Id = Guid.Parse(ClassId);
        obj = dLClass.SelectClass(obj, ObjConetion.connectionstring);
        if (!IsPostBack)
        {
            TextBoxClassName.Text = obj.Name;
            TextBoxDescription.Text = obj.Description;
            TextBoxClassPublicVariable.Text = obj.ClassPublicVairables;
            DDClassScope.Items.FindByValue(obj.ClassScope).Selected = true;
            ClassCreator.Text = obj.Creator.ToString();
            ClassCreatedAt.Text = obj.CreatedAt.ToString();
        }

        
    }

    protected void UpdateClassSubmit_Click(object sender, EventArgs e)
    {
        ELClass updateClass = new ELClass();
        updateClass.Id = Guid.Parse(ClassId);
        updateClass.Name = TextBoxClassName.Text;
        updateClass.Description = TextBoxDescription.Text;
        updateClass.ClassPublicVairables = TextBoxClassPublicVariable.Text;
        updateClass.ClassScope = DDClassScope.Text;
        updateClass.Modifier = Guid.Parse(Session["UserId"].ToString());
        updateClass.ModifiedAt = DateTime.Now;
        dLClass.UpdateClass(updateClass, ObjConetion.connectionstring);
        ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Updated Successfully');Window.location ='ClassMenuPage.aspx';", true);
    }

    protected void ViewClass_Click(object sender, EventArgs e)
    {
        Response.Redirect("ClassMenuPage.aspx");
    }
}