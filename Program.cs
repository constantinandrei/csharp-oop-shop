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

product1.SetPrice(9.87);
Console.WriteLine("prezzo pieno: " + product1.GetFullPrice());

// cambio iva e prova

product1.SetIva(0.04);
Console.WriteLine("prezzo pieno: " + product1.GetFullPrice());
Console.WriteLine("iva: " + product1.GetIva());

// cambio nome e prova

product1.SetName("postit");
Console.WriteLine("nome completo: " + product1.GetFullName());

// cambio descrizione e prova

product1.SetDescription("per scriverci sopra");
Console.WriteLine(product1.GetDescription());

// cambio prezzo e prova getter prezzo base

product1.SetPrice(18.4);
Console.WriteLine(product1.GetPrice());

public class Product
{
    int id;
    string name;
    string description;
    double price;
    double iva;

    public Product(string name, string description, double price)
    {
        this.name = name;
        this.description = description;
        this.price = price;
        id = new Random().Next(1, 10001);
        iva = 0.22;
    }

    public int GetId()
    {
        return id;
    }

    public string GetName() 
    {
        return name;
    }

    public void SetName(string name)
    {
        this.name = name;
    }

    public string GetDescription()
    {
        return description;
    }

    public void SetDescription(string description)
    {
        this.description = description;
    }

    public double GetPrice()
    {
        return price;
    }

    public void SetPrice (double price)
    {
        this.price = price;
    }

    public double GetIva()
    {
        return iva;
    }

    public void SetIva(double iva)
    {
        this.iva = iva;
    }

    // metodo che restituisce prezzo + iva
    public double GetFullPrice()
    {
        return Math.Round((this.price + this.price * iva), 2);
    }

    public string GetFullName()
    {
        string idString = this.id.ToString();
        string paddedId = "";
        for (int i = 0; i < 8 - idString.Length; i++)
        {
            paddedId += "0";
        }

        paddedId += idString;
        return this.name + "-" + paddedId;
    }
}
