using System;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using CoHomeWebService;

public partial class _Default : System.Web.UI.Page
{
    CoHomeWebService.CoHomeWebService proxy;

    protected void Page_Load(object sender, EventArgs e)
    {
        proxy = new CoHomeWebService.CoHomeWebService();
        String[] s = proxy.getlocation();
        Label1.Text=s[0];
        Label2.Text = s[1];
        Label3.Text = s[2];
    }

    protected void btnHello_Click(object sender, EventArgs e)
    {
        //Label1.Text = proxy.hello("Andrea");
    }
}