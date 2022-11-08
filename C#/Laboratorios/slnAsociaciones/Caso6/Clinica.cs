using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caso6
{
    public class Clinica
    {
        int Id { get; set; }
        string Nombre { get; set; }
        string Direccion  { get; set; }

        Director Director;
    }
}
