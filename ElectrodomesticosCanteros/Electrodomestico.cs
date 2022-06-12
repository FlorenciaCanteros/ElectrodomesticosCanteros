namespace ElectrodomesticosCanteros
{
    public class Electrodomestico
    {
        public double PrecioBase { set; get; }

        public string ConsumoEnergetico { set; get; }

        public string Peso { set; get; }

        public Electrodomestico()
        {
            PrecioBase = 100;
            ConsumoEnergetico = "C";
            Peso = "medio";

        }

        public Electrodomestico( double precioBase, string consumoEnergetico, string peso)
        {
            PrecioBase = precioBase;
            ConsumoEnergetico = consumoEnergetico;
            Peso = peso;

        }

        /// <summary>
        /// calcula el precio final de acuerdo a su consumo energetico y peso
        /// </summary>
        /// <returns></returns>
        public virtual double PrecioFinal()
        {
            double peso = 0;

            double consumoEnergetico = 0;

            switch (ConsumoEnergetico)
            {
                case "A":
                    consumoEnergetico = 100;
                    break;

                case "B":
                    consumoEnergetico = 80;
                    break;

                default:
                    consumoEnergetico = 60;
                    break;
            }

            switch (Peso)
            {
                case "liviano":
                    peso = 10;
                    break;

                case "medio":
                    peso = 50;
                    break;
                default:
                    peso = 80;
                    break;
            }

            return consumoEnergetico + peso + PrecioBase;
        }

    }
}
