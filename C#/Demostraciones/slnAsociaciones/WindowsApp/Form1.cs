using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using LibAsociaciones.Caso7;
namespace WindowsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCrearProductos_Click(object sender, EventArgs e)
        {
            Producto manzana = new Producto("Manzana", (decimal)5);
            Producto banana = new Producto("Banana", (decimal)5.5);
            Producto jabon = new Producto("Jabon", (decimal)50.5);
            
            List<Producto> alim = new List<Producto>();
            alim.Add(manzana);
            alim.Add(banana);

            Categoria alimentos = new Categoria("Alimentos",alim);

            gridProductos.DataSource = alim;

        }
    }
}
