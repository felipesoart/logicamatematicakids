﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KidsLogicaMatematica
{
    public partial class _Default : Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
               
                    Response.Redirect("~/index.aspx"); // Redireciona para a página index.aspx
               
            }           
        }
    }
}