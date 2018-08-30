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
    public partial class SkecchDayton : Form
    {
        //实例主窗体  
        Form1 pall = new Form1();
        public SkecchDayton(Form1 f1)
        {
            pall = f1;
            InitializeComponent();
        }

        private string planeselect;
        public string PlaneSelect
        {
            get { return planeselect; }
            set { planeselect = value; }
        }

        #region
        private string _x0;
        public string _X0
        {
            get { return _x0; }
            set { _x0 = value; }
        }

        private string _y0;
        public string _Y0
        {
            get { return _y0; }
            set { _y0 = value; }
        }

        private string _z0;
        public string _Z0
        {
            get { return _z0; }
            set { _z0 = value; }
        }

        private string pic;
        public string Pic
        {
            get { return pic; }
            set { pic = value; }
        }

        private int page;
        public int Page
        {
            get { return page; }
            set { page = value; }
        }

        private string step2select;
        public string Step2select
        {
            get { return step2select; }
            set { step2select = value; }
        }

        private string[] step3info;
        public string[] Step3info
        {
            get { return step3info; }
            set { step3info = value; }
        }

        private string typeSelect;
        public string TypeSelect
        {
            get { return typeSelect; }
            set { typeSelect = value; }
        }
        #endregion
        private void Skecch_Load(object sender, EventArgs e)
        {
            TypeSelect = "Extrude";
            PlaneSelect = "xy";
            _X0 = "0";
            _Y0 = "0";
            _Z0 = "0";
            Page = 1;
            Back.Visible = false;
            addpicbox();
        }

        # region//step1 选择事件

        private void XY_MouseEnter(object sender, EventArgs e)
        {
           XY.BackColor = Color.FromArgb(79, 176, 247);
        }

        private void XY_MouseLeave(object sender, EventArgs e)
        {
            if (PlaneSelect == "xy")
                XY.BackColor = Color.FromArgb(2, 143, 245);
            else
                XY.BackColor = Color.White;
        }

        private void XZ_MouseEnter(object sender, EventArgs e)
        {
            XZ.BackColor = Color.FromArgb(79, 176, 247);
        }

        private void XZ_MouseLeave(object sender, EventArgs e)
        {
            if (PlaneSelect == "xz")
                XZ.BackColor = Color.FromArgb(2, 143, 245);
            else
                XZ.BackColor = Color.White;
        }

        private void YZ_MouseEnter(object sender, EventArgs e)
        {
            YZ.BackColor = Color.FromArgb(79, 176, 247);
        }

        private void YZ_MouseLeave(object sender, EventArgs e)
        {
            if (PlaneSelect == "yz")
                YZ.BackColor = Color.FromArgb(2, 143, 245);
            else
                YZ.BackColor = Color.White;
        }

        private void XY_Click(object sender, EventArgs e)
        {
            YZ.BackColor = Color.White;
            YZ.TextAlign = ContentAlignment.MiddleLeft;
            YZ.ForeColor = Color.Black;
            XZ.BackColor = Color.White;
            XZ.TextAlign = ContentAlignment.MiddleLeft;
            XZ.ForeColor = Color.Black;

            PlaneSelect = "xy";
            XY.BackColor = Color.FromArgb(2, 143, 245);
            XY.ForeColor = Color.White;
            XY.TextAlign = ContentAlignment.MiddleCenter;
        }

        private void XZ_Click(object sender, EventArgs e)
        {
            YZ.BackColor = Color.White;
            YZ.TextAlign = ContentAlignment.MiddleLeft;
            YZ.ForeColor = Color.Black;
            XY.BackColor = Color.White;
            XY.TextAlign = ContentAlignment.MiddleLeft;
            XY.ForeColor = Color.Black;

            PlaneSelect = "xz";
            XZ.BackColor = Color.FromArgb(2, 143, 245);
            XZ.ForeColor = Color.White;
            XZ.TextAlign = ContentAlignment.MiddleCenter;
        }

        private void YZ_Click(object sender, EventArgs e)
        {
            XY.BackColor = Color.White;
            XY.TextAlign = ContentAlignment.MiddleLeft;
            XY.ForeColor = Color.Black;
            XZ.BackColor = Color.White;
            XZ.TextAlign = ContentAlignment.MiddleLeft;
            XZ.ForeColor = Color.Black;

            PlaneSelect = "yz";
            YZ.BackColor = Color.FromArgb(2, 143, 245);
            YZ.ForeColor = Color.White;
            YZ.TextAlign = ContentAlignment.MiddleCenter;
        }

        #endregion

        #region//添加picturebox
        private void addpicbox()
        {
            int k = 1;
            for (int i = 0; i < 11; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (k > 55)
                        break;
                    PictureBox p = new PictureBox();
                    p.Name = "Edge_" + k.ToString();
                    p.Top = 6 + i * 86;
                    p.Left = 6 + j * 126;
                    p.Width = 120;
                    p.Height = 80;
                    p.SizeMode = PictureBoxSizeMode.StretchImage;
                    p.Image = Image.FromFile(Application.StartupPath + @"\pic\SketchDayton\C" + k.ToString() + ".JPG");
                    //p.Click += new EventHandler(this.pictureBox_Click);
                    Label l = new Label();
                    l.Name = "C" + k.ToString();
                    l.Top = -1;
                    l.Left = -1;
                    l.Width = 122;
                    l.Height = 82;
                    l.Click += new EventHandler(this.label_Click);
                    l.MouseHover += new EventHandler(this.label_MouseHover); 
                    l.MouseLeave += new EventHandler(this.label_MouseLeave);
                    p.Controls.Add(l);
 
                    k += 1;
                    this.Step2.Controls.Add(p);
                }
            }
        }
        #endregion

        # region//picturebox 选中事件
        private void pictureBox_Click(object sender, EventArgs e)
        {
            foreach (Control c in Step2.Controls)
            {
                if (c is PictureBox)
                {
                    PictureBox pb = c as PictureBox;
                    pb.BorderStyle = BorderStyle.None;
                }
            }

            PictureBox p = (PictureBox)sender;
            p.BorderStyle = BorderStyle.Fixed3D;
            Step2select = p.Name;
            //MessageBox.Show(Step2select);
        }
        #endregion

        /// <summary>
        /// label 事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        #region// label 事件
        private void label_Click(object sender, EventArgs e)
        {
            foreach (Control c in Step2.Controls)
            {
                if (c is PictureBox)
                {
                    PictureBox pb = c as PictureBox;
                    foreach (Control d in pb.Controls)
                    {
                        if (d is Label)
                        {
                            Label _pb = (Label)d;
                            d.BackColor = Color.FromArgb(0, 2, 143, 245);
                        }
                    }
                }
            }

            Label p = (Label)sender;
            p.BackColor = Color.FromArgb(50, 255, 0, 0);
            Step2select = p.Name;
        }

        private void label_MouseHover(object sender, EventArgs e)
        {
            Label p = (Label)sender;
            p.BackColor = Color.FromArgb(20, 255, 0, 0);
        }

        private void label_MouseLeave(object sender, EventArgs e)
        {
            Label p = (Label)sender;
            if (Step2select == p.Name)
                p.BackColor = Color.FromArgb(50, 255, 0, 0);
            else
                p.BackColor = Color.FromArgb(0, 2, 143, 245);
        }
        #endregion
        private void Step1Next_Click(object sender, EventArgs e)
        {
            switch (Page)
            {
                case 1:
                    tabControl1.SelectedTab = Step2;
                    break;
                case 2:
                    if (string.IsNullOrEmpty(Step2select))
                    {
                        MessageBox.Show("Error:Step2未选择!");
                        Step2.Focus();
                        return;
                    }
                    tabControl1.SelectedTab = Step3;
                    break;
                case 3:
                    string temp=string.Empty;
                    foreach (Control cur in this.step3Pic.Controls)
                    {
                        if (cur is TextBox)
                        {
                            temp += ComTransFrom._F(cur.Text) + " ,";
                        }
                    }
                    temp = temp.Substring(0, temp.Length - 2);
                    
                    step3info[0] = String.Format(step3info[0], temp);
                    //MessageBox.Show(step3info[0]);

                    pall.bodyID += 1;
                    string check1 = "0";
                    if(checkBox1.CheckState==CheckState.Checked)
                    {
                        check1 = "1";
                    }
                    string check2 = "0";
                    if (checkBox2.CheckState == CheckState.Checked)
                    {
                        check2 = "1";
                    }
                    string v = string.Empty;
                    if (TypeSelect == "Extrude")
                    {
                        v = String.Format("var body{0} = Extrude( {1}, {2}, {3}, 0, {4}, {5} );\r\n", pall.bodyID.ToString(), step3info[0], ComTransFrom._F(textBox1.Text), check1, check2, ComTransFrom._F(textBox2.Text));
                    }
                    else
                    {
                        v = String.Format("var body{0} = Revolve( {1}, true, 0, {1}, false );\r\n", pall.bodyID.ToString(), step3info[0], ComTransFrom._F(textBox2.Text));
                    }
                    //v += "AGM.Sketcher.FixModel();\r\n";
                    //v += String.Format("var body{0} = GetBody();\r\n", pall.bodyID.ToString());
                    pall.richTextBox1.Text += v;
                    
                    this.Close();
                    this.Dispose();
                    break;
            }
            //pictureBox1.Image = Image.FromFile(@"C:\Users\Host003\Documents\Visual Studio 2008\Projects\SID\WindowsFormsApplication6\bin\Release\pic\Sketch\Edge_1A.bmp"); 
        }

        private void Back_Click(object sender, EventArgs e)
        {
            switch (Page)
            {
                case 2:
                    tabControl1.SelectedTab = Step1;
                    break;
                case 3:
                    tabControl1.SelectedTab = Step2;
                    break;
            }
            //MessageBox.Show(Page.ToString());
        }

        /// <summary>
        /// step3 命令
        /// </summary>
        #region
        private void step3()
        {
            //info[0] 命令
            string[] info = new string[4];
            string com = string.Empty;
            switch (Step2select)
            {
                case "C1":
                    com = "S_C30";
                    com = com + "('{0}', {1}, {2}, {3}, ";
                    info[0] = String.Format(com, PlaneSelect, _X0, _Y0, _Z0);
                    info[0] = info[0] + "{0})";
                    info[1] = "420,170|410,280|180,110|110,190|110,240";
                    info[2] = "P|W|A|0|0";
                    //MessageBox.Show(info[0]);
                    break;
                case "C2":
                    com = "S_C31";
                    com = com + "('{0}', {1}, {2}, {3}, ";
                    info[0] = String.Format(com, PlaneSelect, _X0, _Y0, _Z0);
                    info[0] = info[0] + "{0})";
                    info[1] = "450,190|160,270|410,130|100,120|100,190";
                    info[2] = "P|W|A|0|0";
                    //MessageBox.Show(info[0]);
                    break;
                case "C3":
                    com = "S_C32";
                    com = com + "('{0}', {1}, {2}, {3}, ";
                    info[0] = String.Format(com, PlaneSelect, _X0, _Y0, _Z0);
                    info[0] = info[0] + "{0})";
                    info[1] = "440,170|385,280|390,125|100,110|100,180";
                    info[2] = "P|W|A|0|0";
                    //MessageBox.Show(info[0]);
                    break;
                case "C4":
                    com = "S_C61";
                    com = com + "('{0}', {1}, {2}, {3}, ";
                    info[0] = String.Format(com, PlaneSelect, _X0, _Y0, _Z0);
                    info[0] = info[0] + "{0})";
                    info[1] = "400,180|385,285|170,200|120,90|120,170";
                    info[2] = "P|W|B|0|0";
                    //MessageBox.Show(info[0]);
                    break;
                case "C5":
                    com = "S_C62";
                    com = com + "('{0}', {1}, {2}, {3}, ";
                    info[0] = String.Format(com, PlaneSelect, _X0, _Y0, _Z0);
                    info[0] = info[0] + "{0})";
                    info[1] = "440,175|385,290|395,130|145,152|140,275";
                    info[2] = "P|W|A|R|0";
                    //MessageBox.Show(info[0]);
                    break;
                case "C6":
                    com = "S_C86";
                    com = com + "('{0}', {1}, {2}, {3}, ";
                    info[0] = String.Format(com, PlaneSelect, _X0, _Y0, _Z0);
                    info[0] = info[0] + "{0})";
                    info[1] = "150,170|165,290|385,75";
                    info[2] = "W|N|R";
                    //MessageBox.Show(info[0]);
                    break;
                case "C7":
                    com = "S_C36";
                    com = com + "('{0}', {1}, {2}, {3}, ";
                    info[0] = String.Format(com, PlaneSelect, _X0, _Y0, _Z0);
                    info[0] = info[0] + "{0})";
                    info[1] = "160,110|175,280|395,75";
                    info[2] = "W|N|0";
                    //MessageBox.Show(info[0]);
                    break;
                case "C8":
                    com = "S_C89";
                    com = com + "('{0}', {1}, {2}, {3}, ";
                    info[0] = String.Format(com, PlaneSelect, _X0, _Y0, _Z0);
                    info[0] = info[0] + "{0})";
                    info[1] = "400,175|375,292|395,80";
                    info[2] = "P|W|0";
                    //MessageBox.Show(info[0]);
                    break;
                case "C9":
                    com = "S_C37";
                    com = com + "('{0}', {1}, {2}, {3}, ";
                    info[0] = String.Format(com, PlaneSelect, _X0, _Y0, _Z0);
                    info[0] = info[0] + "{0})";
                    info[1] = "235,265|150,135|150,95";
                    info[2] = "W|0|0";
                    //MessageBox.Show(info[0]);
                    break;
                case "C10":
                    com = "S_C38";
                    com = com + "('{0}', {1}, {2}, {3}, ";
                    info[0] = String.Format(com, PlaneSelect, _X0, _Y0, _Z0);
                    info[0] = info[0] + "{0})";
                    info[1] = "220,245|150,115|190,75";
                    info[2] = "W|0|0";
                    //MessageBox.Show(info[0]);
                    break;
                case "C11":
                    com = "S_C39";
                    com = com + "('{0}', {1}, {2}, {3}, ";
                    info[0] = String.Format(com, PlaneSelect, _X0, _Y0, _Z0);
                    info[0] = info[0] + "{0})";
                    info[1] = "395,150|210,195|260,45|210,260|190,75|375,35";
                    info[2] = "P|W|B|A|0|0";
                    //MessageBox.Show(info[0]);
                    break;
                case "C12":
                    com = "S_C90";
                    com = com + "('{0}', {1}, {2}, {3}, ";
                    info[0] = String.Format(com, PlaneSelect, _X0, _Y0, _Z0);
                    info[0] = info[0] + "{0})";
                    info[1] = "415,195|200,245|245,15|375,85|180,150";
                    info[2] = "P|W|A|0|0";
                    //MessageBox.Show(info[0]);
                    break;
                case "C13":
                    com = "S_C59";
                    com = com + "('{0}', {1}, {2}, {3}, ";
                    info[0] = String.Format(com, PlaneSelect, _X0, _Y0, _Z0);
                    info[0] = info[0] + "{0})";
                    info[1] = "410,175|375,290|220,55|185,105";
                    info[2] = "P|W|A|0";
                    //MessageBox.Show(info[0]);
                    break;
                case "C14":
                    com = "S_C60";
                    com = com + "('{0}', {1}, {2}, {3}, ";
                    info[0] = String.Format(com, PlaneSelect, _X0, _Y0, _Z0);
                    info[0] = info[0] + "{0})";
                    info[1] = "395,175|360,290|215,65|150,110|400,70";
                    info[2] = "P|W|A|0|0";
                    //MessageBox.Show(info[0]);
                    break;
                case "C15":
                    com = "S_C17";
                    com = com + "('{0}', {1}, {2}, {3}, ";
                    info[0] = String.Format(com, PlaneSelect, _X0, _Y0, _Z0);
                    info[0] = info[0] + "{0})";
                    info[1] = "415,165|175,225|230,50|185,138";
                    info[2] = "P|W|A|0";
                    //MessageBox.Show(info[0]);
                    break;
                case "C16":
                    com = "S_C18";
                    com = com + "('{0}', {1}, {2}, {3}, ";
                    info[0] = String.Format(com, PlaneSelect, _X0, _Y0, _Z0);
                    info[0] = info[0] + "{0})";
                    info[1] = "415,190|225,70|190,290|185,110";
                    info[2] = "P|W|A|0";
                    //MessageBox.Show(info[0]);
                    break;
                case "C17":
                    com = "S_C21";
                    com = com + "('{0}', {1}, {2}, {3}, ";
                    info[0] = String.Format(com, PlaneSelect, _X0, _Y0, _Z0);
                    info[0] = info[0] + "{0})";
                    info[1] = "400,160|380,270|285,45|170,160|350,185|120,270";
                    info[2] = "P|W|A|B|0|0";
                    //MessageBox.Show(info[0]);
                    break;
                case "C18":
                    com = "S_C91";
                    com = com + "('{0}', {1}, {2}, {3}, ";
                    info[0] = String.Format(com, PlaneSelect, _X0, _Y0, _Z0);
                    info[0] = info[0] + "{0})";
                    info[1] = "410,160|405,275|300,40|190,165|170,255|350,185|180,52";
                    info[2] = "P|W|A|B|R|0.1|0";
                    //MessageBox.Show(info[0]);
                    break;
                case "C19":
                    com = "S_C15";
                    com = com + "('{0}', {1}, {2}, {3}, ";
                    info[0] = String.Format(com, PlaneSelect, _X0, _Y0, _Z0);
                    info[0] = info[0] + "{0})";
                    info[1] = "415,175|405,285|295,50|170,185|130,285";
                    info[2] = "P|W|A|0|0";
                    //MessageBox.Show(info[0]);
                    break;
                case "C20":
                    com = "S_C45";
                    com = com + "('{0}', {1}, {2}, {3}, ";
                    info[0] = String.Format(com, PlaneSelect, _X0, _Y0, _Z0);
                    info[0] = info[0] + "{0})";
                    info[1] = "400,170|380,285|220,65|150,175|150,125|400,45";
                    info[2] = "P|W|A|B|0.1|0";
                    //MessageBox.Show(info[0]);
                    break;
                case "C21":
                    com = "S_C67";
                    com = com + "('{0}', {1}, {2}, {3}, ";
                    info[0] = String.Format(com, PlaneSelect, _X0, _Y0, _Z0);
                    info[0] = info[0] + "{0})";
                    info[1] = "400,170|395,285|220,60|155,170|155,120";
                    info[2] = "P|W|A|B|0.1";
                    //MessageBox.Show(info[0]);
                    break;
                case "C22":
                    com = "S_C46";
                    com = com + "('{0}', {1}, {2}, {3}, ";
                    info[0] = String.Format(com, PlaneSelect, _X0, _Y0, _Z0);
                    info[0] = info[0] + "{0})";
                    info[1] = "405,155|345,285|225,40|145,250|140,110|430,35";
                    info[2] = "P|W|A|B|0.1|0";
                    //MessageBox.Show(info[0]);
                    break;
                case "C23":
                    com = "S_C77";
                    com = com + "('{0}', {1}, {2}, {3}, ";
                    info[0] = String.Format(com, PlaneSelect, _X0, _Y0, _Z0);
                    info[0] = info[0] + "{0})";
                    info[1] = "405,155|345,275|225,40|145,245|400,245|140,110";
                    info[2] = "P|W|A|B|0|0";
                    //MessageBox.Show(info[0]);
                    break;
                case "C24":
                    com = "S_C78";
                    com = com + "('{0}', {1}, {2}, {3}, ";
                    info[0] = String.Format(com, PlaneSelect, _X0, _Y0, _Z0);
                    info[0] = info[0] + "{0})";
                    info[1] = "405,150|400,230|350,280|355,250|240,45|155,235|155,100|430,45";
                    info[2] = "P|PP|W|WW|A|B|0|0";
                    //MessageBox.Show(info[0]);
                    break;
                case "C25":
                    com = "S_C79";
                    com = com + "('{0}', {1}, {2}, {3}, ";
                    info[0] = String.Format(com, PlaneSelect, _X0, _Y0, _Z0);
                    info[0] = info[0] + "{0})";
                    info[1] = "395,145|400,230|350,285|340,255|240,45|155,235|340,225|155,100";
                    info[2] = "P|PP|W|WW|A|B|0|0";
                    //MessageBox.Show(info[0]);
                    break;
                case "C26":
                    com = "S_C48";
                    com = com + "('{0}', {1}, {2}, {3}, ";
                    info[0] = String.Format(com, PlaneSelect, _X0, _Y0, _Z0);
                    info[0] = info[0] + "{0})";
                    info[1] = "155,155|215,280|340,45|400,250|420,110|130,45";
                    info[2] = "P|W|A|B|0|0";
                    //MessageBox.Show(info[0]);
                    break;
                case "C27":
                    com = "S_C80";
                    com = com + "('{0}', {1}, {2}, {3}, ";
                    info[0] = String.Format(com, PlaneSelect, _X0, _Y0, _Z0);
                    info[0] = info[0] + "{0})";
                    info[1] = "165,150|230,280|345,30|430,245|200,240|445,105";
                    info[2] = "P|W|A|B|0|0";
                    //MessageBox.Show(info[0]);
                    break;
                case "C28":
                    com = "S_C81";
                    com = com + "('{0}', {1}, {2}, {3}, ";
                    info[0] = String.Format(com, PlaneSelect, _X0, _Y0, _Z0);
                    info[0] = info[0] + "{0})";
                    info[1] = "155,145|160,230|220,285|205,255|330,45|395,235|400,110|130,45";
                    info[2] = "P|PP|W|WW|A|B|0|0";
                    //MessageBox.Show(info[0]);
                    break;
                case "C29":
                    com = "S_C82";
                    com = com + "('{0}', {1}, {2}, {3}, ";
                    info[0] = String.Format(com, PlaneSelect, _X0, _Y0, _Z0);
                    info[0] = info[0] + "{0})";
                    info[1] = "155,145|160,230|210,285|195,255|310,45|390,230|210,225|400,110";
                    info[2] = "P|PP|W|WW|A|B|0|0";
                    //MessageBox.Show(info[0]);
                    break;
                case "C30":
                    com = "S_C50";
                    com = com + "('{0}', {1}, {2}, {3}, ";
                    info[0] = String.Format(com, PlaneSelect, _X0, _Y0, _Z0);
                    info[0] = info[0] + "{0})";
                    info[1] = "155,160|225,283|225,50|430,163|220,250|420,30|410,275";
                    info[2] = "P|W|A|B|0|0|0";
                    //MessageBox.Show(info[0]);
                    break;
                case "C31":
                    com = "S_C68";
                    com = com + "('{0}', {1}, {2}, {3}, ";
                    info[0] = String.Format(com, PlaneSelect, _X0, _Y0, _Z0);
                    info[0] = info[0] + "{0})";
                    info[1] = "165,170|210,285|200,55|420,170|210,255|410,40|400,290";
                    info[2] = "P|W|A|B|0.2|0.1|0";
                    //MessageBox.Show(info[0]);
                    break;
                case "C32":
                    com = "S_C10";
                    com = com + "('{0}', {1}, {2}, {3}, ";
                    info[0] = String.Format(com, PlaneSelect, _X0, _Y0, _Z0);
                    info[0] = info[0] + "{0})";
                    info[1] = "400,170|360,270|220,60";
                    info[2] = "P|W|0";
                    //MessageBox.Show(info[0]);
                    break;
                case "C33":
                    com = "S_C11";
                    com = com + "('{0}', {1}, {2}, {3}, ";
                    info[0] = String.Format(com, PlaneSelect, _X0, _Y0, _Z0);
                    info[0] = info[0] + "{0})";
                    info[1] = "415,180|385,280|180,90";
                    info[2] = "P|W|R";
                    //MessageBox.Show(info[0]);
                    break;
                case "C34":
                    com = "S_C33";
                    com = com + "('{0}', {1}, {2}, {3}, ";
                    info[0] = String.Format(com, PlaneSelect, _X0, _Y0, _Z0);
                    info[0] = info[0] + "{0})";
                    info[1] = "415,180|375,285|415,40";
                    info[2] = "P|W|R";
                    //MessageBox.Show(info[0]);
                    break;
                case "C35":
                    com = "S_C52";
                    com = com + "('{0}', {1}, {2}, {3}, ";
                    info[0] = String.Format(com, PlaneSelect, _X0, _Y0, _Z0);
                    info[0] = info[0] + "{0})";
                    info[1] = "200,90|410,290|415,177|150,200";
                    info[2] = "G|W|P|0";
                    //MessageBox.Show(info[0]);
                    break;
                case "C36":
                    com = "S_C40";
                    com = com + "('{0}', {1}, {2}, {3}, ";
                    info[0] = String.Format(com, PlaneSelect, _X0, _Y0, _Z0);
                    info[0] = info[0] + "{0})";
                    info[1] = "170,185|420,140|420,220";
                    info[2] = "P|R1|R2";
                    //MessageBox.Show(info[0]);
                    break;
                case "C37":
                    com = "S_C13";
                    com = com + "('{0}', {1}, {2}, {3}, ";
                    info[0] = String.Format(com, PlaneSelect, _X0, _Y0, _Z0);
                    info[0] = info[0] + "{0})";
                    info[1] = "240,60|420,170|375,285|165,105";
                    info[2] = "A|P|W|R";
                    //MessageBox.Show(info[0]);
                    break;
                case "C38":
                    com = "S_C54";
                    com = com + "('{0}', {1}, {2}, {3}, ";
                    info[0] = String.Format(com, PlaneSelect, _X0, _Y0, _Z0);
                    info[0] = info[0] + "{0})";
                    info[1] = "235,50|415,155|380,290|175,95";
                    info[2] = "A|P|W|R";
                    //MessageBox.Show(info[0]);
                    break;
                case "C39":
                    com = "S_C14";
                    com = com + "('{0}', {1}, {2}, {3}, ";
                    info[0] = String.Format(com, PlaneSelect, _X0, _Y0, _Z0);
                    info[0] = info[0] + "{0})";
                    info[1] = "225,60|405,165|375,280|405,40|175,130";
                    info[2] = "A|P|W|0|0";
                    //MessageBox.Show(info[0]);
                    break;
                case "C40":
                    com = "S_C57";
                    com = com + "('{0}', {1}, {2}, {3}, ";
                    info[0] = String.Format(com, PlaneSelect, _X0, _Y0, _Z0);
                    info[0] = info[0] + "{0})";
                    info[1] = "230,50|410,155|385,285|415,55|175,130";
                    info[2] = "A|P|W|0.1|0";
                    //MessageBox.Show(info[0]);
                    break;
                case "C41":
                    com = "S_C22";
                    com = com + "('{0}', {1}, {2}, {3}, ";
                    info[0] = String.Format(com, PlaneSelect, _X0, _Y0, _Z0);
                    info[0] = info[0] + "{0})";
                    info[1] = "410,165|385,285|200,295";
                    info[2] = "P|W|0";
                    //MessageBox.Show(info[0]);
                    break;
                case "C42":
                    com = "S_C23";
                    com = com + "('{0}', {1}, {2}, {3}, ";
                    info[0] = String.Format(com, PlaneSelect, _X0, _Y0, _Z0);
                    info[0] = info[0] + "{0})";
                    info[1] = "410,165|385,290|375,60|175,265";
                    info[2] = "P|W|R|S";
                    //MessageBox.Show(info[0]);
                    break;
                case "C43":
                    com = "S_C24";
                    com = com + "('{0}', {1}, {2}, {3}, ";
                    info[0] = String.Format(com, PlaneSelect, _X0, _Y0, _Z0);
                    info[0] = info[0] + "{0})";
                    info[1] = "410,165|380,280|370,65|175,290";
                    info[2] = "P|W|R|0";
                    //MessageBox.Show(info[0]);
                    break;
                case "C44":
                    com = "S_C25";
                    com = com + "('{0}', {1}, {2}, {3}, ";
                    info[0] = String.Format(com, PlaneSelect, _X0, _Y0, _Z0);
                    info[0] = info[0] + "{0})";
                    info[1] = "250,45|415,165|390,277|175,290";
                    info[2] = "A|P|W|0";
                    //MessageBox.Show(info[0]);
                    break;
                case "C45":
                    com = "S_C26";
                    com = com + "('{0}', {1}, {2}, {3}, ";
                    info[0] = String.Format(com, PlaneSelect, _X0, _Y0, _Z0);
                    info[0] = info[0] + "{0})";
                    info[1] = "240,50|410,160|390,277|390,60|170,250";
                    info[2] = "A|P|W|R|S";
                    //MessageBox.Show(info[0]);
                    break;
                case "C46":
                    com = "S_C42";
                    com = com + "('{0}', {1}, {2}, {3}, ";
                    info[0] = String.Format(com, PlaneSelect, _X0, _Y0, _Z0);
                    info[0] = info[0] + "{0})";
                    info[1] = "140,280|415,165|390,277|160,45";
                    info[2] = "A|P|W|0";
                    //MessageBox.Show(info[0]);
                    break;
                case "C47":
                    com = "S_C93";
                    com = com + "('{0}', {1}, {2}, {3}, ";
                    info[0] = String.Format(com, PlaneSelect, _X0, _Y0, _Z0);
                    info[0] = info[0] + "{0})";
                    info[1] = "200,165|380,285|400,200";
                    info[2] = "P|W|R";
                    //MessageBox.Show(info[0]);
                    break;
                case "C48":
                    com = "S_C16";
                    com = com + "('{0}', {1}, {2}, {3}, ";
                    info[0] = String.Format(com, PlaneSelect, _X0, _Y0, _Z0);
                    info[0] = info[0] + "{0})";
                    info[1] = "415,165|395,272|190,65";
                    info[2] = "P|W|R";
                    //MessageBox.Show(info[0]);
                    break;
                case "C49":
                    com = "S_C34";
                    com = com + "('{0}', {1}, {2}, {3}, ";
                    info[0] = String.Format(com, PlaneSelect, _X0, _Y0, _Z0);
                    info[0] = info[0] + "{0})";
                    info[1] = "410,175|388,280|390,65";
                    info[2] = "P|W|0";
                    //MessageBox.Show(info[0]);
                    break;
                case "C50":
                    com = "S_C28";
                    com = com + "('{0}', {1}, {2}, {3}, ";
                    info[0] = String.Format(com, PlaneSelect, _X0, _Y0, _Z0);
                    info[0] = info[0] + "{0})";
                    info[1] = "410,175|388,280|150,65";
                    info[2] = "P|W|0";
                    //MessageBox.Show(info[0]);
                    break;
                case "C51":
                    com = "S_C64";
                    com = com + "('{0}', {1}, {2}, {3}, ";
                    info[0] = String.Format(com, PlaneSelect, _X0, _Y0, _Z0);
                    info[0] = info[0] + "{0})";
                    info[1] = "405,165|370,280|405,65|165,255|430,250";
                    info[2] = "P|W|A|B|0";
                    //MessageBox.Show(info[0]);
                    break;
                case "C52":
                    com = "S_C41";
                    com = com + "('{0}', {1}, {2}, {3}, ";
                    info[0] = String.Format(com, PlaneSelect, _X0, _Y0, _Z0);
                    info[0] = info[0] + "{0})";
                    info[1] = "400,160|365,60";
                    info[2] = "P|W";
                    //MessageBox.Show(info[0]);
                    break;
                case "C53":
                    com = "S_C27";
                    com = com + "('{0}', {1}, {2}, {3}, ";
                    info[0] = String.Format(com, PlaneSelect, _X0, _Y0, _Z0);
                    info[0] = info[0] + "{0})";
                    info[1] = "405,165|375,285|210,265|390,62|160,160";
                    info[2] = "P|W|B|R|S";
                    //MessageBox.Show(info[0]);
                    break;
                case "C54":
                    com = "S_C51";
                    com = com + "('{0}', {1}, {2}, {3}, ";
                    info[0] = String.Format(com, PlaneSelect, _X0, _Y0, _Z0);
                    info[0] = info[0] + "{0})";
                    info[1] = "370,140|280,40";
                    info[2] = "P|W";
                    //MessageBox.Show(info[0]);
                    break;
                case "C55":
                    com = "S_C121";
                    com = com + "('{0}', {1}, {2}, {3}, ";
                    info[0] = String.Format(com, PlaneSelect, _X0, _Y0, _Z0);
                    info[0] = info[0] + "{0})";
                    info[1] = "390,150|290,285|290,40|290,240|215,95|215,50";
                    info[2] = "P|W|A|B|R|S";
                    //MessageBox.Show(info[0]);
                    break;
            }
            Step3info = info;
        }
        #endregion

        ///<summary>
        ///添加textbox插件
        ///</summary>
        #region

        private void addtextbox()
        {
            string[] textlocal = Step3info[1].Split('|');
            string[] textvalue = Step3info[2].Split('|');
            for (int i = 0; i < textlocal.Length; i++)
            {
                TextBox t = new TextBox();
                t.Top = int.Parse(textlocal[i].Split(',')[1]);
                t.Left = int.Parse(textlocal[i].Split(',')[0]);
                t.TextAlign = HorizontalAlignment.Center;
                t.BorderStyle = BorderStyle.Fixed3D;
                t.Width = 40;
                t.Text = textvalue[i];
                t.ForeColor = Color.Red;
                t.Font = new Font("微软雅黑", 12,FontStyle.Bold);               
                this.step3Pic.Controls.Add(t);
                t.Focus();
                t.SelectAll();
            }
        }
        #endregion

        /// <summary>
        /// page切换事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(tabControl1.SelectedIndex)
            {
                case 0:
                    Page = 1;
                    Back.Visible = false;
                    Step1.Focus();                   
                    break;
                case 1:
                    Page = 2;
                    Back.Visible = true;
                    Step2.Focus();
                    //清空所有控件
                    break;
                case 2: 
                    if (string.IsNullOrEmpty(Step2select))
                    {
                        tabControl1.SelectedTab = Step2;
                        MessageBox.Show("Error:Step2未选择!");
                        Step2.Focus();
                        return;
                    }

                    _X0 = ComTransFrom._F(X0.Text);
                    _Y0 = ComTransFrom._F(Y0.Text);
                    _Z0 = ComTransFrom._F(Z0.Text);

                    step3Pic.Image = Image.FromFile(Application.StartupPath + @"\pic\SketchDayton\" + Step2select + ".JPG");
                    Page = 3;
                    Back.Visible = true;
                    this.step3Pic.Controls.Clear();
                    step3();
                    addtextbox();
                    Step3.Focus();
                    break;
            }
            //MessageBox.Show(Page.ToString());
        }

        private void Extrudelabel_MouseEnter(object sender, EventArgs e)
        {
            Extrudelabel.BackColor = Color.FromArgb(79, 176, 247);
        }

        private void revolvelabel_MouseEnter(object sender, EventArgs e)
        {
            revolvelabel.BackColor = Color.FromArgb(79, 176, 247);
        }

        private void Extrudelabel_MouseLeave(object sender, EventArgs e)
        {
            if (TypeSelect == "Extrude")
                Extrudelabel.BackColor = Color.FromArgb(2, 143, 245);
            else
                Extrudelabel.BackColor = Color.White;
        }

        private void revolvelabel_MouseLeave(object sender, EventArgs e)
        {
            if (TypeSelect == "Revolve")
                revolvelabel.BackColor = Color.FromArgb(2, 143, 245);
            else
                revolvelabel.BackColor = Color.White;
        }

        private void Extrudelabel_Click(object sender, EventArgs e)
        {
            revolvelabel.BackColor = Color.White;
            revolvelabel.TextAlign = ContentAlignment.MiddleLeft;
            revolvelabel.ForeColor = Color.Black;

            TypeSelect = "Extrude";
            Extrudelabel.BackColor = Color.FromArgb(2, 143, 245);
            Extrudelabel.ForeColor = Color.White;
            Extrudelabel.TextAlign = ContentAlignment.MiddleCenter;

            label6.Enabled = true;
            textBox1.Enabled = true;
            checkBox1.Enabled = true;
            checkBox2.Enabled = true;
        }

        private void revolvelabel_Click(object sender, EventArgs e)
        {
            Extrudelabel.BackColor = Color.White;
            Extrudelabel.TextAlign = ContentAlignment.MiddleLeft;
            Extrudelabel.ForeColor = Color.Black;

            TypeSelect = "Revolve";
            revolvelabel.BackColor = Color.FromArgb(2, 143, 245);
            revolvelabel.ForeColor = Color.White;
            revolvelabel.TextAlign = ContentAlignment.MiddleCenter;

            label6.Enabled=false;
            textBox1.Enabled=false;
            checkBox1.Enabled=false;
            checkBox2.Enabled = false;
        }


    }
}
