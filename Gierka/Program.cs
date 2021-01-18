using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gierka
{
    class Program
    {
        static void Main(string[] args)
        {
            var rand = new Random();
          
            int randomInt = rand.Next(101);

            int counter = 1;
            while (true)
            {
                

             try { 
            Console.WriteLine("Komputer losuje liczbę od 0 do 100. Wpisz jaką Twoim zdaniem, CPU wybrał.");
                    

                    int userInt = int.Parse(Console.ReadLine());

                  

             while (randomInt != userInt)
            {

                if(randomInt > userInt)
                {
                    Console.WriteLine("Nie odgadnąłeś liczby. Jest ona większa, próbuj dalej.");
                }
                if(randomInt < userInt)
                {
                    Console.WriteLine("Nie odgadnąłeś liczby. Jest ona mniejsza, próbuj dalej.");
                }


                userInt = int.Parse(Console.ReadLine());
                counter++;

            }
            Console.WriteLine("Odgadnąłeś liczbę w " + counter + " podejściach, brawo!");
                    break;
            }
            catch (Exception Ex)
            {
                Console.WriteLine("Podana wartość jest niewłaściwa, następnym razem wpisz liczbę!");
                    counter++;
            }
            }

        }
        }
    }

   

