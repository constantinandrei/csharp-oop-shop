// See https://aka.ms/new-console-template for more information
//Nel progetto csharp-oop-shop, creare la classe Prodotto che gestisce i prodotti dello shop. Un prodotto è caratterizzato da:
//codice(numero intero)
//nome
//descrizione
//prezzo
//iva
//Usate opportunamente i livelli di accesso (public, private), i costruttori, i metodi getter e setter ed eventuali altri metodi di “utilità” per fare in modo che:
//alla creazione di un nuovo prodotto il codice sia valorizzato con un numero random
//Il codice prodotto sia accessibile solo in lettura
//Gli altri attributi siano accessibili sia in lettura che in scrittura
//Il prodotto esponga sia un metodo per avere il prezzo base che uno per avere il prezzo comprensivo di iva
//Il prodotto esponga un metodo per avere il nome esteso, ottenuto concatenando codice + nome
//Nella vostro programma principale, testate tutte le funzionalità della classe Prodotto.
//BONUS: create un metodo che restituisca il codice con un pad left di 0 per arrivare a 8 caratteri (ad esempio codice 91 diventa 00000091, mentre codice 123445567 resta come è)

Product product1 = new Product("penna", "per scrivere", 0.78);

Console.WriteLine("prezzo pieno: " + product1.GetFullPrice());
Console.WriteLine("nome completo: " + product1.GetFullName());

// cambio prezzo e prova

product1.Price = 9.87;
Console.WriteLine("prezzo pieno: " + product1.GetFullPrice());

// cambio iva e prova

product1.Iva = 0.04;
Console.WriteLine("prezzo pieno: " + product1.GetFullPrice());
Console.WriteLine("iva: " + product1.Iva);

// cambio nome e prova

product1.Name = "postit";
Console.WriteLine("nome completo: " + product1.GetFullName());

// cambio descrizione e prova

product1.Description = "per scriverci sopra";
Console.WriteLine(product1.Description);

// cambio prezzo e prova getter prezzo base

product1.Price = 18.4;
Console.WriteLine(product1.Price);

public class Product
{
    public int Id { get; }
    public string Name { get; set; }
    public string Description { get; set; }
    public double Price { get; set; }
    public double Iva { get; set; }

    public Product(string name, string description, double price)
    {
        Name = name;
        Description = description;
        Price = price;
        Id = new Random().Next(1, 10001);
        Iva = 0.22;
    }


    // metodo che restituisce prezzo + iva
    public double GetFullPrice()
    {
        return Math.Round((Price + Price * Iva), 2);
    }

    public string GetFullName()
    {
        string idString = this.Id.ToString();
        string paddedId = "";
        for (int i = 0; i < 8 - idString.Length; i++)
        {
            paddedId += "0";
        }

        paddedId += idString;
        return Name + "-" + paddedId;
    }
}
