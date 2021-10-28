using UnityEngine;

namespace Snake_MVVM.Model
{
    public sealed class SnakeHead : SnakePiece
    {
        public Direction CurrentDirection;
        public SnakeHead(Vector2 position, Vector2 nextPosition)
            : base(position, nextPosition)
        {
            CurrentDirection = Direction.Right;
        }

        public void ChangeDirection(Direction direction)
        {
            if (CurrentDirection.CanChangeBaseDirection(direction))
                CurrentDirection = direction;
        }

    }
}
