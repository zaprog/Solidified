using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public static class SceneObjectLocator<T> where T : SceneObject {
  public static T Single {
    get { return FindMonoBehavioursAs<T>().FirstOrDefault(sceneObject => sceneObject != null); }
  }

  public static IEnumerable<T> Multiple {
    get { return FindMonoBehavioursAs<T>().Where(sceneObject => sceneObject != null); }
  }

  private static IEnumerable<MonoBehaviour> MonoBehaviours {
    get { return Object.FindObjectsOfType<MonoBehaviour>(); }
  }

  private static IEnumerable<TComponent> FindMonoBehavioursAs<TComponent>() {
    return MonoBehaviours.Select(monoBehaviour => monoBehaviour.GetComponent<TComponent>());
  }
}