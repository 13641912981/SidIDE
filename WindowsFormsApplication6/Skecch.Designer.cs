namespace WindowsFormsApplication6
{
    partial class Skecch
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.Back = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Step1 = new System.Windows.Forms.TabPage();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.revolvelabel = new System.Windows.Forms.Label();
            this.Extrudelabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Z0 = new System.Windows.Forms.TextBox();
            this.Y0 = new System.Windows.Forms.TextBox();
            this.X0 = new System.Windows.Forms.TextBox();
            this.YZ = new System.Windows.Forms.Label();
            this.XZ = new System.Windows.Forms.Label();
            this.XY = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SetPointLabel = new System.Windows.Forms.Label();
            this.selectPlaneLabel = new System.Windows.Forms.Label();
            this.Step2 = new System.Windows.Forms.TabPage();
            this.Step3 = new System.Windows.Forms.TabPage();
            this.step3Pic = new System.Windows.Forms.PictureBox();
            this.Step1Next = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.Step1.SuspendLayout();
            this.Step3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.step3Pic)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.Back);
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Controls.Add(this.Step1Next);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(716, 495);
            this.panel1.TabIndex = 0;
            // 
            // Back
            // 
            this.Back.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.Back.Location = new System.Drawing.Point(470, 384);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(90, 40);
            this.Back.TabIndex = 1;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Step1);
            this.tabControl1.Controls.Add(this.Step2);
            this.tabControl1.Controls.Add(this.Step3);
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(667, 375);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // Step1
            // 
            this.Step1.Controls.Add(this.checkBox2);
            this.Step1.Controls.Add(this.checkBox1);
            this.Step1.Controls.Add(this.textBox2);
            this.Step1.Controls.Add(this.textBox1);
            this.Step1.Controls.Add(this.label7);
            this.Step1.Controls.Add(this.label6);
            this.Step1.Controls.Add(this.revolvelabel);
            this.Step1.Controls.Add(this.Extrudelabel);
            this.Step1.Controls.Add(this.label4);
            this.Step1.Controls.Add(this.label3);
            this.Step1.Controls.Add(this.label2);
            this.Step1.Controls.Add(this.label1);
            this.Step1.Controls.Add(this.Z0);
            this.Step1.Controls.Add(this.Y0);
            this.Step1.Controls.Add(this.X0);
            this.Step1.Controls.Add(this.YZ);
            this.Step1.Controls.Add(this.XZ);
            this.Step1.Controls.Add(this.XY);
            this.Step1.Controls.Add(this.label5);
            this.Step1.Controls.Add(this.SetPointLabel);
            this.Step1.Controls.Add(this.selectPlaneLabel);
            this.Step1.Location = new System.Drawing.Point(4, 22);
            this.Step1.Name = "Step1";
            this.Step1.Padding = new System.Windows.Forms.Padding(3);
            this.Step1.Size = new System.Drawing.Size(659, 349);
            this.Step1.TabIndex = 0;
            this.Step1.Text = "Step1";
            this.Step1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold);
            this.checkBox2.Location = new System.Drawing.Point(516, 276);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(71, 31);
            this.checkBox2.TabIndex = 14;
            this.checkBox2.Text = "对称";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold);
            this.checkBox1.Location = new System.Drawing.Point(429, 276);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(71, 31);
            this.checkBox1.TabIndex = 14;
            this.checkBox1.Text = "反向";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("微软雅黑", 15F);
            this.textBox2.ForeColor = System.Drawing.Color.Red;
            this.textBox2.Location = new System.Drawing.Point(497, 218);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(120, 34);
            this.textBox2.TabIndex = 12;
            this.textBox2.Text = "0";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("微软雅黑", 15F);
            this.textBox1.ForeColor = System.Drawing.Color.Red;
            this.textBox1.Location = new System.Drawing.Point(497, 175);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(120, 34);
            this.textBox1.TabIndex = 9;
            this.textBox1.Text = "50";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(424, 221);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 27);
            this.label7.TabIndex = 13;
            this.label7.Text = "角度：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(424, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 27);
            this.label6.TabIndex = 13;
            this.label6.Text = "距离：";
            // 
            // revolvelabel
            // 
            this.revolvelabel.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold);
            this.revolvelabel.Location = new System.Drawing.Point(424, 115);
            this.revolvelabel.Name = "revolvelabel";
            this.revolvelabel.Size = new System.Drawing.Size(193, 42);
            this.revolvelabel.TabIndex = 11;
            this.revolvelabel.Text = "Revolve";
            this.revolvelabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.revolvelabel.Click += new System.EventHandler(this.revolvelabel_Click);
            this.revolvelabel.MouseEnter += new System.EventHandler(this.revolvelabel_MouseEnter);
            this.revolvelabel.MouseLeave += new System.EventHandler(this.revolvelabel_MouseLeave);
            // 
            // Extrudelabel
            // 
            this.Extrudelabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(143)))), ((int)(((byte)(245)))));
            this.Extrudelabel.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold);
            this.Extrudelabel.ForeColor = System.Drawing.Color.White;
            this.Extrudelabel.Location = new System.Drawing.Point(424, 64);
            this.Extrudelabel.Name = "Extrudelabel";
            this.Extrudelabel.Size = new System.Drawing.Size(193, 42);
            this.Extrudelabel.TabIndex = 10;
            this.Extrudelabel.Text = "Extrude";
            this.Extrudelabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Extrudelabel.Click += new System.EventHandler(this.Extrudelabel_Click);
            this.Extrudelabel.MouseEnter += new System.EventHandler(this.Extrudelabel_MouseEnter);
            this.Extrudelabel.MouseLeave += new System.EventHandler(this.Extrudelabel_MouseLeave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(180, 264);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 27);
            this.label4.TabIndex = 9;
            this.label4.Text = "Z";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(124, 266);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 27);
            this.label3.TabIndex = 9;
            this.label3.Text = "Y";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(67, 266);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 27);
            this.label2.TabIndex = 9;
            this.label2.Text = "X";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(70, 264);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 27);
            this.label1.TabIndex = 9;
            this.label1.Text = "X";
            // 
            // Z0
            // 
            this.Z0.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Z0.Location = new System.Drawing.Point(166, 296);
            this.Z0.Name = "Z0";
            this.Z0.Size = new System.Drawing.Size(50, 34);
            this.Z0.TabIndex = 8;
            this.Z0.Text = "0";
            this.Z0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Y0
            // 
            this.Y0.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Y0.Location = new System.Drawing.Point(110, 296);
            this.Y0.Name = "Y0";
            this.Y0.Size = new System.Drawing.Size(50, 34);
            this.Y0.TabIndex = 7;
            this.Y0.Text = "0";
            this.Y0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // X0
            // 
            this.X0.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.X0.Location = new System.Drawing.Point(54, 296);
            this.X0.Name = "X0";
            this.X0.Size = new System.Drawing.Size(50, 34);
            this.X0.TabIndex = 6;
            this.X0.Text = "0";
            this.X0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // YZ
            // 
            this.YZ.BackColor = System.Drawing.Color.White;
            this.YZ.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.YZ.Location = new System.Drawing.Point(49, 167);
            this.YZ.Name = "YZ";
            this.YZ.Size = new System.Drawing.Size(193, 42);
            this.YZ.TabIndex = 5;
            this.YZ.Text = "Plane_YZ";
            this.YZ.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.YZ.Click += new System.EventHandler(this.YZ_Click);
            this.YZ.MouseEnter += new System.EventHandler(this.YZ_MouseEnter);
            this.YZ.MouseLeave += new System.EventHandler(this.YZ_MouseLeave);
            // 
            // XZ
            // 
            this.XZ.BackColor = System.Drawing.Color.White;
            this.XZ.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.XZ.Location = new System.Drawing.Point(49, 115);
            this.XZ.Name = "XZ";
            this.XZ.Size = new System.Drawing.Size(193, 42);
            this.XZ.TabIndex = 4;
            this.XZ.Text = "Plane_XZ";
            this.XZ.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.XZ.Click += new System.EventHandler(this.XZ_Click);
            this.XZ.MouseEnter += new System.EventHandler(this.XZ_MouseEnter);
            this.XZ.MouseLeave += new System.EventHandler(this.XZ_MouseLeave);
            // 
            // XY
            // 
            this.XY.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(143)))), ((int)(((byte)(245)))));
            this.XY.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.XY.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.XY.Location = new System.Drawing.Point(49, 64);
            this.XY.Name = "XY";
            this.XY.Size = new System.Drawing.Size(193, 42);
            this.XY.TabIndex = 3;
            this.XY.Text = "Plane_XY";
            this.XY.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.XY.Click += new System.EventHandler(this.XY_Click);
            this.XY.MouseEnter += new System.EventHandler(this.XY_MouseEnter);
            this.XY.MouseLeave += new System.EventHandler(this.XY_MouseLeave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(388, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(199, 39);
            this.label5.TabIndex = 1;
            this.label5.Text = "3. 拉伸or旋转";
            // 
            // SetPointLabel
            // 
            this.SetPointLabel.AutoSize = true;
            this.SetPointLabel.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SetPointLabel.Location = new System.Drawing.Point(16, 221);
            this.SetPointLabel.Name = "SetPointLabel";
            this.SetPointLabel.Size = new System.Drawing.Size(226, 39);
            this.SetPointLabel.TabIndex = 1;
            this.SetPointLabel.Text = "2. 设置草图原点";
            // 
            // selectPlaneLabel
            // 
            this.selectPlaneLabel.AutoSize = true;
            this.selectPlaneLabel.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.selectPlaneLabel.Location = new System.Drawing.Point(16, 17);
            this.selectPlaneLabel.Name = "selectPlaneLabel";
            this.selectPlaneLabel.Size = new System.Drawing.Size(226, 39);
            this.selectPlaneLabel.TabIndex = 1;
            this.selectPlaneLabel.Text = "1. 选择草绘平面";
            // 
            // Step2
            // 
            this.Step2.AutoScroll = true;
            this.Step2.Location = new System.Drawing.Point(4, 22);
            this.Step2.Name = "Step2";
            this.Step2.Padding = new System.Windows.Forms.Padding(3);
            this.Step2.Size = new System.Drawing.Size(659, 349);
            this.Step2.TabIndex = 1;
            this.Step2.Text = "Step2";
            this.Step2.UseVisualStyleBackColor = true;
            // 
            // Step3
            // 
            this.Step3.Controls.Add(this.step3Pic);
            this.Step3.Location = new System.Drawing.Point(4, 22);
            this.Step3.Name = "Step3";
            this.Step3.Padding = new System.Windows.Forms.Padding(3);
            this.Step3.Size = new System.Drawing.Size(659, 349);
            this.Step3.TabIndex = 2;
            this.Step3.Text = "Step3";
            this.Step3.UseVisualStyleBackColor = true;
            // 
            // step3Pic
            // 
            this.step3Pic.Location = new System.Drawing.Point(7, 7);
            this.step3Pic.Name = "step3Pic";
            this.step3Pic.Size = new System.Drawing.Size(646, 336);
            this.step3Pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.step3Pic.TabIndex = 0;
            this.step3Pic.TabStop = false;
            // 
            // Step1Next
            // 
            this.Step1Next.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Step1Next.Location = new System.Drawing.Point(576, 384);
            this.Step1Next.Name = "Step1Next";
            this.Step1Next.Size = new System.Drawing.Size(90, 40);
            this.Step1Next.TabIndex = 0;
            this.Step1Next.Text = "Next";
            this.Step1Next.UseVisualStyleBackColor = true;
            this.Step1Next.Click += new System.EventHandler(this.Step1Next_Click);
            // 
            // Skecch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 429);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Skecch";
            this.ShowIcon = false;
            this.Text = "Skecch";
            this.Load += new System.EventHandler(this.Skecch_Load);
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.Step1.ResumeLayout(false);
            this.Step1.PerformLayout();
            this.Step3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.step3Pic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Step1;
        private System.Windows.Forms.TabPage Step2;
        private System.Windows.Forms.Button Step1Next;
        private System.Windows.Forms.Label selectPlaneLabel;
        private System.Windows.Forms.Label YZ;
        private System.Windows.Forms.Label XZ;
        private System.Windows.Forms.Label XY;
        private System.Windows.Forms.Label SetPointLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Z0;
        private System.Windows.Forms.TextBox Y0;
        private System.Windows.Forms.TextBox X0;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.TabPage Step3;
        private System.Windows.Forms.PictureBox step3Pic;
        private System.Windows.Forms.Label Extrudelabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label revolvelabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}