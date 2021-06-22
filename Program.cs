using System;

namespace ca_demo
{
    class Program
    {
        public static int aCount { get; private set; }
        public static int eCount { get; private set; }
        public static int iCount { get; private set; }
        public static int oCount { get; private set; }
        public static int uCount { get; private set; }

        static void Main(string[] args)
        {
            string phrase = "The stray cat is way cool.";
            string[] words = phrase.Split(' ');
            Console.WriteLine(words.Length);
            foreach (var word in words)
            {
                char[] characters = word.ToCharArray();
                foreach (var character in characters)
                {
                    if (character == 'a')
                        aCount++;

                    if (character == 'e')
                        eCount++;

                    if (character == 'i')
                        iCount++;

                    if (character == 'o')
                        oCount++;

                    if (character == 'u')
                        uCount++;
                }
                Console.WriteLine("A count: " + aCount);
                Console.WriteLine("E count: " + eCount);
                Console.WriteLine("I count: " + iCount);
                Console.WriteLine("O count: " + oCount);
                Console.WriteLine("U count: " + uCount);

            }
        }

        private static bool doesWordHaveVowel(string vowelWord)
        {
            throw new NotImplementedException();
        }
    }
}
