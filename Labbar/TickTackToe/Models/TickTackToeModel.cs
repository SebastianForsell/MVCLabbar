﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TickTackToe.Models
{
    public class TickTackToeModel
    {
        public List<int> PlayerXNumbers { get; set; } = new List<int>() { };
        public List<int> PlayerONumbers { get; set; } = new List<int>() { };
        public int Turn { get; set; }
        public int Choice { get; set; }
        public string Nooo { get; set; }
        public string GameOverText { get; set; }
        public bool GameOver { get; set; } = false;

        private int[,] winCombos = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9, }, { 1, 5, 9 }, { 3, 5, 7 }, { 1, 4, 7 }, { 2, 5, 8 }, { 3, 6, 9 } };
        public void CheckIfWon()
        {
            if (Turn < 9)
            {
                if (Turn % 2 == 1)
                {
                    if (CheckIfThreeInRow(PlayerONumbers))
                    {
                        GameOverText = "O wins!";
                        GameOver = true;
                    }
                    
                }
                else if (CheckIfThreeInRow(PlayerXNumbers))
                {
                    GameOverText = "X wins!";
                    GameOver = true;
                }
            }
            else
            {
                GameOverText = "Draw";
                GameOver = true;
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
        }
        public void AddNumber()
        {
            if (Turn % 2 == 0)
            {
                PlayerONumbers.Add(Choice);
            }
            else
            {
                PlayerXNumbers.Add(Choice);
            }
            Turn++;
        }
    }
}