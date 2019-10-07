namespace Assessment2Graphics
{
    partial class frmMain
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDrawHouse = new System.Windows.Forms.Button();
            this.panDraw = new System.Windows.Forms.Panel();
            this.btnDrawClear = new System.Windows.Forms.Button();
            this.lblAbout = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(12, 228);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDrawHouse
            // 
            this.btnDrawHouse.Location = new System.Drawing.Point(12, 51);
            this.btnDrawHouse.Name = "btnDrawHouse";
            this.btnDrawHouse.Size = new System.Drawing.Size(75, 23);
            this.btnDrawHouse.TabIndex = 1;
            this.btnDrawHouse.Text = "House";
            this.btnDrawHouse.UseVisualStyleBackColor = true;
            this.btnDrawHouse.Click += new System.EventHandler(this.btnDrawHouse_Click);
            // 
            // panDraw
            // 
            this.panDraw.BackColor = System.Drawing.Color.LightGray;
            this.panDraw.Location = new System.Drawing.Point(109, 51);
            this.panDraw.Name = "panDraw";
            this.panDraw.Size = new System.Drawing.Size(200, 200);
            this.panDraw.TabIndex = 4;
            // 
            // btnDrawClear
            // 
            this.btnDrawClear.Location = new System.Drawing.Point(12, 80);
            this.btnDrawClear.Name = "btnDrawClear";
            this.btnDrawClear.Size = new System.Drawing.Size(75, 23);
            this.btnDrawClear.TabIndex = 5;
            this.btnDrawClear.Text = "Clear";
            this.btnDrawClear.UseVisualStyleBackColor = true;
            this.btnDrawClear.Click += new System.EventHandler(this.btnDrawClear_Click);
            // 
            // lblAbout
            // 
            this.lblAbout.AutoSize = true;
            this.lblAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAbout.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblAbout.Location = new System.Drawing.Point(12, 13);
            this.lblAbout.Name = "lblAbout";
            this.lblAbout.Size = new System.Drawing.Size(240, 25);
            this.lblAbout.TabIndex = 6;
            this.lblAbout.Text = "Conor Lynch - CIT185593";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 263);
            this.Controls.Add(this.lblAbout);
            this.Controls.Add(this.btnDrawClear);
            this.Controls.Add(this.panDraw);
            this.Controls.Add(this.btnDrawHouse);
            this.Controls.Add(this.btnExit);
            this.DoubleBuffered = true;
            this.Name = "frmMain";
            this.Text = "2D Graphics";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDrawHouse;
        private System.Windows.Forms.Panel panDraw;
        private System.Windows.Forms.Button btnDrawClear;
        private System.Windows.Forms.Label lblAbout;
    }
}

