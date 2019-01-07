public static class SwordUtility {
  public static float GetForwardAngleTargetIf(bool isActionButtonBeingPressed) {
    return isActionButtonBeingPressed
        ? SwordConstant.ForwardAngleTargetActive
        : SwordConstant.ForwardAngleTargetPassive;
  }

  public static float GetForwardAngleUpdateStepIf(bool isActionButtonBeingPressed) {
    return isActionButtonBeingPressed
        ? SwordConstant.ForwardAngleUpdateStepActive
        : SwordConstant.ForwardAngleUpdateStepPassive;
  }
}