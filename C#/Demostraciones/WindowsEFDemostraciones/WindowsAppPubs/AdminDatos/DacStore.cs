using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsAppPubs.Models;

namespace WindowsAppPubs.AdminDatos
{
    public static class DacStore
    {
        // Instanciar objeto de PubsContext
        public static PubsContext contextPub = new PubsContext();

        public static List<Store> Lista()
        {
            // Crear lista de Stores --> método ToList()
            List<Store> lista = contextPub.Store.ToList();
            return lista;
        }

        public static Store TraerUno(string storeId)
        {
            // Encuentra objeto en base a su Id --> método Find()
            Store store = contextPub.Store.Find(storeId);
            return store;
        }

        public static int Nuevo (Store store)
        {
            // Agrega objeto --> método Add()
            contextPub.Store.Add(store); 
            return contextPub.SaveChanges();
        }

        public static int Modificar (Store storeToModify)
        {
            // Buscar objeto a modificar
            Store store = contextPub.Store.Find(storeToModify.stor_id);

            // Al obtener el Id de la store, ya se sabe que esta existe
            store.stor_name = "Barnes & Noble";
            store.city = "Orlando";
            store.zip = "32819";
            store.stor_address = "7900 W Sand Lake Rd";
            return contextPub.SaveChanges();
        }

        public static int Eliminar (Store storeToRemove)
        {
            // Buscar objeto a eliminar
            Store store = contextPub.Store.Find(storeToRemove.stor_id);

            // Al obtener el Id de la store, ya se sabe que esta existe
            contextPub.Store.Remove(storeToRemove);
            return contextPub.SaveChanges();
        }
    }
}
