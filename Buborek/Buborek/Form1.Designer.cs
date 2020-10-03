namespace Buborek
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
            this.vaszon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.vaszon)).BeginInit();
            this.SuspendLayout();
            // 
            // vaszon
            // 
            this.vaszon.Location = new System.Drawing.Point(-2, 2);
            this.vaszon.Name = "vaszon";
            this.vaszon.Size = new System.Drawing.Size(801, 445);
            this.vaszon.TabIndex = 0;
            this.vaszon.TabStop = false;
            this.vaszon.Click += new System.EventHandler(this.vaszon_Click);
            this.vaszon.Paint += new System.Windows.Forms.PaintEventHandler(this.vaszon_Paint);
            this.vaszon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.vaszon_MouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.vaszon);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.vaszon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox vaszon;
    }
}

