using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using CapaEntidades;

namespace CapaDatos
{
    public class D_Aula
    {
        static string conn_string = System.Configuration.ConfigurationManager.ConnectionStrings["connection_string"].ConnectionString;

        SqlConnection conexion = new SqlConnection(conn_string);

        //Metodo para insertar Aula
        public void insertAula(E_Aula e_Aula)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand("SP_INSERTARAULA", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ID_Aula", e_Aula.IdAula);
            cmd.Parameters.AddWithValue("@Edificio", e_Aula.Edificio);
            cmd.ExecuteNonQuery();
            conexion.Close();

        }
        //Actualizar aula
        public void updateAula(E_Aula e_Aula, String newId)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand("SP_ACTUALIZARAULA", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ID_Actualizar", newId);
            cmd.Parameters.AddWithValue("@ID_Aula", e_Aula.IdAula);
            cmd.Parameters.AddWithValue("@Edificio", e_Aula.Edificio);
            cmd.ExecuteNonQuery();
            conexion.Close();

        }
        //Listar aula por id
        public List<E_Aula> listarPorId(String buscar)
        {
            SqlDataReader reader;
            SqlCommand cmd = new SqlCommand("SP_BUSCARAULA", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();
            cmd.Parameters.AddWithValue("@Buscar", buscar);
            reader = cmd.ExecuteReader();
            List<E_Aula> listar = new List<E_Aula>();

            while (reader.Read())
            {
                listar.Add(new E_Aula
                {
                    IdAula = reader.GetString(0),
                    Edificio = reader.GetInt32(1)
                });
            }
            conexion.Close();
            return listar;
        }

        //Listar aula por edificio
        public List<E_Aula> listarPorEdificio(int buscar)
        {
            conexion.Open();
            SqlDataReader reader;
            SqlCommand cmd = new SqlCommand("SP_BUSCARAUPEDI", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Edificio", buscar);
            reader = cmd.ExecuteReader();
            List<E_Aula> listar = new List<E_Aula>();

            while (reader.Read())
            {
                listar.Add(new E_Aula
                {
                    IdAula = reader.GetString(0),
                    Edificio = reader.GetInt32(1)
                });
            }
            conexion.Close();
            return listar;
        }

        //Eliminar aula
        public void deleteAula(E_Aula e_Aula)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand("SP_ELIMINARAULA", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ID_Aula", e_Aula.IdAula);
            cmd.ExecuteNonQuery();
            conexion.Close();
        }
    }
}
