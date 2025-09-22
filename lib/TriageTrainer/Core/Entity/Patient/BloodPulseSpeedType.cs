namespace TriageTrainer.Core.Entity.Patient
{
  public enum BloodPulseSpeedType
  {
    Bradycardia,  // < 60
    Normal,       // 60 <= x <= 100
    Tachycardia,  // > 100 (most case: 140 < x < 170)
  }
}
