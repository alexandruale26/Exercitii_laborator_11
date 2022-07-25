using Exercitii_laborator_11.Interfaces;


namespace Exercitii_laborator_11.TaxesCalculator
{
    /// <summary>
    /// Calculator taxe produse menajere
    /// </summary>
    internal class HouseholdProductsTaxesCalculator : ITaxesCalculator
    {
        public double VATPercentage { get { return 19; } }


        public double ApplyTaxes(double price)
        {
            return price + (price * VATPercentage / 100);
        }
    }
}
