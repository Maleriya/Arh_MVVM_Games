using System;
using Snake_MVVM.Model;
using Snake_MVVM.View;
using UnityEngine;

namespace Snake_MVVM.ModelView
{
    public class MoveVM
    {
        private IPiece _piece;
        public event Action<Vector2> MovePiece;

        public MoveVM(IPiece piece, TimerV timer)
        {
            _piece = piece;
            timer.Tick += Move;
        }

        public void Move()
        {
            Vector2 position = new Vector2(_piece.Position.x, _piece.Position.y);
            MovePiece?.Invoke(position);
        }
    }
}
