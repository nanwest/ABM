﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AdmEdificios.Presentacion
{
    public partial class Home : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Email"] == null)
            {

                Response.Redirect("~/Presentacion/Login.aspx");
            }
            else
            {
                string usuarioLogueado = Session["Email"].ToString();
                lblUsuario.Text = usuarioLogueado;
            }
        }

        protected void btnSalir_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Session.Clear();
            Response.Redirect("~/Presentacion/Login.aspx");
        }
    }
}