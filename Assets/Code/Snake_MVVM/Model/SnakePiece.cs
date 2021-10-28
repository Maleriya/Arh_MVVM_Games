using UnityEngine;

namespace Snake_MVVM.Model
{
    public class SnakePiece : IPiece
    {
        public Vector2 Position { get; set; }
        public Vector2 NextPosition { get; set; }

        public SnakePiece(Vector2 position, Vector2 nextPosition)
        {
            Position = position;
            NextPosition = nextPosition;
        }
    }
}
