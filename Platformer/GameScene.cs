using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Nez;
using Nez.Sprites;
using Nez.Textures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Platformer
{
  class GameScene : Nez.Scene
  {
    public GameScene() : base() {
      clearColor = Color.BurlyWood;
    }

    public override void initialize()
    {
      base.initialize();

      var player = addEntity(new Player());
      player.position = new Vector2(160, 120);
    }
  }
}
