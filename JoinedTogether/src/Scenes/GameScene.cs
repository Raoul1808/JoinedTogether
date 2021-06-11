using JoinedTogether.Entities;
using MewsToolbox.Scenes;
using Microsoft.Xna.Framework.Graphics;

namespace JoinedTogether.Scenes
{
    public class GameScene : Scene
    {
        Player player;

        public GameScene()
            : base()
        {
            player = new Player();
        }

        public override void Update()
        {
            player.Update();
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            player.Draw(spriteBatch);
        }
    }
}
