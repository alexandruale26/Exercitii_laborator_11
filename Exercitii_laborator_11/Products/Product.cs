using System;
using Exercitii_laborator_11.Interfaces;


namespace Exercitii_laborator_11.Products
{
    /// <summary>
    /// Modeleaza un produs
    /// </summary>
    class Product
    {
        public string Name { get; private set; }
        public double GrossPrice { get; private set; }
        public Guid Id { get; private set; }
        public Tag Tag { get; private set; }
        public readonly ITaxesCalculator taxesCalculator;


        /// <summary>
        /// Creeaza un produs
        /// </summary>
        /// <param name="name">numele produsului</param>
        /// <param name="grossPrice">pretul brut</param>
        /// <param name="taxesCalculator">tipul de calculator de taxe</param>
        public Product(string name, double grossPrice, ITaxesCalculator taxesCalculator)
        {
            this.Name = name;
            this.Id = Guid.NewGuid();
            this.GrossPrice = grossPrice;
            this.taxesCalculator = taxesCalculator;
            this.Tag = new Tag(this.Name, this.Id, this.taxesCalculator.ApplyTaxes(grossPrice));
        }
    }
}
