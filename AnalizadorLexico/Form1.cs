using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO; //se agrego la libreria
using System.Xml;

namespace AnalizadorLexico
{
    public partial class Form1 : Form
    {
        EjecutorQuerys miConexion = new EjecutorQuerys();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAnalizador_Click(object sender, EventArgs e)
        {
            Cadena miCadena = new Cadena();
            Automata miAutomata = new Automata();

            miCadena.Caracteres = rtxtProgramaFuente.Text.ToCharArray();

            
            foreach (char caracterActual in miCadena.Caracteres)
            {
                if (caracterActual != char.Parse("\n"))
                {
                    if (char.IsUpper(caracterActual))
                    {
                        miAutomata.BuscarSiguienteEstado(caracterActual.ToString() + "1", miConexion);
                    }
                    else
                    {
                        miAutomata.BuscarSiguienteEstado(caracterActual.ToString(), miConexion);
                    }
                    if (char.IsWhiteSpace(caracterActual))
                    {
                        miAutomata.BuscarSiguienteEstado("Δ", miConexion);
                    }
                }
            }
            string ArchivoToken = "";
            foreach (Token token in miAutomata.lstTokens)
            {
                ArchivoToken = ArchivoToken + " " + token.CAT;
            }
            rtxtArchivoTokens.Text = ArchivoToken;

            string Errores = "";
            foreach (Error error in miAutomata.lstErrores)
            {
                Errores = Errores + error.CatError;
            }
            rtxtErrores.Text = Errores;

            txtErrores.Text = miAutomata.lstErrores.Count.ToString();
        }
        

        private void btnConexion_Click(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LineNumberTextBox.Font = rtxtProgramaFuente.Font;
            rtxtProgramaFuente.Select();
            AddLineNumbers();


            miConexion.CargarSimbolos(dgvSimbolos);
        }

        private void btnCargarPrograma_Click(object sender, EventArgs e)
        {
            OpenFileDialog miArchivo = new OpenFileDialog(); //Se inicializa el constructor.
            StreamReader miLectura = null;

            miArchivo.Filter = "Archivos de texto (.txt)|*.txt|Todos los archivos (*.*)|*.*"; //se abre cualquier tipo.
            miArchivo.Title ="Abrir archivo "; //titulo del mensaje de dialogo
            miArchivo.ShowDialog(); //se abre el dialogo
            miArchivo.OpenFile(); //abrimos el documento
            string ruta = miArchivo.FileName; //obtiene o establece el nombre de archivos.


            miLectura = File.OpenText(ruta); //abre el archivo y se asigna en el objeto lectura, que contiene todos los parametros.
            rtxtProgramaFuente.Text = miLectura.ReadToEnd();
            rtxtProgramaFuente.Enabled = false;



        }

        private void btnEditarPrograma_Click(object sender, EventArgs e)
        {
            rtxtProgramaFuente.Enabled = true;

        }

        private void btnGuardarPrograma_Click(object sender, EventArgs e)
        {
            SaveFileDialog Guardar = new SaveFileDialog();
            StreamWriter miEscritura = null;
            Guardar.Filter="Archivos de texto (.txt)|*.txt|Todos los archivos (*.*)|*.*"; //se abre cualquier tipo.
            Guardar.Title = "Guardar como..."; //titulo del mensaje de dialogo
            Guardar.ShowDialog();
            string ruta = Guardar.FileName; //ruta para guardar el programa.
            miEscritura = File.AppendText(ruta); //ruta donde se guarda el archivo
            miEscritura.Write(rtxtProgramaFuente.Text); //todo lo que esta en el richtexbox se guarda...
            miEscritura.Flush(); //todos los datos escribe y borra el buffer... toma el texto y lo escribe en el txt. 
        }

        private void btnGuardarArchivo_Click(object sender, EventArgs e)
        {
            SaveFileDialog Guardar = new SaveFileDialog();
            StreamWriter miEscritura = null;
            Guardar.Filter = "Archivos de texto (.txt)|*.txt|Todos los archivos (*.*)|*.*"; //se abre cualquier tipo.
            Guardar.Title = "Guardar como..."; //titulo del mensaje de dialogo
            Guardar.ShowDialog();
            string ruta = Guardar.FileName; //ruta para guardar el programa.
            miEscritura = File.AppendText(ruta); //ruta donde se guarda el archivo
            miEscritura.Write(rtxtArchivoTokens.Text); //todo lo que esta en el richtexbox se guarda...
            miEscritura.Flush(); //todos los datos escribe y borra el buffer... toma el texto y lo escribe en el txt. 
        }


        //Numeracion del richtexbox
        public int getWidth()
        {
            int w = 25;
            // get total lines of richTextBox1    
            int line = rtxtProgramaFuente.Lines.Length;

            if (line <= 99)
            {
                w = 20 + (int)rtxtProgramaFuente.Font.Size;
            }
            else if (line <= 999)
            {
                w = 30 + (int)rtxtProgramaFuente.Font.Size;
            }
            else
            {
                w = 50 + (int)rtxtProgramaFuente.Font.Size;
            }

            return w;
        }
        public void AddLineNumbers()
        {
            // create & set Point pt to (0,0)    
            Point pt = new Point(0, 0);
            // get First Index & First Line from richTextBox1    
            int First_Index = rtxtProgramaFuente.GetCharIndexFromPosition(pt);
            int First_Line = rtxtProgramaFuente.GetLineFromCharIndex(First_Index);
            // set X & Y coordinates of Point pt to ClientRectangle Width & Height respectively    
            pt.X = ClientRectangle.Width;
            pt.Y = ClientRectangle.Height;
            // get Last Index & Last Line from richTextBox1    
            int Last_Index = rtxtProgramaFuente.GetCharIndexFromPosition(pt);
            int Last_Line = rtxtProgramaFuente.GetLineFromCharIndex(Last_Index);
            //set Center alignment to LineNumberTextBox
            LineNumberTextBox.SelectionAlignment = HorizontalAlignment.Center;
            // set LineNumberTextBox text to null & width to getWidth() function value    
            LineNumberTextBox.Text = "";
            LineNumberTextBox.Width = getWidth();
            // now add each line number to LineNumberTextBox upto last line    
            for (int i = First_Line; i <= Last_Line + 50; i++)
            {
                LineNumberTextBox.Text += i + 1 + "\n";
            }
        }

        private void rtxtProgramaFuente_SelectionChanged(object sender, EventArgs e)
        {
            Point pt = rtxtProgramaFuente.GetPositionFromCharIndex(rtxtProgramaFuente.SelectionStart);
            if (pt.X == 1)
            {
                AddLineNumbers();
            }
        }

        private void rtxtProgramaFuente_TextChanged(object sender, EventArgs e)
        {
            if (rtxtProgramaFuente.Text == "")
            {
                AddLineNumbers();
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            AddLineNumbers();
        }

        private void updateNumberLabel()
        {
            //we get index of first visible char and 
            //number of first visible line
            Point pos = new Point(0, 0);
            int firstIndex = rtxtProgramaFuente.GetCharIndexFromPosition(pos);
            int firstLine = rtxtProgramaFuente.GetLineFromCharIndex(firstIndex);

            //now we get index of last visible char 
            //and number of last visible line
            pos.X = ClientRectangle.Width;
            pos.Y = ClientRectangle.Height;
            int lastIndex = rtxtProgramaFuente.GetCharIndexFromPosition(pos);
            int lastLine = rtxtProgramaFuente.GetLineFromCharIndex(lastIndex);

            //this is point position of last visible char, we'll 
            //use its Y value for calculating numberLabel size
            pos = rtxtProgramaFuente.GetPositionFromCharIndex(lastIndex);

            //finally, renumber label
            numberLabel.Text = "";
            for (int i = firstLine; i <= lastLine + 1; i++)
            {
                numberLabel.Text += i + 1 + "\n";
            }

        }
        private void rtxtProgramaFuente_VScroll(object sender, EventArgs e)
        {
            LineNumberTextBox.Text = "";
            AddLineNumbers();
            LineNumberTextBox.Invalidate();
        }

        private void rtxtProgramaFuente_FontChanged(object sender, EventArgs e)
        {
            LineNumberTextBox.Font = rtxtProgramaFuente.Font;
            rtxtProgramaFuente.Select();
            AddLineNumbers();
        }

        private void btnGuardarCadena_Click(object sender, EventArgs e)
        {
            Cadena miC = new Cadena();

            SqlConnection con = new SqlConnection("Data Source = DESKTOP - NJIFA2O\\SQLEXPRESS; Initial Catalog = AUTOMATAS; User ID = automata; Password = 12345; Integrated Security = False");

            SqlDataAdapter sda;

            DataTable dt = new DataTable();


            foreach (DataRow row in dt.Rows)
            {
                sda = new SqlDataAdapter("Select * from Matriz", con);
                sda.Fill(dt);

                miC.Caracteres = rtxtProgramaFuente.Text.ToCharArray();


            }

        }
    }
}
