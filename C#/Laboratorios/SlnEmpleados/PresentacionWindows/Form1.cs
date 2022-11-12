using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using LibreriaEmpleado.Data;
using LibreriaEmpleado.Models;

namespace PresentacionWindows
{
    public partial class Form1 : Form
    {
        //instanciar DBContext
        private DBEmpleadoContext context = new DBEmpleadoContext();
        List<Empleado> list = new List<Empleado>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCargaEmpleados_Click(object sender, EventArgs e)
        {
            //instanciar objeto Lista de Empleados
            list.Add(new Empleado(1, "Amalia", "Cocora", "1234"));
            list.Add(new Empleado(2, "Baltasar", "Barracos", "1235"));
            list.Add(new Empleado(3, "Camila", "Carracas", "1236"));

            //instanciar objeto Departamento
            Departamento departamento = new Departamento() { DepartamentoId=Convert.ToInt32(txtIdDepartamento.Text), Empleados=list, Nombre="Control de calidad"};

            //DbSet
            context.Departamentos.Add(departamento);

            //Guardar en tabla
            int filasAfectadas = context.SaveChanges();
            if (filasAfectadas> 0)
            {
                MessageBox.Show("Ok");
            }
        }

        private void btnMuestraEmpleados_Click(object sender, EventArgs e)
        {
            list = context.Empleados.ToList();
            gridEmpleados.DataSource= list;
        }
    }
}
