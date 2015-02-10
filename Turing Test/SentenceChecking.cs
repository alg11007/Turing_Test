using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turing_Test
{
    static class Sentences
    {
        static List<string> Sentences = new List<string>();

        /// <summary>
        /// Start of the breaking up process</summary>
        /// <param name="Input">Input string that is going to be broken up!</param>
        static public void BreakItUpSentencesStart(string Input)
        {
            Input = Input.ToLower();
            Sentences.AddRange(Input.Split('.',','));
            foreach (string item in Sentences)
            {
                Words.BreakItUpWordsStart(item);
            }
        }
    }

    static class Words
    {
        static public void BreakItUpWordsStart(string input)
        {

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
