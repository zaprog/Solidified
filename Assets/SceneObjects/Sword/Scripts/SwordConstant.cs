using UnityEngine;

public static class SwordConstant {
  public static float ForwardAngleTargetActive {
    get { return 135; }
  }

  public static float ForwardAngleTargetPassive {
    get { return 0; }
  }

  public static float ForwardAngleUpdateStepActive {
    get {
      return 720.0f * Time.deltaTime;
    }
  }

  public static float ForwardAngleUpdateStepPassive {
    get {
      return 1440.0f * Time.deltaTime;
    }
  }
}