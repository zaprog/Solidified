using UnityEngine;

public class PlayerInputController : MonoBehaviour, PlayerInputView {
  private PlayerInputPresenter _presenter;

  public Vector2 Direction {
    get {
      return new Vector2 {
          x = Input.GetAxisRaw("Horizontal"),
          y = Input.GetAxisRaw("Vertical")
      }.normalized;
    }
  }

  public MainCamera MainCamera {
    get {
      return SceneObjectLocator<MainCamera>.Single;
    }
  }

  public void Start() {
    _presenter = new PlayerInputPresenter(this);
  }

  public void Update() {
    _presenter.NotifyDirectionListeners();
    _presenter.NotifyActionButtonListeners();
    _presenter.NotifyMouseWorldPositionListeners();
    _presenter.NotifyBlockButtonListeners();
  }
}