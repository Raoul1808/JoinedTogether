using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;

namespace JoinedTogether
{
    public static class ContentIndex
    {
        public static Dictionary<string, Texture2D> Textures;
        public static Texture2D Pixel;

        public static void LoadContent(ContentManager Content, GraphicsDevice GD)
        {
            Pixel = new Texture2D(GD, 1, 1);
            Pixel.SetData(new Color[] { Color.White });

            Textures = new Dictionary<string, Texture2D>();
            List<string> textureNames = new List<string>()
            {

            };

            foreach (string asset in textureNames)
            {
                Textures.Add(asset, Content.Load<Texture2D>(asset));
            }
        }
    }
}
