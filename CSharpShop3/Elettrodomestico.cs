using CSharpShop3.CustomException;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpShop3 {
    class Elettrodomestico : ProdottoBase {
        private int consumo;
        private string presa;
        private string marca;
        
        public Elettrodomestico() : base() { }

        public Elettrodomestico(string nome, int prezzo, double peso, double iva, int consumo, string presa, string marca, string descrizione = "") : base(nome, prezzo, peso, iva, descrizione) {
            this.consumo = consumo;
            this.presa = presa;
            this.marca = marca;
        }
        public void SetConsumo(int consumo) {
            if (consumo <= 0) {
                throw new UnexpectedParameterException("non hai inserito il consumo");
            } else {
                this.consumo = consumo;
            }
        }
        public void SetPresa(string presa) {
            if (presa == "") {
                throw new UnexpectedParameterException("non hai inserito il tipo di presa");
            } else {
                this.presa = presa;
            }
        }
        public void SetMarca(string marca) {
            if (marca == "") {
                throw new UnexpectedParameterException("non hai inserito una marca");
            } else {
                this.marca = marca;
            }
        }

        public int GetConsumo() { 
            return consumo; 
        }
        public string GetPresa() { 
            return presa; 
        }
        public string GetMarca() { 
            return marca; 
        }

        public override void StampaProdotto() {
            base.StampaProdotto();
            Console.WriteLine("consumo: " + GetConsumo() + "kWh");
            Console.WriteLine("resa della corrente: " + GetPresa());
            Console.WriteLine("marca: " + GetMarca());
            Console.WriteLine("--------------------------------");
        }
    }
}
