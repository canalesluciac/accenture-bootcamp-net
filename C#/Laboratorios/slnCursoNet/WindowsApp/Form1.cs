using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsApp.Models; // !!!!!
using WindowsApp.Practica2;

namespace WindowsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCrearObjetos_Click(object sender, EventArgs e)
        {
            //Autor
            Autor autor1 = new Autor();
            Autor autor2 = new Autor();

            //Empleado
            Empleado empleado1 = new Empleado();
            Empleado empleado2 = new Empleado();   

            //Proveedor
            Proveedor proveedor1 = new Proveedor();
            Proveedor proveedor2 = new Proveedor();

            //Publicador
            Publicador publicador1 = new Publicador();
            Publicador publicador2 = new Publicador();

            //Título
            Titulo titulo1 = new Titulo();
            Titulo titulo2 = new Titulo();

            //Venta
            Venta venta1 = new Venta();
            Venta venta2 = new Venta();

        }
    }
}
