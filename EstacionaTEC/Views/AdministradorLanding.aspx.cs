﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EstacionaTEC.Views
{
    public partial class AdministradorLanding : System.Web.UI.Page
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

        protected void btnCrearEstacionamiento_Click(object sender, EventArgs e)
        {
            Response.Redirect("CrearEstacionamiento.aspx");
        }

        protected void btnRegistrarUsuario_Click(object sender, EventArgs e)
        {
            Response.Redirect("CrearFuncionario.aspx");
        }

        protected void btnAgregarEspacio_Click(object sender, EventArgs e)
        {
            Response.Redirect("AgregarEspacio.aspx");
        }

        protected void btnEditarUsuario_Click(object sender, EventArgs e)
        {
            Response.Redirect("EditarFuncionarios.aspx");
        }

        protected void btnInformes_Click(object sender, EventArgs e)
        {
            Response.Redirect("Informes.aspx");
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("CrearFuncionario.aspx");
        }

        protected void ImageButton3_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("EditarFuncionarios.aspx");
        }

        protected void ImageButton4_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("CrearEstacionamiento.aspx");
        }

        protected void ImageButton5_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("AgregarEspacio.aspx");
        }

        protected void ImageButton6_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("Informes.aspx");
        }

        protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("CrearOperador.aspx");
        }

        protected void ImageButton7_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("CrearReservaAdmin.aspx");
        }
    }
}