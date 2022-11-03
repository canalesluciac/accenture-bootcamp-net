using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using LibEntidades;
namespace WindowsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCrearEmpleados_Click(object sender, EventArgs e)
        {
            List<Empleados> lista = new List<Empleados>();

            lista.Add(new Empleados() { Id=1, Nombre="Manuela", Apellido="Pescader"});
            lista.Add(new Empleados() { Id = 2, Nombre = "Rafael", Apellido = "Cabrales" });

            Empleados.Comision = (decimal)0.4;
            MessageBox.Show("Comision: " + Empleados.Comision.ToString());

            lista.Add(new Empleados() { Id = 3, Nombre = "Andrea", Apellido = "Skwortsow" });
            lista.Add(new Empleados() { Id = 4, Nombre = "Lorena", Apellido = "Ivanovich" });

            Empleados.Comision = (decimal)0.5;
            MessageBox.Show("Comision: " + Empleados.Comision.ToString());

        }
    }
}
