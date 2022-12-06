// See https://aka.ms/new-console-template for more information

using CSharpOOPShop3;

//Dichiaro una bottiglia d'acqua sbagliando apposta i litri.

try
{
    BottledWater bottigliaTest = new("Acqua", "Bottiglia d'acqua", 1.75f, -2, 6, "Fonte di Fontedacqua");
}
catch (Exception e)
{
    Console.WriteLine("Qualcosa è andato storto nella creazione dell'oggetto. Riporto l'errore:");
    Console.WriteLine(e);
}

BottledWater bottigliaBuona = new("Acqua frizzante", "È frizzante.", 1.75f, 1.0f, 6, "Fonte Frizzante", true);

//La funzione di stampa è stata aggiornata. Adesso utilizza il metodo statico ConvertToGallons, dove riporta il valore dei litri in galloni.
bottigliaBuona.PrintProductDetails();

Console.WriteLine("Riga di console per vedere che il programma procede");
