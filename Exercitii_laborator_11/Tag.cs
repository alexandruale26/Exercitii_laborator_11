using System;
using System.Text;


namespace Exercitii_laborator_11
{
    /// <summary>
    /// Modeleaza o eticheta
    /// </summary>
    class Tag
    {
        private readonly StringBuilder productTag = new StringBuilder();


        /// <summary>
        /// Creeaza o eticheta
        /// </summary>
        /// <param name="name">Numele produsului</param>
        /// <param name="id">ID-ul produsului</param>
        /// <param name="netPrice"> Pretul net al prodului</param>
        public Tag(string name, Guid id, double netPrice)
        {
            productTag.AppendLine($"ID: {id}");
            productTag.AppendLine($"Nume produs: {name}");
            productTag.AppendLine($"Pret net: {netPrice:N2} lei");
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
