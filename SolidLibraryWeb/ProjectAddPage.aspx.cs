using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SolidLibiaryDataLayer;
using SolidLibiary;
using ConnectionDatabase;


public partial class ProjectAdd : System.Web.UI.Page
{
    string UserName;
    Guid Id;
    ConnectionClass ObjConetion = new ConnectionClass();
   
    protected void Page_Load(object sender, EventArgs e)
    {
      
        UserName = Session["UserName"].ToString();
        Id = Guid.Parse(Session["UserId"].ToString());
        IdUserName.Text = UserName;
        IdUserId.Text = Id.ToString();
       // Response.Write(Request.QueryString["projectId"].ToString());

    }

    protected void AddProjectSubmit_Click(object sender, EventArgs e)
    {
            Guid ProjectId;
            ProjectId = Guid.NewGuid();
            IdProjectId.Text = ProjectId.ToString();
            IdProjectName.Text = TextBoxProjectName.Text;
            IdProjectCreator.Text = UserName;
            IdProjectCreatedAt.Text = DateTime.Now.ToString();
            IdProjectModifier.Text = UserName;
            IdProjectModifierAt.Text = DateTime.Now.ToString();

            ELProject obj = new ELProject();
            obj.Id = ProjectId;
            obj.Name = TextBoxProjectName.Text;
            obj.Creator = Id;
            obj.CreatedAt = DateTime.Now;
            obj.Modifier = Id;
            obj.ModifiedAt = obj.CreatedAt;
            DLProject dLProject = new DLProject();
            dLProject.AddProject(obj, ObjConetion.connectionstring);
            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert( '" + TextBoxProjectName.Text + " ' );window.location ='ProjectViewPage.aspx';", true);


    }
}