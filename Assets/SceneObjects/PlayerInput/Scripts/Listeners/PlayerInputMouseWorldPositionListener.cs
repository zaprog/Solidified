using UnityEngine;

public interface PlayerInputMouseWorldPositionListener : SceneObject {
  void OnMouseWorldPositionUpdated(Vector3 mouseWorldPosition);
}