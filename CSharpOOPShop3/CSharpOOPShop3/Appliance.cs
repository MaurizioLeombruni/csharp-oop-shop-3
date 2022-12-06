using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOPShop3
{
    public class Appliance : Product
    {

        //Proprietà
        private float weight;
        private int wattage;

        private bool isTurnedOn;

        //Costruttore
        public Appliance(string name, string description, float basePrice, float weight, int wattage) : base(name, description, basePrice)
        {
            this.wattage = wattage;
            this.weight = weight;

            isTurnedOn = false;
        }

        //Getters
        public float GetWeight()
        {
            return weight;
        }

        public int GetWattage()
        {
            return wattage;
        }

        public void GetStatus()
        {
            if (isTurnedOn)
            {
                Console.WriteLine("Sì");
            }
            else
            {
                Console.WriteLine("No");
            }
        }

        //Setter (probabilmente inutile)
        public void SetWeight(float weight)
        {
            this.weight = weight;
        }

        public void TurnOn()
        {
            if (isTurnedOn)
            {
                Console.WriteLine("L'elettrodomestico è già acceso.");
            }
            else
            {
                Console.WriteLine("L'elettrodomestico si è acceso.");
                isTurnedOn = true;
            }
        }

        public void TurnOff()
        {
            if (isTurnedOn)
            {
                Console.WriteLine("L'elettrodomestico si è spento.");
                isTurnedOn = false;
            }
            else
            {
                Console.WriteLine("Ah ah ah il bottone fa click! (L'elettrodomestico è già spento.)");
            }
        }

        public void Move(float strength)
        {
            if (strength >= weight)
            {
                Console.WriteLine("Riesci a muovere con successo l'elettrodomestico!");
            }
            else
            {
                Console.WriteLine("L'elettrodomestico è troppo pesante. Forse ti serve una mano?");
            }
        }

        public void Install(int wattage)
        {
            if (this.wattage < wattage)
            {
                Console.WriteLine("Attacchi l'elettrodomestico alla corrente.");
            }
            else
            {
                Console.WriteLine("Collegando l'elettrodomestico faresti saltare tutto!");
            }
        }


        //Override del metodo della classe padre.
        public override void PrintProductDetails()
        {
            Console.WriteLine("-------DETTAGLI-------");
            Console.WriteLine("Nome prodotto: " + GetProductName());
            Console.WriteLine("Codice prodotto: " + GetProductCode());
            Console.WriteLine("Nome esteso: " + GetExtendedName());

            Console.WriteLine("Peso prodotto: " + GetWeight());
            Console.WriteLine("Wattaggio: " + GetWattage());
            Console.WriteLine("Codice prodotto compilato: " + GetPaddedCode());
            Console.WriteLine("Descrizione prodotto: " + GetProductDescription());
            PrintBasePrice();
            PrintPriceTotal();
            Console.WriteLine("-----------------------");
        }
    }
}
