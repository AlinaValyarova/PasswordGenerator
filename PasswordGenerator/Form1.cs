using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PasswordGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void Exception(string str)
        {
            if(str == null || str == "")
            {
                throw new ArgumentException("Не может быть");
            }

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
        public void CheckCheckBox2WithSym(bool a, int len_pas)
        {
            string pas; 
            if (a == true)
            {
                pas = GeneratePassWithSym(len_pas);
                label1.Text = ReplaceMiddle(pas).Substring(0, len_pas);
            }
            else
            {
                label1.Text = GeneratePassWithSym(len_pas);
            }
        }

        public void CheckCheckBox2WithoutSym(bool a, int len_pas)
        {
            string pas;
            if (a == true)
            {
                pas = GeneratePassWithoutSym(len_pas);
                label1.Text = ReplaceMiddle(pas).Substring(0, len_pas);
            }
            else
            {
                label1.Text = GeneratePassWithoutSym(len_pas);
            }
        }


        public string GeneratePassWithoutSym(int len)
        {
            string iPass = "";
            string[] arr = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "B", "C", "D", "F", "G", "H", "J", "K", "L", "M", "N", "P", "Q", "R", "S", "T", "V", "W", "X", "Z", "b", "c", "d", "f", "g", "h", "j", "k", "m", "n", "p", "q", "r", "s", "t", "v", "w", "x", "z", "A", "E", "U", "Y", "a", "e", "i", "o", "u", "y" };
            Random rnd = new Random();
            for (int i = 0; i < len; i += 1)
            {
                iPass = iPass + arr[rnd.Next(0, 57)];
            }
            return iPass;
        }

        public string GeneratePassWithSym(int len)
        {
            string iPass = "";
            string[] arr = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "B", "C", "D", "F", "G", "H", "J", "K", "L", "M", "N", "P", "Q", "R", "S", "T", "V", "W", "X", "Z", "b", "c", "d", "f", "g", "h", "j", "k", "m", "n", "p", "q", "r", "s", "t", "v", "w", "x", "z", "A", "E", "U", "Y", "a", "e", "i", "o", "u", "y", "{", "}", "[", "]", "(", ")", "'", "\"", "`", "~", ",", ";", ":", ".", "<", ">" };
            Random rnd = new Random();
            for (int i = 0; i < len; i += 1)
            {
                iPass = iPass + arr[rnd.Next(0, 72)];
            }
            return iPass;
        }

        public static string ReplaceMiddle(string _text)
        {
            string[] badwords = {"Shit", "Crap","Fuck", "Damn", "Whore", "Slut", "Bitch", "Freak", "Douchebag", "Bastard", "Asshole", "Jerk", "Dick", "Cunt", "Loser", "Sucker",
                "Nerd", "Noob", "Fool", "Stupid", "Dumb", "Retard" };
            Random rnd = new Random();

            return _text.Insert(_text.Length / 2, badwords[rnd.Next(0, 22)]);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int len_pas = (int)numericUpDown1.Value;

            if(checkBox1.Checked == true)
            {
                CheckCheckBox2WithSym(checkBox2.Checked, len_pas);
            }
            else
            {
                CheckCheckBox2WithoutSym(checkBox2.Checked, len_pas);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "" || label1.Text == "")
            {
                MessageBox.Show("Вы ввели не все данные", "Упс!");
                Exception(textBox1.Text);
            }
            else
            {
                StreamWriter file = new StreamWriter("FilewithPassword.txt");
                file.Write(textBox1.Text + " " + label1.Text);
                file.Close();
                MessageBox.Show("Пароль сохранен!", "Успех!");
            }

        }
    }
}
