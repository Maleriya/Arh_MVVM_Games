using UnityEngine;
using UnityEngine.UI;
using Example_MVVM.ViewModel;
using System;

namespace Example_MVVM.View
{
    internal sealed class HpView : MonoBehaviour
    {
        [SerializeField] private Text _text;
        private IHpViewModel _hpViewModel;

        public void Initialize(IHpViewModel hpViewModel)
        {
            _hpViewModel = hpViewModel;
            _hpViewModel.OnHpChange += OnHpChange;
            OnHpChange(_hpViewModel.HpModel.CurrentHp);
        }

        private void OnHpChange(float currentHp)
        {
            _text.text = _hpViewModel.IsDead ? "Вы погибли." : currentHp.ToString();
        }

        ~HpView()
        {
            _hpViewModel.OnHpChange -= OnHpChange;
        }
    }
}
