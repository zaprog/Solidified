using UnityEngine;

public class RocketController : MonoBehaviour, RocketView {
  private RocketPresenter _presenter;
  private RocketCache _cache;

  public PlayerAgent PlayerAgent {
    get { return SceneObjectLocator<PlayerAgent>.Single; }
  }

  public GameObject GameObject {
    get { return gameObject; }
  }

  public Rigidbody2D Rigidbody2D {
    get { return GetComponent<Rigidbody2D>(); }
  }

  public Vector3 Direction {
    get {
      if (PlayerAgent == null) return _cache.Direction;
      _cache.Direction = (PlayerAgent.Position - Position).normalized; 
      return _cache.Direction;
    }
  }

  public Vector3 Position {
    get { return transform.position; }
  }

  public Vector3 EulerAngles {
    get { return transform.eulerAngles; }
    set { transform.eulerAngles = value; }
  }

  public float PlayerAgentDistance {
    get {
      if (PlayerAgent != null) _cache.PlayerAgentPosition = PlayerAgent.Position;
      return Vector3.Distance(_cache.PlayerAgentPosition, Position);
    }
  }

  public void Start() {
    _presenter = new RocketPresenter(this);
    _cache = new RocketCache();
  }

  public void Update() {
    _presenter.UpdatePosition();
    _presenter.LookAtPlayerAgent();
  }

  public void OnCollisionEnter2D(Collision2D other) {
    _presenter.ReactTowards(other.collider.gameObject);
  }
}