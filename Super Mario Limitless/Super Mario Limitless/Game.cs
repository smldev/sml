using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

/// Comment blocks ("/* */") denote section headings.
/// Inline comments ("//") generally describe what's going on in that line.
/// {Material in braces} notates developer comments that are subject to be removed later, as they are really just ways for us to communicate with eachother.
/// 
/// SML Source, 2012 Stardust Fields and the Super Mario Limitless development team
/// http://sml.stardustfields.net/

namespace SML
{
    
    public class Game : Microsoft.Xna.Framework.Game
    {
        
        /* Variable initialization, used so that we can clean up and not dec/init in the same spot. */
        GraphicsDeviceManager graphics;
        SpriteBatch           spriteBatch;


        /* Game constructor method. */
        public Game()
        {
            int resolution; // This is a value tied to whatever window resolution the user has picked. {We should probably specify where they'd pick that. - Joey}

            graphics                           = new GraphicsDeviceManager(this);
            graphics.PreferredBackBufferWidth  = 256;
            graphics.PreferredBackBufferHeight = 224;
            
            Content.RootDirectory              = "Content";

            this.IsMouseVisible                = true;
        }

        
        /* Initialize SML and stuff, seems like that'd be necessary right? */
        protected override void Initialize()
        {
            base.Initialize();
        }


        /* Here we'll load all the game's content so we can actually do something. */
        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);
        }

        
        /* Unloading game content will happen once. */
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        
        /* This is where updating the game will happen. It's good to feed it logic so it doesn't try to argue with you like a 12 year old. */
        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed)
            {
                this.Exit();
            }

            base.Update(gameTime);
        }

        
        /* SML will draw itself here. */
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.White);

            base.Draw(gameTime);
        }

    }

}
