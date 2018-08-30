using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication6
{
    public partial class Cylinder : Form
    {
        //实例主窗体  
        Form1 pall = new Form1();

        private void init()
        {
            string[] temp= pall.par.Split(',');
            int i = 9;
            int k = temp.Length;
            comboBox1.Visible = false;
            this.comboBox1.SelectedIndex = 5;
            foreach (Control cur in this.panel1.Controls)
            {
                if (cur is TextBox)
                {
                    if (i <= k)
                    {
                        cur.Visible = true;
                        cur.Text = temp[i - 1];
                        if (cur.Text == "type")
                        {
                            k -= 1;
                            cur.Visible = false;
                            comboBox1.Visible = true;
                        }
                    }
                    else
                        cur.Visible = false;
                    i -= 1;
                }
            }
            i = 9;
            foreach (Control cur in this.panel1.Controls)
            {
                if (cur is Label)
                {
                    if (i <= k)
                        cur.Visible = true;
                    else
                        cur.Visible = false;
                    i -= 1;
                }
            }
        }

        public Cylinder(Form1 f1)
        {
            InitializeComponent();
            pall = f1;
            pictureBox1.Image =Image.FromFile(pall.pic); 
            init();
        }

        private int getN(string k)
        {
            int n = 0;
            if (k == "type")
            {
                if (comboBox1.Text == "X")
                    n = 1;
                if (comboBox1.Text == "Y")
                    n =2;
                if (comboBox1.Text == "Z")
                    n = 3;
                if (comboBox1.Text == "-X")
                    n = 4;
                if (comboBox1.Text == "-Y")
                    n = 5;
                if (comboBox1.Text == "-Z")
                    n = 6;
            }
            return n;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] temp = pall.par.Split(',');
            int k = temp.Length;//参数数量
            int ktemp = getN(temp[k - 1]);
            if (ktemp == 0)
                pall.bodyID +=1;
            string v = string.Empty;
            switch (k)
            {
                case 1:
                    if (ktemp != 0)
                        textBox1.Text = ktemp.ToString();
                    v = String.Format(pall.com, pall.bodyID.ToString(), textBox1.Text);
                    break;
                case 2:
                    if (ktemp != 0)
                        textBox2.Text = ktemp.ToString();
                    v = String.Format(pall.com, pall.bodyID.ToString(), ComTransFrom._F(textBox1.Text), textBox2.Text);
                    break;
                case 3:
                    if (ktemp != 0)
                        textBox3.Text = ktemp.ToString();
                    v = String.Format(pall.com, pall.bodyID.ToString(), ComTransFrom._F(textBox1.Text), ComTransFrom._F(textBox2.Text), textBox3.Text);
                    break;
                case 4:
                    if (ktemp != 0)
                        textBox4.Text = ktemp.ToString();
                    v = String.Format(pall.com, pall.bodyID.ToString(), ComTransFrom._F(textBox1.Text), ComTransFrom._F(textBox2.Text), ComTransFrom._F(textBox3.Text), textBox4.Text);
                    break;
                case 5:
                    if (ktemp != 0)
                        textBox5.Text = ktemp.ToString();
                    v = String.Format(pall.com, pall.bodyID.ToString(), ComTransFrom._F(textBox1.Text), ComTransFrom._F(textBox2.Text), ComTransFrom._F(textBox3.Text), ComTransFrom._F(textBox4.Text), textBox5.Text);
                    break;
                case 6:
                    if (ktemp != 0)
                        textBox6.Text = ktemp.ToString();
                    v = String.Format(pall.com, pall.bodyID.ToString(), ComTransFrom._F(textBox1.Text), ComTransFrom._F(textBox2.Text), ComTransFrom._F(textBox3.Text), ComTransFrom._F(textBox4.Text), ComTransFrom._F(textBox5.Text), textBox6.Text);
                    break;
                case 7:
                    if (ktemp != 0)
                        textBox7.Text = ktemp.ToString();
                    v = String.Format(pall.com, pall.bodyID.ToString(), ComTransFrom._F(textBox1.Text), ComTransFrom._F(textBox2.Text), ComTransFrom._F(textBox3.Text), ComTransFrom._F(textBox4.Text), ComTransFrom._F(textBox5.Text), ComTransFrom._F(textBox6.Text), textBox7.Text);
                    break;
                case 8:
                    if (ktemp != 0)
                        textBox8.Text = ktemp.ToString();
                    v = String.Format(pall.com, pall.bodyID.ToString(), ComTransFrom._F(textBox1.Text), ComTransFrom._F(textBox2.Text), ComTransFrom._F(textBox3.Text), ComTransFrom._F(textBox4.Text), ComTransFrom._F(textBox5.Text), ComTransFrom._F(textBox6.Text), ComTransFrom._F(textBox7.Text), textBox8.Text);
                    break;
                case 9:
                    if (ktemp != 0)
                        textBox9.Text = ktemp.ToString();
                    v = String.Format(pall.com, pall.bodyID.ToString(), ComTransFrom._F(textBox1.Text), ComTransFrom._F(textBox2.Text), ComTransFrom._F(textBox3.Text), ComTransFrom._F(textBox4.Text), ComTransFrom._F(textBox5.Text), ComTransFrom._F(textBox6.Text), ComTransFrom._F(textBox7.Text), ComTransFrom._F(textBox8.Text), textBox9.Text);
                    break;
                default:
                    if (ktemp != 0)
                        textBox2.Text = ktemp.ToString();
                    v = String.Format(pall.com, pall.bodyID.ToString(), ComTransFrom._F(textBox1.Text), textBox2.Text);
                    break;
            }
            pall.richTextBox1.Text += v;
            //string a = String.Format("Punches({0},{1},{2},{3},{4},{5})\r\n", textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text);
            //pall.textBox1.Text += a;

            ////int index = pall.textBox1.GetFirstCharIndexOfCurrentLine();//得到当前行第一个字符的索引
            //int line = pall.textBox1.Lines.GetUpperBound(0);
            //string b = String.Format("Feature{0}\r\n", line.ToString());
            //pall.textBox2.Text += b;
            this.Close();
            this.Dispose();
        }

    }
}
