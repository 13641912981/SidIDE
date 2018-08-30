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
    public partial class Plane : Form
    {
        //实例主窗体  
        Form1 pall = new Form1();
        public Plane(Form1 f1)
        {
            InitializeComponent();
            pall = f1;
            if (string.IsNullOrEmpty(pall.pic) == false)
                pictureBox1.Image = Image.FromFile(pall.pic);
            if (string.IsNullOrEmpty(pall.pic1) == false)
                pictureBox2.Image = Image.FromFile(pall.pic1);
            if (string.IsNullOrEmpty(pall.pic2) == false)
                pictureBox3.Image = Image.FromFile(pall.pic2);
            //if (string.IsNullOrEmpty(pall.pic3) == false)
            //    pictureBox4.Image = Image.FromFile(pall.pic3);
            //if (string.IsNullOrEmpty(pall.pic4) == false)
            //    pictureBox5.Image = Image.FromFile(pall.pic4);
            //if (string.IsNullOrEmpty(pall.pic5) == false)
            //    pictureBox6.Image = Image.FromFile(pall.pic5);
        }

        private string getname(string n)
        {
            string[] temp = n.Split('\\');
            return temp[temp.Length - 1];
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //if (string.IsNullOrEmpty(pall.pic))
            //    return;
            ////MessageBox.Show(getname(pall.pic));
            string v = "var pointSketch = Plane('xy');\r\n";
            pall.richTextBox1.Text += v;
            ////pall.pic = getname(pall.pic);
            //pall.par = "d1,d2,h1,h2,x0,y0,z0,type";
            //Cylinder newForm = new Cylinder(pall);
            this.Close();
            this.Dispose();
            //newForm.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //if (string.IsNullOrEmpty(pall.pic1))
            //    return;
            //pall.com = "Hole1({1}, {2}, {3}, {4}, {5}, {6});\r\n";
            //pall.pic = getname(pall.pic1);
            //pall.par = "D,L,x0,y0,z0,type";
            //Cylinder newForm = new Cylinder(pall);
            //this.Close();
            //this.Dispose();
            //newForm.ShowDialog();
            string v = "var pointSketch = Plane('xz');\r\n";
            pall.richTextBox1.Text += v;
            this.Close();
            this.Dispose();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            //if (string.IsNullOrEmpty(pall.pic2))
            //    return;
            //pall.com = "Through_hole({1}, {2}, {3}, {4}, {5});\r\n";
            //pall.pic = getname(pall.pic2);
            //pall.par = "D,x0,y0,z0,type";
            //Cylinder newForm = new Cylinder(pall);
            //this.Close();
            //this.Dispose();
            //newForm.ShowDialog();
            string v = "var pointSketch = Plane('yz');\r\n";
            pall.richTextBox1.Text += v;
            this.Close();
            this.Dispose();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            //if (string.IsNullOrEmpty(pall.pic3))
            //    return;
            //pall.com = "var body{0} = Counterbore({1}, {2}, {3}, {4}, {5}, {6}, {7});\r\n";
            //pall.pic = getname(pall.pic3);
            //pall.par = "d1,d2,h1,h2,x0,y0,z0";
            //Cylinder newForm = new Cylinder(pall);
            //this.Close();
            //this.Dispose();
            //newForm.ShowDialog();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            //if (string.IsNullOrEmpty(pall.pic4))
            //    return;
            //pall.com = "var body{0} = Drilling_IM({1}, {2}, {3}, {4}, {5}, {6});\r\n";
            //pall.pic = getname(pall.pic4);
            //pall.par = "prof,dg,dg1,x0,y0,z0";
            //Cylinder newForm = new Cylinder(pall);
            //this.Close();
            //this.Dispose();
            //newForm.ShowDialog();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            //if (string.IsNullOrEmpty(pall.pic5))
            //    return;
            //pall.com = "var body{0} = Drilling_BT({1}, {2}, {3}, {4}, {5}, {6}, {7});\r\n";
            //pall.pic = getname(pall.pic5);
            //pall.par = "d,pas,h,hf,x0,y0,z0";
            //Cylinder newForm = new Cylinder(pall);
            //this.Close();
            //this.Dispose();
            //newForm.ShowDialog();
        }

        private void Plane_Load(object sender, EventArgs e)
        {

        }
    }
}
