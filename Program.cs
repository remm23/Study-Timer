using System;
//using System.Timers;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace StudyTimer
{
    class Program : Form
    {
        

        //public Button button1;

        /*
        public Program() 
        {
            button1 = new Button();
            button1.Size = new Size(40, 40);
            button1.Location = new Point(30, 30);
            button1.Text = "Click me";
            this.Controls.Add(button1);
            button1.Click += new EventHandler(button1_Click);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello World");
        }
        */
        static void Main(string[] args)
        {
            //Application.EnableVisualStyles();
            //Application.Run(new Program());
            MyTimer timer = new MyTimer();


            timer.SetTimer();
            Console.Read();
            timer.KillTimer();
            
        }

        
    }
}
