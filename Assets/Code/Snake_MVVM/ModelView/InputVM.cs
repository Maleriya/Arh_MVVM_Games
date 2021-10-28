using Snake_MVVM.Model;

namespace Snake_MVVM.ModelView
{
    public class InputVM
    {
        private SnakeHead _snakeHead;

        public InputVM(SnakeHead snakeHead)
        {
            _snakeHead = snakeHead;
        }

        public void ChangeDirection(Direction direction)
        {
            _snakeHead.ChangeDirection(direction);
        }
    }
}
