namespace TriageTrainer.Core.Entity.Patient
{
  /// <summary>
  /// 환자의 호흡 상태를 정의합니다.
  /// - Respiration.Regular: 규칙적
  /// - Respiration.Irregular: 불규칙적
  /// - Respiration.ChainStocks: 임종호흡
  /// </summary>
  public enum RespirationType
  {
    Regular,
    Irregular,
    ChainStocks,
  }
}
