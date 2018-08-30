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
    public partial class Skecch : Form
    {
        //实例主窗体  
        Form1 pall = new Form1();
        public Skecch(Form1 f1)
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

        #region
        //step1 选择事件
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

        #region
        //添加picturebox
        private void addpicbox()
        {
            int k = 1;
            for (int i = 0; i < 11; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (k > 49)
                        break;
                    PictureBox p = new PictureBox();
                    p.Name = "Edge_" + k.ToString();
                    p.Top = 6 + i * 86;
                    p.Left = 6 + j * 126;
                    p.Width = 120;
                    p.Height = 80;
                    p.Image = Image.FromFile(Application.StartupPath + @"\pic\Sketch\Edge_" + k.ToString() + ".bmp");
                    //p.Click += new EventHandler(this.pictureBox_Click);
                    Label l = new Label();
                    l.Name = "Edge_" + k.ToString();
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

        /// <summary>
        /// picturebox 选中事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        #region
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
        #region
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
                        v = String.Format("AGM.Sketcher.Extrude( {0}, {1}, {2}, 0, {3}, {4} );\r\n", step3info[0], ComTransFrom._F(textBox1.Text), check1, check2, ComTransFrom._F(textBox2.Text));
                    }
                    else
                    {
                        v = String.Format("AGM.Sketcher.Revolve( {0}, true, 0, {1}, false );\r\n", step3info[0], ComTransFrom._F(textBox2.Text));
                    }
                    v += "AGM.Sketcher.FixModel();\r\n";
                    v += String.Format("var body{0} = GetBody();\r\n", pall.bodyID.ToString());
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
        #region
        private void step3()
        {
            //info[0] 命令
            string[] info = new string[4];
            string com = string.Empty;
            switch (Step2select)
            {
                case "Edge_1":
                    com = "S_Circle";
                    com = com + "('{0}', {1}, {2}, {3}, ";
                    info[0] = String.Format(com, PlaneSelect, _X0, _Y0, _Z0);
                    info[0] = info[0] + "{0})";
                    info[1] = "400,230";
                    info[2] = "D";
                    //MessageBox.Show(info[0]);
                    break;
                case "Edge_2":
                    com = "S_Edge_2";
                    com = com + "('{0}', {1}, {2}, {3}, ";
                    info[0] = String.Format(com, PlaneSelect, _X0, _Y0, _Z0);
                    info[0] = info[0] + "{0})";
                    info[1] = "130,180|320,25";
                    info[2] = "A|B";
                    //MessageBox.Show(info[0]);
                    break;
                case "Edge_3":
                    com = "S_Edge_3";
                    com = com + "('{0}', {1}, {2}, {3}, ";
                    info[0] = String.Format(com, PlaneSelect, _X0, _Y0, _Z0);
                    info[0] = info[0] + "{0})";
                    info[1] = "430,140|335,252";
                    info[2] = "P|W";
                    //MessageBox.Show(info[0]);
                    break;
                case "Edge_4":
                    com = "S_Edge_4";
                    com = com + "('{0}', {1}, {2}, {3}, ";
                    info[0] = String.Format(com, PlaneSelect, _X0, _Y0, _Z0);
                    info[0] = info[0] + "{0})";
                    info[1] = "390,165|300,270|480,275|350,18";
                    info[2] = "P|W|S|R";
                    //MessageBox.Show(info[0]);
                    break;
                case "Edge_5":
                    com = "S_Edge_5";
                    com = com + "('{0}', {1}, {2}, {3}, ";
                    info[0] = String.Format(com, PlaneSelect, _X0, _Y0, _Z0);
                    info[0] = info[0] + "{0})";
                    info[1] = "380,130|250,110|250,195";
                    info[2] = "A|S|R";
                    //MessageBox.Show(info[0]);
                    break;
                case "Edge_6":
                    com = "S_Edge_6";
                    com = com + "('{0}', {1}, {2}, {3}, ";
                    info[0] = String.Format(com, PlaneSelect, _X0, _Y0, _Z0);
                    info[0] = info[0] + "{0})";
                    info[1] = "305,30|390,170|305,270";
                    info[2] = "A|P|W";
                    //MessageBox.Show(info[0]);
                    break;
                case "Edge_7":
                    com = "S_Edge_7";
                    com = com + "('{0}', {1}, {2}, {3}, ";
                    info[0] = String.Format(com, PlaneSelect, _X0, _Y0, _Z0);
                    info[0] = info[0] + "{0})";
                    info[1] = "335,20|375,170|290,270";
                    info[2] = "R|P|W";
                    //MessageBox.Show(info[0]);
                    break;
                case "Edge_8":
                    com = "S_Edge_8";
                    com = com + "('{0}', {1}, {2}, {3}, ";
                    info[0] = String.Format(com, PlaneSelect, _X0, _Y0, _Z0);
                    info[0] = info[0] + "{0})";
                    info[1] = "370,160|230,140|230,225";
                    info[2] = "A|S|R";
                    //MessageBox.Show(info[0]);
                    break;
                case "Edge_9":
                    com = "S_Edge_9";
                    com = com + "('{0}', {1}, {2}, {3}, ";
                    info[0] = String.Format(com, PlaneSelect, _X0, _Y0, _Z0);
                    info[0] = info[0] + "{0})";
                    info[1] = "310,25|420,160|310,270";
                    info[2] = "A|P|W";
                    //MessageBox.Show(info[0]);
                    break;
                case "Edge_10":
                    com = "S_Edge_10";
                    com = com + "('{0}', {1}, {2}, {3}, ";
                    info[0] = String.Format(com, PlaneSelect, _X0, _Y0, _Z0);
                    info[0] = info[0] + "{0})";
                    info[1] = "290,22|390,160|290,265|450,22|460,265";
                    info[2] = "A|P|W|S|R";
                    //MessageBox.Show(info[0]);
                    break;
                case "Edge_11":
                    com = "S_Edge_11";
                    com = com + "('{0}', {1}, {2}, {3}, ";
                    info[0] = String.Format(com, PlaneSelect, _X0, _Y0, _Z0);
                    info[0] = info[0] + "{0})";
                    info[1] = "290,22|410,160|290,265";
                    info[2] = "A|P|W";
                    //MessageBox.Show(info[0]);
                    break;
                case "Edge_12":
                    com = "S_Edge_12";
                    com = com + "('{0}', {1}, {2}, {3}, ";
                    info[0] = String.Format(com, PlaneSelect, _X0, _Y0, _Z0);
                    info[0] = info[0] + "{0})";
                    info[1] = "310,25|380,170|310,265";
                    info[2] = "A|P|W";
                    //MessageBox.Show(info[0]);
                    break;
                case "Edge_13":
                    com = "S_Edge_13";
                    com = com + "('{0}', {1}, {2}, {3}, ";
                    info[0] = String.Format(com, PlaneSelect, _X0, _Y0, _Z0);
                    info[0] = info[0] + "{0})";
                    info[1] = "305,28|385,113|305,262";
                    info[2] = "A|P|W";
                    //MessageBox.Show(info[0]);
                    break;
                case "Edge_14":
                    com = "S_Edge_14";
                    com = com + "('{0}', {1}, {2}, {3}, ";
                    info[0] = String.Format(com, PlaneSelect, _X0, _Y0, _Z0);
                    info[0] = info[0] + "{0})";
                    info[1] = "285,25|355,140|285,267|285,220";
                    info[2] = "A|P|W|B";
                    //MessageBox.Show(info[0]);
                    break;
                case "Edge_15":
                    com = "S_Edge_15";
                    com = com + "('{0}', {1}, {2}, {3}, ";
                    info[0] = String.Format(com, PlaneSelect, _X0, _Y0, _Z0);
                    info[0] = info[0] + "{0})";
                    info[1] = "395,160|305,265|800,22";
                    info[2] = "P|W|0";
                    //MessageBox.Show(info[0]);
                    break;
                case "Edge_16":
                    com = "S_Edge_15";
                    com = com + "('{0}', {1}, {2}, {3}, ";
                    info[0] = String.Format(com, PlaneSelect, _X0, _Y0, _Z0);
                    info[0] = info[0] + "{0})";
                    info[1] = "375,160|285,260|460,17";
                    info[2] = "P|W|R";
                    //MessageBox.Show(info[0]);
                    break;
                case "Edge_17":
                    com = "S_Edge_17";
                    com = com + "('{0}', {1}, {2}, {3}, ";
                    info[0] = String.Format(com, PlaneSelect, _X0, _Y0, _Z0);
                    info[0] = info[0] + "{0})";
                    info[1] = "375,170|290,270|700,17|455,270";
                    info[2] = "P|W|0|R";
                    //MessageBox.Show(info[0]);
                    break;
                case "Edge_18":
                    com = "S_Edge_17";
                    com = com + "('{0}', {1}, {2}, {3}, ";
                    info[0] = String.Format(com, PlaneSelect, _X0, _Y0, _Z0);
                    info[0] = info[0] + "{0})";
                    info[1] = "375,170|290,270|420,270|420,40";
                    info[2] = "P|W|S|R";
                    //MessageBox.Show(info[0]);
                    break;
                case "Edge_19":
                    com = "S_Edge_19";
                    com = com + "('{0}', {1}, {2}, {3}, ";
                    info[0] = String.Format(com, PlaneSelect, _X0, _Y0, _Z0);
                    info[0] = info[0] + "{0})";
                    info[1] = "400,150|308,261";
                    info[2] = "P|W";
                    //MessageBox.Show(info[0]);
                    break;
                case "Edge_20":
                    com = "S_Edge_11";
                    com = com + "('{0}', {1}, {2}, {3}, ";
                    info[0] = String.Format(com, PlaneSelect, _X0, _Y0, _Z0);
                    info[0] = info[0] + "{0})";
                    info[1] = "435,30|376,160|290,260";
                    info[2] = "R|P|W";
                    //MessageBox.Show(info[0]);
                    break;
                case "Edge_21":
                    com = "S_Edge_21";
                    com = com + "('{0}', {1}, {2}, {3}, ";
                    info[0] = String.Format(com, PlaneSelect, _X0, _Y0, _Z0);
                    info[0] = info[0] + "{0})";
                    info[1] = "315,20|435,160|315,260";
                    info[2] = "A|P|W";
                    //MessageBox.Show(info[0]);
                    break;
                case "Edge_22":
                    com = "S_Edge_22";
                    com = com + "('{0}', {1}, {2}, {3}, ";
                    info[0] = String.Format(com, PlaneSelect, _X0, _Y0, _Z0);
                    info[0] = info[0] + "{0})";
                    info[1] = "305,22|435,160|305,265|425,115|445,30";
                    info[2] = "A|P|W|S|R";
                    //MessageBox.Show(info[0]);
                    break;
                case "Edge_23":
                    com = "S_Edge_23";
                    com = com + "('{0}', {1}, {2}, {3}, ";
                    info[0] = String.Format(com, PlaneSelect, _X0, _Y0, _Z0);
                    info[0] = info[0] + "{0})";
                    info[1] = "300,30|435,160|305,260|230,85";
                    info[2] = "A|P|W|S";
                    //MessageBox.Show(info[0]);
                    break;
                case "Edge_24":
                    com = "S_Edge_24";
                    com = com + "('{0}', {1}, {2}, {3}, ";
                    info[0] = String.Format(com, PlaneSelect, _X0, _Y0, _Z0);
                    info[0] = info[0] + "{0})";
                    info[1] = "295,22|430,160|300,265|225,82";
                    info[2] = "A|P|W|S";
                    //MessageBox.Show(info[0]);
                    break;
                case "Edge_25":
                    com = "S_Edge_25";
                    com = com + "('{0}', {1}, {2}, {3}, ";
                    info[0] = String.Format(com, PlaneSelect, _X0, _Y0, _Z0);
                    info[0] = info[0] + "{0})";
                    info[1] = "305,22|430,160|300,265";
                    info[2] = "A|P|W";
                    //MessageBox.Show(info[0]);
                    break;
                case "Edge_26":
                    com = "S_Edge_26";
                    com = com + "('{0}', {1}, {2}, {3}, ";
                    info[0] = String.Format(com, PlaneSelect, _X0, _Y0, _Z0);
                    info[0] = info[0] + "{0})";
                    info[1] = "315,22|435,165|310,270|220,73";
                    info[2] = "A|P|W|S";
                    //MessageBox.Show(info[0]);
                    break;
                case "Edge_27":
                    com = "S_Edge_27";
                    com = com + "('{0}', {1}, {2}, {3}, ";
                    info[0] = String.Format(com, PlaneSelect, _X0, _Y0, _Z0);
                    info[0] = info[0] + "{0})";
                    info[1] = "395,25|390,160|297,262";
                    info[2] = "R|P|W";
                    //MessageBox.Show(info[0]);
                    break;
                case "Edge_28":
                    com = "S_Edge_28";
                    com = com + "('{0}', {1}, {2}, {3}, ";
                    info[0] = String.Format(com, PlaneSelect, _X0, _Y0, _Z0);
                    info[0] = info[0] + "{0})";
                    info[1] = "290,26|433,130|290,265|380,112|380,215";
                    info[2] = "A|P|W|C|B";
                    //MessageBox.Show(info[0]);
                    break;
                case "Edge_29":
                    com = "S_Edge_29";
                    com = com + "('{0}', {1}, {2}, {3}, ";
                    info[0] = String.Format(com, PlaneSelect, _X0, _Y0, _Z0);
                    info[0] = info[0] + "{0})";
                    info[1] = "395,155|285,260";
                    info[2] = "P|W";
                    //MessageBox.Show(info[0]);
                    break;
                case "Edge_30":
                    com = "S_Edge_30";
                    com = com + "('{0}', {1}, {2}, {3}, ";
                    info[0] = String.Format(com, PlaneSelect, _X0, _Y0, _Z0);
                    info[0] = info[0] + "{0})";
                    info[1] = "380,168|290,270|450,67";
                    info[2] = "P|W|R";
                    //MessageBox.Show(info[0]);
                    break;
                case "Edge_31":
                    com = "S_Edge_31";
                    com = com + "('{0}', {1}, {2}, {3}, ";
                    info[0] = String.Format(com, PlaneSelect, _X0, _Y0, _Z0);
                    info[0] = info[0] + "{0})";
                    info[1] = "442,167|300,270|444,122|245,25|390,200";
                    info[2] = "P|W|S|R|B";
                    //MessageBox.Show(info[0]);
                    break;
                case "Edge_32":
                    com = "S_Edge_32";
                    com = com + "('{0}', {1}, {2}, {3}, ";
                    info[0] = String.Format(com, PlaneSelect, _X0, _Y0, _Z0);
                    info[0] = info[0] + "{0})";
                    info[1] = "442,160|290,265|390,200";
                    info[2] = "P|W|B";
                    //MessageBox.Show(info[0]);
                    break;
                case "Edge_33":
                    com = "S_Edge_33";
                    com = com + "('{0}', {1}, {2}, {3}, ";
                    info[0] = String.Format(com, PlaneSelect, _X0, _Y0, _Z0);
                    info[0] = info[0] + "{0})";
                    info[1] = "386,130|290,246";
                    info[2] = "P|W";
                    //MessageBox.Show(info[0]);
                    break;
                case "Edge_34":
                    com = "S_Edge_34";
                    com = com + "('{0}', {1}, {2}, {3}, ";
                    info[0] = String.Format(com, PlaneSelect, _X0, _Y0, _Z0);
                    info[0] = info[0] + "{0})";
                    info[1] = "365,158|300,260|450,29";
                    info[2] = "P|W|R";
                    //MessageBox.Show(info[0]);
                    break;
                case "Edge_35":
                    com = "S_Edge_35";
                    com = com + "('{0}', {1}, {2}, {3}, ";
                    info[0] = String.Format(com, PlaneSelect, _X0, _Y0, _Z0);
                    info[0] = info[0] + "{0})";
                    info[1] = "390,180|310,275|220,105|410,35";
                    info[2] = "P|W|S|R";
                    //MessageBox.Show(info[0]);
                    break;
                case "Edge_36":
                    com = "S_Edge_36";
                    com = com + "('{0}', {1}, {2}, {3}, ";
                    info[0] = String.Format(com, PlaneSelect, _X0, _Y0, _Z0);
                    info[0] = info[0] + "{0})";
                    info[1] = "295,22|445,160|290,265|390,200";
                    info[2] = "A|P|W|B";
                    //MessageBox.Show(info[0]);
                    break;
                case "Edge_37":
                    com = "S_Edge_37";
                    com = com + "('{0}', {1}, {2}, {3}, ";
                    info[0] = String.Format(com, PlaneSelect, _X0, _Y0, _Z0);
                    info[0] = info[0] + "{0})";
                    info[1] = "280,30|430,160|280,260|370,200|380,125|450,260";
                    info[2] = "A|P|W|B|S|R";
                    //MessageBox.Show(info[0]);
                    break;
                case "Edge_38":
                    com = "S_Edge_38";
                    com = com + "('{0}', {1}, {2}, {3}, ";
                    info[0] = String.Format(com, PlaneSelect, _X0, _Y0, _Z0);
                    info[0] = info[0] + "{0})";
                    info[1] = "270,25|430,160|275,255|370,200|380,130|450,255";
                    info[2] = "A|P|W|B|S|R";
                    //MessageBox.Show(info[0]);
                    break;
                case "Edge_39":
                    com = "S_Edge_39";
                    com = com + "('{0}', {1}, {2}, {3}, ";
                    info[0] = String.Format(com, PlaneSelect, _X0, _Y0, _Z0);
                    info[0] = info[0] + "{0})";
                    info[1] = "300,60|445,170|300,270|390,190";
                    info[2] = "A|P|W|B";
                    //MessageBox.Show(info[0]);
                    break;
                case "Edge_40":
                    com = "S_Edge_40";
                    com = com + "('{0}', {1}, {2}, {3}, ";
                    info[0] = String.Format(com, PlaneSelect, _X0, _Y0, _Z0);
                    info[0] = info[0] + "{0})";
                    info[1] = "280,28|430,160|280,260|370,185|400,44|450,260";
                    info[2] = "A|P|W|B|S|R";
                    //MessageBox.Show(info[0]);
                    break;
                case "Edge_41":
                    com = "S_Edge_41";
                    com = com + "('{0}', {1}, {2}, {3}, ";
                    info[0] = String.Format(com, PlaneSelect, _X0, _Y0, _Z0);
                    info[0] = info[0] + "{0})";
                    info[1] = "285,65|433,160|290,255|380,180|400,40|455,255";
                    info[2] = "A|P|W|B|S|R";
                    //MessageBox.Show(info[0]);
                    break;
                case "Edge_42":
                    com = "S_Edge_42";
                    com = com + "('{0}', {1}, {2}, {3}, ";
                    info[0] = String.Format(com, PlaneSelect, _X0, _Y0, _Z0);
                    info[0] = info[0] + "{0})";
                    info[1] = "345,20|410,160|320,265|165,200";
                    info[2] = "A|P|W|B";
                    //MessageBox.Show(info[0]);
                    break;
                case "Edge_43":
                    com = "S_Edge_43";
                    com = com + "('{0}', {1}, {2}, {3}, ";
                    info[0] = String.Format(com, PlaneSelect, _X0, _Y0, _Z0);
                    info[0] = info[0] + "{0})";
                    info[1] = "315,25|380,160|295,265|160,200|230,125|455,255";
                    info[2] = "A|P|W|B|S|R";
                    //MessageBox.Show(info[0]);
                    break;
                case "Edge_44":
                    com = "S_Edge_44";
                    com = com + "('{0}', {1}, {2}, {3}, ";
                    info[0] = String.Format(com, PlaneSelect, _X0, _Y0, _Z0);
                    info[0] = info[0] + "{0})";
                    info[1] = "280,25|165,165|300,270|440,210";
                    info[2] = "A|P|W|B";
                    //MessageBox.Show(info[0]);
                    break;
                case "Edge_45":
                    com = "S_Edge_45";
                    com = com + "('{0}', {1}, {2}, {3}, ";
                    info[0] = String.Format(com, PlaneSelect, _X0, _Y0, _Z0);
                    info[0] = info[0] + "{0})";
                    info[1] = "298,22|180,160|310,260|445,198|375,122|205,250";
                    info[2] = "A|P|W|B|S|R";
                    //MessageBox.Show(info[0]);
                    break;
                case "Edge_46":
                    com = "S_Edge_46";
                    com = com + "('{0}', {1}, {2}, {3}, ";
                    info[0] = String.Format(com, PlaneSelect, _X0, _Y0, _Z0);
                    info[0] = info[0] + "{0})";
                    info[1] = "290,20|440,165|290,265|380,165";
                    info[2] = "A|P|W|B";
                    //MessageBox.Show(info[0]);
                    break;
                case "Edge_47":
                    com = "S_Edge_47";
                    com = com + "('{0}', {1}, {2}, {3}, ";
                    info[0] = String.Format(com, PlaneSelect, _X0, _Y0, _Z0);
                    info[0] = info[0] + "{0})";
                    info[1] = "285,29|430,165|290,265|380,165|460,255|425,29";
                    info[2] = "A|P|W|B|S|R";
                    //MessageBox.Show(info[0]);
                    break;
                case "Edge_48":
                    com = "S_Edge_48";
                    com = com + "('{0}', {1}, {2}, {3}, ";
                    info[0] = String.Format(com, PlaneSelect, _X0, _Y0, _Z0);
                    info[0] = info[0] + "{0})";
                    info[1] = "305,20|450,165|305,270|395,165";
                    info[2] = "A|P|W|B";
                    //MessageBox.Show(info[0]);
                    break;
                case "Edge_49":
                    com = "S_Edge_49";
                    com = com + "('{0}', {1}, {2}, {3}, ";
                    info[0] = String.Format(com, PlaneSelect, _X0, _Y0, _Z0);
                    info[0] = info[0] + "{0})";
                    info[1] = "295,22|430,165|290,265|380,165|225,145|455,265";
                    info[2] = "A|P|W|B|S|R";
                    //MessageBox.Show(info[0]);
                    break;
            }
            Step3info = info;
        }
        #endregion
        #region
        //添加textbox插件
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

                    step3Pic.Image = Image.FromFile(Application.StartupPath + @"\pic\Sketch\" + Step2select + ".bmp");
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
