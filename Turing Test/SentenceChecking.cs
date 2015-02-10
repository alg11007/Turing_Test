using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

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
            //SentencesInInput.AddRange(Input.Split('.', ',','?'));
            SentencesInInput.AddRange(Regex.Split(Input, @"(?<=[.,?])"));
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
            WordsInSentence.Clear();
            KeywordsInSentence.Clear();

            bool QuestionSentence;
            WordsInSentence.AddRange(input.Split(' '));
            foreach(string item in WordsInSentence)
            {
                if (item.Contains('?'))
                {
                    Check_Add_KeyWord(item.Substring(0, item.Length - 1));      // Tabort Questionmark.
                }
                else if (item.Contains('.'))
                {
                    Check_Add_KeyWord(item.Substring(0, item.Length - 1));      // Tabort Questionmark.
                }
                else if (item.Contains(','))
                {
                    Check_Add_KeyWord(item.Substring(0, item.Length - 1));      // Tabort Questionmark.
                }
                else
                {
                    Check_Add_KeyWord(item);
                }
            }
            Check_Keywords();
        }

        /// <summary>
        /// Checking if first word is question</summary>
        /// <param name="firstWord">Word to be checked</param>
        static private bool Check_Add_KeyWord(string Word)
        {
            switch (Word)
            {
                case "heter":
                    KeywordsInSentence.Add(Word);
                    return true;
                case "du":
                    KeywordsInSentence.Add(Word);
                    return true;
            }
            return false;
        }

        static private bool Check_Keywords()
        {
            if (Contains("heter") && Contains("du"))
                Console.WriteLine("Jag heter bahamas");
            return false;
        }

        static private bool Contains(string word)
        {
            return KeywordsInSentence.Contains(word);
        }
    }
}
