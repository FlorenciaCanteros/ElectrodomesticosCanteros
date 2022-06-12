using System;
using System.Collections.Generic;

namespace ElectrodomesticosCanteros
{
    class Program
    {
        static void Main(string[] args)
        {
            Lavadora lavadora1 = new Lavadora(50, 40500, "A", "medio");
            Lavadora lavadora2 = new Lavadora(20, 29200, "B", "liviano");
            Lavadora lavadora3 = new Lavadora(45, 30200, "C", "pesado");
            Electrodomestico electrodomestico4 = new Electrodomestico();
            Electrodomestico electrodomestico5 = new Electrodomestico(500, "B", "liviano");
            Electrodomestico electrodomestico6 = new Electrodomestico(1500, "C", "medio");
            Television television7 = new Television(50, true, 50000, "A", "medio");
            Television television8 = new Television(35, false, 35000, "B", "liviano");
            Television television9 = new Television(45, true, 40000, "C", "pesado");
            Television television10 = new Television(55, false, 60000, "B", "medio");

            List<Electrodomestico> listaElectrodomesticos = new List<Electrodomestico>();
            listaElectrodomesticos.Add(lavadora1);
            listaElectrodomesticos.Add(lavadora2);
            listaElectrodomesticos.Add(lavadora3);
            listaElectrodomesticos.Add(electrodomestico4);
            listaElectrodomesticos.Add(electrodomestico5);
            listaElectrodomesticos.Add(electrodomestico6);
            listaElectrodomesticos.Add(television7);
            listaElectrodomesticos.Add(television8);
            listaElectrodomesticos.Add(television9);
            listaElectrodomesticos.Add(television10);

            foreach (Electrodomestico electrodomestico in listaElectrodomesticos)
            {
                Console.WriteLine("Precio final de electrodomestico = $" + electrodomestico.PrecioFinal());
                Console.WriteLine(" ");
            }

        }
    }
}
