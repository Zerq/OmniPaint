using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace MonoPaintEditor
{
    class Canvas :  UserControl //  MonoGame.Forms.Controls.MonoGameControl
    {/*
       private Texture2D blank;

        protected override void Initialize()
        {
         //   this.Editor.Content.Load<Texture2D>("");
       base.Initialize();
            blank = new Texture2D(this.Editor.graphics, 1, 1, true, SurfaceFormat.Color);
            blank.SetData<Color>(new Color[] { Color.White });
        }
        protected override void Update(GameTime gameTime)
        {
     
            //  throw new NotImplementedException();
        }
        protected override void Draw()
        {
            base.Draw();
       
        
            this.Editor.spriteBatch.Begin(Microsoft.Xna.Framework.Graphics.SpriteSortMode.Deferred);

            this.Editor.graphics.Clear(Color.CornflowerBlue);

            int x = 0;
            int y = 1;
            this.Editor.spriteBatch.Draw(blank, new Rectangle(x, y, x + 6, y + 6), new Rectangle(0, 0, 1, 1), Color.Red);

            this.Editor.spriteBatch.End();
     

        }
    */


        public bool MouseHoverUpdatesOnly = false;
    }
}
