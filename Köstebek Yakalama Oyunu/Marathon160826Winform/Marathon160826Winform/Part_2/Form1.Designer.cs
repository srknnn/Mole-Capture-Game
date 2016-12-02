namespace Part_2
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.txtBxFirstName = new System.Windows.Forms.TextBox();
            this.txtBxLastName = new System.Windows.Forms.TextBox();
            this.txtBxSpecialShoot = new System.Windows.Forms.TextBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.cmbBxTeams = new System.Windows.Forms.ComboBox();
            this.nmrcUpDwnShoting = new System.Windows.Forms.NumericUpDown();
            this.nmrcUpDwnPassing = new System.Windows.Forms.NumericUpDown();
            this.nmrcUpDwnDribbling = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcUpDwnShoting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcUpDwnPassing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcUpDwnDribbling)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(16, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Player";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "FirstName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "LastName";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "DateOfBirth";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Team";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 271);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "SpecialShoot";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(40, 300);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Shooting";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(45, 331);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Passing";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(41, 355);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Dribbling";
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(151, 27);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(160, 38);
            this.btnCreate.TabIndex = 10;
            this.btnCreate.Text = "Ekle";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(363, 27);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(127, 38);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(535, 27);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(128, 38);
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(275, 104);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(556, 277);
            this.listBox1.TabIndex = 13;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // txtBxFirstName
            // 
            this.txtBxFirstName.Location = new System.Drawing.Point(128, 161);
            this.txtBxFirstName.Name = "txtBxFirstName";
            this.txtBxFirstName.Size = new System.Drawing.Size(105, 20);
            this.txtBxFirstName.TabIndex = 18;
            // 
            // txtBxLastName
            // 
            this.txtBxLastName.Location = new System.Drawing.Point(128, 191);
            this.txtBxLastName.Name = "txtBxLastName";
            this.txtBxLastName.Size = new System.Drawing.Size(105, 20);
            this.txtBxLastName.TabIndex = 20;
            // 
            // txtBxSpecialShoot
            // 
            this.txtBxSpecialShoot.Location = new System.Drawing.Point(128, 268);
            this.txtBxSpecialShoot.Name = "txtBxSpecialShoot";
            this.txtBxSpecialShoot.Size = new System.Drawing.Size(105, 20);
            this.txtBxSpecialShoot.TabIndex = 26;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(128, 219);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(105, 20);
            this.dateTimePicker.TabIndex = 33;
            // 
            // cmbBxTeams
            // 
            this.cmbBxTeams.FormattingEnabled = true;
            this.cmbBxTeams.Items.AddRange(new object[] {
            "Fenerbahçe",
            "Galatasaray",
            "Beşiktaş ",
            "KonyaSpor ",
            "Arsenal",
            "Manchaster United",
            "Barça ",
            "Real"});
            this.cmbBxTeams.Location = new System.Drawing.Point(128, 245);
            this.cmbBxTeams.Name = "cmbBxTeams";
            this.cmbBxTeams.Size = new System.Drawing.Size(105, 21);
            this.cmbBxTeams.TabIndex = 34;
            // 
            // nmrcUpDwnShoting
            // 
            this.nmrcUpDwnShoting.Location = new System.Drawing.Point(129, 298);
            this.nmrcUpDwnShoting.Name = "nmrcUpDwnShoting";
            this.nmrcUpDwnShoting.Size = new System.Drawing.Size(104, 20);
            this.nmrcUpDwnShoting.TabIndex = 35;
            // 
            // nmrcUpDwnPassing
            // 
            this.nmrcUpDwnPassing.Location = new System.Drawing.Point(128, 329);
            this.nmrcUpDwnPassing.Name = "nmrcUpDwnPassing";
            this.nmrcUpDwnPassing.Size = new System.Drawing.Size(105, 20);
            this.nmrcUpDwnPassing.TabIndex = 36;
            // 
            // nmrcUpDwnDribbling
            // 
            this.nmrcUpDwnDribbling.Location = new System.Drawing.Point(128, 353);
            this.nmrcUpDwnDribbling.Name = "nmrcUpDwnDribbling";
            this.nmrcUpDwnDribbling.Size = new System.Drawing.Size(105, 20);
            this.nmrcUpDwnDribbling.TabIndex = 37;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(48, 125);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(18, 13);
            this.label10.TabIndex = 38;
            this.label10.Text = "ID";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 408);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.nmrcUpDwnDribbling);
            this.Controls.Add(this.nmrcUpDwnPassing);
            this.Controls.Add(this.nmrcUpDwnShoting);
            this.Controls.Add(this.cmbBxTeams);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.txtBxSpecialShoot);
            this.Controls.Add(this.txtBxLastName);
            this.Controls.Add(this.txtBxFirstName);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nmrcUpDwnShoting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcUpDwnPassing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcUpDwnDribbling)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox txtBxFirstName;
        private System.Windows.Forms.TextBox txtBxLastName;
        private System.Windows.Forms.TextBox txtBxSpecialShoot;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.ComboBox cmbBxTeams;
        private System.Windows.Forms.NumericUpDown nmrcUpDwnShoting;
        private System.Windows.Forms.NumericUpDown nmrcUpDwnPassing;
        private System.Windows.Forms.NumericUpDown nmrcUpDwnDribbling;
        private System.Windows.Forms.Label label10;
    }
}

