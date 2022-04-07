using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication2.Model;

namespace WebApplication2
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            using (MIModel context = new MIModel())
            {
                var items = context.StorePurchasesView.ToList();
            }
        }
    }
}