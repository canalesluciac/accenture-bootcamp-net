using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using LibreriaPOO.Models.Derivada;
using LibAjedrez.Models.Derivada;
using LibHospital.Models.Derivadas;
using LibAnimaless.Models.Derivadas;
using LibTransportes.Models.Derivadas;

namespace WindowsPresentacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCrearInstrumentos_Click(object sender, EventArgs e)
        {
            Guitarra guitarra = new Guitarra();
            MessageBox.Show(guitarra.Afinar());

            Violin violin = new Violin();
            MessageBox.Show(violin.Afinar());

            Piano piano = new Piano();
            MessageBox.Show(piano.Afinar());
        }
        
        private void btnCrearPiezaAjedrez_Click(object sender, EventArgs e)
        {
            Caballo caballo = new Caballo();
            MessageBox.Show(caballo.Mover());

            Peon peon = new Peon();
            MessageBox.Show(peon.Mover());

            Torre torre = new Torre();
            MessageBox.Show(torre.Mover());
        }

        private void btnCrearPersonaHospital_Click(object sender, EventArgs e)
        {
            Paciente paciente = new Paciente("Gregorio","A111");
            MessageBox.Show(paciente.ToString());
            Medico medico = new Medico("Bautista", "Dermatologo");
            MessageBox.Show(medico.ToString());
        }

        private void btnCrearAnimales_Click(object sender, EventArgs e)
        {
            Conejo conejo = new Conejo();
            MessageBox.Show(conejo.ImprimirComida());

            Leon leon = new Leon();
            MessageBox.Show(leon.ImprimirComida());

            Loro loro = new Loro();
            MessageBox.Show(loro.ImprimirComida());
        }

        private void btnCrearTransporte_Click(object sender, EventArgs e)
        {
            Auto auto = new Auto();
            MessageBox.Show(auto.Acelerar());
            MessageBox.Show(auto.Desacelerar());
            MessageBox.Show(auto.DoblarAIzq());
            MessageBox.Show(auto.DoblarADcha());

            Avion avion = new Avion();
            MessageBox.Show(avion.Acelerar());
            MessageBox.Show(avion.Desacelerar());
            MessageBox.Show(avion.DoblarAIzq());
            MessageBox.Show(avion.DoblarADcha());
        }
    }
}
