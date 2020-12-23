
namespace OmnipainMonoGame
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
            this.omniPaintView1 = new OmnipainMonoGame.OmniPaintView();
            this.SuspendLayout();
            // 
            // omniPaintView1
            // 
            this.omniPaintView1.Location = new System.Drawing.Point(27, 22);
            this.omniPaintView1.MouseHoverUpdatesOnly = false;
            this.omniPaintView1.Name = "omniPaintView1";
            this.omniPaintView1.Size = new System.Drawing.Size(661, 372);
            this.omniPaintView1.TabIndex = 0;
            this.omniPaintView1.Text = "omniPaintView1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.omniPaintView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private OmniPaintView omniPaintView1;
    }
}

