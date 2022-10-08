using System;
using System.Globalization;
using Dythervin.AutoAttach;
using TMPro;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace NONAMe.UI
{
    public class VolumeSlider : MonoBehaviour
    {
        [SerializeField] [Attach] private Slider _slider;

        [SerializeField] [Attach(Attach.Child)]
        private TMP_Text _volumeText;

        private void OnEnable()
        {
            _slider.onValueChanged.AddListener(_ => UpdateVolumeText());
            UpdateVolumeText();
        }

        private void UpdateVolumeText()
        {
            var newValue =  Mathf.RoundToInt(_slider.value * 100);
            _volumeText.text = newValue.ToString() + "%";
        }
    }
}
