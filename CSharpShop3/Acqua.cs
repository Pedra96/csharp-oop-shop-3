using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpShop3 {
    class Acqua : ProdottoBase {

        private double capienza;
        private double pH;
        private string sorgente;
        private double litri;
        public Acqua(double capienza, double pH, string nome, double prezzo, double peso, double iva, string descrizione = "", string sorgente = "") : base(nome, prezzo, peso, iva, descrizione) {
            this.capienza = Math.Round(capienza, 2);
            this.pH = Math.Round(pH, 2);
            this.sorgente = sorgente;
            this.litri = this.capienza;
        }
        public double GetCapienza() {
            return capienza;
        }
        public double GetpH() {
            return pH;
        }
        public string GetSorgente() {
            return sorgente;
        }
        public double GetLitri() {
            return litri;
        }
        public void SvuotaBottiglia() {
            this.litri = 0;
            Console.WriteLine($"bottiglia svuotata litri correnti {this.litri}L/{this.capienza}L");
        }
        public void RiempiBottiglia(double litri) {
            if (litri > this.capienza || (this.litri + litri) > this.capienza) {
                this.litri = this.capienza - 0.2;
                Console.WriteLine($"hai aggiunto troppa acqua e ora hai il pavimento è bagnato,litri correnti: {this.litri}L");
            } else if (litri < 0) {
                this.litri = 0;
                Console.WriteLine($"sei riuscito a fare una cosa illegale creando un buco nero... litri correnti {this.litri}L");
            } else {
                this.litri = this.litri + litri;
            }
        }
        public void BeviAcqua(double litri) {
            if (litri < 0) {
                Console.WriteLine("in qualche modo sei riuscito a bere in negativo facendo esplodere la tua bottiglia");
            } else if (litri > this.capienza) {
                this.litri = 0;
                Console.WriteLine("hai bevuto tutta l'acqua nella bottiglia, peccato che non era abbastanza ti senti ancora assetato");
            } else {
                if (this.litri == 0) {
                    Console.WriteLine("l'acqua è vuota dovresti riempirla");
                } else if (this.litri - litri <= 0) {
                    this.litri = 0;
                } else { this.litri -= litri; }
            }

        }
        public override string ToString() {
            StampaProdotto();
            return "";
        }
        public override void StampaProdotto() {
            base.StampaProdotto();
            Console.WriteLine($"Capienza Massima: {this.capienza}L");
            Console.WriteLine($"ph: {this.pH}");
            Console.WriteLine($"Sorgente: {this.sorgente}");
            Console.WriteLine($"litri: {this.litri}L");
            Console.WriteLine("--------------------------------");
        }
    }
}
