using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace MonoPaintEditor
{
    public class EditorTool
    {

    }


    
    public abstract class  EditorToolUIItem : ToolStripButton
    {

        private static List<EditorToolUIItem> instance;
        public static List<EditorToolUIItem> GetInstances() {

            if (instance == null)
            {
                var types = typeof(EditorToolUIItem).Assembly.GetTypes()
                     .Where(n => n.IsSubclassOf(typeof(EditorToolUIItem)));
                     instance = types.Select(t => (EditorToolUIItem) Activator.CreateInstance(t)).ToList();
            }
                return instance;

        }

        public EditorToolUIItem() {

         
            var rex = new Regex("([A-Z][^A-Z]*)");           
            foreach (Match m in rex.Matches(this.Tool.GetType().Name)) {
             this.ToolTipText +=   $"{m.Value} ";
            }
            Name = this.GetType().Name;
            var imagePath = $@"{Application.StartupPath}resources\{Name.ToLower()}.png";
            Image = Bitmap.FromFile(imagePath);
      
            Width = 32;
            Height= 32;
        }

        public abstract int Order { get; }
        public abstract EditorTool Tool { get; }


        public static List<EditorToolUIItem> Items { get; set; }

    }

    public class Pen : EditorTool { 
    
    }
    public  class PenUiItem : EditorToolUIItem {

        public PenUiItem() : base() {
 
        }
        public override EditorTool Tool => new Pen();

        public override int Order => 1;


    }


    public class Erasser : EditorTool
    {

    }
    public class ErasserUItem : EditorToolUIItem
    {

        public ErasserUItem() : base()
        {

        }
        public override EditorTool Tool => new Erasser();

        public override int Order => 1;


    }
}
