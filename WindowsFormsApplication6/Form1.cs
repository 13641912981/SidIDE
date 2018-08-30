using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

namespace WindowsFormsApplication6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            buttonInit();//初始化按钮图标
        }

        public string Textbox1
        {
            get { return this.richTextBox1.Text; }
            set { this.richTextBox1.Text = value; }
        }

        private int ID = 0;
        public int bodyID
        {
            get { return ID; }
            set { ID = value; }
        }

        //命令
        private string Com = string.Empty;
        public string com
        {
            get { return Com; }
            set { Com = value; }
        }

        //图片名称
        private string PicName = string.Empty;
        public string pic
        {
            get { return PicName; }
            set { PicName = Application.StartupPath + "\\pic\\" + value; }
        }

        private string PicName1 = string.Empty;
        public string pic1
        {
            get { return PicName1; }
            set { PicName1 = Application.StartupPath + "\\pic\\" + value; }
        }

        private string PicName2 = string.Empty;
        public string pic2
        {
            get { return PicName2; }
            set { PicName2 = Application.StartupPath + "\\pic\\" + value; }
        }

        private string PicName3 = string.Empty;
        public string pic3
        {
            get { return PicName3; }
            set { PicName3 = Application.StartupPath + "\\pic\\" + value; }
        }

        private string PicName4 = string.Empty;
        public string pic4
        {
            get { return PicName4; }
            set { PicName4 = Application.StartupPath + "\\pic\\" + value; }
        }

        private string PicName5 = string.Empty;
        public string pic5
        {
            get { return PicName5; }
            set { PicName5 = Application.StartupPath + "\\pic\\" + value; }
        }

        //参数
        private string Param = string.Empty;
        public string par
        {
            get { return Param; }
            set { Param = value; }
        }

        ////窗体透明
        //[StructLayout(LayoutKind.Sequential)]
        //public struct MARGINS
        //{
        //    public int Left;
        //    public int Right;
        //    public int Top;
        //    public int Bottom;
        //}
        //[DllImport("dwmapi.dll", PreserveSig = false)]
        //static extern void DwmExtendFrameIntoClientArea(IntPtr hwnd, ref MARGINS margins);

        //[DllImport("dwmapi.dll", PreserveSig = false)]
        //static extern bool DwmIsCompositionEnabled(); //Dll 导入 DwmApi
        //private void Form1_Load(object sender, EventArgs e)
        //{
            ////如果启用Aero
            //if (DwmIsCompositionEnabled())
            //{
            //    MARGINS m = new MARGINS();
            //    m.Right = -1; //设为负数,则全窗体透明
            //    DwmExtendFrameIntoClientArea(this.Handle, ref m); //开启全窗体透明效果
            //}
            
        //}

        //protected override void OnPaintBackground(PaintEventArgs e)
        //{
        //    base.OnPaintBackground(e);
        //    if (DwmIsCompositionEnabled())
        //    {
        //        e.Graphics.Clear(Color.Black); //将窗体用黑色填充（Dwm 会把黑色视为透明区域）
        //    }
        //}
        ////窗体透明end

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            Pen pen1 = new Pen(Color.Gainsboro, 1);
            //pen1.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            //pen1.DashPattern = new float[] { 4f, 2f };
            e.Graphics.DrawRectangle(pen1, 0, 0, this.panel2.Width - 1, this.panel2.Height - 1);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            Pen pen1 = new Pen(Color.Gainsboro, 1);
            //pen1.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            //pen1.DashPattern = new float[] { 4f, 2f };
            e.Graphics.DrawRectangle(pen1, 0, 0, this.panel3.Width - 1, this.panel3.Height - 1);
        }

        //按钮图标初始化
        private void buttonInit()
        {
            string path1 = Application.StartupPath + "\\pic\\button\\";
            //圆柱
            string buttonName = path1 + "cylinder.gif";
            button6.Image = Image.FromFile(buttonName);
            //矩形
            buttonName = path1 + "block.gif";
            button12.Image = Image.FromFile(buttonName);
            //圆锥
            buttonName = path1 + "cone.gif";
            button8.Image = Image.FromFile(buttonName);
            //圆台
            buttonName = path1 + "boss.gif";
            button9.Image = Image.FromFile(buttonName);
            //球体
            buttonName = path1 + "sphere.gif";
            button16.Image = Image.FromFile(buttonName);
            //多边体
            buttonName = path1 + "polygon.gif";
            button15.Image = Image.FromFile(buttonName);
            //求和
            buttonName = path1 + "unite.gif";
            button4.Image = Image.FromFile(buttonName);
            //求差
            buttonName = path1 + "subtract.gif";
            button7.Image = Image.FromFile(buttonName);
            //打孔
            buttonName = path1 + "hole.gif";
            button1.Image = Image.FromFile(buttonName);
            //旋转
            buttonName = path1 + "rotate.gif";
            button19.Image = Image.FromFile(buttonName);
            //平移距离
            buttonName = path1 + "Transfdis.gif";
            button31.Image = Image.FromFile(buttonName);
            //平移两点
            buttonName = path1 + "Transfpoint.gif";
            button32.Image = Image.FromFile(buttonName);
            //get body
            buttonName = path1 + "body.gif";
            button13.Image = Image.FromFile(buttonName);
            //cb
            buttonName = path1 + "cb.gif";
            button11.Image = Image.FromFile(buttonName);
            //MSW
            buttonName = path1 + "MSW.gif";
            button17.Image = Image.FromFile(buttonName);
            //MS
            buttonName = path1 + "MS.gif";
            button18.Image = Image.FromFile(buttonName);
            //Nut
            buttonName = path1 + "Nut.gif";
            button20.Image = Image.FromFile(buttonName);
            //打开草图
            buttonName = path1 + "sketch.gif";
            button23.Image = Image.FromFile(buttonName);
            //草图直线
            buttonName = path1 + "line.gif";
            button24.Image = Image.FromFile(buttonName);
            //草图圆
            buttonName = path1 + "circle.gif";
            button25.Image = Image.FromFile(buttonName);
            //草图矩形
            buttonName = path1 + "rectangle.gif";
            button29.Image = Image.FromFile(buttonName);
            //拉伸
            buttonName = path1 + "extruded_body.gif";
            button27.Image = Image.FromFile(buttonName);
            //旋转
            buttonName = path1 + "revolved_body.gif";
            button28.Image = Image.FromFile(buttonName);
            //三角函数1
            buttonName = path1 + "Math1.gif";
            button21.Image = Image.FromFile(buttonName);
            //三角函数2角度
            buttonName = path1 + "Math2.gif";
            button22.Image = Image.FromFile(buttonName);
            //打开
            buttonName = path1 + "open.gif";
            button14.Image = Image.FromFile(buttonName);
            //导出
            buttonName = path1 + "JS.gif";
            button2.Image = Image.FromFile(buttonName);
            //初始化
            buttonName = path1 + "new.gif";
            button5.Image = Image.FromFile(buttonName);
            //过渡圆角
            buttonName = path1 + "overround.gif";
            button10.Image = Image.FromFile(buttonName);
            //预览
            buttonName = path1 + "review.gif";
            button30.Image = Image.FromFile(buttonName);
            //求交
            buttonName = path1 + "intersect.gif";
            button33.Image = Image.FromFile(buttonName);
            //复制体
            buttonName = path1 + "copybody.gif";
            button34.Image = Image.FromFile(buttonName);
            //矩阵平移
            buttonName = path1 + "ArrayRect.gif";
            button35.Image = Image.FromFile(buttonName);
            //矩阵旋转
            buttonName = path1 + "ArrayRotate.gif";
            button36.Image = Image.FromFile(buttonName);
            //平移（主体，平移向量）
            buttonName = path1 + "Translation.gif";
            button39.Image = Image.FromFile(buttonName);
            //平移（主体，平移向量）
            buttonName = path1 + "CopyWithTranslation.gif";
            button40.Image = Image.FromFile(buttonName);
            //旋转(主体，起始点，旋转轴向量，旋转角度)
            buttonName = path1 + "Rotation.gif";
            button41.Image = Image.FromFile(buttonName);
            //旋转复制体(主体，起始点，旋转轴向量，旋转角度)
            buttonName = path1 + "CopyWithRotation.gif";
            button42.Image = Image.FromFile(buttonName);
            ////线性阵列求差
            buttonName = path1 + "Array_Subtract.gif";
            button43.Image = Image.FromFile(buttonName);
            ////线性阵列求和
            buttonName = path1 + "Array_Unite.gif";
            button44.Image = Image.FromFile(buttonName);
            //圆周阵列求和
            buttonName = path1 + "Circular_Array_Unite.gif";
            button45.Image = Image.FromFile(buttonName);
            //圆周阵列求差
            buttonName = path1 + "Circular_Array_Subtract.gif";
            button46.Image = Image.FromFile(buttonName);
            //三点圆弧
            buttonName = path1 + "arc_point-point-point.gif";
            button26.Image = Image.FromFile(buttonName);
            //断点
            buttonName = path1 + "stop.gif";
            button49.Image = Image.FromFile(buttonName);
            //倒c角
            buttonName = path1 + "chamfer.gif";
            chamfer.Image = Image.FromFile(buttonName);
            //倒r角
            buttonName = path1 + "edge_blend.gif";
            edge_blend.Image = Image.FromFile(buttonName);
            //2D
            buttonName = path1 + "2D.gif";
            button47.Image = Image.FromFile(buttonName);
            //2D dt
            buttonName = path1 + "2DDT.gif";
            button48.Image = Image.FromFile(buttonName);
            //2D 草图命令轮带
            buttonName = path1 + "Tan2Circles.gif";
            button50.Image = Image.FromFile(buttonName);
            //2D 草图命令多段线
            buttonName = path1 + "Polyline.gif";
            button51.Image = Image.FromFile(buttonName);
            //锥圆头
            buttonName = path1 + "parab.jpg";
            button52.Image = Image.FromFile(buttonName);
            //凸模头部形状
            buttonName = path1 + "formingShape.jpg";
            button53.Image = Image.FromFile(buttonName);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cylinder newForm = new Cylinder(this);
            newForm.ShowDialog();
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            string str = string.Empty;
            SaveFileDialog sav = new SaveFileDialog();
            sav.Title = "请选择要保存的位置";
            sav.Filter = "文本文件|*.js";
            sav.InitialDirectory = @"E:\JS\";
            sav.FileName = "DT-P0102010000-03-CN";
            DialogResult result = sav.ShowDialog();
            string stt = sav.FileName;
            //if (stt == "")
            //    return;
            if (result != DialogResult.OK)
            {
                return;
            }

            using (FileStream fil = new FileStream(stt, FileMode.OpenOrCreate, FileAccess.Write))
            {
                byte[] byt = new byte[1024];
                if (comboBox1.SelectedIndex == 0)
                    str = release(this.richTextBox1.Text);
                else
                    str = release(this.richTextBox1.Text + string.Format("AGM.Modelling.SaveSat('{0}', 16);", "c:\\\\temp\\\\temp.sat"));
                byt = Encoding.Default.GetBytes(str);
                fil.Write(byt, 0, byt.Length);
            }
            MessageBox.Show("OK");  
        }

        private void button14_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            //ofd.InitialDirectory = @"E:\JS\"; //设置初始路径
            ofd.Filter = "文本文件|*.js";//"Excel文件(*.xls)|*.xls|Csv文件(*.csv)|*.csv|所有文件(*.*)|*.*"; //设置“另存为文件类型”或“文件类型”框中出现的选择内容
            //ofd.FilterIndex = 2; //设置默认显示文件类型为Csv文件(*.csv)|*.csv
            ofd.Title = "打开文件"; //获取或设置文件对话框标题
            ofd.RestoreDirectory = true;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                //FileName：所选文件的全路径  SafeFileName：所选的文件名
                string FileName = ofd.FileName;
                StreamReader sr = new StreamReader(FileName); //path是要读取的文件的完整路径
                String str_read = sr.ReadToEnd(); //从开始到末尾读取文件的所有内容，str_read 存放的就是读取到的文本
                sr.Close(); //读完文件记得关闭流
                richTextBox1.Text = str_read;
                //MessageBox.Show(str_read);
            }
        }

        private string release(string text)
        {
            Com test = new Com();
            string[] ContentLines = text.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries); //忽略空行
            string comm = string.Empty;
            if (ContentLines.Length > 0)
            {
                for (int i = 0; i < ContentLines.Length; i++)
                {
                    comm += test.getCom(ContentLines[i],i+1);
                    //MessageBox.Show(comm);
                }
            }
            return comm;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Com test = new Com();
            string[] ContentLines = this.richTextBox1.Text.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries); //忽略空行
            string comm = string.Empty;
            if (ContentLines.Length > 0)
            {
                for (int i = 0; i < ContentLines.Length; i++)
                {
                    //comm += test.getCom(ContentLines[i], i + 1);
                    MessageBox.Show(test.getCom(ContentLines[i], i + 1));
                }
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string a = String.Format("Unite({0}, {1});\r\n", "body1", "body" + this.bodyID.ToString());
            richTextBox1.Text += a;
            this.bodyID -= 1;
            //int line = richTextBox1.Lines.GetUpperBound(0);
            //string b = String.Format("Feature{0}\r\n", line.ToString());
            //textBox2.Text += b;
        }



        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            showLineNo();
            textBox1.Text = bodyID.ToString();
        }


        private void richTextBox1_VScroll(object sender, EventArgs e)
        {
            showLineNo();
        }

        public void showLineNo()
        {
            //获得当前坐标信息
            Point p = this.richTextBox1.Location;
            int crntFirstIndex = this.richTextBox1.GetCharIndexFromPosition(p);
            int crntFirstLine = this.richTextBox1.GetLineFromCharIndex(crntFirstIndex);
            Point crntFirstPos = this.richTextBox1.GetPositionFromCharIndex(crntFirstIndex);
            //
            p.Y += this.richTextBox1.Height;
            //
            int crntLastIndex = this.richTextBox1.GetCharIndexFromPosition(p);
            int crntLastLine = this.richTextBox1.GetLineFromCharIndex(crntLastIndex);
            Point crntLastPos = this.richTextBox1.GetPositionFromCharIndex(crntLastIndex);
            //
            //
            //准备画图
            Graphics g = this.panel1.CreateGraphics();
            Font font = new Font(this.richTextBox1.Font, this.richTextBox1.Font.Style);
            SolidBrush brush = new SolidBrush(Color.Green);
            //
            //
            //画图开始
            //刷新画布
            Rectangle rect = this.panel1.ClientRectangle;
            brush.Color = this.panel1.BackColor;
            g.FillRectangle(brush, 0, 0, this.panel1.ClientRectangle.Width, this.panel1.ClientRectangle.Height);
            brush.Color = Color.Green;//重置画笔颜色
            //
            //绘制行号
            int lineSpace = 0;
            if (crntFirstLine != crntLastLine)
            {
                lineSpace = (crntLastPos.Y - crntFirstPos.Y) / (crntLastLine - crntFirstLine);
            }
            else
            {
                lineSpace = Convert.ToInt32(this.richTextBox1.Font.Size);
            }
            int brushX = this.panel1.ClientRectangle.Width - Convert.ToInt32(font.Size * 3);
            int brushY = crntLastPos.Y + Convert.ToInt32(font.Size * 0.21f);//惊人的算法啊！！
            for (int i = crntLastLine; i >= crntFirstLine; i--)
            {
                g.DrawString((i + 1).ToString(), font, brush, brushX, brushY);
                brushY -= lineSpace;
            }
            g.Dispose();
            font.Dispose();
            brush.Dispose();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ID = 0;
            this.richTextBox1.Text = string.Empty;
            string v = "AGM.Document.LoadScript(\"C:\\\\SID\\\\Script\\\\Feature3D.js\");\r\n";
            v += "AGM.Document.LoadScript(\"C:\\\\SID\\\\Script\\\\Feature2D.js\");\r\n";
            v += "var result;\r\n";
            this.richTextBox1.Text = v;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.com = "var body{0} = Cylinder({1}, {2});\r\n";
            this.pic = "cylinder.JPG";
            this.par = "D,L";
            Cylinder newForm = new Cylinder(this);
            newForm.Text = "Cylinder";
            newForm.ShowDialog();
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            //showLineNo();
            //MessageBox.Show("1");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string a = String.Format("Subtract({0}, {1});\r\n", "body1", "body" + this.bodyID.ToString());
            richTextBox1.Text += a;
            this.bodyID -= 1;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //this.bodyID += 1;
            //string a = String.Format("var body{0} = Cone({1}, {2}, {3}, {4}, {5});\r\n",this.bodyID.ToString(), "D", "Angel", "0", "0", "0");
            //richTextBox1.Text += a;
            this.com = "var body{0} = Cone({1}, {2}, {3}, {4}, {5});\r\n";
            this.pic = "cone.JPG";
            this.par = "D,Angel,x0,y0,z0";
            Cylinder newForm = new Cylinder(this);
            newForm.Text = "Cone";
            newForm.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //this.bodyID += 1;
            //string a = String.Format("var body{0} = Boss({1}, {2}, {3}, {4}, {5}, {6});\r\n", this.bodyID.ToString(), "D", "Angel","y", "0", "0", "0");
            //richTextBox1.Text += a;
            this.com = "var body{0} = Boss({1}, {2}, {3}, {4}, {5}, {6});\r\n";
            this.pic = "boss.JPG";
            this.par = "D,Angel,y,x0,y0,z0";
            Cylinder newForm = new Cylinder(this);
            newForm.Text = "Boss";
            newForm.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //this.bodyID += 1;
            //string a = String.Format("OverRound0({1}, {2}, {3}, {4});\r\n", this.bodyID.ToString(), "x", "y", "z", "D");
            //a += String.Format("result = AGM.Modelling.GetModelBody({0}, body{0});\r\n", this.bodyID.ToString());
            //richTextBox1.Text += a;
            this.com = "var body{0} = OverRound0(0, {1}, {2}, {3});\r\n";
            this.pic = "OverRound0.JPG";
            this.par = "y0,z0,D";
            Cylinder newForm = new Cylinder(this);
            newForm.Text = "OverRound";
            newForm.ShowDialog();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //this.bodyID += 1;
            //string a = String.Format("var body{0} = addCB({1}, {2}, {3}, {4}, {5});\r\n", this.bodyID.ToString(), "M", "L", "x", "y", "z");
            //richTextBox1.Text += a;
            this.com = "var body{0} = addCB({1}, {2}, {3}, {4}, {5}, {6}, {7}, {8});\r\n";
            this.pic = "addCB.JPG";
            this.par = "M,L,A,E,B,x0,y0,z0";
            Cylinder newForm = new Cylinder(this);
            newForm.Text = "addCB";
            newForm.ShowDialog();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //this.bodyID += 1;
            //string a = String.Format("var body{0} = Block({1}, {2}, {3}, {4}, {5}, {5});\r\n", this.bodyID.ToString(), "长", "宽", "高", "0", "0", "0");
            //richTextBox1.Text += a;
            this.com = "var body{0} = BlockN({1}, {2}, {3}, {4}, {5}, {6}, {7});\r\n";
            this.pic = "Block.JPG";
            this.par = "长,宽,高,x0,y0,z0,Type";
            Cylinder newForm = new Cylinder(this);
            newForm.Text = "Block";
            newForm.ShowDialog();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.bodyID += 1;
            //string a = String.Format("result = AGM.Modelling.GetModelBody({0}, body{0});\r\n", this.bodyID.ToString());
            string a = String.Format("var body{0} = GetBody();\r\n", this.bodyID.ToString());
            richTextBox1.Text += a;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            this.com = "var body{0} = Polygon({1}, {2}, {3}, {4}, {5}, {6});\r\n";
            this.pic = "Polygon.JPG";
            this.par = "num,d,l,x0,y0,z0";
            Cylinder newForm = new Cylinder(this);
            newForm.Text = "Polygon";
            newForm.ShowDialog();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            this.com = "var body{0} = Sphere({1}, {2}, {3}, {4});\r\n";
            this.pic = "Sphere.JPG";
            this.par = "D,x0,y0,z0";
            Cylinder newForm = new Cylinder(this);
            newForm.Text = "Sphere";
            newForm.ShowDialog();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            this.com = "var body{0} = addMSW({1}, {2}, {3}, {4}, {5}, {6});\r\n";
            this.pic = "addMSW.JPG";
            this.par = "M,L,B,x0,y0,z0";
            Cylinder newForm = new Cylinder(this);
            newForm.Text = "addMSW";
            newForm.ShowDialog();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            this.com = "var body{0} = addMS({1}, {2}, {3}, {4}, {5});\r\n";
            this.pic = "addMS.JPG";
            this.par = "D,L,x0,y0,z0";
            Cylinder newForm = new Cylinder(this);
            newForm.Text = "addMS";
            newForm.ShowDialog();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            string a = String.Format("Rotate(body{0}, {1}, {2}, {3});//旋转体;③=0绕x，③=1绕y，③=2绕z\r\n", this.bodyID.ToString(), "angel", "2","false");
            richTextBox1.Text += a;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.pic = "Counterbore1.JPG";
            this.pic1 = "Hole.JPG";
            this.pic2 = "Through_hole.JPG";
            
            this.pic3 = "Counterbore.JPG";
            //this.pic1 = "Blind_hole.JPG";
            //this.pic2 = "Drilling_BT.JPG";
            this.pic4 = "Drilling_IM.JPG";
            this.pic5 = "Drilling_BT.JPG";
            //MessageBox.Show(this.pic.ToString());
            Hole newForm = new Hole(this);
            newForm.Text = "Hole";
            newForm.ShowDialog();

        }

        private void button20_Click(object sender, EventArgs e)
        {
            this.com = "var body{0} = Nut({1}, {2}, {3});\r\n";
            this.pic = "Nut.JPG";
            this.par = "M,B,T";
            Cylinder newForm = new Cylinder(this);
            newForm.Text = "Nut";
            newForm.ShowDialog();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            this.com = "{3} = Math.sqrt(Math.pow({1},2) + Math.pow({2},2));\r\n";
            this.pic = "sqrt.JPG";
            this.par = "A,B,C";
            Special newForm = new Special(this);
            newForm.Text = "Sqrt";
            newForm.ShowDialog();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            this.com = "{3} = Math.sqrt(Math.pow({1},2) + Math.pow({2},2));\r\n";
            this.pic = "sqrt1.JPG";
            this.par = ",,,A,0";
            Special newForm = new Special(this);
            newForm.Text = "sqrt1";
            newForm.ShowDialog();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            this.pic = "XY.JPG";
            this.pic1 = "XZ.JPG";
            this.pic2 = "YZ.JPG";
            Plane newForm = new Plane(this);
            newForm.ShowDialog();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            this.com = "AGM.Sketcher.CreateLine({1}, {2}, {3}, {4});\r\n";
            this.pic = "line.JPG";
            this.par = "x0,y0,x1,y1";
            Cylinder newForm = new Cylinder(this);
            newForm.Text = "Line";
            newForm.ShowDialog();
            bodyID -= 1;
        }

        private void button26_Click(object sender, EventArgs e)
        {
            this.com = "AGM.Sketcher.CreateArc3Points({1}, {2}, {3}, {4}, {5}, {6});\r\n";
            this.pic = "Arc3.JPG";
            this.par = "x0,y0,x1,y1,x2,y2";
            Cylinder newForm = new Cylinder(this);
            newForm.ShowDialog();
            bodyID -= 1;
        }

        private void button25_Click(object sender, EventArgs e)
        {
            this.com = "AGM.Sketcher.CreateCircle( {1}, {2}, {3});\r\n";
            this.pic = "Arc.JPG";
            this.par = "x0,y0,D";
            Cylinder newForm = new Cylinder(this);
            newForm.ShowDialog();
            newForm.Text = "Arc";
            bodyID -= 1;
        }

        private void button27_Click(object sender, EventArgs e)
        {
            string a = "AGM.Sketcher.CloseSketch();\r\n";
            a += "////1拉伸草图，2拉伸高度，3是否反向拉伸，4是否切除拉伸，5是否双向拉伸，6拉伸角度\r\n";
            a += "AGM.Sketcher.Extrude( pointSketch, n, 0, 0, 0, 0 );\r\n";
            a += "AGM.Sketcher.FixModel();\r\n";
            //richTextBox1.Text += a;
            this.bodyID += 1;
            a += String.Format("var body{0} = GetBody();\r\n", this.bodyID.ToString());
            richTextBox1.Text += a;
        }

        private void button28_Click(object sender, EventArgs e)
        {
            string a = "AGM.Sketcher.CloseSketch();\r\n";
            a += "AGM.Sketcher.Revolve(pointSketch,true , 0, 360, false);\r\n";
            a += "AGM.Sketcher.FixModel();\r\n";
            //richTextBox1.Text += a;
            this.bodyID += 1;
            a += String.Format("var body{0} = GetBody();\r\n", this.bodyID.ToString());
            richTextBox1.Text += a;
        }

        private void button29_Click(object sender, EventArgs e)
        {
            this.com = "AGM.Sketcher.CreateRect( {1}, {2}, {3}, {4});\r\n";
            this.pic = "Rec.JPG";
            this.par = "x0,y0,x1,y1";
            Cylinder newForm = new Cylinder(this);
            newForm.Text = "Rec";
            newForm.ShowDialog();
        }

        private void button30_Click(object sender, EventArgs e)
        {
            string path = string.Empty;
            OpenFileDialog file = new OpenFileDialog();
            file.Title = "请选择";
            file.Filter = "文本文件|*.CSV";
            //file.InitialDirectory = @"C:\SID\data";
            file.ShowDialog();
            string stt = file.FileName;
            if (stt == "")
                return;
            CSV.Read(stt, richTextBox1.Text);
        }

        private void button31_Click(object sender, EventArgs e)
        {
            string a = String.Format("Transfdis(body{0}, {1}, {2}, {3});//水平移动体,③=0绕x，③=1绕y，③=2绕z\r\n", this.bodyID.ToString(), "100", "2","false");
            richTextBox1.Text += a;
        }

        private void button32_Click(object sender, EventArgs e)
        {
            string a = String.Format("Transfpoint(body{0}, {1}, {2}, {3});//2点移动体,PointA,PointB\r\n", this.bodyID.ToString(), "[0,0,0]", "[10,10,10]", "false");
            richTextBox1.Text += a;
        }

        private void button33_Click(object sender, EventArgs e)
        {
            string a = String.Format("Intersect({0}, {1});\r\n", "body1", "body" + this.bodyID.ToString());
            richTextBox1.Text += a;
            this.bodyID -= 1;
        }

        private void button34_Click(object sender, EventArgs e)
        {
            this.bodyID += 1;
            string a = String.Format("var body{0} = CopyBody(body{1});\r\n", this.bodyID.ToString(), (this.bodyID-1).ToString());
            richTextBox1.Text += a;
        }

        private void button35_Click(object sender, EventArgs e)
        {
            this.com = "ArrayRect({1}, {2}, {3}, {4});\r\n";
            this.pic = "ArrayRect.JPG";
            this.par = "xN,yN,xStep,yStep";
            Special newForm = new Special(this);
            newForm.Text = "ArrayRect";
            newForm.ShowDialog();
        }

        private void button36_Click(object sender, EventArgs e)
        {
            this.com = "ArrayRotate({1}, {2}, {3}, {4});\r\n";
            this.pic = "ArrayRotate.JPG";
            this.par = "N,Angel,2,0";
            Special newForm = new Special(this);
            newForm.Text = "ArrayRotate";
            newForm.ShowDialog();
        }

        private void button37_Click(object sender, EventArgs e)
        {
            bodyID += 1;
            textBox1.Text = bodyID.ToString();
        }

        private void button38_Click(object sender, EventArgs e)
        {
            bodyID -= 1;
            textBox1.Text = bodyID.ToString();
        }

        private void button39_Click(object sender, EventArgs e)
        {
            string a = String.Format("Translation(body{0}, {1}, {2}, {3});//平移（主体，平移向量）\r\n", this.bodyID.ToString(), "x", "y", "z");
            richTextBox1.Text += a;
        }

        private void button40_Click(object sender, EventArgs e)
        {
            bodyID += 1;
            string a = String.Format("body{0} = CopyWithTranslation(body{1}, {2}, {3}, {4});//平移复制体（主体，平移向量）\r\n", this.bodyID.ToString(), (this.bodyID - 1).ToString(), "x", "y", "z");        
            richTextBox1.Text += a;
        }

        private void button41_Click(object sender, EventArgs e)
        {
            string a = String.Format("Rotation(body{0}, {1}, {2}, {3}, {4}, {5}, {6}, {7});//旋转(主体，起始点，旋转轴向量，旋转角度)\r\n", this.bodyID.ToString(), "0", "0", "0", "x", "y", "z", "angle");
            richTextBox1.Text += a;
        }

        private void button42_Click(object sender, EventArgs e)
        {
            bodyID += 1;
            string a = String.Format("body{0} = CopyWithRotation(body{1}, {2}, {3}, {4}, {5}, {6}, {7}, {8});//旋转复制体(主体，起始点，旋转轴向量，旋转角度)\r\n", this.bodyID.ToString(), (this.bodyID - 1).ToString(), "0", "0", "0", "x", "y", "z", "angle");
            richTextBox1.Text += a;
        }

        private void button43_Click(object sender, EventArgs e)
        {
            this.com = "Array_Subtract(body{1}, body{2}, {3}, {4}, {5}, {6}, {7});\r\n";
            this.pic = "Array.JPG";
            this.par = "body_main,body_unit,N1,L1,N2,L2,1";
            Cylinder newForm = new Cylinder(this);
            newForm.Text = "Array_Subtract";
            newForm.ShowDialog();
        }

        private void button44_Click(object sender, EventArgs e)
        {
            this.com = "Array_Unite(body{1}, body{2}, {3}, {4}, {5}, {6}, {7});\r\n";
            this.pic = "Array.JPG";
            this.par = "body_main,body_unit,N1,L1,N2,L2,1";
            Cylinder newForm = new Cylinder(this);
            newForm.Text = "Array_Unite";
            newForm.ShowDialog();
        }

        private void button45_Click(object sender, EventArgs e)
        {
            this.com = "Circular_Array_Unite(body{1}, body{2}, {3}, {4}, {5}, {6}, {7}, {8});\r\n";
            this.pic = "Circular_Array.JPG";
            this.par = "body_main,body_unit,angle,N1,X0,Y0,Z0,axis";
            Cylinder newForm = new Cylinder(this);
            newForm.Text = "Circular_Array_Unite";
            newForm.ShowDialog();
        }

        private void button46_Click(object sender, EventArgs e)
        {
            this.com = "Circular_Array_Subtract(body{1}, body{2}, {3}, {4}, {5}, {6}, {7}, {8});\r\n";
            this.pic = "Circular_Array.JPG";
            this.par = "body_main,body_unit,angle,N1,X0,Y0,Z0,axis";
            Cylinder newForm = new Cylinder(this);
            newForm.Text = "Circular_Array_Subtract";
            newForm.ShowDialog();
        }


        //private void button47_Click(object sender, EventArgs e)
        //{
        //    string str = richTextBox1.Text;
        //    string k = string.Empty;
        //    string[] temp = str.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);
        //    int end = temp.Length;
        //    int start = 1 + richTextBox1.GetLineFromCharIndex(richTextBox1.SelectionStart);
        //    for (int i = 0; i < end-1; i++)
        //    {
        //        if (i<start-1)
        //            k += temp[i] + "\r\n";
        //        else
        //            k += "\\\\" + temp[i] + "\r\n";
        //    }
        //    richTextBox1.Text = k;
        //}

        //private void button48_Click(object sender, EventArgs e)
        //{
        //    string str = richTextBox1.Text;
        //    string k = string.Empty;
        //    string[] temp = str.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);
        //    int end = temp.Length;
        //    int start = 1 + richTextBox1.GetLineFromCharIndex(richTextBox1.SelectionStart);
        //    for (int i = 0; i < end - 1; i++)
        //    {
        //        if (i < start - 1)
        //            k += temp[i] + "\r\n";
        //        else
        //        {
        //            if (temp[i].Length > 2)
        //            {
        //                if (temp[i].Substring(0, 2) == "\\\\")
        //                    k += temp[i].Substring(2, temp[i].Length - 2) + "\r\n";
        //                else
        //                    k += temp[i] + "\r\n";
        //            }
        //        }
        //    }
        //    richTextBox1.Text = k;
        //}

        private void button49_Click(object sender, EventArgs e)
        {
            richTextBox1.Select(richTextBox1.GetFirstCharIndexOfCurrentLine(), 1);
            if (richTextBox1.SelectionColor == Color.Red)
            {
                richTextBox1.SelectedText = string.Empty;
                richTextBox1.SelectionColor = Color.Black;
            }
            else
            {
                richTextBox1.SelectedText = "●" + richTextBox1.SelectedText;
                richTextBox1.Select(richTextBox1.GetFirstCharIndexOfCurrentLine(), 1);
                richTextBox1.SelectionColor = Color.Red;
            }
        }

        private void button47_Click(object sender, EventArgs e)
        {
            Blend o = new Blend(this,1);
            o.Text = "Chamfer";
            o.ShowDialog();
        }

        private void button48_Click(object sender, EventArgs e)
        {
            Blend o = new Blend(this, 2);
            o.Text = "Blend";
            o.ShowDialog();
        }


        private void button47_Click_1(object sender, EventArgs e)
        {
            Skecch newform = new Skecch(this);
            newform.ShowDialog();
        }

        private void button48_Click_1(object sender, EventArgs e)
        {
            SkecchDayton newform = new SkecchDayton(this);
            newform.ShowDialog();
        }

        private void button53_Click(object sender, EventArgs e)
        {
            formingShape newform = new formingShape(this);
            newform.ShowDialog();
        }

        private void button50_Click(object sender, EventArgs e)
        {
            this.com = "AGM.Sketcher.CreateTan2Circles( {1}, {2}, {3}, {4}, {5}, {6});\r\n";
            this.pic = "Tan2Circles.JPG";
            this.par = "x0,y0,r0,x1,y1,r1";
            Cylinder newForm = new Cylinder(this);
            newForm.Text = "Tan2Circles";
            newForm.ShowDialog();
        }

        private void button51_Click(object sender, EventArgs e)
        {
            string a = "////草图多边体,支持布尔运算,在Points数组中添加点(3维)\r\n";
            a += "var Points= [];\r\n";
            a += "Points[0] = AGM.Position(x1, y1, 0);\r\n";
            a += "Points[1] = AGM.Position(x2, y2, 0);\r\n";
            a += "Points[2] = AGM.Position(x3, y3, 0);\r\n";
            a += "AGM.Sketcher.CreatePolygon(Points);\r\n";
            richTextBox1.Text += a;
        }

        private void button52_Click(object sender, EventArgs e)
        {
            this.com = "Parab({1}, {2}, {3}, {4}, {5});\r\n";
            this.pic = "parab.JPG";
            this.par = "P,x,y,z,0";
            Cylinder newForm = new Cylinder(this);
            newForm.Text = "Cone";
            newForm.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string v = "AGM.Document.LoadScript(\"C:\\\\SID\\\\Script\\\\Feature3D.js\");\r\n";
            v += "AGM.Document.LoadScript(\"C:\\\\SID\\\\Script\\\\Feature2D.js\");\r\n";
            v += "var result;\r\n";
            comboBox1.SelectedIndex = 0;
            this.richTextBox1.Text = v;
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            showLineNo();
        }

        //鼠标事件
        private void button10_MouseEnter(object sender, EventArgs e)
        {
            ToolTip p = new ToolTip();
            p.ShowAlways = true;
            p.SetToolTip(this.button10, "过渡圆角");
        }

        private void button6_MouseEnter(object sender, EventArgs e)
        {
            ToolTip p = new ToolTip();
            p.ShowAlways = true;
            p.SetToolTip(this.button6, "圆柱");
        }

        private void button12_MouseEnter(object sender, EventArgs e)
        {
            ToolTip p = new ToolTip();
            p.ShowAlways = true;
            p.SetToolTip(this.button12, "立方体");
        }

        private void button16_MouseEnter(object sender, EventArgs e)
        {
            ToolTip p = new ToolTip();
            p.ShowAlways = true;
            p.SetToolTip(this.button16, "球体");
        }

        private void button9_MouseEnter(object sender, EventArgs e)
        {
            ToolTip p = new ToolTip();
            p.ShowAlways = true;
            p.SetToolTip(this.button9, "凸台");
        }

        private void button8_MouseEnter(object sender, EventArgs e)
        {
            ToolTip p = new ToolTip();
            p.ShowAlways = true;
            p.SetToolTip(this.button8, "圆锥体");
        }

        private void button15_MouseEnter(object sender, EventArgs e)
        {
            ToolTip p = new ToolTip();
            p.ShowAlways = true;
            p.SetToolTip(this.button15, "多边体");
        }

        private void button4_MouseEnter(object sender, EventArgs e)
        {
            ToolTip p = new ToolTip();
            p.ShowAlways = true;
            p.SetToolTip(this.button4, "求和");
        }

        private void button7_MouseEnter(object sender, EventArgs e)
        {
            ToolTip p = new ToolTip();
            p.ShowAlways = true;
            p.SetToolTip(this.button7, "求差");
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            ToolTip p = new ToolTip();
            p.ShowAlways = true;
            p.SetToolTip(this.button1, "打孔");
        }

        private void button19_MouseEnter(object sender, EventArgs e)
        {
            ToolTip p = new ToolTip();
            p.ShowAlways = true;
            p.SetToolTip(this.button19, "变换-旋转");
        }

        private void button13_MouseEnter(object sender, EventArgs e)
        {
            ToolTip p = new ToolTip();
            p.ShowAlways = true;
            p.SetToolTip(this.button13, "获取最后一个零件");
        }

        private void button11_MouseEnter(object sender, EventArgs e)
        {
            ToolTip p = new ToolTip();
            p.ShowAlways = true;
            p.SetToolTip(this.button11, "添加螺丝CB");
        }

        private void button17_MouseEnter(object sender, EventArgs e)
        {
            ToolTip p = new ToolTip();
            p.ShowAlways = true;
            p.SetToolTip(this.button17, "添加螺栓MSW");
        }

        private void button18_MouseEnter(object sender, EventArgs e)
        {
            ToolTip p = new ToolTip();
            p.ShowAlways = true;
            p.SetToolTip(this.button18, "添加销钉MS");
        }

        private void button20_MouseEnter(object sender, EventArgs e)
        {
            ToolTip p = new ToolTip();
            p.ShowAlways = true;
            p.SetToolTip(this.button20, "添加六角螺母");
        }

        private void button14_MouseEnter(object sender, EventArgs e)
        {
            ToolTip p = new ToolTip();
            p.ShowAlways = true;
            p.SetToolTip(this.button14, "打开");
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            ToolTip p = new ToolTip();
            p.ShowAlways = true;
            p.SetToolTip(this.button2, "导出JS");
        }

        private void button5_MouseEnter(object sender, EventArgs e)
        {
            ToolTip p = new ToolTip();
            p.ShowAlways = true;
            p.SetToolTip(this.button5, "初始化");
        }

        private void button23_MouseEnter(object sender, EventArgs e)
        {
            ToolTip p = new ToolTip();
            p.ShowAlways = true;
            p.SetToolTip(this.button23, "创建草图");
        }

        private void button24_MouseEnter(object sender, EventArgs e)
        {
            ToolTip p = new ToolTip();
            p.ShowAlways = true;
            p.SetToolTip(this.button24, "直线");
        }

        private void button25_MouseEnter(object sender, EventArgs e)
        {
            ToolTip p = new ToolTip();
            p.ShowAlways = true;
            p.SetToolTip(this.button25, "圆");
        }

        private void button29_MouseEnter(object sender, EventArgs e)
        {
            ToolTip p = new ToolTip();
            p.ShowAlways = true;
            p.SetToolTip(this.button29, "矩形");
        }

        private void button27_MouseEnter(object sender, EventArgs e)
        {
            ToolTip p = new ToolTip();
            p.ShowAlways = true;
            p.SetToolTip(this.button27, "拉伸");
        }

        private void button28_MouseEnter(object sender, EventArgs e)
        {
            ToolTip p = new ToolTip();
            p.ShowAlways = true;
            p.SetToolTip(this.button28, "旋转");
        }

        private void button21_MouseEnter(object sender, EventArgs e)
        {
            ToolTip p = new ToolTip();
            p.ShowAlways = true;
            p.SetToolTip(this.button21, "直角三角形,已知2边计算第3边");
        }

        private void button22_MouseEnter(object sender, EventArgs e)
        {
            ToolTip p = new ToolTip();
            p.ShowAlways = true;
            p.SetToolTip(this.button22, "直角三角形,已知1边和角度计算第3边");
        }

        private void button30_MouseEnter(object sender, EventArgs e)
        {
            ToolTip p = new ToolTip();
            p.ShowAlways = true;
            p.SetToolTip(this.button30, "3D预览");
        }

        private void button31_MouseEnter(object sender, EventArgs e)
        {
            ToolTip p = new ToolTip();
            p.ShowAlways = true;
            p.SetToolTip(this.button31, "平移距离");
        }

        private void button32_MouseEnter(object sender, EventArgs e)
        {
            ToolTip p = new ToolTip();
            p.ShowAlways = true;
            p.SetToolTip(this.button32, "平移两点");
        }

        private void button33_MouseEnter(object sender, EventArgs e)
        {
            ToolTip p = new ToolTip();
            p.ShowAlways = true;
            p.SetToolTip(this.button33, "求交");
        }

        private void button34_MouseEnter(object sender, EventArgs e)
        {
            ToolTip p = new ToolTip();
            p.ShowAlways = true;
            p.SetToolTip(this.button34, "复制体");
        }

        private void button35_MouseEnter(object sender, EventArgs e)
        {
            ToolTip p = new ToolTip();
            p.ShowAlways = true;
            p.SetToolTip(this.button35, "矩阵平移");
        }

        private void button36_MouseEnter(object sender, EventArgs e)
        {
            ToolTip p = new ToolTip();
            p.ShowAlways = true;
            p.SetToolTip(this.button36, "矩阵旋转");
        }

        private void button39_MouseEnter(object sender, EventArgs e)
        {
            ToolTip p = new ToolTip();
            p.ShowAlways = true;
            p.SetToolTip(this.button39, "平移");
        }

        private void button40_MouseEnter(object sender, EventArgs e)
        {
            ToolTip p = new ToolTip();
            p.ShowAlways = true;
            p.SetToolTip(this.button40, "平移复制体");
        }

        private void button41_MouseEnter(object sender, EventArgs e)
        {
            ToolTip p = new ToolTip();
            p.ShowAlways = true;
            p.SetToolTip(this.button41, "旋转");
        }

        private void button42_MouseEnter(object sender, EventArgs e)
        {
            ToolTip p = new ToolTip();
            p.ShowAlways = true;
            p.SetToolTip(this.button42, "旋转复制体");
        }

        private void button43_MouseEnter(object sender, EventArgs e)
        {
            ToolTip p = new ToolTip();
            p.ShowAlways = true;
            p.SetToolTip(this.button43, "线性阵列求差");
        }

        private void button44_MouseEnter(object sender, EventArgs e)
        {
            ToolTip p = new ToolTip();
            p.ShowAlways = true;
            p.SetToolTip(this.button44, "线性阵列求和");
        }

        private void button45_MouseEnter(object sender, EventArgs e)
        {
            ToolTip p = new ToolTip();
            p.ShowAlways = true;
            p.SetToolTip(this.button45, "圆周阵列求和");
        }

        private void button46_MouseEnter(object sender, EventArgs e)
        {
            ToolTip p = new ToolTip();
            p.ShowAlways = true;
            p.SetToolTip(this.button46, "圆周阵列求差");
        }

        private void button26_MouseEnter(object sender, EventArgs e)
        {
            ToolTip p = new ToolTip();
            p.ShowAlways = true;
            p.SetToolTip(this.button26, "三点圆弧");
        }

        private void button49_MouseEnter(object sender, EventArgs e)
        {
            ToolTip p = new ToolTip();
            p.ShowAlways = true;
            p.SetToolTip(this.button49, "断点");
        }

        private void button47_MouseHover(object sender, EventArgs e)
        {
            ToolTip p = new ToolTip();
            p.ShowAlways = true;
            p.SetToolTip(this.chamfer, "边倒角-C角");
        }

        private void button48_MouseHover(object sender, EventArgs e)
        {
            ToolTip p = new ToolTip();
            p.ShowAlways = true;
            p.SetToolTip(this.edge_blend, "边倒角-R角");
        }

        private void button47_MouseHover_1(object sender, EventArgs e)
        {
            ToolTip p = new ToolTip();
            p.ShowAlways = true;
            p.SetToolTip(this.button47, "2D MEX");
        }

        private void button48_MouseHover_1(object sender, EventArgs e)
        {
            ToolTip p = new ToolTip();
            p.ShowAlways = true;
            p.SetToolTip(this.button48, "2D Dayton");
        }

        private void button50_MouseHover(object sender, EventArgs e)
        {
            ToolTip p = new ToolTip();
            p.ShowAlways = true;
            p.SetToolTip(this.button50, "2圆");
        }

        private void button51_MouseHover(object sender, EventArgs e)
        {
            ToolTip p = new ToolTip();
            p.ShowAlways = true;
            p.SetToolTip(this.button51, "多段线");
        }

        private void button52_MouseHover(object sender, EventArgs e)
        {
            ToolTip p = new ToolTip();
            p.ShowAlways = true;
            p.SetToolTip(this.button52, "圆锥-头部圆角");
        }

        private void button53_MouseHover(object sender, EventArgs e)
        {
            ToolTip p = new ToolTip();
            p.ShowAlways = true;
            p.SetToolTip(this.button53, "凸模头部形状");
        }


    }
}