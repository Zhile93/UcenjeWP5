using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.JavaScript;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E02VarijableTipoviPodataka
    {



        public static void Izvedi()
        {

            // deklaracija  varijable
            int i;

            // dodjeljivanje vrijednosti -> operator dodjeljivanja = 
            i = 7;

            // korištenje varijable
            Console.WriteLine(i);

            // učitanje broja od korisnika
            // pročitati Why are good programers lazy and dumb?

            Console.WriteLine("Molim upisati broj veći od nule: ");

            int broj = int.Parse(Console.ReadLine());

            Console.WriteLine(broj + 1);

            // za decimalne brojeve koristit ćemo float

            Console.WriteLine("Unesi decimalni broj (, je oznaka za decimalni broj): ");

            Console.WriteLine(float.Parse(Console.ReadLine()) + 1);


            bool uvjet = false;


            Console.WriteLine(uvjet);

            // operatori za rad s varijablama
            // =, +, -, *, /
            // == operator uspoređivanja, tipa bool
            // != različito, tipa bool
            int j = 3;

            Console.WriteLine(j == 3);
            Console.WriteLine(j != 6);


            // increment i decrement

            i = 0;

            i = i + 1;
            i += 1;
            i++; // prvo koristi pa uvećaj
            ++i; // prvo uvećaj pa koristi

            i = 1;
            Console.WriteLine(i++); // rješenje 1
            Console.WriteLine(i); // rješenje 2
            Console.WriteLine(++i); // rješenje 3
            Console.WriteLine(i); // rješenje isto 3

            // dekrement je ista stvar, samo u minusu

            i--;
            --i;

            // Prekrasni zadaci
            int x = 0, y = 1;
            x = ++x - y; // x = 0, y = 1
            y = x-- + y; // x = -1, y  = 1

            Console.WriteLine(x + y); // 0

            // operator modulo piše se s %

            Console.WriteLine("9%2 = {0}", 9 % 2);
            Console.WriteLine("8%2 = {0}", 8 % 2);

            x = 5;
            y = 2;

            // int / int daje int
            // molra se raditi cast da bi se dobio decimalni broj

            Console.WriteLine(x /(float) y); // (flooat) - cast u tip podatka float; možeš castati int u float, ali ne i string u float






        }




    }








}
