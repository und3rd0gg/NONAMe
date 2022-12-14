using UnityEngine;

namespace NONAMe.Gameplay
{
  public class LightSwitch : MonoBehaviour, IInteractable
  {
    [SerializeField] private Light _light;

    public bool CanInteract { get; }

    public void Interact(object sender)
    {
      SwitchLight();
    }

    private void SwitchLight()
    {
      _light.enabled = !_light.enabled;
    }
  }
}
