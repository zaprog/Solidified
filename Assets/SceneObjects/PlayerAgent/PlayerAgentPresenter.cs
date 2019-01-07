using UnityEngine;

public class PlayerAgentPresenter {
  private readonly PlayerAgentView _view;

  public PlayerAgentPresenter(PlayerAgentView view) {
    _view = view;
  }

  public void LookAtCursor() {
    if (_view.MouseDirection.magnitude < 0.0001f) return;

    var eulerAngles = _view.EulerAngles;
    eulerAngles.z = _view.MouseDirection.GetPolarAngle() - 90;
    _view.EulerAngles = eulerAngles;
  }

  public void UpdatePosition(Vector2 direction) {
    _view.Rigidbody2D.MovePosition(_view.Position + (Vector3) direction * 80.0f * Time.deltaTime);
  }
}