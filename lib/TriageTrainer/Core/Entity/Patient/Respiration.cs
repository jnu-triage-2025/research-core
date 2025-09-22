namespace TriageTrainer.Core.Entity.Patient
{
  /// <summary>
  /// 환자의 호흡 상태를 정의합니다.
  /// - awRR: int 분당 호흡 횟수
  /// - type: RespirationType 호흡 유형
  /// </summary>
  public class Respiration
  {
    public int awRR;
    public RespirationType type;
  }
}