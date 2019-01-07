using UnityEngine;

public interface RocketView : Rocket {
  PlayerAgent PlayerAgent { get; }
  GameObject GameObject { get; }
  Rigidbody2D Rigidbody2D { get; }
  Vector3 Direction { get; }
  Vector3 Position { get; }
  Vector3 EulerAngles { get; set; }
  float PlayerAgentDistance { get; }
}