using System;
using UnityEngine;
using Snake_MVVM.Model;

namespace Snake_MVVM.ModelView
{
    public class FoodVM
    {
        private IFood _food;
        public event Action<Vector2> ChangeFoodPosition;

        public FoodVM(IFood food)
        {
            _food = food;
        }

        public void FoodEat()
        {
            _food.Eat();
            ChangePosition();
        }

        private void ChangePosition()
        {
            Vector2 newFoodPosition = new Vector2(_food.Position.x, _food.Position.y);
            ChangeFoodPosition?.Invoke(newFoodPosition);
        }
    }
}
