using UnityEngine;

public interface MainCamera : SceneObject {
  Vector2 ScreenToWorldPoint(Vector3 mousePosition);
}