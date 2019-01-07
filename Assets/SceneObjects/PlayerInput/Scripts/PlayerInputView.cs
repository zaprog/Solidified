using UnityEngine;

public interface PlayerInputView : PlayerInput {
  Vector2 Direction { get; }
  MainCamera MainCamera { get; }
}