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
            List<Medico> medicos = new List<Medico>();
            AdmMedico admMedico = new AdmMedico();
            medicos = admMedico.Listar();

            List<Paciente> pacientes = new List<Paciente>();
            AdmPaciente admPaciente = new AdmPaciente();
            pacientes = admPaciente.Listar();

            List<Habitacion> habitaciones = new List<Habitacion>();
            AdmHabitacion admHabitacion = new AdmHabitacion();
            habitaciones = admHabitacion.Listar();

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

            foreach(Habitacion habitacion in habitaciones)
            {
                lstHabitaciones.Items.Add("Habitacion n° " + habitacion.Numero + ", Estado: " + habitacion.Estado);
            }
        }
    }
}
