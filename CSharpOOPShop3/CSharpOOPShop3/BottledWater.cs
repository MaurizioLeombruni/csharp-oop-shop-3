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
        private readonly int ph;
        private readonly string waterSpring;

        private bool isCarbonated;

        //Proprietà costanti

        private const float maxCapacity = 1.5f;


        //Costruttore
        public BottledWater(string name, string description, float basePrice, float liters, int ph, string waterSpring, bool isCarbonated = false) : base(name, description, basePrice)
        {
            //this.maxCapacity = 1.5f;

            if(liters > maxCapacity || liters < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(liters));
            }

            if(ph > 10 || ph < 0)
            {
                throw new ArgumentOutOfRangeException("Il valore del ph inserito non è valido");
            }

            this.liters = liters;
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
                throw new InvalidOperationException("Non puoi bere acqua da una bottiglia vuota.");
            }
            else if(litersToDrink > liters)
            {
                throw new ArgumentOutOfRangeException("Non puoi bere più acqua di quella che è rimasta in bottiglia.");
            }
            else
            {
                liters -= litersToDrink;
            }
            
        }

        public void Refill(float litersToRefill)
        {
            if ((liters + litersToRefill) > maxCapacity)
            {
                throw new ArgumentOutOfRangeException("Non puoi riempire la bottiglia oltre il massimo della sua capacità!");
            }
            else
            {
                Console.WriteLine("Hai riempito un po' la bottiglia.");
                liters += litersToRefill;
            }
        }

        public void Empty()
        {
            if(liters == 0)
            {
                throw new InvalidOperationException("La bottiglia è già vuota!");
            }

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

        //METODO STATICO. Preso un numero, lo moltiplica per la costante specificata dei galloni.

        private static float ConvertToGallons(float num)
        {
            return num * 3.785f;
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
            Console.WriteLine("Litri in galloni: " + ConvertToGallons(liters) + " galloni");
            Console.WriteLine("pH dell'acqua: " + GetPH());
            Console.WriteLine("Sorgente di provenienza: " + GetSpring());
            Console.WriteLine("Frizzante: " + GetCarbonated());
            PrintBasePrice();
            PrintPriceTotal();
            Console.WriteLine("-----------------------");
        }
    }
}
