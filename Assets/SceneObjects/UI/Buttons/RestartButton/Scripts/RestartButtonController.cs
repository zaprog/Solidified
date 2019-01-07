using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class RestartButtonController : MonoBehaviour, RestartButtonView {
  public Button Button {
    get { return GetComponent<Button>(); }
  }

  public void Start() {
    Button.onClick.AddListener(() => SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex));
  }
}