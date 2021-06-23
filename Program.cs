using System;
using System.Linq;

namespace ca_demoNS
{
    class Program
    {
        public static int phrase;
        public class Example
        {
            private string m_phrase;
            private Example() { }

            public Example(string phrase)
            {
                m_phrase = phrase;
            }

            public string Phrase
            {
                get { return m_phrase; }
            }

            public void ConvertPhrase(string phrase)
            {
                string[] words = phrase.Split(' ');
                Console.WriteLine("Number of Words: " + words.Length);
                foreach (var word in words)
                {
                    Console.WriteLine(word);
                    int[] vowelValues = { 0, 0, 0, 0, 0 };
                    char[] characters = word.ToCharArray();
                    foreach (var character in characters)
                    {
                        if (character == 'a')
                        {
                            vowelValues[0] = 1;
                        }
                        else if (character == 'e')
                        {
                            vowelValues[1] = 1;
                        }
                        else if (character == 'i')
                        {
                            vowelValues[2] = 1;
                        }
                        else if (character == 'o')
                        {
                            vowelValues[3] = 1;
                        }
                        else if (character == 'u')
                        {
                            vowelValues[4] = 1;
                        }
                    }
                    // var segment = new ArraySegment<string>( characters, 1, 2 );
                    m_phrase = String.Concat(characters[0].ToString() + vowelValues.Sum() + characters[characters.Length - 1]);
                    Console.WriteLine(characters[0].ToString() + vowelValues.Sum() + characters[characters.Length - 1]);
                }


            }
            public static void Main(string[] args)
            {
                string main_phrase = "The stray cat is way cool.";
                Example example = new Example();
                
                example.ConvertPhrase(main_phrase);
            }
        }
    }
}
