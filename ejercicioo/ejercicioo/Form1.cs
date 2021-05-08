using ejercicioo.clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicioo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string[] arregloalumnos;

        private void button1archivos_Click(object sender, EventArgs e)
        {

            clsarchivos arch = new clsarchivos();
            OpenFileDialog msj = new OpenFileDialog();
            msj.Title = "Porfa, Selecciona tu archivo plano";
            msj.InitialDirectory = @"C: \Users\alumno\Desktop\datos Texto.csv";
            msj.Filter = "Archivo Plano (*.csv)|*.csv";

            if (msj.ShowDialog() == DialogResult.OK)
            {
                var archivo = msj.FileName;
                string resultado = arch.LeertodoArchivo(archivo);
                arregloalumnos = arch.LeerArchivo(archivo);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clasesql cn = new clasesql();
            foreach (string linea in arregloalumnos)

            {
                string[] lineas = linea.Split(';');
                Console.OutputEncoding = System.Text.Encoding.Unicode;
                string line = $"insert into tb_alumnos values('{lineas[0]}','{lineas[1]}','{lineas[2]}','{lineas[3]}','{lineas[4]}')";
                cn.consultaTablaDirecta(line);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            clasemysql cn = new clasemysql();
            foreach (string linea in arregloalumnos)

            {
                string[] lineas = linea.Split(';');
                Console.OutputEncoding = System.Text.Encoding.Unicode;
                string line = $"insert into tb_alumnos values('{lineas[0]}','{lineas[1]}','{lineas[2]}','{lineas[3]}','{lineas[4]}')";
                cn.consultaTablaDirecta(line);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            clasesoracle cn = new clasesoracle();
            foreach (string linea in arregloalumnos)

            {
                string[] lineas = linea.Split(';');
                Console.OutputEncoding = System.Text.Encoding.Unicode;
                string line = $"insert into TB_ALUMNOS values('{lineas[0]}','{lineas[1]}','{lineas[2]}','{lineas[3]}','{lineas[4]}')";
                cn.consultaTablaDirecta(line);
            }

        }
    }
}

