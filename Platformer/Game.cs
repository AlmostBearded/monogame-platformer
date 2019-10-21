using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Nez;
using Nez.Console;

namespace Platformer
{
    public class Game : Nez.Core
    {
        public Game() : base(320, 240, false, true, "Platformer", "Content") { }

        protected override void Initialize()
        {
            base.Initialize();

            Window.AllowUserResizing = true;
            DebugConsole.consoleKey = Keys.F1;

            var gameScene = new GameScene();

            scene = gameScene;
        }
    }
}
