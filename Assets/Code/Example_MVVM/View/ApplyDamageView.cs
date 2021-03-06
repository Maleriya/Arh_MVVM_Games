using Example_MVVM.ViewModel;
using UnityEngine;
using UnityEngine.UI;

namespace Example_MVVM.View
{
    internal sealed class ApplyDamageView : MonoBehaviour
    {
        [SerializeField] private Button _button;
        [SerializeField] private float _damage;
        private IHpViewModel _hpViewModel;

        public void Initialize(IHpViewModel hpViewModel)
        {
            _hpViewModel = hpViewModel;
            _button.onClick.RemoveAllListeners();
            _button.onClick.AddListener(() => _hpViewModel.ApplyDamage(_damage));
        }
    }
}
