using System;
using Example_MVVM.Model;

namespace Example_MVVM.ViewModel
{
    public interface IHpViewModel
    {
        IHpModel HpModel { get; }
        bool IsDead { get; }
        void ApplyDamage(float damage);
        event Action<float> OnHpChange;
    }
}
