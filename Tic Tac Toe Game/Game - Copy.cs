using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe_Game
{
    internal class CopyGame
    { 
        CopyMatrix matrixobj = new CopyMatrix();
     
        public string countClick(int click, int a, int b)
        {
            string point;
            if (click %2 == 0)
            {
                point = "o";
                matrixobj.changeStatus(a, b, point);
                return point;
            }

            else
            {
                point = "x";
                matrixobj.changeStatus(a, b, point);
                return point;
            }
        }

 
        public int checkGame()
        {            
            int message = matrixobj.checkMatrix();            
            return message ;
        }
      
        public void rebuildMatrix()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    matrixobj.matrix[i, j] = 0;
                }
            }
        }
    }

}