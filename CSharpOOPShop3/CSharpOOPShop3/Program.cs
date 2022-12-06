// See https://aka.ms/new-console-template for more information

using CSharpOOPShop3;

//Dichiaro una bottiglia d'acqua sbagliando apposta i litri.
//Gli altri oggetti si comportano in modo simile.

/*try
{
    BottledWater bottigliaTest = new("Acqua", "Bottiglia d'acqua", 1.75f, -2, 6, "Fonte di Fontedacqua");
}
catch (Exception e)
{
    Console.WriteLine("Qualcosa è andato storto nella creazione dell'oggetto. Riporto l'errore:");
    Console.WriteLine(e);
}*/

//Creo oggetti in modo corretto per testare il contatore statico.

string[] frutti = { "banana", "mandarino", "kiwi", "arancia" };

BottledWater bottigliaBuona = new("Acqua frizzante", "È frizzante.", 1.75f, 1.0f, 6, "Fonte Frizzante", true);
Appliance fornoBuono = new("Forno", "Un forno.", 750.0f, 400.0f, 1200);

//Vediamo il counter prodotti a metà dell'opera.

fornoBuono.PrintProductCounter();

FruitBasket cestelloBuono = new("Cestello di frutta", "Un cestello con frutti.", 3.5f, frutti);
CannedFood polloBuono = new("Pollo in scatola?", "Un pollo. In scatola.", 5.55f, 3, 0);

//La funzione di stampa è stata aggiornata. Adesso utilizza il metodo statico ConvertToGallons, dove riporta il valore dei litri in galloni.
bottigliaBuona.PrintProductDetails();
fornoBuono.PrintProductDetails();
cestelloBuono.PrintProductDetails();
polloBuono.PrintProductDetails();

//Vediamo il counter alla fine. La funzione può essere richiamata da qualsiasi prodotto.
fornoBuono.PrintProductCounter();


Console.WriteLine("Riga di console per vedere che il programma procede");
