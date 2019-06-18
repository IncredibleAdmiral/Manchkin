using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace machkin
{
    class NewGame
    {
        Random rnd = new Random();
        TurnHandler TurnHand = new TurnHandler();
        RicherDeck Richers = new RicherDeck();
        DoorDeck Doors = new DoorDeck();

        List<Riches> GameRicherDeck= new List<Riches>();
        List<Door> GameDoorDeck = new List<Door>();

     public bool  NewGameCreate(int QuantitiPlayers )
        {
            if (QuantitiPlayers < 3)
                return false;
            else
            {
                try
                {
                    PlayersCreate(QuantitiPlayers);
                    GameRicherDeck.AddRange(Richers.FormationDeck());
                    GameDoorDeck.AddRange(Doors.FormationDeck());
                    BeginDistributionCards();
                    TurnHand.Turn = rnd.Next(0, QuantitiPlayers - 1);
                    return true;
                }
                catch
                {
                    return false;
                }
            }
            
        }


        private void PlayersCreate(int QuantitiPlayers)

        {
            for (int i = 0; i < QuantitiPlayers; i++)

            {
                TurnHand.AddPlayer("Player" + Convert.ToString(i++), "муж");
            }

           
        }
        private void BeginDistributionCards()
        {
            var PlList = TurnHand.ReturnPlayersList;

            for (int i = 0; i < PlList.Count; i++)
            {
                var PL = PlList[i];
                for (int j = 0; j < 4;i++)
                {
                    PL.TakeCard(GameRicherDeck[0]);
                    PL.TakeCard(GameDoorDeck[0]);

                    GameRicherDeck.RemoveAt(0);
                    GameDoorDeck.RemoveAt(0);
                }

            }


        }

    }
}
