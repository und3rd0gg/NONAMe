using Dythervin.AutoAttach;
using UnityEngine;
using UnityEngine.EventSystems;

namespace NONAMe.UI
{
    public class SettingsButton : MonoBehaviour, IPointerClickHandler
    {
        [SerializeField][Attach(Attach.Scene)] private SettingsPanel _settingsPanel;

        public void OnPointerClick(PointerEventData eventData)
        {
            _settingsPanel.Activate();
        }
    }
}