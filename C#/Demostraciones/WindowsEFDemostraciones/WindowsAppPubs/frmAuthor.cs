using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsAppPubs.AdminDatos;
using WindowsAppPubs.Models;

namespace WindowsAppPubs
{
    public partial class frmAuthor : Form
    {
        private PubsContext context = new PubsContext();
        Author author = new Author() { au_fname = "Isabel", au_lname = "Allende", address = "Valparaiso 123", city = "Isla Negra", contract = true, phone = "123456", state = "VP", zip = "12000" };

    public frmAuthor()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            int nuevo = DacAuthor.Nuevo(author);
            if (nuevo != 0 )
            {
                MessageBox.Show("Ok", "Nuevo funciona");
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int modificar = DacAuthor.Modificar(author);
            if ( modificar != 0 )
            {
                MessageBox.Show("Ok", "Modificar funciona");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int eliminar = DacAuthor.Eliminar(author);
            if (eliminar != 0)
            {
                MessageBox.Show("Ok", "Eliminar funciona");
            }
        }

        private void btnTraerUno_Click(object sender, EventArgs e)
        {
            Author author1 = DacAuthor.TraerUno(author.au_id);
            MessageBox.Show("Autor " + author1.au_fname + " " + author.au_lname);
        }

        private void btnLista_Click(object sender, EventArgs e)
        {
            List<Author> lista = context.Author.ToList();
            gridListar.DataSource = lista;
        }
    }
}
