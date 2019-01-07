using UnityEngine;

public class RocketPresenter {
  private readonly RocketView _view;

  public RocketPresenter(RocketView view) {
    _view = view;
  }

  public void UpdatePosition() {
    if (_view.Direction.magnitude < 0.0001f) return;
    _view.Rigidbody2D.MovePosition(_view.Position + _view.Direction * RocketConstant.MoveSpeed * Time.deltaTime);
  }

  public void LookAtPlayerAgent() {
    if (_view.PlayerAgentDistance < 0.0001f) return;

    var eulerAngles = _view.EulerAngles;
    eulerAngles.z = _view.Direction.GetPolarAngle() - 90;
    _view.EulerAngles = eulerAngles;
  }

  public void ReactTowards(GameObject otherGameObject) {
    if (otherGameObject.GetComponent<PlayerAgent>() != null) Object.Destroy(otherGameObject);
    if (otherGameObject.GetComponent<Rocket>() == null) Object.Destroy(_view.GameObject);
  }
}