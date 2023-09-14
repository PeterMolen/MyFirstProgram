//                                  PETER MOLEN NET23
namespace MyFirstProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 18; // skapat en variabel (i) som sparat siffran 18

            if (i > 10) //if sats: OM (i) är större än 10 så (se nedan)
            {
                Console.WriteLine("Talet är stort!"); //  <<---- Svaret
            }
            else //annars får du svaret ( se nedan )
            {
                Console.WriteLine("Oj, lågt tal!"); //<<---- Svaret
            }

            Console.WriteLine("Vad heter du?");
            string name = Console.ReadLine();

            Console.WriteLine($"Hej {name}! ");


        for(int y = 0; y < i; y += 1) /*for loop, 
        den kör ifrån 0 till (i), alltså upp till 18*/
        {
            Console.WriteLine(y);
        }

        }
    }
}