using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Russian_roulate_askaran
{
    public partial class MainForm : Form
    {
        spin obj_sp = new spin();
        public MainForm()
        {
            InitializeComponent();
        }

        private void button_shoot(object sender, EventArgs e)
        {
            // this code is for the picture box
            pictureBox_main.Visible = true;
            //this code takes the gif from url and puts it in img variable
            Image img = Image.FromFile(@"C:\Users\sunny\source\repos\Russian roulate askaran\res\3.gif");
            pictureBox_main.Image = img;
            // this code is for the sound
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C: \Users\sunny\source\repos\Russian roulate askaran\res\3.wav");
            player.Play();
            do
            {
                if (obj_sp.shoot == 0 && obj_sp.load == obj_sp.Spin)//this code checks if the shoot is equal to and load is equal to spin then it runs the below code
                {
                    MessageBox.Show("you won and your score is 10");
                    obj_sp.shoot = 3;//this code sets the shoot to 3
                    Shoot_btn.Enabled = false;//this code disable the shoot button
                }
                else if (obj_sp.shoot == 1 && obj_sp.load == obj_sp.Spin)
                {
                    MessageBox.Show("you won and your score is 5");
                    obj_sp.shoot = 3;//this code sets the shoot to 3
                    obj_sp.reset = obj_sp.reset - 1;//this code decrease the value of reset by 1

                }
                else if (obj_sp.shoot == 2 && obj_sp.load != obj_sp.Spin)
                {
                    MessageBox.Show("you loose");//this code shows the loose message 
                    obj_sp.shoot = 3;//this code sets the shoot to 3
                    obj_sp.reset = obj_sp.reset - 1;//this code decrease the value of reset by 1

                }
                else
                {
                    obj_sp.shoot++;// this code increase the shoot variable by 1

                    
                    //this code is calling the spin class
                    spin s = new spin();
                    obj_sp.Spin = s.spined(obj_sp.Spin);
                }
            }
            while (obj_sp.shoot <= 2);

            if (obj_sp.reset == 0)
            {   //This code reset the buttons 
                Shoot_btn .Enabled = false;//this code disable the shoot button
                Spin_btn .Enabled = true;//this code enable the spin button
                Load_btn.Enabled = true;// this code enable the load button
                obj_sp.reset = 2;
            }



        }
    

        private void button_spin(object sender, EventArgs e)
        {
            pictureBox_main.Visible = true;
            Image img = Image.FromFile(@"C:\Users\sunny\source\repos\Russian roulate askaran\res\2.gif");
            pictureBox_main.Image = img;

            //this code is for spining the chamber and it will pick bullet randomly
            Random rnd = new Random();
            //this code helps to pick random number between 1-7.
            obj_sp.Spin = rnd.Next(1, 7);

            Shoot_btn .Enabled = true;//this code enables the shoot button
            Spin_btn.Enabled = false;// this code enables the spin button
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void button_playagain(object sender, EventArgs e)
        { //this code restart the game 

            (new MainForm()).Show();
            this.Hide();
        }

        private void Load_btn_Click(object sender, EventArgs e)
        {
            // this code is for the gif
            pictureBox_main.Visible = true;
            // this code is for to transfer img from url to variable 
            Image img = Image.FromFile(@"C:\Users\sunny\source\repos\Russian roulate askaran\res\1.gif");
            pictureBox_main.Image = img;


            //this code loads the 1 bullet
            obj_sp.load = 1;

            Load_btn.Enabled = false;//this code disable the load button
            Spin_btn.Enabled = true;//this code enable the spin button
        }
    }
}
