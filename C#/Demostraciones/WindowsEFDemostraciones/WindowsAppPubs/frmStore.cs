using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using WindowsAppPubs.AdminDatos;
using WindowsAppPubs.Models;
namespace WindowsAppPubs
{
    public partial class frmStore : Form
    {
        //Crear instancia de EF DbContext (para ser visible en todo el formulario)
        private PubsContext context = new PubsContext();

        public frmStore()
        {
            InitializeComponent();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            //Crear instancia de la clase
            Store store = new Store() { stor_id = "6380", stor_name = "Fray Mocho", stor_address = "Belgrano 123", city = "Mar del Plata", state = "Buenos Aires", zip = "7600" };
            //DBSet
            context.Store.Add(store);

            //Guardar en la DataBase
            int filasAfectadas = context.SaveChanges();
            if (filasAfectadas > 0)
            {
                MessageBox.Show("Ok");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //Buscar id en modelo
            int id = 3;
            Store storeDB = context.Store.Find(id);

            //Modificar datos
            if (storeDB != null)
            {
                storeDB.stor_name = "Yenny";
                storeDB.zip = "7600";
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
            int id = 3;
            Store storeDB = context.Store.Find(id);

            // Remover
            if (storeDB != null)
            {
                context.Store.Remove(storeDB);
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
            List<Store> storeList = new List<Store>();
            gridStores.DataSource = storeList;
        }

        private void btnDacStore_Click(object sender, EventArgs e)
        {
            string mensaje = "";
            Store store1 = new Store() { stor_id = "5001", stor_name = "Palito", stor_address = "Moreno 123", city = "Buenos Aires", state = "Buenos Aires", zip = "1700" };
            Store store2 = new Store() { stor_id = "5002", stor_name = "El Ateneo", stor_address = "Balcarce 123", city = "Buenos Aires", state = "Buenos Aires", zip = "1700" };

            //Probar método Nuevo() de DacStore
            if (DacStore.Nuevo(store1) == 0)
            {
                mensaje = "no funciona nuevo - ";
            }

            //Probar método Modificar() de DacStore
            if (DacStore.Modificar(store1) == 0)
            {
                mensaje += "no funciona modificar - ";
            }

            //Probar método Eliminar() de DacStore
            if (DacStore.Eliminar(store1) == 0) 
            {
                mensaje += "no funciona eliminar - ";
            }
            
            MessageBox.Show(mensaje);

            //Probar método TraerUno() de DacStore
            MessageBox.Show("Store " + (DacStore.TraerUno(store2.stor_id)).stor_name + " is located on " + DacStore.TraerUno(store2.stor_id).stor_address + ", " + DacStore.TraerUno(store2.stor_id).city);

            //Probar método Lista() de DacStore
            gridStores.DataSource = DacStore.Lista();
        }
    }
}
