using JoinedTogether.Scenes;
using MewsToolbox;
using MewsToolbox.Input;
using MewsToolbox.Scenes;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System;

namespace JoinedTogether
{
    class Program : GameApp
    {
        static void Main(string[] args)
        {
            GameApp game = new Program();
            game.Run();
        }
        
        public Program(bool mouseVisible = true, int width = 1280, int height = 720)
            : base(mouseVisible, width, height)
        {
        }


        public override void PreInit()
        {
            ContentIndex.LoadContent(Content, GraphicsDevice);
        }

        public override void PostInit()
        {
            SceneManager.AddScene("GameScene", new GameScene());
        }

        protected override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
        }
    }
}
