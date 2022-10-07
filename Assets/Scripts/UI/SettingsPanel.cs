using DG.Tweening;
using Dythervin.AutoAttach;
using UnityEngine;

namespace UI
{
    public class SettingsPanel : Panel
    {
        [SerializeField] [Attach] private CanvasGroup _canvasGroup;

        private void Start()
        {
        }

        public void Activate()
        {
            _canvasGroup.DOFade(1, 1);
        }

        public void Deactivate()
        {
            _canvasGroup.DOFade(0, 1);
        }
    }
}