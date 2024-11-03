using SFML.Graphics;

namespace ObidoBingo.Rendering
{
    public interface IDrawable : Drawable
    {
        bool Visible { get; }

        FloatRect? GetBoundingBox() { return null; }

        void Init() { }

        void Dispose() { }
    }
}