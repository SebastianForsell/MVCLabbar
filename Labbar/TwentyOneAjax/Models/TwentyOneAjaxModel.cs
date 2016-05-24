using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOneAjax.Models
{
    public class TwentyOneAjaxModel
    {
        public int Increment { get; set; }
        public int CpuTurn { get; set; }
        public int ActualNumber { get; set; }
        public string GameOverText { get; set; }

        public int Randomize(int min, int max)
        {
            Random random = new Random();
            int result = random.Next(min, max);
            return result;
        }

        public void ComputerChoice()
        {
            int cpuChoice = 0;
            switch (ActualNumber)
            {
                case 19:
                    cpuChoice = 2;
                    break;
                case 20:
                    cpuChoice = 1;
                    break;
                default:
                    if (CpuTurn % 2 == 1)
                    {
                        cpuChoice = cpuSmartMove(cpuChoice);
                    }
                    else
                    {
                        cpuChoice = Randomize(1, 3);
                    }
                    break;
            }
            Increment = cpuChoice;
            CpuTurn++;
        }

        public int cpuSmartMove(int cpuChoice)
        {
            switch (ActualNumber % 3)
            {
                case 1:
                    cpuChoice = 2;
                    break;
                case 2:
                    cpuChoice = 1;
                    break;
                default:
                    cpuChoice = Randomize(1, 3);
                    break;
            }
            return cpuChoice;
        }

        public void IncreaseActualNumber(int i)
        {
            if (ActualNumber < 21)
            {
                ActualNumber += Increment;
                if (ActualNumber == 21)
                {
                    if (i == 1)
                    {
                        GameOverText = "You win!";
                    }
                    else if (i == 2)
                    {
                        GameOverText = "You lose!";
                    }
                    else if (ActualNumber == 22)
                    {
                        GameOverText = "The game is completely broken!";
                    }
                }
            }
        }
    }
}
