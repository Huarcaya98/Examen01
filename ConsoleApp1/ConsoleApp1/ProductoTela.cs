using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ProductoTela : Producto
    {
        public string Tamaño { get; set; }
        public string Material { get; set; }
        public string Color { get; set; }

        public override string Describir()
        {
            return $"Producto de tela: {Nombre}, Tamaño: {Tamaño}, Material: {Material}, Color: {Color}, Precio: {Precio}";
        }
    }
}
