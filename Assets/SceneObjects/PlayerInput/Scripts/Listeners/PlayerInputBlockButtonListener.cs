public interface PlayerInputBlockButtonListener : SceneObject {
  void OnBlockButtonDown();
  void OnBlockButtonUp();
  void OnBlockButtonUpdated(bool isBlockButtonActive);
}