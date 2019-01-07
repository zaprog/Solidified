using UnityEngine;

public class ShieldController : MonoBehaviour, ShieldView, PlayerInputBlockButtonListener {
  private ShieldPresenter _presenter;

  public Collider2D Collider2D {
    get { return GetComponent<Collider2D>(); }
  }

  public Vector3 LocalEulerAngles {
    get { return transform.localEulerAngles; }
    set { transform.localEulerAngles = value; }
  }

  public Vector3 LocalScale {
    get { return transform.localScale; }
    set { transform.localScale = value; }
  }

  public float ForwardAngle { get; set; }

  public void OnBlockButtonDown() {
  }

  public void OnBlockButtonUp() {
  }

  public void OnBlockButtonUpdated(bool isActionButtonActive) {
    _presenter.UpdateForwardAngle(isActionButtonActive);
    Collider2D.enabled = isActionButtonActive;
  }

  public void Start() {
    _presenter = new ShieldPresenter(this);
    ForwardAngle = LocalEulerAngles.z;
  }

  public void Update() {
    _presenter.UpdateLocalEulerAngles();
    _presenter.UpdateLocalScale();
  }
}