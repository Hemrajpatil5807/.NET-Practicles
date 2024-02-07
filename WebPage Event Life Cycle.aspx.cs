using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practice
{
    public partial class WebPage_Event_Life_Cycle : System.Web.UI.Page
    {
        protected override void OnPreInit(EventArgs e)
        {
            Response.Write("<br/> This is before Initialization.");
            base.OnPreInit(e);
        }
        protected override void OnInit(EventArgs e)
        {
            Response.Write("<br/> This is Initialization.");
            base.OnInit(e);
        }
        protected override void OnInitComplete(EventArgs e)
        {
            Response.Write("<br/> This is initialization complete.");
            base.OnInitComplete(e);
        }
        protected override void OnPreLoad(EventArgs e)
        {
            Response.Write("<br/> This is before page loading.");
            base.OnPreLoad(e);
        }
        protected override void OnLoad(EventArgs e)
        {
            Response.Write("<br/> This is  page loading .");
            base.OnLoad(e);
        }
        protected override void OnLoadComplete(EventArgs e)
        {
            Response.Write("<br/> This is  page loading  complete.");
            base.OnLoadComplete(e);
        }
        protected override void OnPreRender(EventArgs e)
        {
            Response.Write("<br/> This is  page.");
            base.OnPreRender(e);
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Unnamed1_Click(object sender, EventArgs e)
        {

        }
    }
}