
namespace AnalizadorLexico
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCargarPrograma = new System.Windows.Forms.Button();
            this.btnEditarPrograma = new System.Windows.Forms.Button();
            this.btnGuardarPrograma = new System.Windows.Forms.Button();
            this.btnGuardarArchivo = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAnalizador = new System.Windows.Forms.Button();
            this.btnConexion = new System.Windows.Forms.Button();
            this.dgvSimbolos = new System.Windows.Forms.DataGridView();
            this.rtxtProgramaFuente = new System.Windows.Forms.RichTextBox();
            this.numberLabel = new System.Windows.Forms.Label();
            this.LineNumberTextBox = new System.Windows.Forms.RichTextBox();
            this.btnGuardarCadena = new System.Windows.Forms.Button();
            this.rtxtArchivoTokens = new System.Windows.Forms.RichTextBox();
            this.rtxtErrores = new System.Windows.Forms.RichTextBox();
            this.lblErrores = new System.Windows.Forms.Label();
            this.txtErrores = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSimbolos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "PROGRAMA FUENTE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(602, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(311, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "ARCHIVO DE TOKENS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1005, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "ERRORES";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1236, 50);
            this.panel1.TabIndex = 6;
            // 
            // btnCargarPrograma
            // 
            this.btnCargarPrograma.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnCargarPrograma.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCargarPrograma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargarPrograma.Font = new System.Drawing.Font("Century", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarPrograma.Location = new System.Drawing.Point(58, 430);
            this.btnCargarPrograma.Name = "btnCargarPrograma";
            this.btnCargarPrograma.Size = new System.Drawing.Size(79, 41);
            this.btnCargarPrograma.TabIndex = 7;
            this.btnCargarPrograma.Text = "Cargar";
            this.btnCargarPrograma.UseVisualStyleBackColor = false;
            this.btnCargarPrograma.Click += new System.EventHandler(this.btnCargarPrograma_Click);
            // 
            // btnEditarPrograma
            // 
            this.btnEditarPrograma.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnEditarPrograma.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditarPrograma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarPrograma.Font = new System.Drawing.Font("Century", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarPrograma.Location = new System.Drawing.Point(143, 430);
            this.btnEditarPrograma.Name = "btnEditarPrograma";
            this.btnEditarPrograma.Size = new System.Drawing.Size(79, 41);
            this.btnEditarPrograma.TabIndex = 9;
            this.btnEditarPrograma.Text = "Editar";
            this.btnEditarPrograma.UseVisualStyleBackColor = false;
            this.btnEditarPrograma.Click += new System.EventHandler(this.btnEditarPrograma_Click);
            // 
            // btnGuardarPrograma
            // 
            this.btnGuardarPrograma.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnGuardarPrograma.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuardarPrograma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarPrograma.Font = new System.Drawing.Font("Century", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarPrograma.Location = new System.Drawing.Point(228, 430);
            this.btnGuardarPrograma.Name = "btnGuardarPrograma";
            this.btnGuardarPrograma.Size = new System.Drawing.Size(93, 41);
            this.btnGuardarPrograma.TabIndex = 10;
            this.btnGuardarPrograma.Text = "Guardar";
            this.btnGuardarPrograma.UseVisualStyleBackColor = false;
            this.btnGuardarPrograma.Click += new System.EventHandler(this.btnGuardarPrograma_Click);
            // 
            // btnGuardarArchivo
            // 
            this.btnGuardarArchivo.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnGuardarArchivo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuardarArchivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarArchivo.Font = new System.Drawing.Font("Century", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarArchivo.Location = new System.Drawing.Point(637, 430);
            this.btnGuardarArchivo.Name = "btnGuardarArchivo";
            this.btnGuardarArchivo.Size = new System.Drawing.Size(234, 41);
            this.btnGuardarArchivo.TabIndex = 11;
            this.btnGuardarArchivo.Text = "Guardar";
            this.btnGuardarArchivo.UseVisualStyleBackColor = false;
            this.btnGuardarArchivo.Click += new System.EventHandler(this.btnGuardarArchivo_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1149, 477);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAnalizador
            // 
            this.btnAnalizador.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnAnalizador.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAnalizador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnalizador.Font = new System.Drawing.Font("Century", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnalizador.Location = new System.Drawing.Point(438, 182);
            this.btnAnalizador.Name = "btnAnalizador";
            this.btnAnalizador.Size = new System.Drawing.Size(127, 41);
            this.btnAnalizador.TabIndex = 13;
            this.btnAnalizador.Text = "Analizador";
            this.btnAnalizador.UseVisualStyleBackColor = false;
            this.btnAnalizador.Click += new System.EventHandler(this.btnAnalizador_Click);
            // 
            // btnConexion
            // 
            this.btnConexion.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnConexion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConexion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConexion.Font = new System.Drawing.Font("Century", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConexion.Location = new System.Drawing.Point(438, 336);
            this.btnConexion.Name = "btnConexion";
            this.btnConexion.Size = new System.Drawing.Size(127, 41);
            this.btnConexion.TabIndex = 14;
            this.btnConexion.Text = "conexion";
            this.btnConexion.UseVisualStyleBackColor = false;
            this.btnConexion.Click += new System.EventHandler(this.btnConexion_Click);
            // 
            // dgvSimbolos
            // 
            this.dgvSimbolos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSimbolos.Location = new System.Drawing.Point(37, 506);
            this.dgvSimbolos.Name = "dgvSimbolos";
            this.dgvSimbolos.Size = new System.Drawing.Size(1187, 269);
            this.dgvSimbolos.TabIndex = 15;
            // 
            // rtxtProgramaFuente
            // 
            this.rtxtProgramaFuente.Location = new System.Drawing.Point(64, 110);
            this.rtxtProgramaFuente.Name = "rtxtProgramaFuente";
            this.rtxtProgramaFuente.Size = new System.Drawing.Size(368, 316);
            this.rtxtProgramaFuente.TabIndex = 16;
            this.rtxtProgramaFuente.Text = "";
            this.rtxtProgramaFuente.SelectionChanged += new System.EventHandler(this.rtxtProgramaFuente_SelectionChanged);
            this.rtxtProgramaFuente.VScroll += new System.EventHandler(this.rtxtProgramaFuente_VScroll);
            this.rtxtProgramaFuente.FontChanged += new System.EventHandler(this.rtxtProgramaFuente_FontChanged);
            this.rtxtProgramaFuente.TextChanged += new System.EventHandler(this.rtxtProgramaFuente_TextChanged);
            // 
            // numberLabel
            // 
            this.numberLabel.AutoSize = true;
            this.numberLabel.Location = new System.Drawing.Point(14, 111);
            this.numberLabel.Name = "numberLabel";
            this.numberLabel.Size = new System.Drawing.Size(0, 13);
            this.numberLabel.TabIndex = 17;
            // 
            // LineNumberTextBox
            // 
            this.LineNumberTextBox.Location = new System.Drawing.Point(37, 110);
            this.LineNumberTextBox.Name = "LineNumberTextBox";
            this.LineNumberTextBox.Size = new System.Drawing.Size(24, 316);
            this.LineNumberTextBox.TabIndex = 18;
            this.LineNumberTextBox.Text = "";
            // 
            // btnGuardarCadena
            // 
            this.btnGuardarCadena.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnGuardarCadena.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuardarCadena.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarCadena.Font = new System.Drawing.Font("Century", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarCadena.Location = new System.Drawing.Point(438, 258);
            this.btnGuardarCadena.Name = "btnGuardarCadena";
            this.btnGuardarCadena.Size = new System.Drawing.Size(127, 58);
            this.btnGuardarCadena.TabIndex = 19;
            this.btnGuardarCadena.Text = "guardar cadena";
            this.btnGuardarCadena.UseVisualStyleBackColor = false;
            this.btnGuardarCadena.Click += new System.EventHandler(this.btnGuardarCadena_Click);
            // 
            // rtxtArchivoTokens
            // 
            this.rtxtArchivoTokens.Location = new System.Drawing.Point(571, 111);
            this.rtxtArchivoTokens.Name = "rtxtArchivoTokens";
            this.rtxtArchivoTokens.Size = new System.Drawing.Size(368, 316);
            this.rtxtArchivoTokens.TabIndex = 20;
            this.rtxtArchivoTokens.Text = "";
            // 
            // rtxtErrores
            // 
            this.rtxtErrores.Location = new System.Drawing.Point(978, 107);
            this.rtxtErrores.Name = "rtxtErrores";
            this.rtxtErrores.Size = new System.Drawing.Size(218, 319);
            this.rtxtErrores.TabIndex = 21;
            this.rtxtErrores.Text = "";
            // 
            // lblErrores
            // 
            this.lblErrores.AutoSize = true;
            this.lblErrores.Location = new System.Drawing.Point(1112, 430);
            this.lblErrores.Name = "lblErrores";
            this.lblErrores.Size = new System.Drawing.Size(84, 13);
            this.lblErrores.TabIndex = 22;
            this.lblErrores.Text = "Cantidad errores";
            // 
            // txtErrores
            // 
            this.txtErrores.Location = new System.Drawing.Point(1133, 445);
            this.txtErrores.Name = "txtErrores";
            this.txtErrores.ReadOnly = true;
            this.txtErrores.Size = new System.Drawing.Size(47, 20);
            this.txtErrores.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1236, 783);
            this.Controls.Add(this.txtErrores);
            this.Controls.Add(this.lblErrores);
            this.Controls.Add(this.rtxtErrores);
            this.Controls.Add(this.rtxtArchivoTokens);
            this.Controls.Add(this.btnGuardarCadena);
            this.Controls.Add(this.LineNumberTextBox);
            this.Controls.Add(this.numberLabel);
            this.Controls.Add(this.rtxtProgramaFuente);
            this.Controls.Add(this.dgvSimbolos);
            this.Controls.Add(this.btnConexion);
            this.Controls.Add(this.btnAnalizador);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnGuardarArchivo);
            this.Controls.Add(this.btnGuardarPrograma);
            this.Controls.Add(this.btnEditarPrograma);
            this.Controls.Add(this.btnCargarPrograma);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSimbolos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCargarPrograma;
        private System.Windows.Forms.Button btnEditarPrograma;
        private System.Windows.Forms.Button btnGuardarPrograma;
        private System.Windows.Forms.Button btnGuardarArchivo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAnalizador;
        private System.Windows.Forms.Button btnConexion;
        private System.Windows.Forms.DataGridView dgvSimbolos;
        private System.Windows.Forms.RichTextBox rtxtProgramaFuente;
        private System.Windows.Forms.Label numberLabel;
        private System.Windows.Forms.RichTextBox LineNumberTextBox;
        private System.Windows.Forms.Button btnGuardarCadena;
        private System.Windows.Forms.RichTextBox rtxtArchivoTokens;
        private System.Windows.Forms.RichTextBox rtxtErrores;
        private System.Windows.Forms.Label lblErrores;
        private System.Windows.Forms.TextBox txtErrores;
    }
}

