using Microsoft.Xna.Framework.Graphics;
using System.IO;
using StardewModdingAPI;

namespace iTile.Core
{
    public class AssetsManager : Manager
    {
        public static readonly string assetsDir = "assets";
        public static readonly string texturesDir = Path.Combine(assetsDir, "textures");
        public static readonly string fontsDir = Path.Combine(assetsDir, "fonts");
        public Texture2D defaultTexture;
        public SpriteFont defaultFont;

        public AssetsManager()
        {
            Init();
        }

        public override void Init()
        {
            defaultTexture = LoadTexture("texture.png");
            defaultFont = LoadFont("Verdana.xnb");
        }

        public Texture2D LoadTexture(string name)
        {
            return Helper.Content.Load<Texture2D>(Path.Combine(texturesDir, name), ContentSource.ModFolder);
        }

        public SpriteFont LoadFont(string name)
        {
            return Helper.Content.Load<SpriteFont>(Path.Combine(fontsDir, name), ContentSource.ModFolder);
        }
    }
}
