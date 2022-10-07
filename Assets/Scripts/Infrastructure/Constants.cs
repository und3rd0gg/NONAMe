using UnityEngine;

namespace Infrastructure
{
  public static class Constants
  {
    public static class Axes
    {
      public const string Horizontal = nameof(Horizontal);
      public const string Vertical = nameof(Vertical);
    }

    public static class SettingsPanelAnimator
    {
      public static readonly int FadeIn = Animator.StringToHash("FadeIn");
      public static readonly int FadeOut = Animator.StringToHash("FadeOut");
    }
  }
}