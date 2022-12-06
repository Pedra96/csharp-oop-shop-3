/*A partire da quanto già fatto con csharp-oop-shop-2 dove vi era stato chiesto di creare una classe Prodotto generica per gestire un generico prodotto dello Shop,
 * e di un paio di prodotti ereditati come Acqua, sacchetto di frutta, ecc ecc.
Ora vi chiedo di inserire correttamente le Eccezioni nei vostri Prodotti e sotto prodotti in modo da gestire correttamente gli eventi eccezionali, senza dover più fare un semplice 
Console.WriteLIne().Ricordatevi poi di testare le vostre classi, in particolare poi gestite e “catturate” correttamente le eccezioni nel vostro programma principale Program.cs e 
fate delle prove per simulare qualche situazione spiacevole per i vostri prodotti che avete previsto, in modo da verificare il comportamento delle vostre eccezioni.
Come primo esercizio focalizzatevi bene SOLO sulla classe Prodotto e sottoclasse Acqua dove potete aggiungere le seguenti Eccezioni:
nel costruttore di Acqua, non posso creare un’acqua se la bottiglia ha un ph negativo, oppure superiore a 10. O ancora non posso avere una capienza sopra la capienza massima o negativa
e così via.
nel metodo bevi (double litriDaBere) se l’acqua finisce, restituire un eccezione magari costruita da voi.
metodo riempi(double litri) che riempie la bottiglia di acqua e restituisce un eccezione se supero la sua capienza massima.
un metodo statico convertiInGalloni(double litri) che presa una quantità di litri restituisca la conversione dei litri in galloni, sapendo che 1 litro è equivalente a 3,785 galloni 
(ricordatevi di codificare le costanti come 3.785 nel modo corretto come visto in classe).
Una volta terminata la classe Prodotto e Acqua correttamente gestite anche le Eccezioni, vi chiedo di inserire un attributo statico alla classe Prodotto che permetta di contare quanti 
Prodotti ho istanziato fino ad un determinato istante nel mio programma. Alla fine o durante l’esecuzione del programma principale stampare in Console l’ammontare dei prodotti creati 
nel vostro negozio online.
BONUS:
Continuare gli stessi ragionamenti anche per tutte le altre sottoclassi che avevate pensato, come il sacchetto di frutta, l’elettrodomestico e così via.*/
using CSharpShop3;
using CSharpShop3.CustomException;
using System.Runtime.CompilerServices;

var Prodotto1 = new Elettrodomestico("Fornello", 12, 23, 4, 12, "europea", "bosh", "Fornello da cucina ad induzione");
var Prodotto2 = new Acqua(1.456, 4.67832, "Acqua Naturale", 2, 200, 4, "bottiglia d'acqua bella fresca", "ghiacciaio dietro casa mia è buona fidati");
Acqua Prodotto3 = new Acqua();



Console.WriteLine("Inserire nome della bottiglia");
SanificatoreInput("Nome", Console.ReadLine(),Prodotto3);

Console.WriteLine("Inserire prezzo:");
SanificatoreInput("Prezzo", Console.ReadLine(), Prodotto3);

Console.WriteLine("Inserire peso:");
SanificatoreInput("Peso", Console.ReadLine(), Prodotto3);

Console.WriteLine("Inserire iva:");
SanificatoreInput("Iva", Console.ReadLine(), Prodotto3);

Console.WriteLine("Inserire descrizione:");
SanificatoreInput("Descrizione", Console.ReadLine(), Prodotto3);

Console.WriteLine("Inserire capienza massima:");
SanificatoreInput("CapienzaMax", Console.ReadLine(), Prodotto3);

Console.WriteLine("Inserire sorgente:");
SanificatoreInput("Sorgente", Console.ReadLine(), Prodotto3);

Console.WriteLine("Inserire ph:");
SanificatoreInput("Ph", Console.ReadLine(), Prodotto3);


/*
Console.WriteLine("Inserire il prezzo");
Prodotto3.SetPrezzo(Double.Parse(Console.ReadLine()));

Console.WriteLine("Inserire il peso");
Prodotto3.SetPeso(Double.Parse(Console.ReadLine()));

Console.WriteLine("Inserire l'iva");
Prodotto3.SetIva(Double.Parse(Console.ReadLine()));

Console.WriteLine("Inserire la descrizione");
Prodotto3.SetDescrizione(Console.ReadLine());

Console.WriteLine("Inserire la capienza massima");
Prodotto3.SetCapienzaMax(Double.Parse(Console.ReadLine()));

Console.WriteLine("Inserire sorgente");
Prodotto3.SetNome(Console.ReadLine());

Console.WriteLine("Inserire il ph della bottiglia");
Prodotto3.SetPh(Double.Parse(Console.ReadLine()));
*/

Prodotto3.SetId();
Prodotto3.SetPrezzoConIva();

Prodotto3.StampaProdotto();
Prodotto1.StampaProdotto();

Console.WriteLine(Prodotto2);
Console.WriteLine(Prodotto2.GetLitri());
Prodotto2.RiempiBottiglia(-0.4);
Console.WriteLine(Prodotto2.GetLitri());
Prodotto2.BeviAcqua(-1);
Prodotto2.BeviAcqua(1);
Console.WriteLine("prodotti creati: " + ProdottoBase.contatore);
Console.WriteLine("il valore in galloni è: " + ConvertitoreLitriInGalloni.Convertitore(Prodotto3.GetLitri()));

void SanificatoreInput(string Attributo, string? Input, ProdottoBase Oggetto) {
    while (true) {
        try {
            switch (Attributo) {
                case "Nome":
                    Oggetto.SetNome(Input);
                    break;
                case "Prezzo":
                    Oggetto.SetPrezzo(Double.Parse(Input));
                    break;
                case "Peso":
                    Oggetto.SetPeso(Double.Parse(Input));
                    break;
                case "Iva":
                    Oggetto.SetIva(Double.Parse(Input));
                    break;
                case "Descrizione":
                    Oggetto.SetDescrizione(Input);
                    break;
                
            }
            if(Oggetto.GetType() == typeof(Acqua)) {
                Acqua OggettoAcqua= (Acqua)Oggetto;
                switch (Attributo) {
                    case "CapienzaMax":
                        OggettoAcqua.SetCapienzaMax(Double.Parse(Input));
                        break;
                    case "Sorgente":
                        OggettoAcqua.SetSorgente(Input);
                        break;
                    case "Ph":
                        OggettoAcqua.SetPh(Double.Parse(Input));
                        break;
                }
            }
            break;

        }
        catch (FormatException e) {
            Console.WriteLine(e.Message);
            Console.WriteLine("Inserire nuovo valore:");
            Input = Console.ReadLine();
        }
        catch (UnexpectedParameterException e) {
            Console.WriteLine(e.Message);
            Console.WriteLine("Inserire nuovo valore:");
            Input=Console.ReadLine();
        }
    }
}