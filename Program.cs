//                                  PETER MOLEN NET23
namespace MyFirstProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 18; // Created a variable (i) as i saved as #18

            if (i > 10) //if statement: IF (i) is bigger then 10, look below
            {
                Console.WriteLine("Talet är stort!"); //  <<---- Anwser
            }
            else //else (otherwise) you get the anwser (look below)
            {
                Console.WriteLine("Oj, lågt tal!"); //<<---- Anwser
            }

            Console.WriteLine("Vad heter du?");
            string name = Console.ReadLine();

            Console.WriteLine($"Hej {name}! ");


        for(int y = 0; y < i; y += 1) /*for loop, 
        it runs from  0 to (i), i=18, so up to 18 */
        {
            Console.WriteLine(y);
        }

        }
    }
}