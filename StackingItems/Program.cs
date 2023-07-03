namespace StackingItems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Stacking items");
            Console.WriteLine("Please choose 1 to Push, 2 to Pop or 3 to Peek:");

            Stack<string> words = new Stack<string>();
            words.Push("one");
            words.Push("two");

            int optionPicked = int.Parse(Console.ReadLine());
            if (optionPicked == 1)
            {
                words.Push(Console.ReadLine());
                foreach (string word in words)
                {
                    Console.WriteLine($"Pushed word is :{word}");
                }

            }
            else if (optionPicked == 2)
            {
                string poppedWord = words.Pop();
                Console.WriteLine(poppedWord);
            }
            else if (optionPicked == 3)
            {
                string peeked = words.Peek();
                Console.WriteLine($"Peeked value is :{peeked}");
            }
            else
            {
                Console.WriteLine("Invalid input.");
            }
        }
    }
}