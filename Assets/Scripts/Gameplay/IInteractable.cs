namespace Infrastructure
{
  public interface IInteractable
  {
    public bool CanInteract { get; }

    public void Interact(object sender);
  }
}