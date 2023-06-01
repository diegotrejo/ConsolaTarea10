using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolaTarea10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float x = SumaDosNumeros(34, 89);

            Console.WriteLine(x);
            Console.WriteLine( SumaDosNumeros(14, 17) );
            Console.WriteLine(AddDay(31, 12, 2022));
            Console.WriteLine( RestarDia(1, 1, 2022));
            Console.ReadKey();
        }

        private static float SumaDosNumeros(float num1, float num2)
        {
            float suma;
            suma = num1 + num2;
            return suma;
        }

        private static float Usd2Pco(float usd) {
            float pco;
            pco = usd * 5000;
            return pco;
        }

        private static float Usd2Euro(float usd)
        {
            float euro;
            euro = usd * (float) 0.9;
            return euro;
        }

        private static string RestarDia(int dia, int mes, int año)
        {
            if (dia == 1)
            {
                if (mes == 1)
                {
                    mes = 12;
                    año--;
                }
                else
                {
                    mes--;
                }
                dia = MaxDiasMes(mes, año);
            }
            else
            {
                dia--;
            }
            return $"{dia}/{mes}/{año}";
        }

        private static string AddDay(int dia, int mes, int año) {
            if (dia == MaxDiasMes(mes, año))
            {
                dia = 1;
                if (mes == 12)
                {
                    mes = 1;
                    año++;
                }
                else
                {
                    mes++;
                }
            }
            else
            {
                dia++;
            }
            return $"{dia}/{mes}/{año}";
        }

        private static int MaxDiasMes(int mes, int año)
        {
            if (mes == 1) // enero
                return 31;
            else if (mes == 2 && EsAñoBisiesto(año)) // febrero
                return 29;
            else if (mes == 2 && !EsAñoBisiesto(año)) // febrero
                return 28;
            else if (mes == 3)  // marzo
                return 31;
            else if (mes == 4)  //abril
                return 30;
            else if (mes == 5)  // mayo
                return 31;
            else if (mes == 6)  // junio
                return 30;
            else if (mes == 7) // julio
                return 31;
            else if (mes == 8) // agosto
                return 31;
            else if (mes == 9) // septiembre
                return 30;
            else if (mes == 10) // octubre
                return 31;
            else if (mes == 11)  // noviembre
                return 30;
            else 
                return 31;  // diciembre
        }

        private static bool EsAñoBisiesto(int año)
        {
            // aqui deben resolver el algortimo de año bisisto
            // al momento voy a considerar que ningún año es bisisto
            return false;
        }
    }
}
