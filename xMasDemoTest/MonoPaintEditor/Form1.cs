using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonoPaintEditor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            EditorToolUIItem.GetInstances().OrderBy(n=> n.Order).ToList().ForEach(n => {
                toolStrip1.Items.Add(n);            
            });
            toolStrip1.Width =64;

            Files.DropDownItemClicked += Files_DropDownItemClicked;

            var palletPath = $@"{Application.StartupPath}resources\default.opf";

            var json = File.ReadAllText(palletPath);

            List<Color> colors = new List<Color>();
            JsonConvert.PopulateObject(json, colors);


            colors.ForEach(AddColorToPallet);

        }


        private void AddColorToPallet(Color c) {
            colorPalleteListView.Items.Add(new ListViewItem("   ") { ToolTipText = ColorTranslator.ToHtml(c), BackColor = c, ForeColor = c });
        }




        // Canvas canvas;
        private void Form1_Load(object sender, EventArgs e)
        {

            //  canvas = new Canvas() { Top = 0, Left = 0 };
            //  this.Controls.Add(canvas);



        }

        private void canvas2_Click(object sender, EventArgs e)
        {

        }

        private void toolStrip1_Click(object sender, EventArgs e)
        {

        }

        private EditorTool ActiveTool {
            get {
                var temp = toolStrip1.Items.Cast<EditorToolUIItem>();
                return temp.First<EditorToolUIItem>(n => n.Checked).Tool;
            }
        }
        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

            foreach (EditorToolUIItem button in toolStrip1.Items) {
                button.Checked = false;
            }

            ((EditorToolUIItem)e.ClickedItem).Checked = true;
        }



        private void Files_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem == SavePallet)
            {
                if (savePalletFileDialog.ShowDialog() == DialogResult.OK)
                {

                    List<Color> colors = new List<Color>();


                    foreach (ListViewItem item in colorPalleteListView.Items)
                    {
                        colors.Add(item.BackColor);
                    }

                    var json = JsonConvert.SerializeObject(colors);
                    File.WriteAllText(savePalletFileDialog.FileName, json);
                }
            }
            else
         if (e.ClickedItem == loadPallet)
            {
                if (openPalletFileDialog.ShowDialog() == DialogResult.OK)
                {
                  
                }

            }
        }
        private void colorPalleteListView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (colorPalleteListView.SelectedItems.Count == 1) {
                var item = colorPalleteListView.SelectedItems[0];
                colorDialog1.Color  = item.BackColor;
                if (colorDialog1.ShowDialog() == DialogResult.OK) {

                    item.ToolTipText = ColorTranslator.ToHtml(colorDialog1.Color);
                    item.BackColor = colorDialog1.Color;
                    item.ForeColor = colorDialog1.Color;
                                  
                }
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
     
            if (e.ClickedItem == addColor)
            {
                if (colorDialog1.ShowDialog() == DialogResult.OK)
                {

                    AddColorToPallet(colorDialog1.Color);

                }
            }
            else if (e.ClickedItem == removeColor) {
                if (colorPalleteListView.SelectedItems.Count > 0) {

                    List<ListViewItem> items = new List<ListViewItem>();
                  for(var i= 0; i< colorPalleteListView.SelectedItems.Count; i++) {
                        items.Add(colorPalleteListView.SelectedItems[i]);
                    }

                    items.ForEach(n => colorPalleteListView.Items.Remove(n));

                }            
            }


 
 
        }

        private void colorPalleteListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void colorPalleteListView_Click(object sender, EventArgs e)
        {
         
        }

        private void colorPalleteListView_MouseClick(object sender, MouseEventArgs e)
        {
            if (colorPalleteListView.SelectedItems.Count == 1 && e.Button == MouseButtons.Left)
            {
                foreColorIndicator.BackColor = colorPalleteListView.SelectedItems[0].BackColor;
            }
            else if (colorPalleteListView.SelectedItems.Count == 1 && e.Button == MouseButtons.Right)
            {
                backColorIndicator.BackColor = colorPalleteListView.SelectedItems[0].BackColor;
            }
        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
