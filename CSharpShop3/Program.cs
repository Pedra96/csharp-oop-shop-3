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

bool flag = false;
var Prodotto1 = new Elettrodomestico("Fornello", 12, 23, 4, 12, "europea", "bosh", "Fornello da cucina ad induzione");
var Prodotto2 = new Acqua(1.456, 4.67832, "Acqua Naturale", 2, 200, 4, "bottiglia d'acqua bella fresca", "ghiacciaio dietro casa mia è buona fidati");
Acqua Prodotto3 = new();

while (flag == false) {
    try {
        Prodotto3.SetPh(Double.Parse(Console.ReadLine()));
        flag = true;
    }
    catch (FormatException e) {
        Console.WriteLine(e.Message);
    }
    catch (UnexpectedParameterException e) {
        Console.WriteLine(e.Message);
    }
}
Prodotto1.StampaProdotto();

Console.WriteLine(Prodotto2);
Console.WriteLine(Prodotto2.GetLitri());
Prodotto2.RiempiBottiglia(-0.4);
Console.WriteLine(Prodotto2.GetLitri());
Prodotto2.BeviAcqua(-1);
Prodotto2.BeviAcqua(1);