namespace TriageTrainer.Core.User
{
  public class AccessAccount
  {
    public string identifier;
    public string displayName;
    public PlayerType playerType;
    public string playerIdentifier;  // Reference Pair Required

    public AccessAccount
    (
      string identifier,
      string displayName,
      PlayerType playerType,
      string playerIdentifier
    )
    {
      this.identifier = identifier;
      this.displayName = displayName;
      this.playerType = playerType;
      this.playerIdentifier = playerIdentifier;
    }
  }
}
