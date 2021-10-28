using UnityEngine;

namespace Example_MVVM.Model
{
    public interface IHpModel
    {
        float MaxHp { get; }
        float CurrentHp { get; set; }
    }
}
