using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe_Game
{
    
    public partial class Form1 : Form
    {       
        bool isHovered;
        public Form1()
        {
            InitializeComponent();
            // Butonun temel ayarları
            button10.FlatStyle = FlatStyle.Flat;
            button10.FlatAppearance.BorderSize = 0;
            button10.BackColor = Color.RoyalBlue;
            button10.BackgroundImageLayout = ImageLayout.Stretch;
            button10.FlatAppearance.MouseOverBackColor = Color.LightSkyBlue;
            button10.FlatAppearance.MouseDownBackColor = Color.SteelBlue;

            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0, 0, button10.Width, button10.Height);
            button10.Region = new Region(path);

            button10.MouseEnter += button10_MouseEnter;
            button10.MouseLeave += button10_MouseLeave;
            button10.Paint += button10_Paint;

            CornerRadius(panel2, 20);
            CornerRadius(panel3, 20);
            CornerRadius(panel1, 20);
            CornerRadius(panel6, 20);

        }
        public void CornerRadius(Panel panel, int radius)
        {
            IntPtr ptr = CreateRoundRegion(0, 0, panel.Width, panel.Height, radius, radius);
            panel.Region = Region.FromHrgn(ptr);
        }

        [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRegion(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);          
        private void sarıPanel_Paint(object sender, PaintEventArgs e)
        {
            LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle, Color.Gold, Color.Orange, 90F);
            e.Graphics.FillRectangle(brush, this.ClientRectangle);
        }
        private void button10_MouseEnter(object sender, EventArgs e)
        {
            isHovered = true;
            button10.Invalidate();
        }
        private void button10_MouseLeave(object sender, EventArgs e)
        {
            isHovered = false;
            button10.Invalidate();
        }

        private void button10_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            if (isHovered)
            {
                using (SolidBrush hoverBrush = new SolidBrush(Color.FromArgb(50, Color.White)))
                {
                    e.Graphics.FillEllipse(hoverBrush, 0, 0, button10.Width - 1, button10.Height - 1);
                }
            }
            using (Pen pen = new Pen(Color.FromArgb(150, Color.White), 2))
            {
                e.Graphics.DrawEllipse(pen, 1, 1, button10.Width - 3, button10.Height - 3);
            }
        }


      // M A I N
        int click = 0;




        int message, round = 1;
       
        bool a1 = false, a2 = false, a3 = false, a4 = false, a5 = false, a6 = false, a7 = false, a8 = false, a9 = false;

        Game game = new Game();
        Matrix matrix = new Matrix();
        Player1 player1 = new Player1();
        Player2 player2 = new Player2();

     
        private async void ButtonFunc(int buttonNumber)
        {
          
            label4.ForeColor = Color.Black;
            label5.ForeColor = Color.Black;
            label3.ForeColor = Color.Black;
            label2.ForeColor = Color.Black;           

            click++;

            if (round %2 == 1)
            {
                if (click % 2 == 0)
                {
                    label2.ForeColor = Color.Navy;
                    label4.ForeColor = Color.Navy;
                }

                if (click % 2 == 1)
                {
                    label3.ForeColor = Color.Navy;
                    label5.ForeColor = Color.Navy;
                }
            }
                
            if (round %2 == 0)
            {

                if (click % 2 == 0)
                {
                    label3.ForeColor = Color.Navy;
                    label5.ForeColor = Color.Navy;
                }

                if (click % 2 == 1)
                {
                    label2.ForeColor = Color.Navy;
                    label4.ForeColor = Color.Navy;
                }
            }

                if (buttonNumber == 1) button1.Text = game.countClick(click, 0, 0);
                else if (buttonNumber == 2) button2.Text = game.countClick(click, 0, 1);
                else if (buttonNumber == 3) button3.Text = game.countClick(click, 0, 2);
                else if (buttonNumber == 4) button4.Text = game.countClick(click, 1, 0);
                else if (buttonNumber == 5) button5.Text = game.countClick(click, 1, 1);
                else if (buttonNumber == 6) button6.Text = game.countClick(click, 1, 2);
                else if (buttonNumber == 7) button7.Text = game.countClick(click, 2, 0);
                else if (buttonNumber == 8) button8.Text = game.countClick(click, 2, 1);
                else if (buttonNumber == 9) button9.Text = game.countClick(click, 2, 2);

                message = game.checkGame();

                if (message == 1)
                {                  
                    if (round % 2 == 1)
                    {
                    await Task.Delay(300);
                    panel9.Visible = true;
                    label9.Text = "";
                        label8.Text = "Player 1 win";
                      

                        player1.score++;
                        label4.Text = player1.score.ToString();

                    }
                    else
                    {
                    await Task.Delay(300);
                    panel9.Visible = true;
                    label9.Text = "";
                        label8.Text = "Player 2 win";
                   

                        player2.score++;
                        label5.Text = player2.score.ToString();

                    }
                    restart();

                }
                else if (message == 2)
                {
                    if (round % 2 == 1)
                    {
                        await Task.Delay(300);
                        panel9.Visible = true;
                    label9.Text = "";
                    label8.Text = "Player 2 win";                     
                    player2.score++;
                    label5.Text = player2.score.ToString();


                    }
                    else
                    {
                        await Task.Delay(300);
                        panel9.Visible = true;
                        label9.Text = "";
                        label8.Text = "Player 1 win";                 
                        player1.score++;
                        label4.Text = player1.score.ToString();


                    }

                    restart();
                }

                else if (click % 9 == 0 && message != 2 && message != 1)
                {
                await Task.Delay(300);
                label8.Text = "";
                panel9.Visible = true;
                label9.Text = "Draw";              
                restart();
                } 
                
                
        }


        private void isEnabled(ref bool aNum, int bNumber)
        {
            if (!aNum)
            {
                ButtonFunc(bNumber);
                aNum = true;
            }
        }


        // ********************************************************************************************* 

        private void button1_Click(object sender, EventArgs e)
        {
            isEnabled(ref a1, 1);
        }
        private void button2_Click(object sender, EventArgs e)
        {

            isEnabled(ref a2, 2);
        }

        private void button3_Click(object sender, EventArgs e)
        {

            isEnabled(ref a3, 3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            isEnabled(ref a4, 4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            isEnabled(ref a5, 5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            isEnabled(ref a6, 6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            isEnabled(ref a7, 7); ;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            isEnabled(ref a8, 8);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            isEnabled(ref a9, 9);
        }

        private void button10_Click(object sender, EventArgs e)
        {

        }
        private void button10_Click_1(object sender, EventArgs e)
        {
            restart();
            round = 0;
            label7.Text = round.ToString();
            player1.score = 0;
            player2.score = 0;
            label4.Text = player1.score.ToString();
            label5.Text = player2.score.ToString();
            label4.ForeColor = Color.Black;
            label5.ForeColor = Color.Black;
            label3.ForeColor = Color.Black;
            label2.ForeColor = Color.Black;

        }

        private void restart()
        {
            Matrix matrixObj = new Matrix();
            click = 0;
            round++;
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
            a1 = false;
            a2 = false;
            a3 = false;
            a4 = false;
            a5 = false;
            a6 = false;
            a7 = false;
            a8 = false;
            a9 = false;
            message = 0;
            game.rebuildMatrix();
            label7.Text = round.ToString();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            panel9.Visible = false;


            label4.ForeColor = Color.Black;
            label5.ForeColor = Color.Black;
            label3.ForeColor = Color.Black;
            label2.ForeColor = Color.Black;

            if (round % 2 == 1)
            {
                if (click % 2 == 0)
                {
                    label2.ForeColor = Color.Navy;
                    label4.ForeColor = Color.Navy;
                }

                if (click % 2 == 1)
                {
                    label3.ForeColor = Color.Navy;
                    label5.ForeColor = Color.Navy;
                }
            }

            if (round % 2 == 0)
            {

                if (click % 2 == 0)
                {
                    label3.ForeColor = Color.Navy;
                    label5.ForeColor = Color.Navy;
                }

                if (click % 2 == 1)
                {
                    label2.ForeColor = Color.Navy;
                    label4.ForeColor = Color.Navy;
                }
            }



        }
    }
}
