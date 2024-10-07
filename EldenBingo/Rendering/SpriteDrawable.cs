using SFML.Graphics;

namespace ObidoBingo.Rendering
{
    public class SpriteDrawable : Sprite, IDrawable
    {
        public SpriteDrawable(Texture tex) : base(tex)
        {
        }

        public bool Visible { get; set; } = true;
    }
}