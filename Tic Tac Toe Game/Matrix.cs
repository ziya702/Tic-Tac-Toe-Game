using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe_Game
{

    internal class Matrix
    {
        int number;
        public Matrix() { number = 0; }
        public int[,] matrix = new int[3, 3];
       

        public void changeStatus(int a, int b, string status)
        {                    
            if (status == "o") matrix[a, b] = 2;         
            else if (status == "x") matrix[a, b] = 1;
        }

        public int checkMatrix()
        {
            int[] array = matrix.Cast<int>().ToArray();
            number = 0;
            if (array[0] != 0 && array[0] == array[1] && array[1] == array[2])
            {
                number = array[0];
                return number;
            }

            if (array[3] != 0 && array[3] == array[4] && array[4] == array[5])
            {
                number = array[3];
                return number;
            }

            if (array[6] != 0 && array[6] == array[7] && array[7] == array[8])
            {
                number = array[6];
                return number;
            }

            if (array[0] != 0 && array[0] == array[3] && array[3] == array[6])
            {
                number = array[0];
                return number;
            }

            if (array[1] != 0 && array[1] == array[4] && array[4] == array[7])
            {
                number = array[1];
                return number;
            }

            if (array[2] != 0 && array[2] == array[5] && array[5] == array[8])
            {
                number = array[2];
                return number;
            }

            if (array[0] != 0 && array[0] == array[4] && array[4] == array[8])
            {
                number = array[0];
                return number;
            }

            if (array[2] != 0 && array[2] == array[4] && array[4] == array[6])
            {
                number = array[2];
                return number;
            }

            

            return number;
        }

        public void checkPlayer (int number)
        {
            Player1 player1 = new Player1();
            Player2 player2 = new Player2();
            int winner = checkMatrix();
            if (number == 1) player1.score++;
            else if(number == 2) player2.score++;

            //return number;
        }


             
    }
}
