﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EstacionaTEC.Views
{
    public partial class EditarFuncionarios : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Consulta del nombre del usuario
            DataView dv = (DataView)sqlGetNombre.Select(DataSourceSelectArguments.Empty);
            //Se convierte el resultado en una tabla
            DataTable groupsTable = dv.ToTable();

            //Variables a usar
            String nombre = "";

            //Se asignan los valores en las variables
            nombre = (String)groupsTable.Rows[0][0];
            lblNombre.Text = nombre;
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            String IDFuncionario = gridViewFuncionarios.SelectedRow.Cells[1].Text;
            Session["FuncionarioEditar"] = IDFuncionario;
            Response.Redirect("EditarFuncionarioIndividual.aspx");
        }

        protected void btnMenu_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdministradorLanding.aspx");
        }
    }
}