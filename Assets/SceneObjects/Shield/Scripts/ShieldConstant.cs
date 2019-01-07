using UnityEngine;

public static class ShieldConstant {
  public static float ForwardAngleTargetActive {
    get { return -90; }
  }

  public static float ForwardAngleTargetPassive {
    get { return 0; }
  }

  public static float ForwardAngleUpdateStepActive {
    get { return 1440.0f * Time.deltaTime; }
  }

  public static float ForwardAngleUpdateStepPassive {
    get { return 1440.0f * Time.deltaTime; }
  }
}