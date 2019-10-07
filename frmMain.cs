/**
*** Author: Conor Lynch CIT185593
*** Date: 07/10/2019
*** IDE: Microsoft Visual Studio Enterprise 2017
*** IDE Version: 15.9.6
*** Software: Microsoft .NET Framework
*** Software Version: 4.7.02558
*** Platform: Microsoft Windows 8.1 64-bit
*** Platform Version: 6.3.9600 Build 9600
*** Project: Assessment02
*** Objective: Creation of a drag and drop image display application 
**/

using System;
using System.Drawing;
using System.Windows.Forms;

namespace Assessment2DragDrop
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmMain_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void frmMain_DragDrop(object sender, DragEventArgs e)
        {
            string[] fileName = (string[])e.Data.GetData(DataFormats.FileDrop, false);

            try
            {
                foreach (string File in fileName)
                    picBox.Image = Image.FromFile(File);//
            }
            catch
            {
                MessageBox.Show("Not a valid image");
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.DragEnter += new DragEventHandler(frmMain_DragEnter);
            this.DragDrop += new DragEventHandler(frmMain_DragDrop);
        }
    }
}
