using System;
using System.Text;


namespace Exercitii_laborator_11
{
    /// <summary>
    /// Modeleaza o eticheta
    /// </summary>
    class Tag
    {
        public string Name { get; private set; }
        public double NetPrice { get; private set; }
        public Guid Id { get; private set; }
        private readonly StringBuilder productTag = new StringBuilder();


        /// <summary>
        /// Creeaza o eticheta
        /// </summary>
        /// <param name="name">Numele produsului</param>
        /// <param name="id">ID-ul produsului</param>
        /// <param name="netPrice"> Pretul net al prodului</param>
        public Tag(string name, Guid id, double netPrice)
        {
            this.Name = name;
            this.Id = id;
            this.NetPrice = netPrice;
        }


        /// <summary>
        /// Creeaza eticheta produsului
        /// </summary>
        public void CreateTag()
        {
            productTag.AppendLine($"ID: {this.Id}");
            productTag.AppendLine($"Nume produs: {this.Name}");
            productTag.AppendLine($"Pret net: {NetPrice:N2} lei");
        }


        /// <summary>
        /// Afiseaza eticheta produsului
        /// </summary>
        public void PrintTag()
        {
            Console.WriteLine(productTag.ToString());
        }
    }
}
