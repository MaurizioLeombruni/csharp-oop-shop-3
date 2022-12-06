using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOPShop3
{
    //L'intera classe è una reference alla saga di Fallout, dove il cibo può essere radioattivo.
    public class CannedFood : Product
    {

        //Proprietà
        private int weight;
        private int rads;

        private bool isSealed;
        private bool isContaminated;

        //Costruttore
        public CannedFood(string name, string description, float basePrice, int weight, int rads) : base(name, description, basePrice)
        {
            this.weight = Math.Min(300, weight);
            this.rads = rads;

            isSealed = true;

            if (rads > 0)
            {
                isContaminated = true;
            }
        }

        //Getters
        public int GetWeight()
        {
            return weight;
        }

        public int GetRads()
        {
            return rads;
        }

        public void GetSealed()
        {
            if (isSealed)
            {
                Console.Write("Si");
            }
            else
            {
                Console.Write("No");
            }
        }

        public string GetContaminated()
        {
            string returnString;

            if (isContaminated)
            {
                returnString = "Sì";
            }
            else
            {
                returnString = "No";
            }

            return returnString;
        }


        //Metodi
        public void Eat(int amount)
        {

            //Se il cibo è irradiato o chiuso, termina la funzione senza fare nulla. Altrimenti consuma il cibo e manda un messaggio apposito.
            if (isContaminated)
            {
                throw new InvalidOperationException("Non puoi mangiare cibo irradiato!");
            }
            else if (isSealed)
            {
                throw new InvalidOperationException("Non puoi mangiare senza aprire la scatoletta prima.");
            }
            else if (amount >= weight)
            {
                Console.WriteLine("Hai mangiato tutto.");
                weight = 0;
            }
            else
            {
                weight -= amount;
                Console.WriteLine("Om nom nom. Nella scatola sono rimasti " + GetWeight() + "g di cibo.");
            }
        }

        public void Open()

        //Setta lo stato aperto della scatoletta.
        //In generale non è possibile risigillare le scatolette, quindi un metodo per richiuderla non serve.
        {
            if (isSealed)
            {
                Console.WriteLine("Apri la scatoletta.");
                isSealed = false;
            }
            else
            {
                throw new InvalidOperationException("La scatoletta è già aperta.");
            }
        }

        public void TreatRads(int amount)
        {

            //Riduce le radiazioni, se sono presenti.

            if (isContaminated)
            {
                if (amount >= rads)
                {
                    Console.WriteLine("Il cibo sembra essere stato decontaminato.");
                    rads = 0;
                    isContaminated = false;
                }
                else
                {
                    Console.WriteLine("Il cibo ha un aspetto migliore, ma non ti fidi ancora nel mangiarlo.");
                    rads -= amount;
                }
            }
            else
            {
                throw new InvalidOperationException("Il cibo non è irradiato.");
            }
        }

        //Override del metodo della classe padre.
        public override void PrintProductDetails()
        {
            Console.WriteLine("-------DETTAGLI-------");
            Console.WriteLine("Nome prodotto: " + GetProductName());
            Console.WriteLine("Codice prodotto: " + GetProductCode());
            Console.WriteLine("Nome esteso: " + GetExtendedName());

            Console.WriteLine("Quantità: " + GetWeight() + "g");
            Console.WriteLine("Radiazioni presenti: " + GetContaminated());
            if (isContaminated)
            {
                Console.WriteLine("Radiazioni rilevate: " + rads);
            }
            Console.WriteLine("Codice prodotto compilato: " + GetPaddedCode());
            Console.WriteLine("Descrizione prodotto: " + GetProductDescription());
            PrintBasePrice();
            PrintPriceTotal();
            Console.WriteLine("-----------------------");
        }
    }
}
