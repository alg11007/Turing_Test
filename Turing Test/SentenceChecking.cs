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
        static public void Break_Up_Sentences_Start(string Input)
        {
            Input = Input.ToLower();
            SentencesInInput.AddRange(Input.Split('.', ','));
            foreach (string item in SentencesInInput)
            {
                Words.Break_Up_Words_Start(item);
            }
        }
    }

    static class Words
    {
        static List<string> WordsInSentence = new List<string>();
        static List<string> KeywordsInSentence = new List<string>();

        static public void Break_Up_Words_Start(string input)
        {
            bool QuestionSentence;
            WordsInSentence.AddRange(input.Split(' '));
            foreach(string item in WordsInSentence)
            {
                if (item.Contains('?'))
                {
                    QuestionSentence = true;                // Är det meningen med frågan
                    item.Substring(0, item.Length - 1);     // Tabort Questionmark.
                }
                //Console.WriteLine(item);
                Check_Add_KeyWord(item);
            }
            Check_Keywords();
        }

        /// <summary>
        /// Checking if first word is question</summary>
        /// <param name="firstWord">Word to be checked</param>
        static private bool Check_Add_KeyWord(string inputWord)
        {
            switch (inputWord)
            {
                case "heter":
                    KeywordsInSentence.Add(inputWord);
                    return true;
            }
            return false;
        }
    }
}
