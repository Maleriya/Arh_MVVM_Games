using UnityEngine;
using Snake_MVVM.ModelView;

namespace Snake_MVVM.View
{
    public class PieceV : MonoBehaviour
    {
        public void Initialize(MoveVM moveVm)
        {
            moveVm.MovePiece += ChangePosition;
        }

        private void ChangePosition(Vector2 position)
        {
            transform.position = position;
        }
    }
}