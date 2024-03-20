using System.Text.Json.Serialization;

namespace BonhommePendu.Events
{
    // Les évnénements sont tous déjà enregistré, SAUF Win
    [JsonDerivedType(typeof(GuessEvent), typeDiscriminator: "Guess")]
    [JsonDerivedType(typeof(WrongGuessEvent), typeDiscriminator: "WrongGuess")]
    [JsonDerivedType(typeof(RevealLetterEvent), typeDiscriminator: "RevealLetter")]
    [JsonDerivedType(typeof(LoseEvent), typeDiscriminator: "Lose")]
    [JsonDerivedType(typeof(GuessedLetterEvent), typeDiscriminator: "GuessedLetter")]
    [JsonDerivedType(typeof(WinEvent), typeDiscriminator:"Win")]
    public class GameEvent
    {
        public List<GameEvent>? Events { get; set; }
    }
}
