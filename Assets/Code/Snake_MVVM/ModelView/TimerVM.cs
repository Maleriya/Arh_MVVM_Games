using Snake_MVVM.View;
using Snake_MVVM.Model;

namespace Snake_MVVM.ModelView
{
    public class TimerVM
    {
        private Snake _snake;
        public TimerVM(Snake snake, TimerV timer)
        {
            _snake = snake;
            timer.Tick += TimerTick;
        }

        private void TimerTick()
        {
            _snake.Move();
        }
    }
}