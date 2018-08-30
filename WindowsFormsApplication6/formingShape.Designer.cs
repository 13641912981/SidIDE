namespace WindowsFormsApplication6
{
    partial class formingShape
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
            this.Step2 = new System.Windows.Forms.TabPage();
            this.Step3 = new System.Windows.Forms.TabPage();
            this.step3Pic = new System.Windows.Forms.PictureBox();
            this.Step1Next = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
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
            this.tabControl1.Controls.Add(this.Step2);
            this.tabControl1.Controls.Add(this.Step3);
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(667, 375);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
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
            // formingShape
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 429);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formingShape";
            this.ShowIcon = false;
            this.Text = "Shape";
            this.Load += new System.EventHandler(this.Skecch_Load);
            this.Shown += new System.EventHandler(this.formingShape_Shown);
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.Step3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.step3Pic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Step2;
        private System.Windows.Forms.Button Step1Next;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.TabPage Step3;
        private System.Windows.Forms.PictureBox step3Pic;
    }
}