﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Agriculture
{
    public partial class Master : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnData_Click(object sender, EventArgs e)
        {
            Response.Redirect("Data.aspx");
        }

        protected void btnAction_Click(object sender, EventArgs e)
        {
            Response.Redirect("Action.aspx");
        }
    }
}