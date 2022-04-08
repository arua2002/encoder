using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace шифратор
{
    public partial class Form1 : Form
    {

        char[] checkru = { '!', '@', '#', '$', '%', '^', '&', '*'}; //a,о,е,и,н,т,р,с 
        char[] checken = { 'æ', 'ϴ', 'Ϫ', 'Ϩ', 'ϗ', 'ψ', 'σ', 'ζ'}; //a,o,e,i,n,t,r,c
        private void button1_Click(object sender, EventArgs e)
        {
            //listBox1.Items.Clear();
            //listBox2.Items.Clear();
            textBox2.Clear();
            string s = textBox1.Text,q1="",q2="",q3="";                      
            char[] mass = new char[s.Length];
            char[] mass1 = new char[s.Length];
            char[] mass2 = new char[s.Length];           
            mass = s.ToCharArray();
            for (int i = 0; i < s.Length; i++)
            {  //ru              
                if (mass[i] == 'а' ) mass[i] = checkru[0];
                if (mass[i] == 'о' ) mass[i] = checkru[1];
                if (mass[i] == 'е' ) mass[i] = checkru[2];
                if (mass[i] == 'и' ) mass[i] = checkru[3];
                if (mass[i] == 'н' ) mass[i] = checkru[4];
                if (mass[i] == 'т' ) mass[i] = checkru[5];
                if (mass[i] == 'р' ) mass[i] = checkru[6];
                if (mass[i] == 'с' ) mass[i] = checkru[7];
                //en
                if (mass[i] == 'a' ) mass[i] = checken[0]; 
                if (mass[i] == 'o' ) mass[i] = checken[1];
                if (mass[i] == 'e' ) mass[i] = checken[2];
                if (mass[i] == 'i' ) mass[i] = checken[3];
                if (mass[i] == 'n' ) mass[i] = checken[4];
                if (mass[i] == 't' ) mass[i] = checken[5];
                if (mass[i] == 'r' ) mass[i] = checken[6];
                if (mass[i] == 'c' ) mass[i] = checken[7];
            }
            if (s.Length % 2 == 0)
            {
                for (int i = 0; i < s.Length/2; i++) mass1[i] = mass[i];//listBox1.Items.Add(mass1[i]);               
                for (int i = s.Length / 2; i < s.Length; i++) mass2[i] = mass[i];  //listBox2.Items.Add(mass2[i]);              
                for (int i = (s.Length/2)-1; i >= 0; i--) q1 += mass1[i].ToString();
                for (int i = s.Length-1 ; i >= s.Length/2; i--) q2 += mass2[i].ToString(); 
                textBox2.Text = q1+q2;
            }
            else if (s.Length % 2 == 1)
            {
                for (int i = 0; i < (s.Length - 1) / 2; i++) mass1[i] = mass[i]; // listBox1.Items.Add(mass1[i]);//             
                for (int i=(s.Length+1)/2;i<s.Length;i++)  mass2[i] = mass[i]; // listBox2.Items.Add(mass2[i]);//                
                for (int i = (s.Length / 2) - 1; i >= 0; i--) q1 += mass1[i].ToString();
                for (int i = s.Length - 1; i >= s.Length / 2; i--) q2 += mass2[i].ToString();
                q3 = mass[((s.Length + 1) / 2) - 1].ToString();
                textBox2.Text = q1 + mass[((s.Length + 1) / 2) - 1].ToString() + q2; // label1.Text = mass[((s.Length+1)/2)-1].ToString();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            string s = textBox3.Text,q1="" , q2="",q3="";
            char[] mass = new char[s.Length];
            char[] mass1 = new char[s.Length];
            char[] mass2 = new char[s.Length];
            mass = s.ToCharArray();
            for (int i = 0; i < s.Length; i++)
            {  //ru              
                if (mass[i] == '!') mass[i] = 'а';
                if (mass[i] == '@') mass[i] = 'о';
                if (mass[i] == '#') mass[i] = 'е';
                if (mass[i] == '$') mass[i] = 'и';
                if (mass[i] == '%') mass[i] = 'н';
                if (mass[i] == '^') mass[i] = 'т';
                if (mass[i] == '&') mass[i] = 'р';
                if (mass[i] == '*') mass[i] = 'с';
                //en
                if (mass[i] == 'æ') mass[i] = 'a';
                if (mass[i] == 'ϴ') mass[i] = 'o';
                if (mass[i] == 'Ϫ') mass[i] = 'e';
                if (mass[i] == 'Ϩ') mass[i] = 'i';
                if (mass[i] == 'ϗ') mass[i] = 'n';
                if (mass[i] == 'ψ') mass[i] = 't';
                if (mass[i] == 'σ') mass[i] = 'r';
                if (mass[i] == 'ζ') mass[i] = 'c';
            }
            if (s.Length % 2 == 0)
            {
                for (int i = 0; i < s.Length / 2; i++) mass1[i] = mass[i];//listBox1.Items.Add(mass1[i]);               
                for (int i = s.Length / 2; i < s.Length; i++) mass2[i] = mass[i];  //listBox2.Items.Add(mass2[i]);              
                for (int i = (s.Length / 2) - 1; i >= 0; i--) q1 += mass1[i].ToString();
                for (int i = s.Length - 1; i >= s.Length / 2; i--) q2 += mass2[i].ToString();
                textBox4.Text = q1 + q2;
            }
            else if (s.Length % 2 == 1)
            {
                for (int i = 0; i < (s.Length - 1) / 2; i++) mass1[i] = mass[i]; // listBox1.Items.Add(mass1[i]);//             
                for (int i = (s.Length + 1) / 2; i < s.Length; i++) mass2[i] = mass[i]; // listBox2.Items.Add(mass2[i]);//                
                for (int i = (s.Length / 2) - 1; i >= 0; i--) q1 += mass1[i].ToString();
                for (int i = s.Length - 1; i >= s.Length / 2; i--) q2 += mass2[i].ToString();
                q3 = mass[((s.Length + 1) / 2) - 1].ToString();
                textBox4.Text = q1 + mass[((s.Length + 1) / 2) - 1].ToString() + q2; // label1.Text = mass[((s.Length+1)/2)-1].ToString();
            }
        }
        public Form1()
        {
            InitializeComponent();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {          
        }
    }
}
