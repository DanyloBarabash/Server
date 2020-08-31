namespace Server
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
            this.start_server = new System.Windows.Forms.Button();
            this.stop_server = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // start_server
            // 
            this.start_server.Location = new System.Drawing.Point(272, 33);
            this.start_server.Name = "start_server";
            this.start_server.Size = new System.Drawing.Size(197, 109);
            this.start_server.TabIndex = 0;
            this.start_server.Text = "Start Server";
            this.start_server.UseVisualStyleBackColor = true;
            this.start_server.Click += new System.EventHandler(this.start_server_Click);
            // 
            // stop_server
            // 
            this.stop_server.Location = new System.Drawing.Point(272, 270);
            this.stop_server.Name = "stop_server";
            this.stop_server.Size = new System.Drawing.Size(197, 89);
            this.stop_server.TabIndex = 1;
            this.stop_server.Text = "Stop Server";
            this.stop_server.UseVisualStyleBackColor = true;
            this.stop_server.Click += new System.EventHandler(this.stop_server_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.stop_server);
            this.Controls.Add(this.start_server);
            this.Name = "Form1";
            this.Text = "Server";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button start_server;
        private System.Windows.Forms.Button stop_server;
    }
}

