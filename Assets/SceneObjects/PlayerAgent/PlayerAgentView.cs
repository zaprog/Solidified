using UnityEngine;

public interface PlayerAgentView : PlayerAgent {
  Rigidbody2D Rigidbody2D { get; }
  Vector2 MouseDirection { get; }
  Vector3 EulerAngles { get; set; }
  new Vector3 Position { get; set; }
}