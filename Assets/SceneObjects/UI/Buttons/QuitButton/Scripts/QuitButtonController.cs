using UnityEngine;
using UnityEngine.UI;

public class QuitButtonController : MonoBehaviour, QuitButtonView {
  public Button Button {
    get { return GetComponent<Button>(); }
  }

  public void Start() {
    Button.onClick.AddListener(() => Application.Quit());
  }
}