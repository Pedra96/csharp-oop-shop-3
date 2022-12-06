using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpShop3 {
    public static class ConvertitoreLitriInGalloni {
        const double ValoreGalloni = 3.785;
       public static double Convertitore(double litri) {
            return litri* ValoreGalloni;
        }
    }
}
