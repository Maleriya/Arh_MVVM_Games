using System;
using Snake_MVVM.ModelView;
using UnityEngine;

namespace Snake_MVVM.View
{
    public class TimerV : MonoBehaviour
    {
        [SerializeField] private float _speed = 0.2f;
        [SerializeField] private float _currentTime;
        public event Action Tick;

        private void Update()
        {
            if(_currentTime <= _speed)
            {
                _currentTime += Time.deltaTime;
                return;
            }

            _currentTime = 0;
            Tick?.Invoke();

        }
    }
}
