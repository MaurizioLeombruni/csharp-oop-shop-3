using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOPShop3
{
    public class FruitBasket : Product
    {
        //Proprietà
        private int maxPieces;
        private int currentPieces;

        private List<string> fruitInBasket = new List<string>();

        private bool isSealed;

        //Costruttore
        public FruitBasket(string name, string description, float basePrice, string[] fruits) : base(name, description, basePrice)
        {
            maxPieces = 5;

            for (int i = 0; i < maxPieces; i++)
            {
                fruitInBasket.Add(fruits[i]);
            }

            currentPieces = fruitInBasket.Count;

            isSealed = true;
        }


        //Getters
        public int GetCurrentPieces()
        {
            return currentPieces;
        }

        public void GetFruitInBasket()
        {
            Console.Write("[");

            for (int i = 0; i < fruitInBasket.Count; i++)
            {
                if (i != fruitInBasket.Count - 1)
                {
                    Console.Write(fruitInBasket[i] + ", ");
                }
                else
                {
                    Console.Write(fruitInBasket[i]);
                }
            }

            Console.WriteLine("]");
        }

        public bool GetSealed()
        {
            return isSealed;
        }

        //Metodi
        public void AddFruitToBasket(string fruit)
        {
            if (fruitInBasket.Count == maxPieces)
            {
                Console.WriteLine("Il cestello è pieno.");
            }
            else
            {
                fruitInBasket.Add(fruit);
                Console.WriteLine("Hai messo nel cestello: " + fruit);
                currentPieces = fruitInBasket.Count;
            }
        }

        public void Eat()
        {
            if (fruitInBasket.Count == 0)
            {
                Console.WriteLine("Non c'è nulla nel cestello.");
            }
            else
            {
                Console.WriteLine("Trovi: " + fruitInBasket.Last() + ". Om nom nom!");
                fruitInBasket.RemoveAt(fruitInBasket.Count - 1);
                currentPieces = fruitInBasket.Count;
            }
        }

        public void RemoveEverything()
        {
            if (fruitInBasket.Count == 0)
            {
                Console.WriteLine("Non c'è nulla nel cestello.");
            }
            else
            {
                Console.WriteLine("Hai tolto tutta la frutta. Il cestello si sente solo, adesso.");
                fruitInBasket.Clear();
                currentPieces = 0;
            }
        }

        //Override del metodo della classe padre.
        public override void PrintProductDetails()
        {
            Console.WriteLine("-------DETTAGLI-------");
            Console.WriteLine("Nome prodotto: " + GetProductName());
            Console.WriteLine("Codice prodotto: " + GetProductCode());
            Console.WriteLine("Nome esteso: " + GetExtendedName());

            Console.WriteLine("Pezzi di frutta nel cestello: " + GetCurrentPieces());
            Console.Write("Cosa c'è nel cestello: ");
            GetFruitInBasket();
            Console.WriteLine("Codice prodotto compilato: " + GetPaddedCode());
            Console.WriteLine("Descrizione prodotto: " + GetProductDescription());
            PrintBasePrice();
            PrintPriceTotal();
            Console.WriteLine("-----------------------");
        }
    }
}
