namespace NONAMe.Gameplay
{
  public interface IInteractable
  {
    public bool CanInteract { get; }

    public void Interact(object sender);
  }
}