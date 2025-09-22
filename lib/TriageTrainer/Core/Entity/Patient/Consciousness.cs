namespace TriageTrainer.Core.Entity.Patient
{
  public class Consciousness
  {
    public int gcs;

    public PupillaryResponse pupillaryResponse;
    public LOCLabel locLabel;
    public GCSLabel GcsLabel
    {
      get
      {
        if (gcs < 2) return GCSLabel.NA;
        if (gcs <= 8) return GCSLabel.Severe;
        if (gcs <= 12) return GCSLabel.Moderate;
        if (gcs <= 15) return GCSLabel.Mild;
        return GCSLabel.NA;
      }
    }
  }
}
