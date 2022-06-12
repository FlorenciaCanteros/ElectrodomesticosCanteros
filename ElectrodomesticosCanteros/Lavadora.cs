using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectrodomesticosCanteros
{
    public class Lavadora : Electrodomestico
    {
        public double Carga{ set; get; }

        public Lavadora(double carga, double precioBase, string consumoEnergetico, string peso) : base( precioBase, consumoEnergetico,  peso)
        {
            Carga = carga;
        }

        /// <summary>
        /// calcula el precio final de acuerdo a su consumo, peso y carga
        /// </summary>
        /// <returns></returns>
        public override double PrecioFinal()
        {
            double cargaMayor = 30;
            double aumento = 50;

            if (Carga > cargaMayor )
            {
                return base.PrecioFinal() + aumento;
            }
            return base.PrecioFinal();
        }
    }
}
