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
    public partial class Special : Form
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
            foreach (Control cur in this.Controls)
            {
                if (cur is TextBox)
                {
                    if (i <= k)
                    {
                        cur.Visible = true;
                        cur.Text = temp[i-1];
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
            foreach (Control cur in this.Controls)
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

        public Special(Form1 f1)
        {
            InitializeComponent();
            pall = f1;
            pictureBox1.Image =Image.FromFile(pall.pic); 
            init();
            //特殊处理
            switch (pall.pic.Split('\\')[pall.pic.Split('\\').Length - 1])
            {
                case "ArrayRotate.JPG":
                    //矩阵变化
                    textBox4.Text = "[0,0,0]";
                    break;
            }
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
            //string[] temp = pall.par.Split(',');
            //int k = temp.Length;//参数数量
            //int ktemp = getN(temp[k - 1]);
            //if (ktemp == 0)
            //    pall.bodyID +=1;
            string v = string.Empty;
            switch(pall.pic.Split('\\')[pall.pic.Split('\\').Length - 1])
            {
                case "sqrt.JPG":
                    //三角函数直角三角形
                    v = sqrt();
                    break;
                case "sqrt1.JPG":
                    //三角函数直角三角形
                    v = sqrt1();
                    break;
                case "ArrayRect.JPG":
                    //矩阵变化
                    v = ArrayRect();
                    break;
                case "ArrayRotate.JPG":
                    //矩阵变化
                    v = ArrayRotate();
                    break;
            }
            pall.richTextBox1.Text += v;

            this.Close();
            this.Dispose();
        }

        private string sqrt()
        {
            string v = string.Empty;
            if (textBox1.Text == "")
                v = String.Format("var temp = Math.sqrt(Math.pow({0},2) - Math.pow({1},2));\r\n", ComTransFrom._F(textBox3.Text), ComTransFrom._F(textBox2.Text));
            if (textBox2.Text == "")
                v = String.Format("var temp = Math.sqrt(Math.pow({0},2) - Math.pow({1},2));\r\n", ComTransFrom._F(textBox3.Text), ComTransFrom._F(textBox1.Text));
            if (textBox3.Text == "")
                v = String.Format("var temp = Math.sqrt(Math.pow({0},2) + Math.pow({1},2));\r\n", ComTransFrom._F(textBox1.Text), ComTransFrom._F(textBox2.Text));
            return v;
        }

        private string sqrt1()
        {
            string v = string.Empty;
            if (textBox5.Text == "0")
            {
                if (textBox1.Text == "")
                {
                    if (textBox2.Text == "")
                        v += String.Format("1 = Math.cos({0}*2*Math.PI/360) * {1};\r\n", ComTransFrom._F(textBox4.Text), ComTransFrom._F(textBox3.Text));
                    if (textBox3.Text == "")
                        v += String.Format("1 = {1} / Math.tan({0}*2*Math.PI/360);\r\n", ComTransFrom._F(textBox4.Text), ComTransFrom._F(textBox2.Text));
                }
                if (textBox2.Text == "")
                {
                    if (textBox1.Text == "")
                        v += String.Format("2 = Math.sin({0}*2*Math.PI/360) * {1};\r\n", ComTransFrom._F(textBox4.Text), ComTransFrom._F(textBox3.Text));
                    if (textBox3.Text == "")
                        v += String.Format("2 = {1} * Math.tan({0}*2*Math.PI/360);\r\n", ComTransFrom._F(textBox4.Text), ComTransFrom._F(textBox1.Text));
                }
                if (textBox3.Text == "")
                {
                    if (textBox1.Text == "")
                        v += String.Format("3 = {1} / Math.sin({0}*2*Math.PI/360);\r\n", ComTransFrom._F(textBox4.Text), ComTransFrom._F(textBox2.Text));
                    if (textBox2.Text == "")
                        v += String.Format("3 = {1} / Math.cos({0}*2*Math.PI/360);\r\n", ComTransFrom._F(textBox4.Text), ComTransFrom._F(textBox1.Text));
                }
            }
            else
            {
                if (textBox1.Text == "")
                {
                    if (textBox2.Text == "")
                        v += String.Format("1 = Math.sin({0}*2*Math.PI/360) * {1};\r\n", ComTransFrom._F(textBox4.Text), ComTransFrom._F(textBox3.Text));
                    if (textBox3.Text == "")
                        v += String.Format("1 = {1} * Math.tan({0}*2*Math.PI/360);\r\n", ComTransFrom._F(textBox4.Text), ComTransFrom._F(textBox2.Text));
                }
                if (textBox2.Text == "")
                {
                    if (textBox1.Text == "")
                        v += String.Format("2 = Math.cos({0}*2*Math.PI/360) * {1};\r\n", ComTransFrom._F(textBox4.Text), ComTransFrom._F(textBox3.Text));
                    if (textBox3.Text == "")
                        v += String.Format("2 = {1} / Math.tan({0}*2*Math.PI/360);\r\n", ComTransFrom._F(textBox4.Text), ComTransFrom._F(textBox1.Text));
                }
                if (textBox3.Text == "")
                {
                    if (textBox1.Text == "")
                        v += String.Format("3 = {1} / Math.cos({0}*2*Math.PI/360);\r\n", ComTransFrom._F(textBox4.Text), ComTransFrom._F(textBox2.Text));
                    if (textBox2.Text == "")
                        v += String.Format("3 = {1} / Math.sin({0}*2*Math.PI/360);\r\n", ComTransFrom._F(textBox4.Text), ComTransFrom._F(textBox1.Text));
                }
            }
            return v;
        }

        private string ArrayRect()
        {
            string v = string.Empty;
            v = String.Format("ArrayRect({0}, {1}, {2}, {3}, body{4});\r\n", ComTransFrom._F(textBox1.Text), ComTransFrom._F(textBox2.Text), ComTransFrom._F(textBox3.Text), ComTransFrom._F(textBox4.Text), pall.bodyID);
            return v;
        }

        private string ArrayRotate()
        {
            string v = string.Empty;
            v = String.Format("ArrayRotate({0}, {1}, {2}, {3}, body{4});\r\n", ComTransFrom._F(textBox1.Text), ComTransFrom._F(textBox2.Text), ComTransFrom._F(textBox3.Text), ComTransFrom._F(textBox4.Text), pall.bodyID);
            return v;
        }

    }
}
