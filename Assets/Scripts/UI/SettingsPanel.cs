using System;
using DG.Tweening;
using Dythervin.AutoAttach;
using NONAMe.Infrastructure;
using UnityEngine;

namespace NONAMe.UI
{
    public class SettingsPanel : Panel, IActivateable, IDeactivateable
    {
        [SerializeField] [Attach] private RectTransform _rectTransform;
        [SerializeField] [Attach] private CanvasGroup _canvasGroup;
        [SerializeField] private float _activationDuration = 1;
        [SerializeField] private float _deactivatedPositionX;

        private void Awake()
        {
            _canvasGroup.alpha = 0;
        }

        public void Activate()
        {
            var sequence = DOTween.Sequence();
            sequence.Append(_canvasGroup.DOFade(1, _activationDuration));
            sequence.Insert(0,
                _rectTransform.DOAnchorPosX(0, _activationDuration).From(new Vector2(_deactivatedPositionX, 0)));
        }

        public void Deactivate()
        {
            var sequence = DOTween.Sequence();
            sequence.Append(_canvasGroup.DOFade(0, _activationDuration));
            sequence.Insert(0,
                _rectTransform.DOAnchorPosX(_deactivatedPositionX, _activationDuration).From(new Vector2(0, 0)));
        }
    }
}