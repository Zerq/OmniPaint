
namespace MonoPaintEditor
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.canvas1 = new MonoPaintEditor.Canvas();
            this.panel1 = new System.Windows.Forms.Panel();
            this.colorPalleteListView = new System.Windows.Forms.ListView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Files = new System.Windows.Forms.ToolStripMenuItem();
            this.SavePallet = new System.Windows.Forms.ToolStripMenuItem();
            this.loadPallet = new System.Windows.Forms.ToolStripMenuItem();
            this.addColor = new System.Windows.Forms.ToolStripMenuItem();
            this.removeColor = new System.Windows.Forms.ToolStripMenuItem();
            this.backColorIndicator = new System.Windows.Forms.Panel();
            this.foreColorIndicator = new System.Windows.Forms.Panel();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.panel2 = new System.Windows.Forms.Panel();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.panel3 = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.savePalletFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openPalletFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.panel4 = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.addLayerButton = new System.Windows.Forms.ToolStripMenuItem();
            this.removeLayerButton = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.panel4.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // canvas1
            // 
            this.canvas1.BackColor = System.Drawing.SystemColors.Highlight;
            this.canvas1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.canvas1.Location = new System.Drawing.Point(0, 0);
            this.canvas1.Name = "canvas1";
            this.canvas1.Size = new System.Drawing.Size(1516, 509);
            this.canvas1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.colorPalleteListView);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Controls.Add(this.backColorIndicator);
            this.panel1.Controls.Add(this.foreColorIndicator);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 548);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1516, 137);
            this.panel1.TabIndex = 2;
            // 
            // colorPalleteListView
            // 
            this.colorPalleteListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.colorPalleteListView.Dock = System.Windows.Forms.DockStyle.Top;
            this.colorPalleteListView.GridLines = true;
            this.colorPalleteListView.HideSelection = false;
            this.colorPalleteListView.Location = new System.Drawing.Point(66, 24);
            this.colorPalleteListView.Margin = new System.Windows.Forms.Padding(0);
            this.colorPalleteListView.Name = "colorPalleteListView";
            this.colorPalleteListView.Size = new System.Drawing.Size(1450, 85);
            this.colorPalleteListView.TabIndex = 2;
            this.colorPalleteListView.TileSize = new System.Drawing.Size(32, 32);
            this.colorPalleteListView.UseCompatibleStateImageBehavior = false;
            this.colorPalleteListView.SelectedIndexChanged += new System.EventHandler(this.colorPalleteListView_SelectedIndexChanged);
            this.colorPalleteListView.Click += new System.EventHandler(this.colorPalleteListView_Click);
            this.colorPalleteListView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.colorPalleteListView_MouseClick);
            this.colorPalleteListView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.colorPalleteListView_MouseDoubleClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Files,
            this.addColor,
            this.removeColor});
            this.menuStrip1.Location = new System.Drawing.Point(66, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1450, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // Files
            // 
            this.Files.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SavePallet,
            this.loadPallet});
            this.Files.Name = "Files";
            this.Files.Size = new System.Drawing.Size(42, 20);
            this.Files.Text = "Files";
            // 
            // SavePallet
            // 
            this.SavePallet.Name = "SavePallet";
            this.SavePallet.Size = new System.Drawing.Size(154, 22);
            this.SavePallet.Text = "Save PalletItem";
            // 
            // loadPallet
            // 
            this.loadPallet.Name = "loadPallet";
            this.loadPallet.Size = new System.Drawing.Size(154, 22);
            this.loadPallet.Text = "Load Pallet";
            // 
            // addColor
            // 
            this.addColor.Name = "addColor";
            this.addColor.Size = new System.Drawing.Size(73, 20);
            this.addColor.Text = "Add Color";
            // 
            // removeColor
            // 
            this.removeColor.Name = "removeColor";
            this.removeColor.Size = new System.Drawing.Size(94, 20);
            this.removeColor.Text = "Remove Color";
            // 
            // backColorIndicator
            // 
            this.backColorIndicator.BackColor = System.Drawing.Color.White;
            this.backColorIndicator.Dock = System.Windows.Forms.DockStyle.Left;
            this.backColorIndicator.Location = new System.Drawing.Point(33, 0);
            this.backColorIndicator.Name = "backColorIndicator";
            this.backColorIndicator.Size = new System.Drawing.Size(33, 137);
            this.backColorIndicator.TabIndex = 6;
            // 
            // foreColorIndicator
            // 
            this.foreColorIndicator.BackColor = System.Drawing.Color.Black;
            this.foreColorIndicator.Dock = System.Windows.Forms.DockStyle.Left;
            this.foreColorIndicator.Location = new System.Drawing.Point(0, 0);
            this.foreColorIndicator.Name = "foreColorIndicator";
            this.foreColorIndicator.Size = new System.Drawing.Size(33, 137);
            this.foreColorIndicator.TabIndex = 5;
            // 
            // trackBar2
            // 
            this.trackBar2.AutoSize = false;
            this.trackBar2.Dock = System.Windows.Forms.DockStyle.Right;
            this.trackBar2.Location = new System.Drawing.Point(1475, 0);
            this.trackBar2.Maximum = 0;
            this.trackBar2.Minimum = -10;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar2.RightToLeftLayout = true;
            this.trackBar2.Size = new System.Drawing.Size(41, 509);
            this.trackBar2.TabIndex = 4;
            this.trackBar2.TickStyle = System.Windows.Forms.TickStyle.Both;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.trackBar1);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 509);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1516, 39);
            this.panel2.TabIndex = 5;
            // 
            // trackBar1
            // 
            this.trackBar1.AutoSize = false;
            this.trackBar1.BackColor = System.Drawing.SystemColors.Control;
            this.trackBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackBar1.Location = new System.Drawing.Point(0, 0);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(1475, 39);
            this.trackBar1.TabIndex = 4;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.Both;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(1475, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(41, 39);
            this.panel3.TabIndex = 5;
            // 
            // toolStrip1
            // 
            this.toolStrip1.AllowMerge = false;
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(46, 509);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            this.toolStrip1.Click += new System.EventHandler(this.toolStrip1_Click);
            // 
            // savePalletFileDialog
            // 
            this.savePalletFileDialog.Filter = "Omnicat Pallet File|*.opf";
            // 
            // openPalletFileDialog
            // 
            this.openPalletFileDialog.FileName = "resources/default.opf";
            this.openPalletFileDialog.Filter = "Omnicat Pallet File|*.opf";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel4.Controls.Add(this.listView1);
            this.panel4.Controls.Add(this.menuStrip2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(1526, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(178, 685);
            this.panel4.TabIndex = 7;
            // 
            // listView1
            // 
            this.listView1.CheckBoxes = true;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 24);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(178, 661);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "👁";
            this.columnHeader3.Width = 100;
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.Color.Teal;
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter1.Location = new System.Drawing.Point(1516, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(10, 685);
            this.splitter1.TabIndex = 8;
            this.splitter1.TabStop = false;
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addLayerButton,
            this.removeLayerButton});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(178, 24);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            this.menuStrip2.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip2_ItemClicked);
            // 
            // addLayerButton
            // 
            this.addLayerButton.Name = "addLayerButton";
            this.addLayerButton.Size = new System.Drawing.Size(72, 20);
            this.addLayerButton.Text = "Add Layer";
            // 
            // removeLayerButton
            // 
            this.removeLayerButton.Name = "removeLayerButton";
            this.removeLayerButton.Size = new System.Drawing.Size(93, 20);
            this.removeLayerButton.Text = "Remove Layer";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1704, 685);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.trackBar2);
            this.Controls.Add(this.canvas1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Canvas canvas1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView colorPalleteListView;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Files;
        private System.Windows.Forms.ToolStripMenuItem SavePallet;
        private System.Windows.Forms.ToolStripMenuItem loadPallet;
        private System.Windows.Forms.ToolStripMenuItem addColor;
        private System.Windows.Forms.ToolStripMenuItem removeColor;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.SaveFileDialog savePalletFileDialog;
        private System.Windows.Forms.OpenFileDialog openPalletFileDialog;
        private System.Windows.Forms.Panel backColorIndicator;
        private System.Windows.Forms.Panel foreColorIndicator;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem addLayerButton;
        private System.Windows.Forms.ToolStripMenuItem removeLayerButton;
    }
}

