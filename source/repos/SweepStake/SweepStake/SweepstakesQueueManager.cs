using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStake
{
    class SweepstakesQueueManager : ISweepstakesManager
    {
        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {

        }
        public Sweepstakes GetSweepstakes()
        {
            Sweepstakes sweepstakes = new Sweepstakes();
            return sweepstakes;
        }
    }
}
