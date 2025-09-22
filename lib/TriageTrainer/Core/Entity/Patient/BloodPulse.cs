namespace TriageTrainer.Core.Entity.Patient
{
  /// <summary>
  /// 맥박을 표현합니다.
  /// - rate: int 분당 맥박 비율
  /// - forceType: BloodPulseForceType 맥박의 세기 유형
  /// - SpeedType: (get) BloodPulseSpeedType 분당 맥박 비율로부터 산출한 맥박 속도 유형
  /// </summary>
  public class BloodPulse
  {
    public int rate;
    public BloodPulseForceType forceType;
    public BloodPulseSpeedType SpeedType
    {
      get
      {
        if (rate < 60) return BloodPulseSpeedType.Bradycardia;
        if (rate <= 100) return BloodPulseSpeedType.Normal;
        return BloodPulseSpeedType.Tachycardia;
      }
    }
  }
}
