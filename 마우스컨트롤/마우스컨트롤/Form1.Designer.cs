namespace 마우스컨트롤
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.panel15 = new System.Windows.Forms.Panel();
            this.panel16 = new System.Windows.Forms.Panel();
            this.panel17 = new System.Windows.Forms.Panel();
            this.panel18 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Location = new System.Drawing.Point(77, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(52, 221);
            this.panel1.TabIndex = 0;
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 478);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Location = new System.Drawing.Point(102, 291);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(52, 287);
            this.panel2.TabIndex = 2;
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Location = new System.Drawing.Point(208, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(52, 269);
            this.panel3.TabIndex = 3;
            this.panel3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseMove);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel4.Location = new System.Drawing.Point(208, 344);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(52, 234);
            this.panel4.TabIndex = 4;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel5.Location = new System.Drawing.Point(312, 225);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(52, 353);
            this.panel5.TabIndex = 1;
            this.panel5.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel5_MouseMove);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(-6, 529);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "START";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel6.Location = new System.Drawing.Point(312, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(52, 165);
            this.panel6.TabIndex = 1;
            this.panel6.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel6_MouseMove);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel7.Location = new System.Drawing.Point(428, 413);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(52, 165);
            this.panel7.TabIndex = 2;
            this.panel7.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel7_MouseMove);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel8.Location = new System.Drawing.Point(428, 2);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(52, 358);
            this.panel8.TabIndex = 2;
            this.panel8.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel8_MouseMove);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Script", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1005, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 38);
            this.label2.TabIndex = 0;
            this.label2.Text = "END";
            this.label2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.label2_MouseClick);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel9.Location = new System.Drawing.Point(537, 360);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(52, 218);
            this.panel9.TabIndex = 2;
            this.panel9.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel9_MouseMove);
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel10.Location = new System.Drawing.Point(522, 2);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(52, 299);
            this.panel10.TabIndex = 2;
            this.panel10.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel10_MouseMove);
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel11.Location = new System.Drawing.Point(649, 2);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(52, 335);
            this.panel11.TabIndex = 2;
            this.panel11.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel11_MouseMove);
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel12.Location = new System.Drawing.Point(628, 413);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(52, 165);
            this.panel12.TabIndex = 2;
            this.panel12.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel12_MouseMove);
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel13.Location = new System.Drawing.Point(754, 225);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(52, 353);
            this.panel13.TabIndex = 2;
            this.panel13.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel13_MouseMove);
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel14.Location = new System.Drawing.Point(820, 2);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(41, 196);
            this.panel14.TabIndex = 2;
            this.panel14.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel14_MouseMove);
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel15.Location = new System.Drawing.Point(735, 2);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(52, 158);
            this.panel15.TabIndex = 5;
            this.panel15.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel15_MouseMove);
            // 
            // panel16
            // 
            this.panel16.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel16.Location = new System.Drawing.Point(872, 382);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(43, 196);
            this.panel16.TabIndex = 3;
            this.panel16.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel16_MouseMove);
            // 
            // panel17
            // 
            this.panel17.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel17.Location = new System.Drawing.Point(921, 187);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(44, 196);
            this.panel17.TabIndex = 4;
            this.panel17.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel17_MouseMove);
            // 
            // panel18
            // 
            this.panel18.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel18.Location = new System.Drawing.Point(971, 187);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(39, 196);
            this.panel18.TabIndex = 5;
            this.panel18.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel18_MouseMove);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1082, 574);
            this.Controls.Add(this.panel18);
            this.Controls.Add(this.panel17);
            this.Controls.Add(this.panel16);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel15);
            this.Controls.Add(this.panel14);
            this.Controls.Add(this.panel13);
            this.Controls.Add(this.panel12);
            this.Controls.Add(this.panel11);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.Panel panel18;
    }
}

