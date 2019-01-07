using UnityEngine;

public class MainCameraController : MonoBehaviour, MainCameraView {
  public Vector2 ScreenToWorldPoint(Vector3 mousePosition) {
    return GetComponent<Camera>().ScreenToWorldPoint(mousePosition);
  }
}