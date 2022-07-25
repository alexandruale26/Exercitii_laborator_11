using Exercitii_laborator_11.Interfaces;


namespace Exercitii_laborator_11.TaxesCalculator
{
    /// <summary>
    /// Calculator taxe alimente
    /// </summary>
    class FoodTaxesCalculator : ITaxesCalculator
    {
        public double VATPercentage { get {return 9;} }

        
        public double ApplyTaxes(double price)
        {
            return price + (price * VATPercentage / 100);
        }
    }
}
