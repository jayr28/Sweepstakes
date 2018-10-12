using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStake
{
    static class UserInput
    {
        public static string GetInput(string userMessage)
        {
            Console.WriteLine(userMessage);
            string Input = Console.ReadLine();
            return Input;

        
        }
    }

}
