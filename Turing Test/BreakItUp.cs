using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turing_Test
{
    static class BreakItUp
    {
        static List<string> Word = new List<string>();

        /// <summary>
        /// Start of the breaking up process</summary>
        /// <param name="Input">Input string that is going to be broken up!</param>
        static public void BreakItUpStart(string Input)
        {
            Input = Input.ToLower();
            Word.AddRange(Input.Split(' '));
            if (CheckIfQuestion(Word[0]))
            {
                    
            }
            else
                Console.WriteLine("Förstog inte riktigt vad du menade");
        }

        /// <summary>
        /// Checking if first word is question</summary>
        /// <param name="firstWord">Word to be checked</param>
        static private bool CheckIfQuestion(string firstWord)
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
