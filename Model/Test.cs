using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetMentor.Model
{
    public class Test
    {
        //NUMEROS PARES
        public static void numerosPares()
        {
            Console.WriteLine("ingresa un numero");
            var num = int.Parse(Console.ReadLine());

            Console.WriteLine("ingresa otro numero");
            var num2 = int.Parse(Console.ReadLine());


            while ( num< num2){

                if (num % 2 == 0)
                {
                    Console.WriteLine($"{num} es par");
                    Console.WriteLine("");
                }

                num++;

            }

        }


        //NUMERO PERFECTO
        public static void numeroPerfecto()
        {
            Console.WriteLine("ingresa un numero");
            var num = int.Parse(Console.ReadLine());

            

            for (int i = 1; i <= num; i++)
            {
              int sumaDivisores = 0;

                for (int j = 1; j < i; j++)
                {
                    if (i%j== 0)
                    {
                        sumaDivisores+=j;

                    }
                }

                if(sumaDivisores == i)
                {
                    Console.WriteLine($"{i} es numero perfecto");
                    Console.WriteLine("");
                }
            }
        }



        // BUCLE DE UN NOMBRE CORRECTO

        public static void NombreCorrecto()
        {
            Console.WriteLine("ingresa un nombre");
            string Nombre = Console.ReadLine();

            while(Nombre != "NetMentor")
            {
                Console.WriteLine("El nombre ingresado es incorrecto, vuelve a ingresar un nombre");
                Nombre = Console.ReadLine();
            };

            Console.WriteLine("----");
            Console.WriteLine("El nombre ingresado es correcto! Bienvenido NetMentor");
            Console.WriteLine("");

        }


        public static void MenuInicio()
        {
            var salir = true;

            while (salir)
            {
                Console.WriteLine("Elige una opcion");
                Console.WriteLine("1 - Numero Pares");
                Console.WriteLine("2 - NUmero Perecto");
                Console.WriteLine("3 - Nombre Correcto");
                Console.WriteLine("4 - Salir");
                var opcion =int.Parse(Console.ReadLine());
                Console.WriteLine("");

                switch (opcion)
                {
                    case 1:  
                        numerosPares();
                        Console.WriteLine("");
                        break;
                    case 2:
                        numeroPerfecto();
                        Console.WriteLine("");
                        break;
                    case 3:
                        NombreCorrecto();
                        Console.WriteLine("");
                        break;
                    case 4:
                        salir = false;
                        break;
                    default:
                        Console.WriteLine("opcion ingresada incorrecta, vuelva a ingresar una opcion");
                        break;

                }

            }
        }


    }
}
