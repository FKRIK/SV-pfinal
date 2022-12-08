using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IMC_aplication.Utils
{
    public class Calculos
    {
        public static double CalcularImc(double peso, double altura ){
            double imc = 0;
            imc = peso / (altura * altura);
            return imc;
        }

        public static string ClassificarImc(double imc){
            string temp = "";

            if (imc < 18.5)
            {
                temp = "MAGREZA";

            }else if (imc <= 24.9)
            {
                temp = "NORMAL";

            }else if (imc <= 29.9)
            {
                temp= "SOBREPESO";

            }else if (imc <= 39.9)
            {
                temp = "OBESIDADE"; 
                
            }else
            {
                temp = "OBESIDADE GRAVE";
            }
            
            return temp;
        }
    }
}