

namespace Exercitii_laborator_11.Interfaces
{
    interface ITaxesCalculator
    {
        public double VATPercentage { get; }


        /// <summary>
        /// Calculeaza pretul net
        /// </summary>
        /// <param name="price">pretul brut ca parametru</param>
        /// <returns>Returneaza pretul net</returns>
        public double ApplyTaxes(double price);
    }
}
