using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.Data;
using System.Net.Sockets;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AplicaicionPersonasRemotoBD
{
    public class ClaseFunciones
    {
        public static string cadena = "workstation id=Bladimir_Class.mssql.somee.com;packet size = 4096; user id = marlonsmith67_SQLLogin_2; pwd=repmj5ov4k;data source = Bladimir_Class.mssql.somee.com; persist security info=False;initial catalog = Bladimir_Class; TrustServerCertificate=True";
        public static string excepcion = "";
        //Funcion Conectar
        public static bool Func_Conectar()
        {
            try
            {
                SqlConnection cnn = new SqlConnection(cadena);
                cnn.Open();
                cnn.Close();
                return true;

            }
            catch (Exception e)
            {
                excepcion = e.ToString();
                return false;
            }
        }
        public static DataTable Func_TraerDatos()
        {
            DataTable dt = new DataTable();
            try
            {
                SqlConnection cnn = new SqlConnection(cadena);
                //adpatador necesita una consulta sql y una conexion
                string consulta = "Select * From Tbl_Persona";
                SqlDataAdapter adap = new SqlDataAdapter(consulta, cnn);
                //ejecuto el adaptador para que llene los datos en una tabla
                adap.Fill(dt);
                return dt;

            }
            catch (Exception e)
            {
                excepcion = e.ToString();
                return dt;
            }
        }
        public static bool Func_Insertar(long id, string name, string tel)
        {
            DataTable dt = new DataTable();
            try
            {
                SqlConnection cnn = new SqlConnection(cadena);
                //adpatador necesita una consulta sql y una conexion
                string consulta = "Insert Into Tbl_Persona Values (" + id + ",'" + name + "','" + tel + "')";
                SqlDataAdapter adap = new SqlDataAdapter(consulta, cnn);
                //ejecuto el adaptador para que llene los datos en una tabla
                adap.Fill(dt);
                return true;

            }
            catch (Exception e)
            {
                excepcion = e.ToString();
                return false;
            }
        }
        public static bool Func_Eliminar(long id)
        {
            DataTable dt = new DataTable();
            try
            {
                SqlConnection cnn = new SqlConnection(cadena);
                //adpatador necesita una consulta sql y una conexion
                string consulta = "Delete From Tbl_Persona Where ID=" + id;
                SqlDataAdapter adap = new SqlDataAdapter(consulta, cnn);
                //ejecuto el adaptador para que llene los datos en una tabla
                adap.Fill(dt);
                return true;

            }
            catch (Exception e)
            {
                excepcion = e.ToString();
                return false;
            }
        }
        //Funcion Editar.
        public static bool Func_Editar(long id, string name, string tel)
        {
            DataTable dt = new DataTable();
            try
            {
                SqlConnection cnn = new SqlConnection(cadena);
                //adpatador necesita una consulta sql y una conexion
                string consulta = "Update Tbl_Persona Set Nombre='" + name + "', Telefono='" + tel + "' Where ID="+id;
                SqlDataAdapter adap = new SqlDataAdapter(consulta, cnn);
                //ejecuto el adaptador para que llene los datos en una tabla
                adap.Fill(dt);
                return true;

            }
            catch (Exception e)
            {
                excepcion = e.ToString();
                return false;
            }
        }
    }
}