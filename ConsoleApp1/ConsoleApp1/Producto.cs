using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Producto
    {
        public string Nombre { get; set; }
        public double Precio { get; set; }

        public virtual string Describir()
        {
            return $"Producto: {Nombre}, Precio: {Precio}";
        }

    }
}
