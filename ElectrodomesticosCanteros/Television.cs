namespace ElectrodomesticosCanteros
{
    public class Television : Electrodomestico
    {
        public double Pulgadas { set; get; }

        public bool SonizadorTDT { set; get; }

        public Television(double pulgadas, bool sonizadorTDT, double precioBase, string consumoEnergetico, string peso): base ( precioBase, consumoEnergetico, peso)
        {
            Pulgadas = pulgadas;
            SonizadorTDT = sonizadorTDT;
        }

        /// <summary>
        /// calcula el precio final de acuerdo a su consumo energetico, precio, pulgadas y sonizador (procetaje de 30%).
        /// </summary>
        /// <returns></returns>
        public override double PrecioFinal()
        {
            double pulgadasMayor = 40;
            double aumento = 50;
            double incrementoPrecio = (PrecioBase * 30) / 100;
            double precioFinal = base.PrecioFinal();

            if (Pulgadas > pulgadasMayor)
            {
                precioFinal = precioFinal + incrementoPrecio;
            }

            if (SonizadorTDT)
            {
                precioFinal = precioFinal + aumento;
            }
            return precioFinal;
        }
    }
}
