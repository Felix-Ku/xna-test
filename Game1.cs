using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    // Main game loop
    public class Game1 : Microsoft.Xna.Framework.Game
    {
        // Represents the player 
        Player player; /// Create instance of player class

        // Initialize the player class
        player = new Player(); /// Initialize new player for memory ready to store

        // Load player graphic and set initial positions
        protected override void LoadContent()
        {
            // Load the player resources 
            Vector2 playerPosition = new Vector2(GraphicsDevice.Viewport.TitleSafeArea.X, GraphicsDevice.Viewport.TitleSafeArea.Y + GraphicsDevice.Viewport.TitleSafeArea.Height / 2);
            player.Initialize(Content.Load<Texture2D>("player"), playerPosition);
        }

        // For drawing anything inside game loop
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue)
            
            // Start drawing
            spriteBatch.Begin();

            // Draw the Player
            player.Draw(spriteBatch);

            // Stop drawing
            spriteBatch.End();
        }
    }

}
