using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_01___Repaso
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero1 = 0;
            int numero2 = 0;
            string texto = "";

            Console.WriteLine("Escriba el primer numero: ");
            numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Escriba el segundo numero: ");
            numero2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Escriba una palabra: ");
            texto=(Console.ReadLine());
            
            Console.WriteLine("La palabra " + texto + " contiene " + Vocales(texto) + " vocales");

            
            Console.WriteLine("La suma es: "+SumaPares(numero1));
            
            if (EsPrimo(numero1))
            {
                Console.WriteLine("El numero introducido es primo");
            }
            else
                Console.WriteLine("El numero introducido no es primo");
            
            ImprimirNumeros();
            
            
            
            Console.WriteLine("El factorial del numero es: "+Factorial(numero1));

            

            Console.WriteLine("La suma de los digitos del numero es " + SumarLosDigitos(numero1));

            Impares(numero1);

            Console.WriteLine(" ");

            ContadorPNC(numero1, numero2);

            Console.WriteLine(" ");

            Console.WriteLine(numero1 + "elevado a " + numero2 + " es: " + Potencia(numero1, numero2));

            Console.WriteLine("La sumatoria hasta "+numero1+" es: "+Sumatoria(numero1));

            Fibonacci(numero1);

            Console.WriteLine();

            Triangulo(numero1);

            Console.ReadKey();
        }
        
        static int SumaPares(int numero1)
        {
            int suma = 0;
            for (int i = 1; i <= numero1; i += 1)
            {
                if (i % 2 == 0)
                {
                    suma += i;
                }

            }
            return suma;

        }
        static bool EsPrimo(int numero1)
        {
            if (numero1 <=1)
            {
                return false;
            }
            for (int i =2; i<numero1;i++)
            {
                if (numero1%i==0)
                {
                    return false;
                }
            }
            return true;
        }
        static void ImprimirNumeros()
        {
            int contador = 1;
            while(contador <=100)
            {
                Console.Write(" "+contador);
                contador += 1;
            }
        
        }
        static int Factorial(int numero1)
        {
            if (numero1 < 0)
            {
                return 0;
            }
            int factorial = 1;
            for (int i=1; i<=numero1;i+=1)
            {
                factorial *= i;
            }
            return factorial;
        }
        static int SumarLosDigitos(int numero1)
        {
            int suma = 0;
            while (numero1>0)
            {
                suma += numero1 % 10;
                numero1 /= 10;
            }
            return suma;   
        }
        static int Vocales(string texto)
        {
            int contador = 0;
            foreach (char c in texto.ToLower())
            {
                if ("aeiou".Contains(c))
                {
                    contador += 1;
                }
            }
            return contador;
        }
        static void Impares(int numero1)
        {
            int contador = 0;
            for (int i=1; i<=numero1;i+=1)
            {
                if (i%2!=0)
                {
                    Console.Write(" "+i);
                    contador += 1;
                }
            }
        }
        static void ContadorPNC(int numero1, int numero2)
        {
            int positivos = 0;
            int negativos = 0;
            int ceros = 0;
            for (int i=numero1; i<=numero2;i+=1)
            {
                if (i>0)
                    positivos += 1;
                else if (i<0)
                    negativos += 1;
                else 
                    ceros += 1;
            }
            Console.WriteLine("Positivos: " + positivos);
            Console.WriteLine("Negativos: " + negativos);
            Console.WriteLine("Ceros: " + ceros);
        }
        static int Potencia(int numero1, int numero2)
        {
            int resultado = 1;
            for (int i = 1; i <= numero2; i++)
            {
                resultado *= numero1;
            }
            return resultado;
        }
        static int Sumatoria(int numero1)
        {
            int suma = 0;
            int contador = 1;
            while (contador<=numero1)
            {
                suma += contador;
                contador += 1;
            }
            return suma;
        }
        static void Fibonacci(int numero1)
        {
            int a = 0;
            int b=1;
            int c = 0;
            for (int i= 0; i < numero1;i+=1)
            {
                Console.Write(" "+a);
                c = a + b;
                a = b;
                b = c;
            }
        }
        static void Triangulo(int numero1)
        {
            for (int i=1;i<=numero1;i+=1)
            {
                for (int j=1;j<=numero1 - i;j+=1)
                {
                    Console.Write(" ");
                }
                for (int j=1; j<=(2*i-1);j+=1)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }



    }   
}
