namespace TriageTrainer.Core.Entity.Patient
{
  public enum BodyTemperatureType
  {
    Hypothermia,  // < 35.5
    Normal,       // 35.5 <= x <= 37.5
    Fever,        // 37.5 < x <= 38.0
    HighFever,    // 38.0 < x
  }
}
