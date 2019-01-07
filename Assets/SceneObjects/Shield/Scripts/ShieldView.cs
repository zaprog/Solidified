using UnityEngine;

public interface ShieldView : Shield {
  Collider2D Collider2D { get; }
  Vector3 LocalEulerAngles { get; set; }
  Vector3 LocalScale { get; set; }
  float ForwardAngle { get; set; }
}