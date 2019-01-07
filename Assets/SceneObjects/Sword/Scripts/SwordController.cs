using UnityEngine;

public class SwordController : MonoBehaviour, SwordView, PlayerInputActionButtonListener {
  private SwordPresenter _presenter;

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

  public void OnActionButtonDown() {
  }

  public void OnActionButtonUp() {
    Collider2D.enabled = true;
  }

  public void OnActionButtonUpdated(bool isActionButtonActive) {
    _presenter.UpdateForwardAngle(isActionButtonActive);
  }

  public void Start() {
    _presenter = new SwordPresenter(this);
    ForwardAngle = LocalEulerAngles.z;
  }

  public void Update() {
    _presenter.UpdateCollider2D();
    _presenter.UpdateLocalEulerAngles();
    _presenter.UpdateLocalScale();
  }
}