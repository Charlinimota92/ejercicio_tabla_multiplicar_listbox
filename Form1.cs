using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio_tabla_multiplicar_listbox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Borrar_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            txt_Numero_Tabla.Clear();
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            int numero, tabla, resultado;

            tabla = int.Parse(txt_Numero_Tabla.Text);

            for(numero = 0; numero <=12; numero++)
            {
                resultado = numero * tabla;
                listBox1.Items.Add(tabla + "x" + numero + "=" + resultado);

            }
        }
    }
}
