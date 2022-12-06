using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOPShop3
{
    public class BottledWater : Product
    {

        //Proprietà

        private float liters;
        private int ph;
        private string waterSpring;


        private float maxCapacity;
        private bool isCarbonated;

        //Costruttore
        public BottledWater(string name, string description, float basePrice, float liters, int ph, string waterSpring, bool isCarbonated) : base(name, description, basePrice)
        {
            this.maxCapacity = 1.5f;

            this.liters = Math.Min(liters, maxCapacity);
            this.ph = ph;
            this.waterSpring = waterSpring;
            this.isCarbonated = isCarbonated;
        }

        //Getters

        public float GetLiters()
        {
            return liters;
        }

        public int GetPH()
        {
            return ph;
        }

        public string GetSpring()
        {
            return waterSpring;
        }

        public string GetCarbonated()
        {
            string resultString;

            if (this.isCarbonated)
            {
                resultString = "Si";
            }
            else
            {
                resultString = "No";
            }

            return resultString;
        }

        public float GetMaxCapacity()
        {
            return maxCapacity;
        }


        //Metodi
        public void Drink(float litersToDrink)
        {
            if (liters == 0)
            {
                Console.WriteLine("La bottiglia è vuota.");
            }
            else
            {
                liters = Math.Max(0, (liters - litersToDrink));
            }
        }

        public void Refill(float litersToRefill)
        {
            if ((liters + litersToRefill) >= maxCapacity)
            {
                Console.WriteLine("La bottiglia è completamente piena.");
                liters = maxCapacity;
            }
            else
            {
                Console.WriteLine("Hai riempito un po' la bottiglia.");
                liters += litersToRefill;
            }
        }

        public void Empty()
        {
            Console.WriteLine("Parlando di sprechi...");
            liters = 0;
        }

        //So che non si dice "deflate" (non è una palla da sgonfiare) ma non so il termine in inglese lel
        public void Deflate()
        {
            if (isCarbonated)
            {
                Console.WriteLine("Acqua non-proprio-naturale ottenuta!");
                isCarbonated = false;
            }
            else
            {
                Console.WriteLine("Non serve sfiatare acqua non frizzante.");
            }
        }

        //Override del metodo della classe padre.

        public override void PrintProductDetails()
        {
            Console.WriteLine("-------DETTAGLI-------");
            Console.WriteLine("Nome prodotto: " + GetProductName());
            Console.WriteLine("Codice prodotto: " + GetProductCode());
            Console.WriteLine("Nome esteso: " + GetExtendedName());
            Console.WriteLine("Codice prodotto compilato: " + GetPaddedCode());
            Console.WriteLine("Descrizione prodotto: " + GetProductDescription());

            Console.WriteLine("Litri in bottiglia: " + GetLiters() + "l");
            Console.WriteLine("pH dell'acqua: " + GetPH());
            Console.WriteLine("Sorgente di provenienza: " + GetSpring());
            Console.WriteLine("Frizzante: " + GetCarbonated());
            PrintBasePrice();
            PrintPriceTotal();
            Console.WriteLine("-----------------------");
        }
    }
}
