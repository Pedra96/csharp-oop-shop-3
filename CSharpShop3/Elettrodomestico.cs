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
        public Elettrodomestico(string nome, int prezzo, double peso, double iva, int consumo, string presa, string marca, string descrizione = "") : base(nome, prezzo, peso, iva, descrizione) {
            this.consumo = consumo;
            this.presa = presa;
            this.marca = marca;
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
