using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turing_Test
{
    static class Sentences
    {
        static List<string> SentencesInInput = new List<string>();

        /// <summary>
        /// Start of the breaking up process</summary>
        /// <param name="Input">Input string that is going to be broken up!</param>
        static public void BreakItUpSentencesStart(string Input)
        {
            Input = Input.ToLower();
            SentencesInInput.AddRange(Input.Split('.', ',', '?'));
            foreach (string item in SentencesInInput)
            {
                Words.BreakItUpWordsStart(item);
            }
        }
    }

    static class Words
    {
        static List<string> WordsInSentence = new List<string>();
        static public void BreakItUpWordsStart(string input)
        {
            WordsInSentence.AddRange(input.Split(' '));
            foreach(string item in WordsInSentence)
            {
                Console.WriteLine(item);
            }
        }
        /// <summary>
        /// Checking if first word is question</summary>
        /// <param name="firstWord">Word to be checked</param>
        static public bool CheckIfKeyWord(string firstWord)
        {
            switch (firstWord)
            {
                case "vad":
                    Console.Write("De Var en Fråga");
                    return true;
            }
            return false;
        }
    }
}
