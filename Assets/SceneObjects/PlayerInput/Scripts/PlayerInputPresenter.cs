using System.Linq;
using UnityEngine;

public class PlayerInputPresenter {
  private readonly PlayerInputView _view;

  public PlayerInputPresenter(PlayerInputView view) {
    _view = view;
  }

  public void NotifyDirectionListeners() {
    SceneObjectLocator<PlayerInputDirectionListener>.Multiple.ToList().ForEach(listener => {
      listener.OnDirectionUpdated(_view.Direction);
    });
  }

  public void NotifyMouseWorldPositionListeners() {
    SceneObjectLocator<PlayerInputMouseWorldPositionListener>.Multiple.ToList().ForEach(listener => {
      listener.OnMouseWorldPositionUpdated(_view.MainCamera.ScreenToWorldPoint(Input.mousePosition));
    });
  }

  public void NotifyActionButtonListeners() {
    SceneObjectLocator<PlayerInputActionButtonListener>.Multiple.ToList().ForEach(listener => {
      if (Input.GetMouseButtonDown(0)) listener.OnActionButtonDown();
      if (Input.GetMouseButtonUp(0)) listener.OnActionButtonUp();
      listener.OnActionButtonUpdated(Input.GetMouseButton(0));
    });
  }

  public void NotifyBlockButtonListeners() {
    SceneObjectLocator<PlayerInputBlockButtonListener>.Multiple.ToList().ForEach(listener => {
      if (Input.GetMouseButtonDown(1)) listener.OnBlockButtonDown();
      if (Input.GetMouseButtonUp(1)) listener.OnBlockButtonUp();
      listener.OnBlockButtonUpdated(Input.GetMouseButton(1));
    });
  }
}