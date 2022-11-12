using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsAppPubs.Models;

namespace WindowsAppPubs
{
    public partial class Form1 : Form
    {
        //Crear instancia de EF DbContext (para ser visible en todo el formulario)
        private PubsContext context = new PubsContext();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            //Crear instancia de la clase
            Job job = new Job() { job_id = 29, job_desc = "Programmer", min_lvl = 100, max_lvl=200 };
            //DBSet
            context.Job.Add(job);

            //Guardar en la DataBase
            int filasAfectadas = context.SaveChanges();
            if (filasAfectadas> 0 )
            {
                MessageBox.Show("Ok");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //Buscar id en modelo
            int id = 26;
            Job jobDB = context.Job.Find(id);

            //Modificar datos
            if (jobDB != null) 
            {
                jobDB.job_desc = "Human Resources";
                jobDB.min_lvl = 100;
                jobDB.max_lvl = 200;
            }

            //Guardar en la database
            int filasAfectadas = context.SaveChanges();
            if (filasAfectadas > 0)
            {
                MessageBox.Show("Ok");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //Buscar objeto en la DB
            int id = 29;
            Job jobDB = context.Job.Find(id);

            // Remover
            if (jobDB != null )
            {
                context.Job.Remove(jobDB);
            }

            //Guardar en la database
            int filasAfectadas = context.SaveChanges();
            if (filasAfectadas > 0)
            {
                MessageBox.Show("Ok");
            }
        }

        private void btnTraerTodos_Click(object sender, EventArgs e)
        {
            List<Job> list = context.Job.ToList();
            gridJobs.DataSource= list;
        }
    }
}
