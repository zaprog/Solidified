using UnityEngine;

public static class Vector3Extension {
  public static float GetPolarAngle(this Vector3 self) {
    var result = Vector3.Angle(Vector3.right, self);
    result = self.y < 0.0f ? 360.0f - result : result;
    
    return result;
  }
}