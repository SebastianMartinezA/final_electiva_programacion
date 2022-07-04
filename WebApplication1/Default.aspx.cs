using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using Negocio;

namespace WebApplication1
{
    public partial class _Default : Page
    {
        private DireccionTransito dt;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                dt = new DireccionTransito();
                Session["dt"] = dt;
            }
        }
    }
}