namespace testSystemClient
{
    partial class controlFormTeacher
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
            this.mainPanel = new System.Windows.Forms.Panel();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.closeBut = new System.Windows.Forms.Label();
            this.saveSelectedExam = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.titleTwo = new System.Windows.Forms.Label();
            this.uploadButton = new System.Windows.Forms.Button();
            this.mainPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(974, 929);
            this.label1.TabIndex = 1;
            this.label1.Text = "Authorization";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.mainPanel.Controls.Add(this.panel2);
            this.mainPanel.Controls.Add(this.title);
            this.mainPanel.Controls.Add(this.comboBox2);
            this.mainPanel.Controls.Add(this.label5);
            this.mainPanel.Controls.Add(this.label4);
            this.mainPanel.Controls.Add(this.comboBox1);
            this.mainPanel.Controls.Add(this.closeBut);
            this.mainPanel.Controls.Add(this.saveSelectedExam);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(974, 929);
            this.mainPanel.TabIndex = 2;
            this.mainPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mainPanel_MouseDown);
            this.mainPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mainPanel_MouseMove);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(374, 209);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(414, 33);
            this.comboBox2.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(93, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(223, 39);
            this.label5.TabIndex = 11;
            this.label5.Text = "Select Exam:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(93, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(247, 39);
            this.label4.TabIndex = 10;
            this.label4.Text = "Select student:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(374, 119);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(414, 33);
            this.comboBox1.TabIndex = 9;
            // 
            // closeBut
            // 
            this.closeBut.AutoSize = true;
            this.closeBut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeBut.ForeColor = System.Drawing.Color.Snow;
            this.closeBut.Location = new System.Drawing.Point(917, 0);
            this.closeBut.Name = "closeBut";
            this.closeBut.Size = new System.Drawing.Size(54, 53);
            this.closeBut.TabIndex = 6;
            this.closeBut.Text = "X";
            this.closeBut.Click += new System.EventHandler(this.closeBut_Click);
            // 
            // saveSelectedExam
            // 
            this.saveSelectedExam.BackColor = System.Drawing.Color.Green;
            this.saveSelectedExam.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveSelectedExam.FlatAppearance.BorderSize = 0;
            this.saveSelectedExam.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(37)))), ((int)(((byte)(91)))));
            this.saveSelectedExam.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(159)))), ((int)(((byte)(36)))));
            this.saveSelectedExam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveSelectedExam.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveSelectedExam.Location = new System.Drawing.Point(374, 318);
            this.saveSelectedExam.Name = "saveSelectedExam";
            this.saveSelectedExam.Size = new System.Drawing.Size(252, 73);
            this.saveSelectedExam.TabIndex = 5;
            this.saveSelectedExam.Text = "Save";
            this.saveSelectedExam.UseVisualStyleBackColor = false;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.Color.Azure;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.SystemColors.Highlight;
            this.title.Location = new System.Drawing.Point(160, 24);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(648, 63);
            this.title.TabIndex = 13;
            this.title.Text = "Choose Exam for student.";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SkyBlue;
            this.panel2.Controls.Add(this.uploadButton);
            this.panel2.Controls.Add(this.titleTwo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 498);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(974, 431);
            this.panel2.TabIndex = 14;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            // 
            // titleTwo
            // 
            this.titleTwo.AutoSize = true;
            this.titleTwo.BackColor = System.Drawing.Color.Azure;
            this.titleTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleTwo.ForeColor = System.Drawing.SystemColors.Highlight;
            this.titleTwo.Location = new System.Drawing.Point(137, 32);
            this.titleTwo.Name = "titleTwo";
            this.titleTwo.Size = new System.Drawing.Size(709, 63);
            this.titleTwo.TabIndex = 15;
            this.titleTwo.Text = "Upload test file to Data Base";
            // 
            // uploadButton
            // 
            this.uploadButton.BackColor = System.Drawing.Color.YellowGreen;
            this.uploadButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uploadButton.FlatAppearance.BorderSize = 0;
            this.uploadButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(37)))), ((int)(((byte)(91)))));
            this.uploadButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(159)))), ((int)(((byte)(36)))));
            this.uploadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uploadButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uploadButton.Location = new System.Drawing.Point(220, 194);
            this.uploadButton.Name = "uploadButton";
            this.uploadButton.Size = new System.Drawing.Size(538, 73);
            this.uploadButton.TabIndex = 16;
            this.uploadButton.Text = "Select with file to upload";
            this.uploadButton.UseVisualStyleBackColor = false;
            this.uploadButton.Click += new System.EventHandler(this.uploadButton_Click);
            // 
            // controlFormTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(974, 929);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "controlFormTeacher";
            this.Text = "controlFormTeacher";
            this.Load += new System.EventHandler(this.controlFormTeacher_Load);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Label closeBut;
        private System.Windows.Forms.Button saveSelectedExam;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button uploadButton;
        private System.Windows.Forms.Label titleTwo;
    }
}