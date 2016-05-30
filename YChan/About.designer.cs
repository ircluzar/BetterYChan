namespace YChan {
    partial class About {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            this.btnAClose = new System.Windows.Forms.Button();
            this.rtAbout = new System.Windows.Forms.RichTextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnAClose
            // 
            this.btnAClose.Location = new System.Drawing.Point(139, 318);
            this.btnAClose.Name = "btnAClose";
            this.btnAClose.Size = new System.Drawing.Size(75, 23);
            this.btnAClose.TabIndex = 0;
            this.btnAClose.Text = "Close";
            this.btnAClose.UseVisualStyleBackColor = true;
            this.btnAClose.Click += new System.EventHandler(this.btnAClose_Click);
            // 
            // rtAbout
            // 
            this.rtAbout.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtAbout.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.rtAbout.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rtAbout.Location = new System.Drawing.Point(12, 80);
            this.rtAbout.Name = "rtAbout";
            this.rtAbout.ReadOnly = true;
            this.rtAbout.Size = new System.Drawing.Size(322, 232);
            this.rtAbout.TabIndex = 1;
            this.rtAbout.Text = resources.GetString("rtAbout.Text");
            this.rtAbout.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.rtAbout_LinkClicked);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.richTextBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.richTextBox1.Location = new System.Drawing.Point(12, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(322, 48);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "BetterYChan\n based on YChan 2.3 \n original credits be" +
    "low.";
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 351);
            this.ControlBox = false;
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.rtAbout);
            this.Controls.Add(this.btnAClose);
            this.Name = "About";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "About";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAClose;
        private System.Windows.Forms.RichTextBox rtAbout;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}