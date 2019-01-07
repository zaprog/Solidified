public static class ShieldUtility {
  public static float GetForwardAngleTargetIf(bool isBlockButtonBeingPressed) {
    return isBlockButtonBeingPressed
        ? ShieldConstant.ForwardAngleTargetActive
        : ShieldConstant.ForwardAngleTargetPassive;
  }

  public static float GetForwardAngleUpdateStepIf(bool isBlockButtonBeingPressed) {
    return isBlockButtonBeingPressed
        ? ShieldConstant.ForwardAngleUpdateStepActive
        : ShieldConstant.ForwardAngleUpdateStepPassive;
  }
}