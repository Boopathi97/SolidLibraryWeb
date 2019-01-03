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

public partial class CustomerViewPage : System.Web.UI.Page
{
    ConnectionClass ObjConetion = new ConnectionClass();
    List<ELCustomer> ELCustomerList = new List<ELCustomer>();
    DLCustomer ObjDlCoustomer = new DLCustomer();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            ViewCustomerData();
            BindGridList();
        }
    }
    protected void ViewCustomerData()
    {

        ELCustomerList = ObjDlCoustomer.SelectAllCustomer(ObjConetion.connectionstring);
        
    }
    protected void BindGridList()
    {
        GridViewCustomer.DataSource = ELCustomerList;
        GridViewCustomer.DataBind();
        //GridViewCustomer.HeaderRow.TableSection = TableRowSection.TableFooter;
        GridViewCustomer.HeaderRow.TableSection = TableRowSection.TableHeader;

    }




    protected void GridViewCustomer_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
    {
        //Response.Write(GridViewCustomer.Rows[e.NewSelectedIndex].Cells[2].Text);
        Response.Redirect("CustomerUbdatePage.aspx?CustomerId=" + GridViewCustomer.Rows[e.NewSelectedIndex].Cells[2].Text);
        //Response.Redirect(".aspx?projectId=" + GridViewCustomer.Rows[e.NewSelectedIndex].Cells[2].Text);
    }

    protected void GridViewCustomer_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        Response.Write(GridViewCustomer.Rows[e.RowIndex].Cells[2].Text);

        var proId = GridViewCustomer.Rows[e.RowIndex].Cells[2].Text;
        ELCustomer ObjElProjectDelete = new ELCustomer();
        ObjElProjectDelete.Id = Guid.Parse(proId);
        try
        {
            ObjDlCoustomer.DeleteCustomer(ObjElProjectDelete, ObjConetion.connectionstring);
        }
        catch (Exception)
        {


            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('You Cant Delete Customer because Its Refernce of Class')", true);
        }
        ViewCustomerData();
        BindGridList();

    }
    protected void ProjectBack_Click(object sender, EventArgs e)
    {
        Response.Redirect("ManuPage.aspx");
    }
}