using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
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
    class Player : Entity
    {
        private Sprite<Animation> _sprite;
        private VirtualButton _jumpInput;
        private VirtualAxis _moveInput;

        public Player() : base("Player") { }

        enum Animation
        {
            Idle = 0,
            Run = 1,
            Hurt = 2,
        }

        public override void onAddedToScene()
        {
            base.onAddedToScene();

            var texture = scene.content.Load<Texture2D>(Content.Player.player);
            var subtextures = Subtexture.subtexturesFromAtlas(texture, 128, 128);

            var idleAnimation = new SpriteAnimation(new List<Subtexture>() {
                    subtextures[0],
                    subtextures[1],
                    subtextures[2],
                    subtextures[3],
                    subtextures[4],
                    subtextures[5],
                    subtextures[6],
                    subtextures[7]
            });

            var runAnimation = new SpriteAnimation(new List<Subtexture>() {
                    subtextures[8],
                    subtextures[9],
                    subtextures[10],
                    subtextures[11],
                    subtextures[12],
                    subtextures[13],
                    subtextures[14],
                    subtextures[15]
            });


            _sprite = addComponent(new Sprite<Animation>(subtextures[0]));
            _sprite.addAnimation(Animation.Idle, idleAnimation);
            _sprite.addAnimation(Animation.Run, runAnimation);


            _jumpInput = new VirtualButton();
            _jumpInput.nodes.Add(new Nez.VirtualButton.KeyboardKey(Keys.Space));
            _jumpInput.nodes.Add(new Nez.VirtualButton.KeyboardKey(Keys.W));
            _jumpInput.nodes.Add(new Nez.VirtualButton.GamePadButton(0, Buttons.A));

            _moveInput = new VirtualAxis();
            _moveInput.nodes.Add(new Nez.VirtualAxis.GamePadDpadLeftRight());
            _moveInput.nodes.Add(new Nez.VirtualAxis.GamePadLeftStickX());
            _moveInput.nodes.Add(new Nez.VirtualAxis.KeyboardKeys(VirtualInput.OverlapBehavior.TakeNewer, Keys.Left, Keys.Right));

            _sprite.play(Animation.Idle);
        }

        public override void update()
        {
            base.update();


        }
    }
}
