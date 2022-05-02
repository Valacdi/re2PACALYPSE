using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace _2PACALYPSE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Random rnd = new Random();
            int botnets = rnd.Next(1, 30);
            label4.Text = "Botnets online: " + botnets;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("give me an ip nigga!");
            }
            else
            {
                MessageBox.Show("aight on it nigguh...");
                this.Hide();
                AllocConsole();

                Console.ForegroundColor = ConsoleColor.Green;

                //random number
                Random rand = new Random();

                //string pattern to print
                String str = "";

                Console.WriteLine("Press ENTER to start the DDOS ATTACK NIGGA!...");
                Console.ReadKey();

                //loop to display string pattern
                //you can change the no. of times the loop execute
                for (int i = 0; i < 100000; i++)
                {
                    //create new string pattern
                    if (i % 2 == 0)
                    {
                        str = "";
                        for (int j = 0; j < 79; j++)
                        {
                            int n = rand.Next(5);
                            if (n < 2)
                            {
                                str += n.ToString();
                            }
                            else
                            {
                                str += " ";
                            }
                        }
                    }

                    //print str pattern
                    Console.WriteLine(str);
                }

                //end of loop
                Console.WriteLine("It's done my nigguh...");
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine("Closing the program in 3...");
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine("Closing the program in 2...");
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine("Closing the program in 1...");
                System.Threading.Thread.Sleep(1000);
                Environment.Exit(0);
            }
        }

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();
    }
}
