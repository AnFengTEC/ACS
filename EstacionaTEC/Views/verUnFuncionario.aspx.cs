﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EstacionaTEC.Views
{
    public partial class verUnFuncionario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblFranjas.Text = "";
            lblVehiculos.Text = "";
            lblInfo.Text = "";
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            string parametro = txtIdentificacion.Text;
            lblId.Text = parametro;

            lblFranjas.Text = "Franjas Horarias";
            lblVehiculos.Text = "Vehículos Registrados";
            lblInfo.Text = "Información Personal";
        }

        protected void btnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("Informes.aspx");
        }
    }
}