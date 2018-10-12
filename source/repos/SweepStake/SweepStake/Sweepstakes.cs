  using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStake
{
    class Sweepstakes
    {
        Dictionary<string, Contestant> allContestants;

        public string _registrationNumber { get; private set; }

        public Sweepstakes(string name)
        {
            
           allContestants = new Dictionary<string, Contestant>();
        }

        public void RegisterContestant(Contestant contestant)
        {
            allContestants.Add(contestant.registrationNumber, contestant);
        }

        public string PickWinner()
        {
            Random rnd = new Random();
            int winner = rnd.Next(1, 10000);

             _registrationNumber = winner.ToString();
            return _registrationNumber;
        }
         public void PrintContestantInfo(Contestant contestant)
        {
            Console.WriteLine("Congratulations to: "+ "_firstName " +"_lastName ");
        }

    }
}
