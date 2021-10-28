using System.Collections.Generic;
using UnityEngine;

namespace Snake_MVVM.Model
{
    public sealed class Snake
    {
        public List<IPiece> AllPiece;

        public Snake(int count)
        {
            AllPiece = new List<IPiece>();
            Vector2 currentVector = new Vector2(0, 0);
            for (int i = 0; i < count; i++)
            {
                IPiece piece;
                if (i == 0)
                {
                    piece = new SnakeHead(new Vector2(-i, 0), currentVector);
                }
                else
                {
                    piece = new SnakePiece(new Vector2(-i, 0), currentVector);
                }
                currentVector = piece.Position;
                AllPiece.Add(piece);
            }
        }

        public IPiece AddPiece()
        {
            Vector2 lastPiece = AllPiece[AllPiece.Count - 1].Position;
            var newPiece = new SnakePiece(new Vector2(lastPiece.x, lastPiece.y), lastPiece);
            AllPiece.Add(newPiece);
            return newPiece;
        }

        public void Move()
        {
            Vector2 temp = Vector2.zero;
            foreach (IPiece piece in AllPiece)
            {
                if (piece is SnakeHead head)
                {
                    head.Position = head.Position + head.CurrentDirection.GetVector2();
                    temp = head.Position;
                }
                else
                {
                    piece.Position = piece.NextPosition;
                    piece.NextPosition = temp;
                    temp = piece.Position;
                }
            }
        }

    }
}