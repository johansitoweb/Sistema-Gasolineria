using System;
using System.Collections.Generic;

class VentaCombustible
{
    public string TipoCombustible { get; set; }
    public double CantidadLitros { get; set; }
    public double PrecioPorLitro { get; set; }

    public VentaCombustible(string tipoCombustible, double cantidadLitros, double precioPorLitro)
    {
        TipoCombustible = tipoCombustible;
        CantidadLitros = cantidadLitros;
        PrecioPorLitro = precioPorLitro;
    }

    public double CalcularTotal()
    {
        return CantidadLitros * PrecioPorLitro;
    }

    public override string ToString()
    {
        return $"Tipo de Combustible: {TipoCombustible}, Cantidad de Litros: {CantidadLitros}, Precio por Litro: {PrecioPorLitro}, Total: {CalcularTotal()}";
    }
}

class Program
{
    static List<VentaCombustible> ventas = new List<VentaCombustible>();

    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Sistema de Gestión de Gasolinería");
            Console.WriteLine("1. Agregar Venta");
            Console.WriteLine("2. Listar Ventas");
            Console.WriteLine("3. Eliminar Venta");
            Console.WriteLine("4. Salir");
            Console.Write("Seleccione una opción: ");
            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    AgregarVenta();
                    break;
                case "2":
                    ListarVentas();
                    break;
                case "3":
                    EliminarVenta();
                    break;
                case "4":
                    return;
                default:
                    Console.WriteLine("Opción no válida. Intente de nuevo.");
                    break;
            }
        }
    }

    static void AgregarVenta()
    {
        Console.Write("Ingrese el tipo de combustible: ");
        string tipoCombustible = Console.ReadLine();
        Console.Write("Ingrese la cantidad de litros: ");
        double cantidadLitros = Convert.ToDouble(Console.ReadLine());
        Console.Write("Ingrese el precio por litro: ");
        double precioPorLitro = Convert.ToDouble(Console.ReadLine());

        VentaCombustible venta = new VentaCombustible(tipoCombustible, cantidadLitros, precioPorLitro);
        ventas.Add(venta);
        Console.WriteLine("Venta agregada exitosamente.");
    }

    static void ListarVentas()
    {
        if (ventas.Count == 0)
        {
            Console.WriteLine("No hay ventas registradas.");
        }
        else
        {
            Console.WriteLine("Lista de Ventas:");
            foreach (var venta in ventas)
            {
                Console.WriteLine(venta);
            }
        }
    }

    static void EliminarVenta()
    {
        Console.Write("Ingrese el índice de la venta a eliminar: ");
        int indice = Convert.ToInt32(Console.ReadLine());

        if (indice >= 0 && indice < ventas.Count)
        {
            ventas.RemoveAt(indice);
            Console.WriteLine("Venta eliminada exitosamente.");
        }
        else
        {
            Console.WriteLine("Índice no válido.");
        }
    }
}
