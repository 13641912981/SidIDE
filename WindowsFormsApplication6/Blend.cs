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
    public partial class Blend : Form
    {
        //实例主窗体  
        Form1 pall = new Form1();
        int isk;
        public Blend(Form1 f1,int k)
        {
            InitializeComponent();
            pall = f1;
            isk = k;
            //pictureBox1.Image = Image.FromFile(pall.pic);
            if (k == 1)
                dis1.Text = "C";
            else
                dis1.Text = "R";
        }

        private int Index;
        public int index
        {
            get { return Index; }
            set { Index = value; }
        }

        private int _Y;
        public int Y
        {
            get { return _Y; }
            set { _Y = value; }
        }

        private int _N;
        public int N
        {
            get { return _N; }
            set { _N = value; }
        }

        private int _Type;
        public int Type
        {
            get { return _Type; }
            set { _Type = value; }
        }

        private int _Class;
        public int Class
        {
            get { return _Class; }
            set { _Class = value; }
        }

        private void Blend_Load(object sender, EventArgs e)
        {
            index = 3;
            N = 0;
            Type = 1;
            Class = 1;
            pictureBox1.Image = Image.FromFile(Application.StartupPath + "\\pic\\Blend1.JPG");
            pictureBox2.Image = Image.FromFile(Application.StartupPath + "\\pic\\button\\symmetric_offsets.gif");
            pictureBox3.Image = Image.FromFile(Application.StartupPath + "\\pic\\button\\asymmetric_offsets.gif");
            pictureBox4.Image = Image.FromFile(Application.StartupPath + "\\pic\\button\\offset_and_angle.gif");
            pic2label.BackColor = Color.FromArgb(120, 2, 143, 245);
            pic3label.BackColor = Color.FromArgb(0, 2, 143, 245);
            pic4label.BackColor = Color.FromArgb(0, 2, 143, 245);

            classEdgeLabel.BackColor = Color.FromArgb(120, 2, 143, 245);
            dis2.Visible = false;
            facePointX.Visible = false;
            facePointY.Visible = false;
            facePointZ.Visible = false;
            dis2Label.Visible = false;
            facePointLabel.Visible = false;
            if (isk != 1)
            {//圆角没有非对称和角度，屏蔽对应选项
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string alix=string.Empty;
            N += 1;
            if (N > 9)
            {
                MessageBox.Show("Error:最多允许10个点");
                return;
            }
            for (int i = 0; i < 3; i++)
            {
                TextBox txt = new TextBox();
                index += 1;
                if(i==0)
                {
                    txt.Left = 14;
                    alix = "X";
                }
                else if (i == 1)
                {
                    txt.Left = 60;
                    alix = "Y";
                }
                else
                {
                    txt.Left = 106;
                    alix = "Z";
                }
                txt.Name = "point" + alix + ((index + 2) / 3).ToString();
                //txt.Text = "11";
                txt.TabIndex = index;
                txt.Top = 28 * N + 35;
                txt.Width = 40;
                txt.TextAlign = HorizontalAlignment.Center;
                txt.Font = new Font("微软雅黑", 9f);
                this.panel1.Controls.Add(txt);
                if (i == 0)
                    txt.Focus();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int k = 0;
            string temp = string.Empty;
            string com = "[";
            foreach (Control cur in this.panel1.Controls)
            {
                if (cur is TextBox & cur.TabIndex < 500)//cur.Name != "dis")
                {
                    if (com != "[")
                        com += ",";
                    k = cur.TabIndex;
                    switch (k % 3)
                    {
                        case 1:
                            temp = "[" + ComTransFrom._F(cur.Text);
                            break;
                        case 2:
                            temp += ComTransFrom._F(cur.Text);
                            break;
                        default:
                            temp += ComTransFrom._F(cur.Text) + "]";
                            break;
                    }
                    com += temp;
                    temp = string.Empty;
                }
            }
            //MessageBox.Show(com);
            string comname = string.Empty;
            if (isk == 1)
            {
                if (Class == 1)
                    comname = "Chamfer";
                else
                    comname = "ChamferFace";
            }
            else
            {
                if (Class == 1)
                    comname = "Blend";
                else
                    comname = "BlendFace";
            }

            switch (Type)
            {
                case 1:
                    com = String.Format("{0}1({1}], {2} );\r\n",comname, com, ComTransFrom._F(dis1.Text));
                    break;
                case 2:
                    if(Class == 2)
                        com = String.Format("{0}2({1}], {2}, {3} );\r\n", comname, com, ComTransFrom._F(dis1.Text), ComTransFrom._F(dis2.Text));
                    else
                        com = String.Format("{0}2({1}], {2}, {3}, [{4},{5},{6}] );\r\n", comname, com, ComTransFrom._F(dis1.Text), ComTransFrom._F(dis2.Text), ComTransFrom._F(facePointX.Text), ComTransFrom._F(facePointY.Text), ComTransFrom._F(facePointZ.Text));
                    break;
                default:
                    if (Class == 2)
                        com = String.Format("{0}3({1}], {2}, {3} );\r\n", comname, com, ComTransFrom._F(dis1.Text), ComTransFrom._F(dis2.Text));
                    else
                        com = String.Format("{0}3({1}], {2}, {3}, [{4},{5},{6}] );\r\n", comname, com, ComTransFrom._F(dis1.Text), ComTransFrom._F(dis2.Text), ComTransFrom._F(facePointX.Text), ComTransFrom._F(facePointY.Text), ComTransFrom._F(facePointZ.Text));
                    //MessageBox.Show(com);
                    break;
            }
            //MessageBox.Show(com);
            pall.richTextBox1.Text += com;
            this.Close();
            this.Dispose();
        }

        private void pic2label_MouseEnter(object sender, EventArgs e)
        {
            pic2label.BackColor = Color.FromArgb(50, 2, 143, 245);
        }

        private void pic3label_MouseEnter(object sender, EventArgs e)
        {
            pic3label.BackColor = Color.FromArgb(50, 2, 143, 245);
        }

        private void pic4label_MouseEnter(object sender, EventArgs e)
        {
            pic4label.BackColor = Color.FromArgb(50, 2, 143, 245);
        }

        private void pic4label_MouseLeave(object sender, EventArgs e)
        {
            if(Type == 3)
                pic4label.BackColor = Color.FromArgb(120, 2, 143, 245);
            else
                pic4label.BackColor = Color.FromArgb(0, 2, 143, 245);
        }

        private void pic3label_MouseLeave(object sender, EventArgs e)
        {
            if (Type == 2)
                pic3label.BackColor = Color.FromArgb(120, 2, 143, 245);
            else
                pic3label.BackColor = Color.FromArgb(0, 2, 143, 245);
        }

        private void pic2label_MouseLeave(object sender, EventArgs e)
        {
            if (Type == 1)
                pic2label.BackColor = Color.FromArgb(120, 2, 143, 245);
            else
                pic2label.BackColor = Color.FromArgb(0, 2, 143, 245);
        }

        private void pic2label_Click(object sender, EventArgs e)
        {
            Type = 1;
            pic2label.BackColor = Color.FromArgb(120, 2, 143, 245);
            pic3label.BackColor = Color.FromArgb(0, 2, 143, 245);
            pic4label.BackColor = Color.FromArgb(0, 2, 143, 245);
            if(Class == 1)
                pictureBox1.Image = Image.FromFile(Application.StartupPath + "\\pic\\Blend" + Type.ToString() + ".JPG");
            else
                pictureBox1.Image = Image.FromFile(Application.StartupPath + "\\pic\\Blend1" + Type.ToString() + ".JPG");
            dis2.Visible = false;
            facePointLabel.Visible = false;
            facePointX.Visible = false;
            facePointY.Visible = false;
            facePointZ.Visible = false;
            dis2Label.Visible = false;
        }

        private void pic3label_Click(object sender, EventArgs e)
        {
            Type = 2;
            pic3label.BackColor = Color.FromArgb(120, 2, 143, 245);
            pic2label.BackColor = Color.FromArgb(0, 2, 143, 245);
            pic4label.BackColor = Color.FromArgb(0, 2, 143, 245);
            if (Class == 1)
                pictureBox1.Image = Image.FromFile(Application.StartupPath + "\\pic\\Blend" + Type.ToString() + ".JPG");
            else
                pictureBox1.Image = Image.FromFile(Application.StartupPath + "\\pic\\Blend1" + Type.ToString() + ".JPG");
            dis2.Visible = true;
            if (Class == 2)
            {
                facePointLabel.Visible = false;
                facePointX.Visible = false;
                facePointY.Visible = false;
                facePointZ.Visible = false;
            }
            else
            {
                facePointLabel.Visible = true;
                facePointX.Visible = true;
                facePointY.Visible = true;
                facePointZ.Visible = true;
            }
            dis2Label.Visible = true;
            
        }

        private void pic4label_Click(object sender, EventArgs e)
        {
            Type = 3;
            pic4label.BackColor = Color.FromArgb(120, 2, 143, 245);
            pic3label.BackColor = Color.FromArgb(0, 2, 143, 245);
            pic2label.BackColor = Color.FromArgb(0, 2, 143, 245);
            if (Class == 1)
                pictureBox1.Image = Image.FromFile(Application.StartupPath + "\\pic\\Blend" + Type.ToString() + ".JPG");
            else
                pictureBox1.Image = Image.FromFile(Application.StartupPath + "\\pic\\Blend1" + Type.ToString() + ".JPG");
            dis2.Visible = true;
            //MessageBox.Show(Class.ToString());
            if (Class == 2)
            {
                facePointLabel.Visible = false;
                facePointX.Visible = false;
                facePointY.Visible = false;
                facePointZ.Visible = false;
            }
            else
            {
                facePointLabel.Visible = true;
                facePointX.Visible = true;
                facePointY.Visible = true;
                facePointZ.Visible = true;
            }
            dis2Label.Visible = true;
        }

        private void pic2label_MouseHover(object sender, EventArgs e)
        {
            ToolTip p = new ToolTip();
            p.ShowAlways = true;
            p.SetToolTip(this.pic2label, "对称");
        }

        private void pic3label_MouseHover(object sender, EventArgs e)
        {
            ToolTip p = new ToolTip();
            p.ShowAlways = true;
            p.SetToolTip(this.pic3label, "非对称");
        }

        private void pic4label_MouseHover(object sender, EventArgs e)
        {
            ToolTip p = new ToolTip();
            p.ShowAlways = true;
            p.SetToolTip(this.pic4label, "偏置和角度");
        }

        private void label_MouseEnter(object sender, EventArgs e)
        {
            classEdgeLabel.BackColor = Color.FromArgb(50, 2, 143, 245);
        }

        private void label5_MouseEnter(object sender, EventArgs e)
        {
            classFaceLabel.BackColor = Color.FromArgb(50, 2, 143, 245);
        }

        private void classEdgeLabel_MouseLeave(object sender, EventArgs e)
        {
            if (Class == 1)
                classEdgeLabel.BackColor = Color.FromArgb(120, 2, 143, 245);
            else
                classEdgeLabel.BackColor = Color.FromArgb(0, 2, 143, 245);      
        }

        private void classFaceLabel_MouseLeave(object sender, EventArgs e)
        {
            if (Class == 2)
                classFaceLabel.BackColor = Color.FromArgb(120, 2, 143, 245);
            else
                classFaceLabel.BackColor = Color.FromArgb(0, 2, 143, 245);      
        }

        private void classEdgeLabel_Click(object sender, EventArgs e)
        {
            if (isk == 1)
            {//圆角没有非对称和角度，屏蔽对应选项
                pictureBox3.Visible = true;
                pictureBox4.Visible = true;
            }

            Class = 1;
            classEdgeLabel.BackColor = Color.FromArgb(120, 2, 143, 245);
            classFaceLabel.BackColor = Color.FromArgb(0, 2, 143, 245);
            if (Class == 1)
                pictureBox1.Image = Image.FromFile(Application.StartupPath + "\\pic\\Blend" + Type.ToString() + ".JPG");
            else
                pictureBox1.Image = Image.FromFile(Application.StartupPath + "\\pic\\Blend1" + Type.ToString() + ".JPG");

        }

        private void classFaceLabel_Click(object sender, EventArgs e)
        {
            if (isk == 1)
            {//
                pictureBox3.Visible = true;
                pictureBox4.Visible = true;
            }
            else
            {   //圆角没有非对称和角度，屏蔽对应选项

                Type = 1;
                pic2label.BackColor = Color.FromArgb(120, 2, 143, 245);
                pic3label.BackColor = Color.FromArgb(0, 2, 143, 245);
                pic4label.BackColor = Color.FromArgb(0, 2, 143, 245);
                dis2.Visible = false;
                dis2Label.Visible = false;
            }

            Class = 2;
            classFaceLabel.BackColor = Color.FromArgb(120, 2, 143, 245);
            classEdgeLabel.BackColor = Color.FromArgb(0, 2, 143, 245);

            if (Class == 1)
                pictureBox1.Image = Image.FromFile(Application.StartupPath + "\\pic\\Blend" + Type.ToString() + ".JPG");
            else
                pictureBox1.Image = Image.FromFile(Application.StartupPath + "\\pic\\Blend1" + Type.ToString() + ".JPG");

            facePointLabel.Visible = false;
            facePointX.Visible = false;
            facePointY.Visible = false;
            facePointZ.Visible = false;
        }
     
    }
}
