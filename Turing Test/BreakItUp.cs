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

        static public void BreakItUpStart(string Input)
        {
            Input = Input.ToLower();
            Word.AddRange(Input.Split(' '));
            CheckIfQuestion(Word[0]);
        }

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
