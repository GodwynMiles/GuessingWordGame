namespace GuessingWordGame
{
    internal class Program
    {
        static void Main(string[] args)
        { //Get random word stuff
            string[] words = { "Molly", "Winter", "Gucci", "Wynwyn", "Maria", "Lorna", "Noel", "Lisa" };
            Random random = new Random();
            int randomIndex = random.Next(words.Length);
            string  selectedWords = words[randomIndex];
            string hiddenWord = "";

            for (int i = 0; i < selectedWords.Length; i++)
            {
                hiddenWord += "*";
            }
            //Gussing stuff
            while (hiddenWord.Contains("*"))
            {
                Console.WriteLine("Words: {0}", hiddenWord);
                Console.Write("Guess a letter: ");
                char letter = char.Parse(Console.ReadLine());
                bool containsLetter = false;

                for (int i = 0; i < selectedWords.Length; i++)
                {
                    if (selectedWords[i] == letter)
                    {
                        hiddenWord = hiddenWord.Remove(i,1);
                        hiddenWord = hiddenWord.Insert(i, letter.ToString());
                        containsLetter = true;
                    }
                }
                if (containsLetter == true)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Yes ! {0} is in the word", letter);
                }
                else
                {
                    Console.ForegroundColor= ConsoleColor.Red;
                    Console.WriteLine("Sorry, {0} is not in the word", letter);
                }
                Console.ResetColor();
            }// you won
            Console.WriteLine("Congratulations you've Won! the word was {0}", selectedWords);
        }
    }
}