public interface PlayerInputActionButtonListener : SceneObject {
  void OnActionButtonDown();
  void OnActionButtonUp();
  void OnActionButtonUpdated(bool isActionButtonActive);
}