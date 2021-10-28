using System;
using Snake_MVVM.ModelView;
using UnityEngine;

namespace Snake_MVVM.View
{
    public class FoodV : MonoBehaviour
    {
        private FoodVM _foodVM;
        public event Action eatFood;

        public void Initialize(FoodVM foodVM)
        {
            _foodVM = foodVM;
            _foodVM.ChangeFoodPosition += ChangePosition;
        }

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (!other.GetComponent<SnakeHeadV>())
            {
                return;
            }

            eatFood?.Invoke();
            _foodVM.FoodEat();
        }

        private void ChangePosition(Vector2 position)
        {
            transform.position = position;
        }

    }
}

