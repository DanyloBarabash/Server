﻿namespace testSystemClient
{
    partial class questionForm
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
            this.label_question = new System.Windows.Forms.Label();
            this.label_result = new System.Windows.Forms.Label();
            this.button_next = new System.Windows.Forms.Button();
            this.radio_answer1 = new System.Windows.Forms.RadioButton();
            this.radio_answer2 = new System.Windows.Forms.RadioButton();
            this.radio_answer3 = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_question
            // 
            this.label_question.AutoSize = true;
            this.label_question.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_question.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_question.ForeColor = System.Drawing.Color.White;
            this.label_question.Location = new System.Drawing.Point(3, 0);
            this.label_question.Name = "label_question";
            this.label_question.Size = new System.Drawing.Size(1021, 110);
            this.label_question.TabIndex = 0;
            this.label_question.Text = "label1";
            this.label_question.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_result
            // 
            this.label_result.AutoSize = true;
            this.label_result.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_result.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_result.ForeColor = System.Drawing.Color.White;
            this.label_result.Location = new System.Drawing.Point(3, 596);
            this.label_result.Name = "label_result";
            this.label_result.Size = new System.Drawing.Size(1021, 78);
            this.label_result.TabIndex = 1;
            this.label_result.Text = "label2";
            this.label_result.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_next
            // 
            this.button_next.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_next.Location = new System.Drawing.Point(3, 500);
            this.button_next.Name = "button_next";
            this.button_next.Size = new System.Drawing.Size(1021, 93);
            this.button_next.TabIndex = 3;
            this.button_next.Text = "button1";
            this.button_next.UseVisualStyleBackColor = true;
            this.button_next.Click += new System.EventHandler(this.button_next_Click);
            // 
            // radio_answer1
            // 
            this.radio_answer1.AutoSize = true;
            this.radio_answer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radio_answer1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radio_answer1.ForeColor = System.Drawing.Color.White;
            this.radio_answer1.Location = new System.Drawing.Point(10, 120);
            this.radio_answer1.Margin = new System.Windows.Forms.Padding(10);
            this.radio_answer1.Name = "radio_answer1";
            this.radio_answer1.Size = new System.Drawing.Size(1007, 111);
            this.radio_answer1.TabIndex = 4;
            this.radio_answer1.TabStop = true;
            this.radio_answer1.Text = "radioButton1";
            this.radio_answer1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radio_answer1.UseVisualStyleBackColor = true;
            // 
            // radio_answer2
            // 
            this.radio_answer2.AutoSize = true;
            this.radio_answer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radio_answer2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radio_answer2.ForeColor = System.Drawing.Color.White;
            this.radio_answer2.Location = new System.Drawing.Point(10, 251);
            this.radio_answer2.Margin = new System.Windows.Forms.Padding(10);
            this.radio_answer2.Name = "radio_answer2";
            this.radio_answer2.Size = new System.Drawing.Size(1007, 115);
            this.radio_answer2.TabIndex = 5;
            this.radio_answer2.TabStop = true;
            this.radio_answer2.Text = "radioButton2";
            this.radio_answer2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radio_answer2.UseVisualStyleBackColor = true;
            // 
            // radio_answer3
            // 
            this.radio_answer3.AutoSize = true;
            this.radio_answer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radio_answer3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radio_answer3.ForeColor = System.Drawing.Color.White;
            this.radio_answer3.Location = new System.Drawing.Point(10, 386);
            this.radio_answer3.Margin = new System.Windows.Forms.Padding(10);
            this.radio_answer3.Name = "radio_answer3";
            this.radio_answer3.Size = new System.Drawing.Size(1007, 101);
            this.radio_answer3.TabIndex = 6;
            this.radio_answer3.TabStop = true;
            this.radio_answer3.Text = "radioButton3";
            this.radio_answer3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radio_answer3.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.label_question, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.radio_answer1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.radio_answer2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.radio_answer3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.button_next, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label_result, 0, 5);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(81, 41);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.51282F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.48718F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 135F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 121F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 99F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 77F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 93F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1027, 674);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // questionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(54)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(1207, 742);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "questionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "questionForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_question;
        private System.Windows.Forms.Label label_result;
        private System.Windows.Forms.Button button_next;
        private System.Windows.Forms.RadioButton radio_answer1;
        private System.Windows.Forms.RadioButton radio_answer2;
        private System.Windows.Forms.RadioButton radio_answer3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}