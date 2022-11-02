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
;
public class Product
{
    int id;
    string name;
    string description;
    float price;
    float iva;

    public Product(string name, string description, float price)
    {
        this.name = name;
        this.description = description;
        this.price = price;
        id = new Random().Next(1, 100001);
        iva = 0.22f;
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

    public float GetPrice()
    {
        return price;
    }

    public void SetPrice (float price)
    {
        this.price = price;
    }

    public float GetIva()
    {
        return iva;
    }

    public void SetIva(float iva)
    {
        this.iva = iva;
    }
}