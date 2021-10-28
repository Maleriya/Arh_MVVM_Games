using UnityEngine;

namespace Snake_MVVM.Model
{
    public enum Direction
    {
        Up = 0,
        Down = 1,
        Left = 2,
        Right = 3
    }

    public static class DirectionExtention
    {
        public static bool CanChangeBaseDirection(this Direction value, Direction nextDirection)
        {
            switch (value)
            {
                case Direction.Up:
                case Direction.Down:
                    switch (nextDirection)
                    {
                        case Direction.Left:
                        case Direction.Right:
                            return true;
                        default:
                            return false;
                    }             
                case Direction.Left:
                case Direction.Right:
                    switch (nextDirection)
                    {
                        case Direction.Up:
                        case Direction.Down:
                            return true;
                        default:
                            return false;
                    }
                default:
                    return false;
            }
        }

        public static Vector2 GetVector2(this Direction value)
        {
            switch (value)
            {
                case Direction.Right:
                    return Vector2.right;
                case Direction.Left:
                    return Vector2.left;
                case Direction.Up:
                    return Vector2.up;
                case Direction.Down:
                    return Vector2.down;
                default:
                    return Vector2.zero;
            }
        }
    }
}