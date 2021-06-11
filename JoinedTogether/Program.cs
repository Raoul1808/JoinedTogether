using JoinedTogether.Scenes;
using MewsToolbox;
using MewsToolbox.Input;
using MewsToolbox.Scenes;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace JoinedTogether
{
    class Program : Game
    {
        static void Main(string[] args)
        {
            Game game = new Program();
            game.Run();
        }

        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        RenderTarget2D Canvas;

        public static int WindowScale = 4;
        public const int GAME_WIDTH = 320;
        public const int GAME_HEIGHT = 180;

        public Program()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            graphics.PreferredBackBufferWidth = WindowScale * GAME_WIDTH;
            graphics.PreferredBackBufferHeight = WindowScale * GAME_HEIGHT;
            graphics.ApplyChanges();
        }

        protected override void Initialize()
        {
            GlobalTime.Initialize();
            InputManager.Initialize();
            SceneManager.Initialize();
            base.Initialize();
        }

        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);
            ContentIndex.LoadContent(Content, GraphicsDevice);

            Canvas = new RenderTarget2D(GraphicsDevice, GAME_WIDTH, GAME_HEIGHT);

            SceneManager.AddScene("GameScene", new GameScene());
        }

        protected override void Update(GameTime gameTime)
        {
            GlobalTime.UpdateTime(gameTime);
            InputManager.Update();
            SceneManager.UpdateScenes();
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.SetRenderTarget(Canvas);
            GraphicsDevice.Clear(Color.Black);
            spriteBatch.Begin(SpriteSortMode.Deferred, BlendState.AlphaBlend, SamplerState.PointClamp, DepthStencilState.Default, RasterizerState.CullNone);
            SceneManager.DrawScenes(spriteBatch);
            spriteBatch.End();

            GraphicsDevice.SetRenderTarget(null);
            GraphicsDevice.Clear(Color.Black);
            spriteBatch.Begin(SpriteSortMode.Deferred, BlendState.AlphaBlend, SamplerState.PointClamp, DepthStencilState.Default, RasterizerState.CullNone);
            spriteBatch.Draw(Canvas, Vector2.Zero, null, Color.White, 0f, Vector2.Zero, WindowScale, SpriteEffects.None, 0f);
            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
