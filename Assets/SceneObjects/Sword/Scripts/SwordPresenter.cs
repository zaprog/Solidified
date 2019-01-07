using UnityEngine;

public class SwordPresenter {
  private readonly SwordView _view;

  public SwordPresenter(SwordView view) {
    _view = view;
  }

  public void UpdateCollider2D() {
    _view.Collider2D.enabled = _view.ForwardAngle == 0.0f
        ? false
        : _view.Collider2D.enabled;
  }

  public void UpdateForwardAngle(bool isActionButtonActive) {
    _view.ForwardAngle = Mathf.MoveTowardsAngle(
        _view.ForwardAngle,
        SwordUtility.GetForwardAngleTargetIf(isActionButtonActive),
        SwordUtility.GetForwardAngleUpdateStepIf(isActionButtonActive));
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