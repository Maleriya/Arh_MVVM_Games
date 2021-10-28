using Example_MVVM.Model;
using Example_MVVM.View;
using Example_MVVM.ViewModel;
using UnityEngine;

namespace Arh_MVVM_Games
{
    internal sealed class Starter : MonoBehaviour
    {
        [SerializeField] private HpView _hpView;
        [SerializeField] private ApplyDamageView _applyDamageView;

        private void Start()
        {
            var hpModel = new HpModel(100);
            var hpViewModel = new HpViewModel(hpModel);
            _hpView.Initialize(hpViewModel);
            _applyDamageView.Initialize(hpViewModel);
        }
    }
}
