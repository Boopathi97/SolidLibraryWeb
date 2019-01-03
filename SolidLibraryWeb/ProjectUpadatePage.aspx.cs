using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SolidLibiaryDataLayer;
using SolidLibiary;
using ConnectionDatabase;

public partial class ProjectUpadatePage : System.Web.UI.Page
{
    ConnectionClass ObjConetion = new ConnectionClass();
    DLProject dLProject = new DLProject();
    
    string ProjectId;
    protected void Page_Load(object sender, EventArgs e)
    {
        ELProject obj = new ELProject();
        ProjectId = Request.QueryString["projectId"];
        LabelProjectId.Text = ProjectId;
        obj.Id = Guid.Parse(ProjectId);
        obj = dLProject.SelectProject(obj, ObjConetion.connectionstring);
        if(!IsPostBack)
        {
            IdProjectName.Text = obj.Name;
        }
        ProjectCreator.Text = obj.Creator.ToString();
        ProjectCreatedAt.Text = obj.CreatedAt.ToString();
        ProjectModifier.Text = obj.Modifier.ToString();
        ProjectModifiedAt.Text = obj.ModifiedAt.ToString();


    }

    protected void ProjectUpdateButton_Click(object sender, EventArgs e)
    {
        string pIdText = IdProjectName.Text;
        ELProject updatedProject = new ELProject();
        updatedProject.Id = Guid.Parse(ProjectId);
        updatedProject.Name = pIdText;
        updatedProject.Modifier = Guid.Parse(Session["UserId"].ToString());
        updatedProject.ModifiedAt = DateTime.Now;
        dLProject.UpdateProject(updatedProject, ObjConetion.connectionstring);
        //ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Record Inserted Successfully')", true);
        ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Updated Successfully');Window.location ='ProjectViewPage.aspx';", true);

    }
    
}