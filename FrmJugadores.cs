using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//CURSO – LEGAJO – APELLIDO – NOMBRE

//Cadena de Conexión: "Data Source=sqlgabineteinformatico.frc.utn.edu.ar;Initial Catalog=Qatar2022;User ID=alumnolab22;Password=SQL-Alu22"

namespace TUP_PI_EF_Qatar2022
{
    public partial class FrmJugadores : Form
    {
        AccesoDatos oBD = new AccesoDatos();
        public FrmJugadores()
        {
            InitializeComponent();
        }

        private void FrmJugadores_Load(object sender, EventArgs e)
        {
            Habilitar(false);
            cargarLista();
            cargarCombo(cboEquipo, "Equipos");
        }

        private void cargarLista()
        {
            DataTable tabla = oBD.ConsultaSQL("SELECT * FROM JUGADORES");
            lstJugadores.Items.Clear();

            foreach(DataRow fila in tabla.Rows)
            {
                Jugador j = new Jugador();

                j.IdJugador = Convert.ToInt32(fila["id_jugador"].ToString());
                j.IdEquipo = Convert.ToInt32(fila["id_equipo"].ToString());
                j.Nombre = fila["nombre"].ToString();
                j.Camiseta = Convert.ToInt32(fila["camiseta"].ToString());
                j.Posicion = Convert.ToInt32(fila["posicion"].ToString());
                j.FechaNacimento = Convert.ToDateTime(fila["fecha_nacimiento"].ToString());

                lstJugadores.Items.Add(j);

            }
        }

        private void Habilitar(bool v)
        {
            
            txtNombre.Enabled = v;
            txtCamiseta.Enabled = v;
            cboEquipo.Enabled = v;
            cboPosicion.Enabled = v;
            dtpFechaNacimiento.Enabled = v;
            

            btnActualizar.Enabled = !v;
            btnGrabar.Enabled = v;
        }
        
        private void cargarCombo(ComboBox combo, string nomTabla)
        {
            DataTable dt =  oBD.ConsultaSQL("SELECT * FROM " + nomTabla + " ORDER BY 1");
            combo.DataSource = dt;
            combo.ValueMember = dt.Columns[0].ColumnName;
            combo.DisplayMember = dt.Columns[1].ColumnName;
            cboEquipo.SelectedIndex = -1;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Habilitar(true);
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {

                Jugador j = new Jugador();

                j.IdJugador = Convert.ToInt32(txtIdJugador.Text);
                j.IdEquipo = 0;
                j.Nombre = txtNombre.Text;
                j.Camiseta = Convert.ToInt32(txtCamiseta.Text);
                j.Posicion = Convert.ToInt32(cboPosicion.SelectedIndex);
                j.FechaNacimento = Convert.ToDateTime(dtpFechaNacimiento.Value);

                Validar();
                oBD.updateParametros("UPDATE Jugadores SET id_equipo=@id_equipo, nombre=@nombre,camiseta=@camiseta, " +
                    "posicion=@posicion, fecha_nacimiento=@fecha_nacimiento WHERE id_jugador=@id_jugador", j);

                //oBD.insertParametros("INSERT INTO Jugadores (id_equipo, nombre, camiseta, posicion, fecha_nacimiento) VALUES " +
                //    "(@id_equipo, @nombre, @camiseta, @posicion, @fecha_nacimiento)" , j);

                cargarLista();
                Habilitar(false);
                Limpiar();
            }
        }

        private bool Validar()
        {
            if (String.IsNullOrEmpty(txtNombre.Text) || String.IsNullOrEmpty(txtCamiseta.Text) || cboEquipo.SelectedIndex == -1 || cboPosicion.SelectedIndex == -1)
            {
                MessageBox.Show("Algun campo esta vacio ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return false;
            }
            if (Convert.ToInt32(txtCamiseta.Text) > 26 || Convert.ToInt32(txtCamiseta.Text) < 1)
            {
                MessageBox.Show(" El numero debe ser desde 1 hasta 26 ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return false;
            }
            if (dtpFechaNacimiento.Value > DateTime.Today.AddYears(-18))
            {
                MessageBox.Show(" El jugador debe ser mayor a 18 años", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return false;
                
            }
            
            if (cboPosicion.SelectedIndex == 0)
            {
                if (Convert.ToInt32(txtCamiseta.Text) == 1 || Convert.ToInt32(txtCamiseta.Text) == 12 || Convert.ToInt32(txtCamiseta.Text) == 23 )
                {
                    return true;
                        
                }
                else
                {
                    MessageBox.Show(" El arquero debe usar los numeros 1, 12 o 23", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                            return false;
                }
            }
            if(cboPosicion.SelectedIndex != 0)
            {
                if (Convert.ToInt32(txtCamiseta.Text) == 1 || Convert.ToInt32(txtCamiseta.Text) == 12 || Convert.ToInt32(txtCamiseta.Text) == 23)
                {
                    MessageBox.Show(" Los numeros 1, 12 y 23 son solo para Arqueros", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    return false;
                    

                }
                else
                {
                    return true;
                }
            }

            return true;
            
            
        }

        private void cboPosicion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show(" Desea salir de la aplicacion", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Close();
            }
        }

        private void Limpiar()
        {
            txtNombre.Text = "";
            txtCamiseta.Text = "";
            cboEquipo.SelectedIndex = -1;
            cboPosicion.SelectedIndex = -1;
            dtpFechaNacimiento.Value = DateTime.Today;
        }

        private void lstJugadores_SelectedIndexChanged(object sender, EventArgs e)
        {
            Jugador j1 = (Jugador)lstJugadores.SelectedItem;
            txtIdJugador.Text = j1.IdJugador.ToString();
            txtNombre.Text = j1.Nombre;
            txtCamiseta.Text = j1.Camiseta.ToString();
            cboEquipo.SelectedIndex = 0;
            cboPosicion.SelectedIndex = j1.Posicion;
            dtpFechaNacimiento.Value = j1.FechaNacimento;
        }
    }
}
