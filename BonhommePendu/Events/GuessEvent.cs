using BonhommePendu.Models;

namespace BonhommePendu.Events
{
    // Un événement à créer chaque fois qu'un utilisateur essai une "nouvelle" lettre
    public class GuessEvent : GameEvent
    {
        // TODO: Compléter
        public GuessEvent(GameData gameData, char letter) {
            // TODO: Commencez par ICI

            Events = new List<GameEvent>(); //new event list

            GuessedLetterEvent gle = new GuessedLetterEvent(gameData, letter); //create new guessed letter event with given gamedata and char

            Events.Add(gle); //add the created event to the list 

            bool guessedALetter = false; //guessed the letter by default is false

            for(int i  = 0; i < gameData.RevealedWord.Length; i++) //going thru the whole word
            {
                if (gameData.HasSameLetterAtIndex(letter, i)) //if the the letter in the word (at position i) is the same as the given one 
                {
                    guessedALetter = true; //we guessed a letter
                    RevealLetterEvent rle = new RevealLetterEvent(gameData, letter, i); //create new revealed letter event with given gamedata, char and index
                    Events.Add(rle); //add the created event to the list 
                }
            }

            if (guessedALetter == false) //if we didnt guess a letter
            {
                WrongGuessEvent wge = new WrongGuessEvent(gameData);
                Events.Add(wge);
            }


        }
    }
}
