using UnityEngine;

namespace Snake_MVVM.Model
{
    public interface IPiece
    {
        Vector2 Position { get; set; }
        Vector2 NextPosition { get; set; }

    }
}
