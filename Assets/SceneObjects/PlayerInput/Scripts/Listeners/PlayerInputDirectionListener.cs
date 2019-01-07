using UnityEngine;

public interface PlayerInputDirectionListener : SceneObject {
  void OnDirectionUpdated(Vector2 direction);
}