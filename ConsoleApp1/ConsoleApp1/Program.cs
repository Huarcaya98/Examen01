using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CarritoCompras carrito = new CarritoCompras();

            while (true)
            {
                Console.WriteLine("¿Qué desea hacer?");
                Console.WriteLine("1. Agregar producto al carrito");
                Console.WriteLine("2. Ver contenido del carrito");
                Console.WriteLine("3. Finalizar compra");

                int opcion;
                if (!int.TryParse(Console.ReadLine(), out opcion))
                {
                    Console.WriteLine("Opción inválida. Por favor, ingrese un número.");
                    continue;
                }

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Seleccione el tipo de producto:");
                        Console.WriteLine("1. Producto de tela");
                        Console.WriteLine("2. Producto de arcilla");

                        int tipoProducto;
                        if (!int.TryParse(Console.ReadLine(), out tipoProducto))
                        {
                            Console.WriteLine("Opción inválida. Por favor, ingrese un número.");
                            continue;
                        }

                        Producto producto;
                        switch (tipoProducto)
                        {
                            case 1:
                                producto = new ProductoTela();
                                Console.Write("Nombre: ");
                                producto.Nombre = Console.ReadLine();
                                Console.Write("Tamaño: ");
                                ((ProductoTela)producto).Tamaño = Console.ReadLine();
                                Console.Write("Material: ");
                                ((ProductoTela)producto).Material = Console.ReadLine();
                                Console.Write("Color: ");
                                ((ProductoTela)producto).Color = Console.ReadLine();
                                double precioTela;
                                Console.Write("Precio: ");
                                if (!double.TryParse(Console.ReadLine(), out precioTela))
                                {
                                    Console.WriteLine("Precio inválido. Por favor, ingrese un número.");
                                    continue;
                                }
                                producto.Precio = precioTela;
                                break;
                            case 2:
                                producto = new ProductoArcilla();
                                Console.Write("Nombre: ");
                                producto.Nombre = Console.ReadLine();
                                Console.Write("Peso (kg): ");
                                double pesoArcilla;
                                if (!double.TryParse(Console.ReadLine(), out pesoArcilla))
                                {
                                    Console.WriteLine("Peso inválido. Por favor, ingrese un número.");
                                    continue;
                                }
                                ((ProductoArcilla)producto).Peso = pesoArcilla;
                                Console.Write("Tamaño: ");
                                ((ProductoArcilla)producto).Tamaño = Console.ReadLine();
                                Console.Write("Color: ");
                                ((ProductoArcilla)producto).Color = Console.ReadLine();
                                double precioArcilla;
                                Console.Write("Precio: ");
                                if (!double.TryParse(Console.ReadLine(), out precioArcilla))
                                {
                                    Console.WriteLine("Precio inválido. Por favor, ingrese un número.");
                                    continue;
                                }
                                producto.Precio = precioArcilla;
                                break;
                            default:
                                Console.WriteLine("Opción inválida.");
                                continue;
                        }

                        Console.WriteLine(producto.Describir());
                        Console.WriteLine("¿Desea agregar este producto al carrito? (S/N)");
                        if (Console.ReadLine().ToUpper() == "S")
                        {
                            carrito.AgregarProducto(producto);
                            Console.WriteLine("Producto agregado al carrito.");
                        }
                        break;
                    case 2:
                        carrito.MostrarContenido();
                        Console.WriteLine($"Precio total: ${carrito.CalcularPrecioTotal()}");
                        break;
                    case 3:
                        Console.WriteLine("Compra finalizada. Gracias por su compra.");
                        return;
                    default:
                        Console.WriteLine("Opción inválida.");
                        break;
                }
            }



        }
    }
}
