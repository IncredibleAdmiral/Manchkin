using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace machkin


{


   public enum Stage
     {Battle,FirstTakeCard,SecondTakeCard,EndStep }
    class TurnHandler
    {

        int turn;


        public int Turn{ set { turn = value; } }


        Stage stage;
        List<Player> PlayersList = new List<Player>();
        public void AddPlayer(string Name, string sex)
        {


            PlayersList.Add(new Player(sex, Name));

        }

        public List<Player> ReturnPlayersList {get { return PlayersList; } }
        

        void ChangePlayer()
        {
            


        }

        public bool ChangeStage(Stage st)
        {
            switch (st)
            {
                case Stage.Battle:
                    break;
                case Stage.FirstTakeCard:
                    break;
                case Stage.SecondTakeCard:
                    break;
                case Stage.EndStep:
                    break;
            }
            return false;
        }


       
    }
}
