﻿using EstacionaTEC.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace EstacionaTEC.Controllers.DAO
{
    public class DAOReservasVisitante : DAOSolicitudes
    {
        public bool create(object obj)
        {
            ReservasVisitante reserva = (ReservasVisitante)obj;
            int retorno;
            SqlConnection conexion = new SqlConnection("Data Source = ProyectoDisenno.mssql.somee.com; Initial Catalog = ProyectoDisenno; Persist Security Info=False;User ID = JohelPF_SQLLogin_1; Password=w7v8k5itwh;Packet Size = 4096; Workstation ID = ProyectoDisenno.mssql.somee.com");
            conexion.Open();
            String cadena = "exec ##### " + reserva.IdentificacionPersona + "," + reserva.IdEstacionamiento + "," + reserva.IdEspacio + "," + "'" + reserva.Placa + "'" + "," + "'" + reserva.HoraEntrada + "'" + "," + "'" + reserva.HoraSalida + "'" + reserva.Id + "," + "'"+ reserva.Motivo+ "'" + "," + "'" + reserva.Nombre + "'" + "," + "," + "'" + reserva.Sitio + "'";
            SqlCommand comando = new SqlCommand(cadena, conexion);
            retorno = (int)comando.ExecuteScalar();
            conexion.Close();
            return Convert.ToBoolean(retorno);
        }

        public bool delete(object obj)
        {
            throw new NotImplementedException();
        }

        public object get(int id)
        {
            throw new NotImplementedException();
        }

        public List<object> getAll()
        {
            throw new NotImplementedException();
        }

        public List<object> getBy(int id)
        {
            throw new NotImplementedException();
        }

        public bool update(object obj)
        {
            throw new NotImplementedException();
        }
    }
}