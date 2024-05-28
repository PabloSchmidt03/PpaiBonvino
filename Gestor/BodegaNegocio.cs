using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Data.SqlClient;

namespace Gestor
{
    public class BodegaNegocio
    {
        public bool tieneActualizacionNovedadesVino(DateTime fechaActual, Bodega bodega)
        {
            int diferenciaMeses = ((fechaActual.Year - bodega.fechaUltimaActualizacion.Year) * 12) + fechaActual.Month - bodega.fechaUltimaActualizacion.Month;
            return diferenciaMeses >= bodega.periodoActualizacion;
        }

        public List<Bodega> listar()
        {
            List<Bodega> listaBodegas = new List<Bodega>();
            
            //Inicializaciones para lectura de BD
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;


            try
            {
                conexion.ConnectionString = "server= NOTEBOOK\\SQLEXPRESS; database=BonvinoDB; integrated security=true";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "SELECT Nombre as NombreBodega, fechaUltimaActualizacion, periodoActualizacion from bodega";
                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();

                while(lector.Read())
                {
                    Bodega aux = new Bodega();
                    aux.nombre = (string)lector["NombreBodega"];
                    aux.fechaUltimaActualizacion = (DateTime)lector["FechaUltimaActualizacion"];
                    aux.periodoActualizacion = (Int32)lector["periodoActualizacion"];

                    if (tieneActualizacionNovedadesVino(DateTime.Now, aux))
                    {
                        listaBodegas.Add(aux);
                    }
    
                   
                }
                conexion.Close();
                return listaBodegas;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
            
        }

    }
}
