using UnityEngine;

public class ShieldPresenter {
  private readonly ShieldView _view;

  public ShieldPresenter(ShieldView view) {
    _view = view;
  }

  public void UpdateForwardAngle(bool isBlockButtonActive) {
    _view.ForwardAngle = Mathf.MoveTowardsAngle(
        _view.ForwardAngle,
        ShieldUtility.GetForwardAngleTargetIf(isBlockButtonActive),
        ShieldUtility.GetForwardAngleUpdateStepIf(isBlockButtonActive));
  }

  public void UpdateLocalEulerAngles() {
    _view.LocalEulerAngles = new Vector3 {
        x = _view.LocalEulerAngles.x,
        y = _view.LocalEulerAngles.y,
        z = _view.ForwardAngle
    };
  }

  public void UpdateLocalScale() {
    _view.LocalScale = Vector3.one;
  }
}