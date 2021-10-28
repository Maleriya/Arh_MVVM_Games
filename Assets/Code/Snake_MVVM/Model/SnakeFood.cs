using UnityEngine;

namespace Snake_MVVM.Model
{
    public class SnakeFood : IFood
    {
        public Vector2 Position { get; set; }
        private Collider2D _foodArea;

        public SnakeFood(Collider2D foodArea)
        {
            _foodArea = foodArea;
            SetNexPosition();
        }

        public void Eat()
        {
            SetNexPosition();
        }

        private void SetNexPosition()
        {
            Bounds bounds = _foodArea.bounds;

            float x = Random.Range(bounds.min.x, bounds.max.x);
            float y = Random.Range(bounds.min.y, bounds.max.y);

            x = Mathf.Round(x);
            y = Mathf.Round(y);

            Position = new Vector2(x, y);
        }
    }
}
