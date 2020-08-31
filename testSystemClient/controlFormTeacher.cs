using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace testSystemClient
{
    public partial class controlFormTeacher : Form
    {
        public controlFormTeacher()
        {
            InitializeComponent();
        }

        private void controlFormTeacher_Load(object sender, EventArgs e)
        {

        }

        void panel1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                label1.Text = "Drop file.";
                e.Effect = DragDropEffects.Copy;
            }
        }

         void panel1_DragDrop(object sender, DragEventArgs e)
        {

            foreach (string file in (string[])e.Data.GetData(DataFormats.FileDrop))
            {
                string sourceFile = file;
                string destinationFile = @"C:\Users\SeedsPC\Desktop\Pizza";
                System.IO.File.Move(sourceFile, destinationFile);
                

            }
        }

         void panel1_DragLeave(object sender, EventArgs e)
        {

        }

        private void panel1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Title = "Select the question file";
            openFile.Filter = "Question File (*xml)|*xml";
            openFile.InitialDirectory = @"C:\Users\SeedsPC\Desktop";
            if(openFile.ShowDialog()==DialogResult.OK)
            {
                
            }
        }

        private void closeBut_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        Point lastPoint;
        private void mainPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void mainPanel_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void uploadButton_Click(object sender, EventArgs e)
        {
            chooseFileForm chff = new chooseFileForm();
            chff.Show();
        }
    }
}
