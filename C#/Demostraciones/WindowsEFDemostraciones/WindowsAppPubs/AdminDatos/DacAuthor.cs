using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WindowsAppPubs.Models;
namespace WindowsAppPubs.AdminDatos
{
    public static class DacAuthor
    {
        // Instanciar objeto de PubsContext
        public static PubsContext contextPub = new PubsContext();

        public static List<Author> Lista()
        {
            // Crear lista de Authors --> método ToList()
            List<Author> lista = contextPub.Author.ToList();
            return lista;
        }

        public static Author TraerUno(string id)
        {
            // Encuentra objeto en base a su Id --> método Find()
            Author author = contextPub.Author.Find(id);
            return author;
        }

        public static int Nuevo(Author author)
        {
            // Agrega objeto --> método Add()
            contextPub.Author.Add(author);
            return contextPub.SaveChanges();
        }

        public static int Modificar(Author author)
        {
            // Buscar objeto a modificar
            Author author1 = contextPub.Author.Find(author.au_id);

            // Al obtener el Id del autor, ya se sabe que este existe
            author.au_lname = "JK Rowling";
            author.address = "Victoria Street 123";
            return contextPub.SaveChanges();
        }

        public static int Eliminar(Author authorToRemove)
        {
            // Buscar objeto a eliminar
            Author author = contextPub.Author.Find(authorToRemove.au_id);

            // Al obtener el Id del autor, ya se sabe que este existe
            contextPub.Author.Remove(authorToRemove);
            return contextPub.SaveChanges();
        }
    }
}
