namespace TriageTrainer.Core.Entity.Patient
{
  public class BodyTemperature
  {
    public float celsius;
    public BodyTemperatureType type
    {
      get
      {
        if (celsius < 36.0f) return BodyTemperatureType.Hypothermia;
        if (celsius <= 37.5f) return BodyTemperatureType.Normal;
        if (celsius <= 38.0f) return BodyTemperatureType.Fever;
        return BodyTemperatureType.HighFever;
      }
    }
  }
}
