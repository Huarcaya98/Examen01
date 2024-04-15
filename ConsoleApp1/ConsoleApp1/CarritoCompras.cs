using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class CarritoCompras 
    {
        private List<Producto> productos = new List<Producto>();

        public void AgregarProducto(Producto producto)
        {
            productos.Add(producto);
        }

        public double CalcularPrecioTotal()
        {
            double precioTotal = 0;
            foreach(var producto in productos)
            {
                precioTotal += producto.Precio;
            }
            return precioTotal;
        }

        public void MostrarContenido()
        {
            Console.WriteLine("Contenido del carrito:");
            foreach (var producto in productos)
            {
                Console.WriteLine($"{producto.Nombre} : ${producto.Precio}");
            }

        }

    }
}
