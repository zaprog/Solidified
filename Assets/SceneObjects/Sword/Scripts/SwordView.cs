using UnityEngine;

public interface SwordView : Sword {
  Collider2D Collider2D { get; }
  Vector3 LocalEulerAngles { get; set; }
  Vector3 LocalScale { get; set; }
  float ForwardAngle { get; set; }
}