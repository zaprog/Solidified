using UnityEngine;

public static class Vector2Extension {
  public static float GetPolarAngle(this Vector2 self) {
    return ((Vector3) self).GetPolarAngle();
  }
}