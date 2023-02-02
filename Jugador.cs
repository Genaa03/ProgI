using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TUP_PI_EF_Qatar2022
{
    class Jugador
    {
        public int IdJugador { get; set; }
        public int IdEquipo { get; set; }
        public string Nombre { get; set; }
        public int Camiseta { get; set; }
        public int Posicion { get; set; }
        public DateTime FechaNacimento { get; set; }

        public Jugador()
        {
            IdJugador = 0;
            IdEquipo = 0;
            Nombre = string.Empty;
            Camiseta = 0;
            Posicion = 0;
            FechaNacimento = DateTime.Today;
        }

        public Jugador(int idJugador, int idEquipo, string nombre, int camiseta, int posicion, DateTime fechaNacimento)
        {
            IdJugador = idJugador;
            IdEquipo = idEquipo;
            Nombre = nombre;
            Camiseta = camiseta;
            Posicion = posicion;
            FechaNacimento = fechaNacimento;
        }

        public override string ToString()
        {
            string Pos = "";

            if(Posicion == 0)
            {
                 Pos = "Arquero";
            }
            else
            {
                if (Posicion == 1)
                {
                    Pos = "Defensor";
                }
                else
                {
                    if (Posicion == 2)
                    {
                        Pos = "Mediocampista";
                    }
                    else
                    {
                        if (Posicion == 3)
                        {
                            Pos = "Delantero";
                        }
                    }
                }
            }
            
            

            return Nombre + " - " + Camiseta + " - " + Pos;
        }
    }
}
