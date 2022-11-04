using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Negocio;
using Entidades.Models.Derivadas;
namespace WindowsPresentacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCrearObjetos_Click(object sender, EventArgs e)
        {
            List<Medico> medicos = new List<Medico>(); //Antes de la Tarea 6 AdmMedico no era estatica, por lo que era necesario --> AdmMedico admMedico = new AdmMedico();
            medicos = AdmMedico.Listar();

            List<Paciente> pacientes = new List<Paciente>(); //Antes de la Tarea 6 AdmPaciente no era estatica, por lo que era necesario --> AdmPaciente admPaciente = new AdmPaciente();
            pacientes = AdmPaciente.Listar();

            List<Habitacion> habitaciones = new List<Habitacion>(); //Antes de la Tarea 6 AdmHabitacion no era estatica, por lo que era necesario --> AdmHabitacion admHabitacion = new AdmHabitacion();
            habitaciones = AdmHabitacion.Listar();

            gridMedicos.DataSource = medicos;
            gridPacientes.DataSource = pacientes;

            int contador = 0;
            foreach (Medico medico in medicos)
            {
                if (medico.Especialidad == "Clinica")
                {
                    contador++;
                    lstClinicos.Items.Add(contador + ": " + medico.Nombre + " " + medico.Apellido);
                }
            }
            lstClinicos.Items.Add("Total de medicos clinicos: " + contador);

            foreach(Habitacion habitacion in habitaciones)
            {
                lstHabitaciones.Items.Add("Habitacion n° " + habitacion.Numero + ", Estado: " + habitacion.Estado);
            }
        }

        private void btnPaciente_Click(object sender, EventArgs e)
        {
            Paciente paciente = new Paciente(1, "Katie", "Bouman", "Nasa 123", "01111", "kbouman@aol.com", "0111", new DateTime(1989, 1,1));
            MessageBox.Show(paciente.Nombre + ", Edad: " + paciente.Edad);
        }
    }
}
