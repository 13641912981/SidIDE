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
    public partial class formingShape : Form
    {
        //实例主窗体  
        Form1 pall = new Form1();
        public formingShape(Form1 f1)
        {
            pall = f1;
            InitializeComponent();
        }

        //private string planeselect;
        //public string PlaneSelect
        //{
        //    get { return planeselect; }
        //    set { planeselect = value; }
        //}

        #region
        //private string _x0;
        //public string _X0
        //{
        //    get { return _x0; }
        //    set { _x0 = value; }
        //}

        //private string _y0;
        //public string _Y0
        //{
        //    get { return _y0; }
        //    set { _y0 = value; }
        //}

        //private string _z0;
        //public string _Z0
        //{
        //    get { return _z0; }
        //    set { _z0 = value; }
        //}

        private string pic;
        public string Pic
        {
            get { return pic; }
            set { pic = value; }
        }

        public int Page { get; set; }

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
        //public string TypeSelect
        //{
        //    get { return typeSelect; }
        //    set { typeSelect = value; }
        //}
        #endregion
        private void Skecch_Load(object sender, EventArgs e)
        {
            //TypeSelect = "Extrude";
            //PlaneSelect = "xy";
            //_X0 = "0";
            //_Y0 = "0";
            //_Z0 = "0";
            
            Page = 2;
            Back.Visible = false;
            addpicbox();
        }

        #region
        //step1 选择事件
        //private void XY_MouseEnter(object sender, EventArgs e)
        //{
        //   XY.BackColor = Color.FromArgb(79, 176, 247);
        //}

        //private void XY_MouseLeave(object sender, EventArgs e)
        //{
        //    if (PlaneSelect == "xy")
        //        XY.BackColor = Color.FromArgb(2, 143, 245);
        //    else
        //        XY.BackColor = Color.White;
        //}

        //private void XZ_MouseEnter(object sender, EventArgs e)
        //{
        //    XZ.BackColor = Color.FromArgb(79, 176, 247);
        //}

        //private void XZ_MouseLeave(object sender, EventArgs e)
        //{
        //    if (PlaneSelect == "xz")
        //        XZ.BackColor = Color.FromArgb(2, 143, 245);
        //    else
        //        XZ.BackColor = Color.White;
        //}

        //private void YZ_MouseEnter(object sender, EventArgs e)
        //{
        //    YZ.BackColor = Color.FromArgb(79, 176, 247);
        //}

        //private void YZ_MouseLeave(object sender, EventArgs e)
        //{
        //    if (PlaneSelect == "yz")
        //        YZ.BackColor = Color.FromArgb(2, 143, 245);
        //    else
        //        YZ.BackColor = Color.White;
        //}

        //private void XY_Click(object sender, EventArgs e)
        //{
        //    YZ.BackColor = Color.White;
        //    YZ.TextAlign = ContentAlignment.MiddleLeft;
        //    YZ.ForeColor = Color.Black;
        //    XZ.BackColor = Color.White;
        //    XZ.TextAlign = ContentAlignment.MiddleLeft;
        //    XZ.ForeColor = Color.Black;

        //    PlaneSelect = "xy";
        //    XY.BackColor = Color.FromArgb(2, 143, 245);
        //    XY.ForeColor = Color.White;
        //    XY.TextAlign = ContentAlignment.MiddleCenter;
        //}

        //private void XZ_Click(object sender, EventArgs e)
        //{
        //    YZ.BackColor = Color.White;
        //    YZ.TextAlign = ContentAlignment.MiddleLeft;
        //    YZ.ForeColor = Color.Black;
        //    XY.BackColor = Color.White;
        //    XY.TextAlign = ContentAlignment.MiddleLeft;
        //    XY.ForeColor = Color.Black;

        //    PlaneSelect = "xz";
        //    XZ.BackColor = Color.FromArgb(2, 143, 245);
        //    XZ.ForeColor = Color.White;
        //    XZ.TextAlign = ContentAlignment.MiddleCenter;
        //}

        //private void YZ_Click(object sender, EventArgs e)
        //{
        //    XY.BackColor = Color.White;
        //    XY.TextAlign = ContentAlignment.MiddleLeft;
        //    XY.ForeColor = Color.Black;
        //    XZ.BackColor = Color.White;
        //    XZ.TextAlign = ContentAlignment.MiddleLeft;
        //    XZ.ForeColor = Color.Black;

        //    PlaneSelect = "yz";
        //    YZ.BackColor = Color.FromArgb(2, 143, 245);
        //    YZ.ForeColor = Color.White;
        //    YZ.TextAlign = ContentAlignment.MiddleCenter;
        //}

        #endregion

        #region//添加picturebox

        private void addpicbox()
        {
            int k = 1;
            for (int i = 0; i < 11; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (k > 40)
                        break;
                    PictureBox p = new PictureBox();
                    p.SizeMode = PictureBoxSizeMode.Zoom;
                    p.Name = "W" + k.ToString();
                    p.Top = 6 + i * 86;
                    p.Left = 6 + j * 126;
                    p.Width = 120;
                    p.Height = 80;
                    p.Image = Image.FromFile(Application.StartupPath + @"\pic\formingShape\W" + k.ToString() + ".JPG");
                    //p.Click += new EventHandler(this.pictureBox_Click);
                    Label l = new Label();
                    l.Name = "W" + k.ToString();
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
                //case 1:
                //    tabControl1.SelectedTab = Step2;
                //    break;
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
                    
                    step3info[0] = String.Format(step3info[0]+";\r\n", temp);
                    //MessageBox.Show(step3info[0]);

                    //pall.bodyID += 1;
                    //string check1 = "0";
                    //if(checkBox1.CheckState==CheckState.Checked)
                    //{
                    //    check1 = "1";
                    //}
                    //string check2 = "0";
                    //if (checkBox2.CheckState == CheckState.Checked)
                    //{
                    //    check2 = "1";
                    //}
                    //string v = string.Empty;
                    //if (TypeSelect == "Extrude")
                    //{
                    //    v = String.Format("AGM.Sketcher.Extrude( {0}, {1}, {2}, 0, {3}, {4} );\r\n", step3info[0], ComTransFrom._F(textBox1.Text), check1, check2, ComTransFrom._F(textBox2.Text));
                    //}
                    //else
                    //{
                    //    v = String.Format("AGM.Sketcher.Revolve( {0}, true, 0, {1}, false );\r\n", step3info[0], ComTransFrom._F(textBox2.Text));
                    //}
                    //v += "AGM.Sketcher.FixModel();\r\n";
                    //v += String.Format("var body{0} = GetBody();\r\n", pall.bodyID.ToString());
                    //v +=
                    pall.richTextBox1.Text += step3info[0];
                    
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
                //case 2:
                //    tabControl1.SelectedTab = Step1;
                //    break;
                case 3:
                    tabControl1.SelectedTab = Step2;
                    Back.Visible = false;
                    break;
            }
            //MessageBox.Show(Page.ToString());
        }
        #region//命令
        private void step3()
        {
            //info[0] 命令
            string[] info = new string[4];
            string com = string.Empty;
            switch (Step2select)
            {
                case "W1":
                    com = "W201";
                    com += "({0})";
                    info[0] = com;
                    info[1] = "480,160|225,65";
                    info[2] = "PP|LA";
                    //MessageBox.Show(info[0]);
                    break;
                case "W2":
                    com = "W202";
                    com += "({0})";
                    info[0] = com;
                    info[1] = "470,150|215,55|415,230";
                    info[2] = "PP|LA|RL";
                    //MessageBox.Show(info[0]);
                    break;
                case "W3":
                    com = "W203";
                    com += "({0})";
                    info[0] = com;
                    info[1] = "230,150|475,140|230,45|405,205";
                    info[2] = "P|PP|LA|RP";
                    //MessageBox.Show(info[0]);
                    break;
                case "W4":
                    com = "W204";
                    com += "({0})";
                    info[0] = com;
                    info[1] = "240,168|493,163|230,70|430,230";
                    info[2] = "P|PP|LA|RP";
                    //MessageBox.Show(info[0]);
                    break;
                case "W5":
                    com = "W211";
                    com += "({0})";
                    info[0] = com;
                    info[1] = "260,260|480,163|245,70";
                    info[2] = "L|PP|LA";
                    //MessageBox.Show(info[0]);
                    break;
                case "W6":
                    com = "W212";
                    com += "({0})";
                    info[0] = com;
                    info[1] = "245,30|450,185|220,85|390,270";
                    info[2] = "L|PP|LA|RL";
                    //MessageBox.Show(info[0]);
                    break;
                case "W7":
                    com = "W213";
                    com += "({0})";
                    info[0] = com;
                    info[1] = "220,170|240,25|450,170|220,75|380,240";
                    info[2] = "P|L|PP|LA|RP";
                    //MessageBox.Show(info[0]);
                    break;
                case "W8":
                    com = "W221";
                    com += "({0})";
                    info[0] = com;
                    info[1] = "260,35|495,190|245,100|490,255";
                    info[2] = "L|PP|LA|RS";
                    //MessageBox.Show(info[0]);
                    break;
                case "W9":
                    com = "W222";
                    com += "({0})";
                    info[0] = com;
                    info[1] = "260,30|495,190|250,90|420,270|490,80";
                    info[2] = "L|PP|LA|RL|RS";
                    //MessageBox.Show(info[0]);
                    break;
                case "W10":
                    com = "W223";
                    com += "({0})";
                    info[0] = com;
                    info[1] = "220,180|240,25|450,180|220,85|380,250|450,120";
                    info[2] = "P|L|PP|LA|RP|RS";
                    //MessageBox.Show(info[0]);
                    break;
                case "W11":
                    com = "W224";
                    com += "({0})";
                    info[0] = com;
                    info[1] = "220,180|240,25|455,180|220,85|390,250|460,110";
                    info[2] = "P|L|PP|LA|RP|RS";
                    //MessageBox.Show(info[0]);
                    break;
                case "W12":
                    com = "W233";
                    com += "({0})";
                    info[0] = com;
                    info[1] = "500,150|445,150|205,55|205,150|375,215";
                    info[2] = "P|PP|LA|RL|RP";
                    //MessageBox.Show(info[0]);
                    break;
                case "W13":
                    com = "W234";
                    com += "({0})";
                    info[0] = com;
                    info[1] = "205,185|460,185|235,90|370,265|375,235";
                    info[2] = "P|PP|LA|RP|RL";
                    //MessageBox.Show(info[0]);
                    break;
                case "W14":
                    com = "W244";
                    com += "({0})";
                    info[0] = com;
                    info[1] = "220,140|240,235|455,140|230,50|380,200|410,70";
                    info[2] = "P|L|PP|LA|RP|RL";
                    //MessageBox.Show(info[0]);
                    break;
                case "W15":
                    com = "W264";
                    com += "({0})";
                    info[0] = com;
                    info[1] = "270,15|475,160|245,60|230,160|320,85|320,220|440,250|460,225|490,95";
                    info[2] = "L|PP|LA|PK|BB|RB|RK|RL|RS";
                    //MessageBox.Show(info[0]);
                    break;
                case "W16":
                    com = "W304";
                    com += "({0})";
                    info[0] = com;
                    info[1] = "465,155|235,45|390,95|130,245|265,162|280,95";
                    info[2] = "P|L|PP|LA|RP|AN";
                    //MessageBox.Show(info[0]);
                    break;
                case "W17":
                    com = "W401";
                    com += "({0})";
                    info[0] = com;
                    info[1] = "200,175|465,170|240,50|249,98";
                    info[2] = "P|PP|LA|AP";
                    //MessageBox.Show(info[0]);
                    break;
                case "W18":
                    com = "W402";
                    com += "({0})";
                    info[0] = com;
                    info[1] = "200,175|465,170|240,50|249,98|249,150";
                    info[2] = "P|PP|LA|AP|RL";
                    //MessageBox.Show(info[0]);
                    break;
                case "W19":
                    com = "W404";
                    com += "({0})";
                    info[0] = com;
                    info[1] = "200,175|470,170|255,50|255,103|410,225|375,250";
                    info[2] = "P|PP|LA|AP|RL|RP";
                    //MessageBox.Show(info[0]);
                    break;
                case "W20":
                    com = "W444";
                    com += "({0})";
                    info[0] = com;
                    info[1] = "270,260|490,160|270,25|225,160|320,60|330,230|430,240|420,200|485,85|300,100";
                    info[2] = "L|PP|LA|PK|BB|RB|RK|RL|RS|AP";
                    //MessageBox.Show(info[0]);
                    break;
                case "W21":
                    com = "W501";
                    com += "({0})";
                    info[0] = com;
                    info[1] = "465,155|230,25|375,85|90,245|200,90|330,120";
                    info[2] = "P|L|PP|LA|AP|AN";
                    //MessageBox.Show(info[0]);
                    break;
                case "W22":
                    com = "W601";
                    com += "({0})";
                    info[0] = com;
                    info[1] = "490,155|220,25";
                    info[2] = "P|L";
                    //MessageBox.Show(info[0]);
                    break;
                case "W23":
                    com = "W602";
                    com += "({0})";
                    info[0] = com;
                    info[1] = "490,155|220,25|440,110";
                    info[2] = "P|L|R";
                    //MessageBox.Show(info[0]);
                    break;
                case "W24":
                    com = "W603";
                    com += "({0})";
                    info[0] = com;
                    info[1] = "490,155|220,25|400,210";
                    info[2] = "P|L|R";
                    //MessageBox.Show(info[0]);
                    break;
                case "W25":
                    com = "W611";
                    com += "({0})";
                    info[0] = com;
                    info[1] = "495,165|220,25|210,65|435,200";
                    info[2] = "P|L|LA|RF";
                    //MessageBox.Show(info[0]);
                    break;
                case "W26":
                    com = "W612";
                    com += "({0})";
                    info[0] = com;
                    info[1] = "240,185|220,25|435,180|460,240";
                    info[2] = "P|L|PP|RP";
                    //MessageBox.Show(info[0]);
                    break;
                case "W27":
                    com = "W621";
                    com += "({0})";
                    info[0] = com;
                    info[1] = "240,185|220,25|460,220";
                    info[2] = "P|L|RF";
                    //MessageBox.Show(info[0]);
                    break;
                case "W28":
                    com = "W701";
                    com += "({0})";
                    info[0] = com;
                    info[1] = "275,185|255,25|310,110";
                    info[2] = "P|L|AP";
                    //MessageBox.Show(info[0]);
                    break;
                case "W29":
                    com = "W702";
                    com += "({0})";
                    info[0] = com;
                    info[1] = "245,180|260,25|315,105|455,250";
                    info[2] = "P|L|AP|RP";
                    //MessageBox.Show(info[0]);
                    break;
                case "W30":
                    com = "W703";
                    com += "({0})";
                    info[0] = com;
                    info[1] = "245,180|260,25|330,100|485,180";
                    info[2] = "P|L|AP|PP";
                    //MessageBox.Show(info[0]);
                    break;
                case "W31":
                    com = "W704";
                    com += "({0})";
                    info[0] = com;
                    info[1] = "245,180|260,25|330,100|485,180|470,260";
                    info[2] = "P|L|AP|PP|RP";
                    //MessageBox.Show(info[0]);
                    break;
                case "W32":
                    com = "W711";
                    com += "({0})";
                    info[0] = com;
                    info[1] = "245,180|260,25|320,90|485,180";
                    info[2] = "P|L|AP|RF";
                    //MessageBox.Show(info[0]);
                    break;
                case "W33":
                    com = "W712";
                    com += "({0})";
                    info[0] = com;
                    info[1] = "245,180|270,25|320,100|500,200|445,260";
                    info[2] = "P|L|AP|RF|RP";
                    //MessageBox.Show(info[0]);
                    break;
                case "W34":
                    com = "W713";
                    com += "({0})";
                    info[0] = com;
                    info[1] = "245,180|270,25|335,110|500,180|480,235";
                    info[2] = "P|L|AP|PP|RS";
                    //MessageBox.Show(info[0]);
                    break;
                case "W35":
                    com = "W714";
                    com += "({0})";
                    info[0] = com;
                    info[1] = "245,180|270,25|335,110|500,180|480,235|460,270";
                    info[2] = "P|L|AP|PP|RS|RP";
                    //MessageBox.Show(info[0]);
                    break;
                case "W36":
                    com = "W801";
                    com += "({0})";
                    info[0] = com;
                    info[1] = "245,180|255,255|270,40|310,95";
                    info[2] = "P|L|LA|AN";
                    //MessageBox.Show(info[0]);
                    break;
                case "W37":
                    com = "W802";
                    com += "({0})";
                    info[0] = com;
                    info[1] = "260,170|255,255|270,45|315,95|470,210";
                    info[2] = "P|L|LA|AN|RL";
                    //MessageBox.Show(info[0]);
                    break;
                case "W38":
                    com = "W811";
                    com += "({0})";
                    info[0] = com;
                    info[1] = "260,170|255,255|280,40|320,90|470,210";
                    info[2] = "P|L|LA|AN|RF";
                    //MessageBox.Show(info[0]);
                    break;
                case "W39":
                    com = "W812";
                    com += "({0})";
                    info[0] = com;
                    info[1] = "260,170|255,255|310,50|325,95|470,180|470,220";
                    info[2] = "P|L|LA|AN|RF|RL";
                    //MessageBox.Show(info[0]);
                    break;
                case "W40":
                    com = "W821";
                    com += "({0})";
                    info[0] = com;
                    info[1] = "260,170|255,255|460,160|220,45|335,95";
                    info[2] = "P|L|PP|LA|AN";
                    //MessageBox.Show(info[0]);
                    break;
            }
            Step3info = info;
            //MessageBox.Show(step3info[0]);
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
                //case 0:
                //    Page = 1;
                //    Back.Visible = false;
                //    Step1.Focus();                   
                //    break;
                case 0:
                    Page = 2;
                    Back.Visible = true;
                    Step2.Focus();
                    //清空所有控件
                    break;
                case 1:
                    //MessageBox.Show(Application.StartupPath + @"\pic\formingShape\" + Step2select + ".JPG");
                    if (string.IsNullOrEmpty(Step2select))
                    {
                        tabControl1.SelectedTab = Step2;
                        MessageBox.Show("Error:Step2未选择!");
                        Step2.Focus();
                        return;
                    }

                    //_X0 = ComTransFrom._F(X0.Text);
                    //_Y0 = ComTransFrom._F(Y0.Text);
                    //_Z0 = ComTransFrom._F(Z0.Text);

                    step3Pic.Image = Image.FromFile(Application.StartupPath + @"\pic\formingShape\" + Step2select + ".JPG");
                    
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

        private void formingShape_Shown(object sender, EventArgs e)
        {
            Step2.Focus();
        }

        //private void Extrudelabel_MouseEnter(object sender, EventArgs e)
        //{
        //    Extrudelabel.BackColor = Color.FromArgb(79, 176, 247);
        //}

        //private void revolvelabel_MouseEnter(object sender, EventArgs e)
        //{
        //    revolvelabel.BackColor = Color.FromArgb(79, 176, 247);
        //}

        //private void Extrudelabel_MouseLeave(object sender, EventArgs e)
        //{
        //    if (TypeSelect == "Extrude")
        //        Extrudelabel.BackColor = Color.FromArgb(2, 143, 245);
        //    else
        //        Extrudelabel.BackColor = Color.White;
        //}

        //private void revolvelabel_MouseLeave(object sender, EventArgs e)
        //{
        //    if (TypeSelect == "Revolve")
        //        revolvelabel.BackColor = Color.FromArgb(2, 143, 245);
        //    else
        //        revolvelabel.BackColor = Color.White;
        //}

        //private void Extrudelabel_Click(object sender, EventArgs e)
        //{
        //    revolvelabel.BackColor = Color.White;
        //    revolvelabel.TextAlign = ContentAlignment.MiddleLeft;
        //    revolvelabel.ForeColor = Color.Black;

        //    TypeSelect = "Extrude";
        //    Extrudelabel.BackColor = Color.FromArgb(2, 143, 245);
        //    Extrudelabel.ForeColor = Color.White;
        //    Extrudelabel.TextAlign = ContentAlignment.MiddleCenter;

        //    label6.Enabled = true;
        //    textBox1.Enabled = true;
        //    checkBox1.Enabled = true;
        //    checkBox2.Enabled = true;
        //}

        //private void revolvelabel_Click(object sender, EventArgs e)
        //{
        //    Extrudelabel.BackColor = Color.White;
        //    Extrudelabel.TextAlign = ContentAlignment.MiddleLeft;
        //    Extrudelabel.ForeColor = Color.Black;

        //    TypeSelect = "Revolve";
        //    revolvelabel.BackColor = Color.FromArgb(2, 143, 245);
        //    revolvelabel.ForeColor = Color.White;
        //    revolvelabel.TextAlign = ContentAlignment.MiddleCenter;

        //    label6.Enabled=false;
        //    textBox1.Enabled=false;
        //    checkBox1.Enabled=false;
        //    checkBox2.Enabled = false;
        //}


    }
}
