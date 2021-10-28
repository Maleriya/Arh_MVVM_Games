using System;
using UnityEngine;

namespace Snake_MVVM.Model
{
    public interface IFood
    {
        public Vector2 Position { get; }
        public void Eat();
    }
}
