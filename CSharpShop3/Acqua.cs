using CSharpShop3.CustomException;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpShop3 {
    class Acqua : ProdottoBase {

        private double CapienzaMax;
        private double pH;
        private string sorgente;
        private double LitriCorrenti;
        public Acqua() : base() { }
        public Acqua(double capienza, double pH, string nome, double prezzo, double peso, double iva, string descrizione = "", string sorgente = "") : base(nome, prezzo, peso, iva, descrizione) {
            this.CapienzaMax = Math.Round(capienza, 2);
            this.pH = Math.Round(pH, 2);
            this.sorgente = sorgente;
            this.LitriCorrenti = this.CapienzaMax;
        }
        public double GetCapienza() {
            return CapienzaMax;
        }
        public double GetpH() {
            return pH;
        }
        public string GetSorgente() {
            return sorgente;
        }
        public double GetLitri() {
            return LitriCorrenti;
        }

        public void SetCapienzaMax(double CapienzaMax) {
            if (CapienzaMax <= 0) {
                throw new UnexpectedParameterException("Hai inserito un valore non valido");
            } else {
                this.CapienzaMax = Math.Round(CapienzaMax, 2);
                LitriCorrenti = this.CapienzaMax;
            }
        }
        public void SetPh(double ph) {
            if (ph < 0 || ph > 14.00) {
                throw new UnexpectedParameterException("il Ph non può essere negativo o maggiore di 14");
            } else {
                this.pH = Math.Round(ph, 2);
            }
        }
        public void SetSorgente(string sorgente) {
            if (sorgente == "") {
                throw new UnexpectedParameterException("non hai inserito un nome");
            } else {
                this.sorgente = sorgente;
            }
        }

        public void SvuotaBottiglia() {
            this.LitriCorrenti = 0;
            Console.WriteLine($"bottiglia svuotata litri correnti {this.LitriCorrenti}L/{this.CapienzaMax}L");
        }
        public void RiempiBottiglia(double litri) {
            if (litri > this.CapienzaMax || (this.LitriCorrenti + litri) > this.CapienzaMax) {
                this.LitriCorrenti = this.CapienzaMax - 0.2;
                Console.WriteLine($"hai aggiunto troppa acqua e ora hai il pavimento è bagnato,litri correnti: {this.LitriCorrenti}L");
            } else if (litri < 0) {
                this.LitriCorrenti = 0;
                Console.WriteLine($"sei riuscito a fare una cosa illegale creando un buco nero... litri correnti {this.LitriCorrenti}L");
            } else {
                this.LitriCorrenti = this.LitriCorrenti + litri;
            }
        }
        public void BeviAcqua(double litri) {
            if (litri < 0) {
                Console.WriteLine("in qualche modo sei riuscito a bere in negativo facendo esplodere la tua bottiglia");
            } else if (litri > this.CapienzaMax) {
                this.LitriCorrenti = 0;
                Console.WriteLine("hai bevuto tutta l'acqua nella bottiglia, peccato che non era abbastanza ti senti ancora assetato");
            } else {
                if (this.LitriCorrenti == 0) {
                    Console.WriteLine("l'acqua è vuota dovresti riempirla");
                } else if (this.LitriCorrenti - litri <= 0) {
                    this.LitriCorrenti = 0;
                } else { this.LitriCorrenti -= litri; }
            }

        }
        public override string ToString() {
            StampaProdotto();
            return "";
        }
        public override void StampaProdotto() {
            base.StampaProdotto();
            Console.WriteLine($"Capienza Massima: {this.CapienzaMax}L");
            Console.WriteLine($"ph: {this.pH}");
            Console.WriteLine($"Sorgente: {this.sorgente}");
            Console.WriteLine($"litri: {this.LitriCorrenti}L");
            Console.WriteLine("--------------------------------");
        }
    }
}
