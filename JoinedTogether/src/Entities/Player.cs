using MewsToolbox;
using MewsToolbox.Input;
using MewsToolbox.Utilities;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace JoinedTogether.Entities
{
    public class Player : Entity
    {
        Rectangle bbox;
        Vector2 position, velocity;
        const float MOVE_SPEED = 100;

        public Player()
        {
            position = new Vector2(100, 100);
            bbox = new Rectangle((int)position.X, (int)position.Y, 50, 50);
            velocity = Vector2.Zero;
        }

        public override void Update()
        {
            double time = GlobalTime.ElapsedGameTime / 1000;
            velocity.X = 0;
            velocity.Y = 0;
            if (InputManager.IsKeyDown(Keys.Down))
            {
                velocity.Y =  MOVE_SPEED * (float)time;
            }
            if (InputManager.IsKeyDown(Keys.Up))
            {
                velocity.Y = -MOVE_SPEED * (float)time;
            }
            if (InputManager.IsKeyDown(Keys.Left))
            {
                velocity.X = -MOVE_SPEED * (float)time;
            }
            if (InputManager.IsKeyDown(Keys.Right))
            {
                velocity.X =  MOVE_SPEED * (float)time;
            }
            position += velocity;
            bbox.Location = position.ToPoint();
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(ContentIndex.Pixel, bbox, Color.Blue);
        }

        public override bool CanDispose()
        {
            return false;
        }
    }
}
