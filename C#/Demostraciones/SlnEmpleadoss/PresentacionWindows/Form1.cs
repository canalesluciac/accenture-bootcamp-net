using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using LibreriaEmpleado;
using LibreriaEmpleado.Derivadas;

namespace PresentacionWindows
{
    public partial class Form1 : Form
    {
        private EmpleadoContext context = new EmpleadoContext();
        private int id = 0;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCargaDepto_Click(object sender, EventArgs e)
        {

            /* Hola Gabi! está sin terminar. Tengo que ir a cursar ahora lo termino hoy a la noche o mañana a primera hora
            Tuve una semana en salud, familiar y académica larga. Se que no es excusa, solo pido perdón */


            Departamento departamento = new Departamento();
            context.Departamentos.Add(departamento);

            Empleado empleado1 = new Empleado(1, "Lucia", "AAA", "1234") { Departamento=departamento};
            context.Empleados.Add(empleado1);

            Empleado empleado2 = new Empleado(2, "Mariela", "BBB", "1245") { Departamento = departamento };
            context.Empleados.Add(empleado2);

            Empleado empleado3 = new Empleado(3, "Susana", "CCC", "1256") { Departamento = departamento };
            context.Empleados.Add(empleado3);

            int filasAfectadas = context.SaveChanges();
            if (filasAfectadas!= 0)
            {
                MessageBox.Show("Ok");
            }
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            List<Empleado> lista = context.Empleados.ToList();
            gridEmpleados.DataSource= lista;
        }
    }
}
