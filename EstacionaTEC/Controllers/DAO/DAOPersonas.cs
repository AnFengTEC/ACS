﻿using EstacionaTEC.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
/*
 * conexion ejemplo
            SqlConnection conexion = new SqlConnection("Data Source=DatabaseServer;Initial Catalog=ProyectoDisenno;User ID=JohelPF_SQLLogin_1;Password=w7v8k5itwh");
            conexion.Open();
            String cadena = "exec nombreprocedure " + parametro1 + parametro2 + ...;
            SqlCommand comando = new SqlCommand(cadena, conexion);
            SqlDataReader registro = comando.ExecuteScalar();

            */
namespace EstacionaTEC.Controllers.DAO
{
    public class DAOPersonas : DAOSolicitudes
    {

        public bool create(Object obj)
        {
            Persona persona = (Persona)obj;
            int retorno;
            SqlConnection conexion = new SqlConnection("Data Source = ProyectoDisenno.mssql.somee.com; Initial Catalog = ProyectoDisenno; Persist Security Info=False;User ID = JohelPF_SQLLogin_1; Password=w7v8k5itwh;Packet Size = 4096; Workstation ID = ProyectoDisenno.mssql.somee.com");
            conexion.Open();
            String cadena = "exec insertarPersona " +persona.Identificacion  + ","+ "'" + persona.NombreCompleto+ "'" + "," +  persona.NumTelefono +","+ "'" + persona.CorreoInstitucional+ "'" + ","+ "'" + persona.CorreoAlterno+ "'" + ","+ persona.Departamento +","+ persona.EsJefatura +"," + persona.EsAdmin +","+ persona.ServiciosEspeciales +","+ persona.EsAdministrativo +","+ persona.EstaEnPlanilla +","+ "'" + persona.Contraseña+ "'";
            SqlCommand comando = new SqlCommand(cadena, conexion);
            retorno = (int)comando.ExecuteScalar();
            conexion.Close();
            return Convert.ToBoolean(retorno);
        } 

        public bool delete(object x)
        {
            throw new NotImplementedException();
        }


        public object get(int id)
        {
            Persona retorno;
            SqlConnection conexion = new SqlConnection("Data Source = ProyectoDisenno.mssql.somee.com; Initial Catalog = ProyectoDisenno; Persist Security Info=False;User ID = JohelPF_SQLLogin_1; Password=w7v8k5itwh;Packet Size = 4096; Workstation ID = ProyectoDisenno.mssql.somee.com");
            conexion.Open();
            String cadena = "exec verPersona " + id;
            SqlCommand comando = new SqlCommand(cadena, conexion);
            SqlDataReader reader = comando.ExecuteReader();
            reader.Read();
            if (reader.HasRows)
            {
                retorno = new Persona(reader.GetInt32(0), reader.GetString(1), reader.GetInt32(2), reader.GetString(3), reader.GetString(4), reader.GetInt32(5), reader.GetBoolean(6), reader.GetBoolean(7), reader.GetBoolean(8),reader.GetBoolean(9),reader.GetBoolean(10),"");
                reader.Close();
                conexion.Close();
                return retorno;
            }
            else
            {
                reader.Close();
                conexion.Close();
                return false;
            }
        }

        public List<object> getAll()
        {
            List<Object> personas = new List<Object>();
            SqlConnection conexion = new SqlConnection("Data Source = ProyectoDisenno.mssql.somee.com; Initial Catalog = ProyectoDisenno; Persist Security Info=False;User ID = JohelPF_SQLLogin_1; Password=w7v8k5itwh;Packet Size = 4096; Workstation ID = ProyectoDisenno.mssql.somee.com");
            conexion.Open();
            String cadena = "exec verTodasPersonas";
            SqlCommand comando = new SqlCommand(cadena, conexion);
            SqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                if (reader.HasRows)
                {
                    Persona persona = new Persona(reader.GetInt32(0), reader.GetString(1), reader.GetInt32(2), reader.GetString(3), reader.GetString(4), reader.GetInt32(5), reader.GetBoolean(6), reader.GetBoolean(7), reader.GetBoolean(8), reader.GetBoolean(9), reader.GetBoolean(10), "");
                    personas.Add(persona);
                }
            }
            return personas;
        }

        public List<object> getBy(int id)
        {
            List<Object> personas = new List<Object>();
            SqlConnection conexion = new SqlConnection("Data Source = ProyectoDisenno.mssql.somee.com; Initial Catalog = ProyectoDisenno; Persist Security Info=False;User ID = JohelPF_SQLLogin_1; Password=w7v8k5itwh;Packet Size = 4096; Workstation ID = ProyectoDisenno.mssql.somee.com");
            conexion.Open();
            String cadena = "exec buscarPersonasPorDepartamento " + id;
            SqlCommand comando = new SqlCommand(cadena, conexion);
            SqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                if (reader.HasRows)
                {
                    Persona persona = new Persona(reader.GetInt32(0), reader.GetString(1), reader.GetInt32(2), reader.GetString(3), reader.GetString(4), reader.GetInt32(5), reader.GetBoolean(6), reader.GetBoolean(7), reader.GetBoolean(8), reader.GetBoolean(9), reader.GetBoolean(10), "");
                    personas.Add(persona);
                }
            }
            return personas;
        }


        public bool update(object obj)
        {
            Persona persona = (Persona)obj;
            int retorno;
            SqlConnection conexion = new SqlConnection("Data Source = ProyectoDisenno.mssql.somee.com; Initial Catalog = ProyectoDisenno; Persist Security Info=False;User ID = JohelPF_SQLLogin_1; Password=w7v8k5itwh;Packet Size = 4096; Workstation ID = ProyectoDisenno.mssql.somee.com");
            conexion.Open();
            String cadena = "exec editarPersona " + persona.Identificacion + "," + "'" + persona.NombreCompleto + "'" + "," + persona.NumTelefono + "," + "'" + persona.CorreoInstitucional + "'" +"," + "'" +persona.CorreoAlterno+ "'"+ "," + persona.Departamento + "," + persona.EsJefatura + "," + persona.EsAdmin + "," + persona.ServiciosEspeciales + "," + persona.EsAdministrativo + "," + persona.EstaEnPlanilla;
            SqlCommand comando = new SqlCommand(cadena, conexion);
            retorno = (int)comando.ExecuteScalar();
            conexion.Close();
            return Convert.ToBoolean(retorno);
        }
    }
}