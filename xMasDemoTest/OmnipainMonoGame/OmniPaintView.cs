using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
namespace OmnipainMonoGame
{
    public class OmniPaintView : MonoGame.Forms  {
       

        string WelcomeMessage = "Zog blarg hgar fragl!";
  
       
        public OmniPaintView() {
  
          
                }

        protected override void Initialize()
        {
            base.Initialize();
       
        
        }
    
      

        protected override void Draw()
        {
            

            base.Draw();
            Editor.spriteBatch.Begin();
     
          // 

            /*
            Editor.spriteBatch.DrawString(Editor.Font, WelcomeMessage, new Vector2(
                (Editor.graphics.Viewport.Width / 2) - (Editor.Font.MeasureString(WelcomeMessage).X / 2),
                (Editor.graphics.Viewport.Height / 2) - (Editor.FontHeight / 2)),
                Color.White);
            */
            Editor.spriteBatch.End();
        }
        protected override void Update(GameTime gameTime)
        {
      

        }
    }
}
