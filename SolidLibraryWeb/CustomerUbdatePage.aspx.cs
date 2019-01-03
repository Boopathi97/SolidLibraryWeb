using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SolidLibiaryDataLayer;
using SolidLibiary;
using ConnectionDatabase;


public partial class CustomerUbdatePage : System.Web.UI.Page
{
    ConnectionClass ObjConetion = new ConnectionClass();
    DLCustomer ObjDlCustomer = new DLCustomer();
  

    string CustomerId;
    protected void Page_Load(object sender, EventArgs e)
    {
        ELCustomer ObjElCustomer = new ELCustomer();
        CustomerId = Request.QueryString["CustomerId"];
        LabelCustomerId.Text = CustomerId;
        ObjElCustomer.Id = Guid.Parse(CustomerId);
        ObjElCustomer = ObjDlCustomer.SelectCustomer(ObjElCustomer, ObjConetion.connectionstring);
        if (!IsPostBack)
        {
            IdCustomerName.Text = ObjElCustomer.Name;
        }
       

        ProjectId.Text = ObjElCustomer.Id.ToString();
        CustomerCreator.Text = ObjElCustomer.Creator.ToString();
        CustomerCreatedAt.Text = ObjElCustomer.CreatedAt.ToString();
        CustomerModifier.Text = ObjElCustomer.Modifier.ToString();

        CustomerModifiedAt.Text = ObjElCustomer.ModifiedAt.ToString();
       
    }

    protected void CustomerUpdateButton_Click(object sender, EventArgs e)
    {
      
        ELCustomer ObjElCustomerUpdate = new ELCustomer();
        ObjElCustomerUpdate.Id = Guid.Parse(CustomerId);
       // ObjElCustomerUpdate.objProject.Id = Guid.Parse(ProjectId.Text);
        ObjElCustomerUpdate.Name = IdCustomerName.Text;
        ObjElCustomerUpdate.Modifier = Guid.Parse(Session["UserId"].ToString());
        ObjElCustomerUpdate.ModifiedAt = DateTime.Now;
        ObjDlCustomer.UpdateCustomer(ObjElCustomerUpdate, ObjConetion.connectionstring);
        //ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Record Inserted Successfully')", true);
        ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Updated Successfully');Window.location ='CustomerViewPage.aspx';", true);
    }
}