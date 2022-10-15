using System;

    class Program
    {
        static void Main(string[]args)
        {
        int numerocompra;
        double precio = 0;
        double cantidad = 0;
        Console.Write("Cuantos productos quiere comprar: ");
        numerocompra = Convert.ToInt32(Console.ReadLine());
        for(int i = 1; i <= numerocompra; i++)
        {
            Console.Write("Ingrese el precio del producto numero: "+i+ " " );
            precio = Convert.ToDouble(Console.ReadLine());
            cantidad = cantidad + Convert.ToDouble(Console.ReadLine());
        }
        Console.WriteLine("El total a pagar es: " + cantidad);
        Console.ReadLine();
        }
    }
