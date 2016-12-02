namespace Part_4_d
{
    partial class FormMediumm
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
            this.components = new System.ComponentModel.Container();
            this.btnStart = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnReset = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.lblClickNo1 = new System.Windows.Forms.Label();
            this.lblClickYes1 = new System.Windows.Forms.Label();
            this.lblClickNo = new System.Windows.Forms.Label();
            this.lblClickYes = new System.Windows.Forms.Label();
            this.lblRemainTime = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(629, 18);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(55, 25);
            this.btnStart.TabIndex = 26;
            this.btnStart.Text = "Başla";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(11, 18);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(497, 474);
            this.flowLayoutPanel1.TabIndex = 25;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(538, 38);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(55, 25);
            this.btnReset.TabIndex = 35;
            this.btnReset.Text = "Sıfırla";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnPause
            // 
            this.btnPause.Location = new System.Drawing.Point(728, 38);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(55, 25);
            this.btnPause.TabIndex = 34;
            this.btnPause.Text = "Duraklat";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // lblClickNo1
            // 
            this.lblClickNo1.AutoSize = true;
            this.lblClickNo1.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClickNo1.ForeColor = System.Drawing.Color.Red;
            this.lblClickNo1.Location = new System.Drawing.Point(626, 307);
            this.lblClickNo1.Name = "lblClickNo1";
            this.lblClickNo1.Size = new System.Drawing.Size(0, 23);
            this.lblClickNo1.TabIndex = 33;
            // 
            // lblClickYes1
            // 
            this.lblClickYes1.AutoSize = true;
            this.lblClickYes1.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClickYes1.ForeColor = System.Drawing.Color.Lime;
            this.lblClickYes1.Location = new System.Drawing.Point(626, 222);
            this.lblClickYes1.Name = "lblClickYes1";
            this.lblClickYes1.Size = new System.Drawing.Size(0, 23);
            this.lblClickYes1.TabIndex = 32;
            // 
            // lblClickNo
            // 
            this.lblClickNo.AutoSize = true;
            this.lblClickNo.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClickNo.Location = new System.Drawing.Point(590, 260);
            this.lblClickNo.Name = "lblClickNo";
            this.lblClickNo.Size = new System.Drawing.Size(100, 23);
            this.lblClickNo.TabIndex = 30;
            this.lblClickNo.Text = "Kaçırılan";
            // 
            // lblClickYes
            // 
            this.lblClickYes.AutoSize = true;
            this.lblClickYes.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClickYes.Location = new System.Drawing.Point(577, 183);
            this.lblClickYes.Name = "lblClickYes";
            this.lblClickYes.Size = new System.Drawing.Size(113, 23);
            this.lblClickYes.TabIndex = 29;
            this.lblClickYes.Text = "Yakalanan";
            // 
            // lblRemainTime
            // 
            this.lblRemainTime.AutoSize = true;
            this.lblRemainTime.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemainTime.Location = new System.Drawing.Point(514, 103);
            this.lblRemainTime.Name = "lblRemainTime";
            this.lblRemainTime.Size = new System.Drawing.Size(150, 18);
            this.lblRemainTime.TabIndex = 28;
            this.lblRemainTime.Text = "Kalan Zaman(Sn): ";
            // 
            // lblTime
            // 
            this.lblTime.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(703, 105);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(80, 25);
            this.lblTime.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(215, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 27;
            // 
            // FormMediumm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 504);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.lblClickNo1);
            this.Controls.Add(this.lblClickYes1);
            this.Controls.Add(this.lblClickNo);
            this.Controls.Add(this.lblClickYes);
            this.Controls.Add(this.lblRemainTime);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.label1);
            this.Name = "FormMediumm";
            this.Text = "FormMediumm";
            this.Load += new System.EventHandler(this.FormMediumm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Label lblClickNo1;
        private System.Windows.Forms.Label lblClickYes1;
        private System.Windows.Forms.Label lblClickNo;
        private System.Windows.Forms.Label lblClickYes;
        private System.Windows.Forms.Label lblRemainTime;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label label1;
    }
}