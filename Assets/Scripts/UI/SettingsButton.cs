using UI;
using UnityEngine;
using UnityEngine.EventSystems;

public class SettingsButton : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private SettingsPanel _settingsPanel;

    public void OnPointerClick(PointerEventData eventData)
    {
        _settingsPanel.Activate();
    }
}