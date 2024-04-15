using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ProductoArcilla : Producto
    {
        public double Peso { get; set; }
        public string Tamaño { get; set; }
        public string Color { get; set; }

        public override string Describir()
        {
            return $"Producto de arcilla: {Nombre}, Peso: {Peso} kg, Tamaño: {Tamaño}, Color: {Color}, Precio: {Precio}";
        }
    }
}
