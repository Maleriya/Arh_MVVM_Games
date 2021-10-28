using UnityEngine;
using Snake_MVVM.ModelView;
using Snake_MVVM.Model;

namespace Snake_MVVM.View
{
    public class InputV : MonoBehaviour
    {
        private InputVM _inputVM;

        public void Initialize(InputVM inputVm)
        {
            _inputVM = inputVm;
        }

        private void Update()
        {
            if (UnityEngine.Input.GetKeyDown(KeyCode.W))
            {
                _inputVM.ChangeDirection(Direction.Up);
            }
            if (UnityEngine.Input.GetKeyDown(KeyCode.S))
            {
                _inputVM.ChangeDirection(Direction.Down);
            }
            if (UnityEngine.Input.GetKeyDown(KeyCode.D))
            {
                _inputVM.ChangeDirection(Direction.Right);
            }
            if (UnityEngine.Input.GetKeyDown(KeyCode.A))
            {
                _inputVM.ChangeDirection(Direction.Left);
            }
        }
    }
}

