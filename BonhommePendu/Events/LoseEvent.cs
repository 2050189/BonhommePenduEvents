using BonhommePendu.Models;

namespace BonhommePendu.Events
{
    // Un événement à créer si il ne reste plus d'essais (NbWrongGuesses est trop grand)
    public class LoseEvent : GameEvent
    {
        // TODO: Compléter
        public LoseEvent(GameData gameData) {
            gameData.Lost = true;
        }
    }
}
