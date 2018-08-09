using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CricketGame
{
    public class Cricket
    {
        public int Result;
        public int PlayerScore { get; set; }
        public Boolean Out=false;
        public Cricket()
        {
            PlayerScore = 0;
        }

        public void playerOut()
        {
            Out = true;
        }

        public void result(int player1score,int player2score)
        {
            if (player1score > player2score)
            {
                Result = 1;
            }
            else if (player1score < player2score)
            {
                Result = 2;
            }
            else
            {
                Result = 0;
            }
        }

        public void Score(int runs)
        {
            if (runs <= 6 && Out==false)
            {
                PlayerScore = PlayerScore + runs;
            }
            //throw new NotImplementedException();
        }
    }
}
