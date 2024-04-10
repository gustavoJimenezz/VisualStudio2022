using CarritoServices.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace CarritoCliente
{
    public partial class Form1 : Form
    {
        // Creamos el atributo para manejar el ID
        private long ID = 0;

        // Cremaos la lista para guardar los articulos 
        //private readonly List<Articulo> listaArticulos;
        private readonly BindingList<Articulo> listaArticulos;
        public Form1()
        {
            InitializeComponent();
            this.listaArticulos = new BindingList<Articulo>();

            // Con el BindingList le notificamos del evento de redibujar 
            //el dataGridView
            dataGridView1.DataSource = listaArticulos;
        }
        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            // Obtenemos los valores de los textBox
            string sDetalle = TextBox1.Text;
            string sPrecio = TextBox2.Text;

            // Parseamos el precio 
            decimal iPrecio = decimal.Parse(sPrecio);

            // Aumentamos el numero de ID 
            this.ID++;

            // Creamos el nuevo objeto de tipo Articulo
            Articulo nuevoArticulo = new Articulo(ID, sDetalle, iPrecio);

            // Agregmos dicho objeot a la lista 
            this.listaArticulos.Add(nuevoArticulo);
        }
    }
}
