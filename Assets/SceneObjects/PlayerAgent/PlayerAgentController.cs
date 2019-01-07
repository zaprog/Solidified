using UnityEngine;

public class PlayerAgentController : MonoBehaviour, PlayerAgentView, PlayerInputDirectionListener, PlayerInputMouseWorldPositionListener {
  private PlayerAgentPresenter _presenter;
  private Vector3 _mouseWorldPosition;

  public Rigidbody2D Rigidbody2D {
    get { return GetComponent<Rigidbody2D>(); }
  }

  public Vector2 MouseDirection {
    get { return (_mouseWorldPosition - transform.position).normalized; }
  }

  public Vector3 EulerAngles {
    get { return transform.eulerAngles; }
    set { transform.eulerAngles = value; }
  }

  public Vector3 Position {
    get { return transform.position; }
    set { transform.position = value; }
  }

  public void OnDirectionUpdated(Vector2 direction) {
    _presenter.UpdatePosition(direction);
  }

  public void OnMouseWorldPositionUpdated(Vector3 mouseWorldPosition) {
    _mouseWorldPosition = mouseWorldPosition;
  }

  public void Start() {
    _presenter = new PlayerAgentPresenter(this);
  }

  public void Update() {
    _presenter.LookAtCursor();
  }
}