using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos_de_COmputacion
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // tipos de datos

            float num1 = 214748364;
            uint valor1;
            float num2 = 5, num3 = 6;
            long largas = 21474836488888;
            ulong ularga = 2222;
            byte b = 100;
            sbyte s = 23;
            float? total = null;

            float flotante = 25.36f;
            double doble = 100.5d;
            decimal dec = 56.65m;

            bool boleana = new bool();

            // var & dynamic 

            var variable = 20.03f;
            variable = 20;

            dynamic dinamico = "Hoy es un buen día";
            dinamico = 20.699f;
            dinamico = true;

            var persona = new { NOMBRE = "Miguel", APELLIDO = "Rios", Edad = 30 };

            //Console.WriteLine($"{persona.NOMBRE} {persona.APELLIDO} {persona.Edad}");

            string nombre = "Carolina";
            String Nombre = "Luis Carlos";
            string apellido = "Rodriguez";
            String Apellido = "Moreno";
            char caracter = 'c';



            // Contadores y acumuladores 
            float salarios = 0f;

            total = 0;

            total += salarios;/* total = total + salario */
            total *= salarios;// total = total * salario 
            total -= salarios;// total = total - salario
            total /= salarios;// total = total / salario

            //Arreglos y matrices 
            int[] edad = new int[] { 20, 22, 33 }; // arreglo de tres posiciones
            _ = new float[] { 200, 300, 150 }; //arreglo de tres posicines
            String[] musico = new String[3];
            musico[0] = "Ringo";
            musico[1] = "Raul";
            musico[2] = "John";



            Console.WriteLine(musico.Length);
            //Ciclo for 
            for (int i = 0; i <musico.Length; i++)
            {

                float IVA = 0;
                IVA = salarios[i] * 0.13f;
                Console.WriteLine($"{musico[i]} Edad: {edad[i]} Salario: {salarios[i]} IVA: {salarios[i] * 0.13f} Total:  ");


            }

            Console.ReadLine();

        }








        }
    }

