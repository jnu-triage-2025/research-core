namespace TriageTrainer.Core.Entity.Patient
{
  public class PatientDescriptor
  {
    public string identifier;
    public string name;
    public Sex sex;
    public int age;
    public BloodType bloodType;
    public BloodPressure bloodPressure;
    public BloodPulse pulse;
    public Skin skin;
    public BodyTemperature bodyTemperature;
    public HealthProblem healthProblem;
    public Consciousness consciousness;
    public Respiration respiration;
    public List<RequiredDrug> requiredDrugs;
    public bool isCardiacArrest;
  }
}
