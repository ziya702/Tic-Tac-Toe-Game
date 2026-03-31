using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Tic_Tac_Toe_Game
{
    using System.Drawing.Drawing2D;


    public partial class Main_Menu : Form
    {
        [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
        int nLeftRect,     
        int nTopRect,      
        int nRightRect,    
        int nBottomRect,   
        int nWidthEllipse, 
        int nHeightEllipse 
        );


        public Main_Menu()
        {
            InitializeComponent();
            this.Region = null;
            this.Opacity = 1.0;
            // this.BackgroundImage = Properties.Resources.main_menu_bg;
            // this.BackgroundImageLayout = ImageLayout.Stretch;

            //button1.Text = "\U0001F465 2 Players";
            //button1.Font = new Font("Segoe UI Symbol", 14,FontStyle.Bold);
            //button2.Text = "\U0001F916 VS Bot";
           // button2.Font = new Font("Segoe UI Symbol", 14, FontStyle.Bold);

            button1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button1.Width, button1.Height, 20, 20));
           // button2.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button2.Width, button2.Height, 20, 20));
        }
        private void Main_Menu_Paint(object sender, PaintEventArgs e)
        {

         
        }
       






        private void button1_Click(object sender, EventArgs e)
        {
            Form1 newForm = new Form1();
            newForm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

       
    }
    
}
