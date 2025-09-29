using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace DungeonSlime;

public class Game1 : Game
{
    private int updateCounter = 0;
    private int drawCounter = 0;
    private GraphicsDeviceManager _graphics;
    private SpriteBatch _spriteBatch;

    public Game1()
    {
        _graphics = new GraphicsDeviceManager(this);
        Content.RootDirectory = "Content";
        IsMouseVisible = true;
    }

    protected override void LoadContent()
    {
        _spriteBatch = new SpriteBatch(GraphicsDevice);
    }

    protected override void Update(GameTime gameTime)
    {
        updateCounter++;
        Console.WriteLine("Updating " + updateCounter);
        var isBackPressed = GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed;
        var isEscapePressed = Keyboard.GetState().IsKeyDown(Keys.Escape);

        if (isBackPressed || isEscapePressed)
        {
            Exit();
        }

        base.Update(gameTime);
    }

    protected override void Draw(GameTime gameTime)
    {
        drawCounter++;
        Console.WriteLine("Drawing " + drawCounter);
        GraphicsDevice.Clear(Color.CornflowerBlue);
        base.Draw(gameTime);
    }
}