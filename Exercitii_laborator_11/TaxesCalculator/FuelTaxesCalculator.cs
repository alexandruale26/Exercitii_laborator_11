using Exercitii_laborator_11.Interfaces;


namespace Exercitii_laborator_11.TaxesCalculator
{
    /// <summary>
    /// Calculator taxe combustibili
    /// </summary>
    internal class FuelTaxesCalculator: ITaxesCalculator
    {
        public double VATPercentage { get { return 19; } }
        private const double fuelTax = 1.8d;
        private const double roadTax = 1.3d;


        public double ApplyTaxes(double price)
        {
            return price + (price * VATPercentage / 100) + fuelTax + roadTax;
        }
    }
}
