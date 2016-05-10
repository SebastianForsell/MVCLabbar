using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TickTackToe.Models
{
    class TickTackToeModel
    {
        public List<int> PlayerXNumbers { get; set; }
        public List<int> PlayerONumbers { get; set; }
        public int Turn { get; set; }
        public string GameOverText { get; set; }

        int[,] winCombos = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9, }, { 1, 5, 9 }, { 3, 5, 7 }, { 1, 4, 7 }, { 2, 5, 8 }, { 3, 6, 9 } };
        public void CheckIfWon()
        {
            if (Turn % 2 == 0)
            {
                if (CheckIfThreeInRow(PlayerONumbers))
                {
                    GameOverText = "O wins!";
                }
            }
            else if (CheckIfThreeInRow(PlayerXNumbers))
            {
                GameOverText = "X wins!";
            }
            else
            {
                GameOverText = "Draw";
            }

        }
        public bool CheckIfThreeInRow(List<int> list)
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (!list.Contains(winCombos[i, j]))
                    {
                        break;
                    }
                    else if (j == 2)
                    {
                        return true;
                        //tre i rad
                    }

                }
            }
            return false;

            //if (list.Contains(1))
            //{
            //    if(list.Contains(2) && list.Contains(3))
            //    {

            //    }
            //    else if(list.Contains(4) && list.Contains(7))
            //    {

            //    }
            //    else if(list.Contains(5) && list.Contains(9))
            //    {

            //    }
            //}
        }
    }
}
