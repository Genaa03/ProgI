
namespace TUP_PI_EF_Qatar2022
{
    partial class FrmJugadores
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpDatos = new System.Windows.Forms.GroupBox();
            this.cboPosicion = new System.Windows.Forms.ComboBox();
            this.txtCamiseta = new System.Windows.Forms.TextBox();
            this.txtIdJugador = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cboEquipo = new System.Windows.Forms.ComboBox();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpLista = new System.Windows.Forms.GroupBox();
            this.lstJugadores = new System.Windows.Forms.ListBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.grpDatos.SuspendLayout();
            this.grpLista.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDatos
            // 
            this.grpDatos.Controls.Add(this.cboPosicion);
            this.grpDatos.Controls.Add(this.txtCamiseta);
            this.grpDatos.Controls.Add(this.txtIdJugador);
            this.grpDatos.Controls.Add(this.label6);
            this.grpDatos.Controls.Add(this.cboEquipo);
            this.grpDatos.Controls.Add(this.dtpFechaNacimiento);
            this.grpDatos.Controls.Add(this.txtNombre);
            this.grpDatos.Controls.Add(this.label5);
            this.grpDatos.Controls.Add(this.label4);
            this.grpDatos.Controls.Add(this.label3);
            this.grpDatos.Controls.Add(this.label2);
            this.grpDatos.Controls.Add(this.label1);
            this.grpDatos.Location = new System.Drawing.Point(16, 15);
            this.grpDatos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpDatos.Name = "grpDatos";
            this.grpDatos.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpDatos.Size = new System.Drawing.Size(500, 299);
            this.grpDatos.TabIndex = 0;
            this.grpDatos.TabStop = false;
            this.grpDatos.Text = "Datos del Jugador: ";
            // 
            // cboPosicion
            // 
            this.cboPosicion.AutoCompleteCustomSource.AddRange(new string[] {
            "1- ARQUERO",
            "2- DEFENSOR",
            "3- MEDIOCAMPISTA",
            "4- DELANTERO"});
            this.cboPosicion.Enabled = false;
            this.cboPosicion.FormattingEnabled = true;
            this.cboPosicion.Items.AddRange(new object[] {
            "1- Arquero",
            "2- Defensor",
            "3- Medio Campista",
            "4- Delantero"});
            this.cboPosicion.Location = new System.Drawing.Point(211, 198);
            this.cboPosicion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboPosicion.Name = "cboPosicion";
            this.cboPosicion.Size = new System.Drawing.Size(220, 24);
            this.cboPosicion.TabIndex = 9;
            this.cboPosicion.SelectedIndexChanged += new System.EventHandler(this.cboPosicion_SelectedIndexChanged);
            // 
            // txtCamiseta
            // 
            this.txtCamiseta.Enabled = false;
            this.txtCamiseta.Location = new System.Drawing.Point(211, 155);
            this.txtCamiseta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCamiseta.Name = "txtCamiseta";
            this.txtCamiseta.Size = new System.Drawing.Size(48, 22);
            this.txtCamiseta.TabIndex = 7;
            // 
            // txtIdJugador
            // 
            this.txtIdJugador.Enabled = false;
            this.txtIdJugador.Location = new System.Drawing.Point(211, 26);
            this.txtIdJugador.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIdJugador.Name = "txtIdJugador";
            this.txtIdJugador.ShortcutsEnabled = false;
            this.txtIdJugador.Size = new System.Drawing.Size(48, 22);
            this.txtIdJugador.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(131, 30);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "ID:";
            // 
            // cboEquipo
            // 
            this.cboEquipo.Enabled = false;
            this.cboEquipo.FormattingEnabled = true;
            this.cboEquipo.Location = new System.Drawing.Point(211, 69);
            this.cboEquipo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboEquipo.Name = "cboEquipo";
            this.cboEquipo.Size = new System.Drawing.Size(220, 24);
            this.cboEquipo.TabIndex = 3;
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Checked = false;
            this.dtpFechaNacimiento.Enabled = false;
            this.dtpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(211, 245);
            this.dtpFechaNacimiento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(127, 22);
            this.dtpFechaNacimiento.TabIndex = 11;
            this.dtpFechaNacimiento.Value = new System.DateTime(2022, 12, 19, 0, 0, 0, 0);
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Location = new System.Drawing.Point(211, 114);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(265, 22);
            this.txtNombre.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 251);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Fecha Nacimiento:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(92, 202);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Posición:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 159);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Camiseta Nº:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 118);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 73);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Equipo:";
            // 
            // grpLista
            // 
            this.grpLista.Controls.Add(this.lstJugadores);
            this.grpLista.Location = new System.Drawing.Point(551, 15);
            this.grpLista.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpLista.Name = "grpLista";
            this.grpLista.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpLista.Size = new System.Drawing.Size(500, 299);
            this.grpLista.TabIndex = 3;
            this.grpLista.TabStop = false;
            this.grpLista.Text = "Listado de Jugadores :";
            // 
            // lstJugadores
            // 
            this.lstJugadores.FormattingEnabled = true;
            this.lstJugadores.ItemHeight = 16;
            this.lstJugadores.Location = new System.Drawing.Point(8, 23);
            this.lstJugadores.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstJugadores.Name = "lstJugadores";
            this.lstJugadores.Size = new System.Drawing.Size(483, 260);
            this.lstJugadores.TabIndex = 0;
            this.lstJugadores.SelectedIndexChanged += new System.EventHandler(this.lstJugadores_SelectedIndexChanged);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(51, 332);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(225, 62);
            this.btnActualizar.TabIndex = 1;
            this.btnActualizar.Text = "Actualizar Jugador";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(792, 332);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(225, 62);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Enabled = false;
            this.btnGrabar.Location = new System.Drawing.Point(421, 332);
            this.btnGrabar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(225, 62);
            this.btnGrabar.TabIndex = 2;
            this.btnGrabar.Text = "Grabar Jugador";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // FrmJugadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 410);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.grpLista);
            this.Controls.Add(this.grpDatos);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmJugadores";
            this.Text = "Jugadores Qatar 2022";
            this.Load += new System.EventHandler(this.FrmJugadores_Load);
            this.grpDatos.ResumeLayout(false);
            this.grpDatos.PerformLayout();
            this.grpLista.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDatos;
        private System.Windows.Forms.ComboBox cboEquipo;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpLista;
        private System.Windows.Forms.ListBox lstJugadores;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.TextBox txtIdJugador;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboPosicion;
        private System.Windows.Forms.TextBox txtCamiseta;
    }
}

