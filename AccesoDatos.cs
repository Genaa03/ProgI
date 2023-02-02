using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace TUP_PI_EF_Qatar2022
{
    internal class AccesoDatos
    {

        SqlConnection conexion = new SqlConnection(@"Data Source=138.99.7.66;Initial Catalog=Qatar2022;User ID = prog1; Password=1234prog");
        SqlCommand comando = new SqlCommand();

        private void Conectar()
        {
            conexion.Open();
            comando.Connection = conexion;
            comando.CommandType = CommandType.Text;
        }

        private void Desconectar()
        {
            conexion.Close();
        }


        public DataTable ConsultaSQL(string consulta)
        {
            DataTable dt = new DataTable();
            Conectar();

            comando.CommandText = consulta;
            dt.Load(comando.ExecuteReader());
            

            Desconectar();
            return dt;
        }

        

        public int insertParametros(string insert, Jugador j)
        {
            
            Conectar();

            //comando.Parameters.AddWithValue("@id_jugador", j.IdJugador);
            comando.Parameters.AddWithValue("@id_equipo", j.IdEquipo);
            comando.Parameters.AddWithValue("@nombre", j.Nombre);
            comando.Parameters.AddWithValue("@camiseta", j.Camiseta);
            comando.Parameters.AddWithValue("@posicion", j.Posicion);
            comando.Parameters.AddWithValue("@fecha_nacimiento", j.FechaNacimento);

            comando.CommandText = insert;
            int filas = comando.ExecuteNonQuery();
            comando.Parameters.Clear();

            Desconectar();
            return filas;

        }

        public int updateParametros(string update, Jugador j)
        {

            Conectar();
            comando.Parameters.Clear();

            comando.Parameters.AddWithValue("@id_jugador", j.IdJugador);
            comando.Parameters.AddWithValue("@id_equipo", j.IdEquipo);
            comando.Parameters.AddWithValue("@nombre", j.Nombre);
            comando.Parameters.AddWithValue("@camiseta", j.Camiseta);
            comando.Parameters.AddWithValue("@posicion", j.Posicion);
            comando.Parameters.AddWithValue("@fecha_nacimiento", j.FechaNacimento);

            comando.CommandText = update;
           int filas = comando.ExecuteNonQuery();
           comando.Parameters.Clear();

            Desconectar();
            return filas;

        }


    }
}
