using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace itinerario2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        Alumno a1, a2;
        private void button1_Click(object sender, EventArgs e)
        {
            a1 = new Alumno();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string l = Interaction.InputBox("ingrese legajo: ");
                if (Information.IsNumeric(l)) 
                {
                    a1.Legajo = int.Parse(l);
                } else { throw new Exception("no es num."); }
                
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show($"legajo : {a1.Legajo}");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);                
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {               
                a1.Nombre = Interaction.InputBox("ingrese nombre: ");
                a1.Apellido = Interaction.InputBox("ingrese apellido: ");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show(a1.mostrar());
                a1.mostrar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);   
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show(a2.mostrar());
                a1.mostrar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                string l = Interaction.InputBox("ingrese legajo: ");
                if (Information.IsNumeric(l))
                {
                    a2 = new Alumno
                        (
                        int.Parse(l),
                        Interaction.InputBox("nombre: "),
                        Interaction.InputBox("apellido: ")
                        );
                }
                else { throw new Exception("no es num."); }

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }

    public class Alumno 
    {
        #region campos
        private int  legajo;
        #endregion

        #region constructor
        //metodo constructor sobre cargado
        // tengo el mismo nombre mas de una vez pero con distinta firma
        // la firma es el nombre de la funcion mas los parametros
        // se llama sobre carga o polimorfismo parametrico
        public Alumno() { }
        public Alumno(int pLegajo) : this()
        {
            Legajo = pLegajo;
        }

        public Alumno (int pLegajo, string pNombre, string pApellido) : this (pLegajo)
        {
            Nombre = pNombre;
            Apellido = pApellido;
        }

        #endregion

        #region propiedades // las propiedades son la parte de interfas, lo que permite leer y escribir los campos privados de la clase
        public int Legajo // declaracion explicita
        {
            get { return legajo; }
            set { legajo = value; }
        }
        public string Nombre { get; set; } // declaracion implicita
        public string Apellido { get; set; }
        #endregion

        #region metodos // funciones

        public string mostrar() 
        {
            return $"nombre: {Nombre}{Environment.NewLine}" +
                   $"apellido: {Apellido}{Environment.NewLine}" +
                   $"legajo:{Legajo} ";
        }




        #endregion
    }
}
