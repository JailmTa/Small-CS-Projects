using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrixScoreRecordeer
{
    public class clsGameRecorder
    {
        public string FirstTeamName { get; set; }
        public string SecondTeamName { get; set;}

        public int FirstTeamScore { get; set; }
        public int SecondTeamScore { get; set; }

        public  enum enGamesPlayed{Trix=0,Collactions=1,KingOfHarts=2,Dimoned=3,Queen=4};

        public enGamesPlayed[] Game = {enGamesPlayed.Trix,enGamesPlayed.Collactions,enGamesPlayed.KingOfHarts,enGamesPlayed.Dimoned,enGamesPlayed.Queen };

        public enGamesPlayed[] GamePaleyed =new enGamesPlayed[5];

        public enGamesPlayed CurrentGame=enGamesPlayed.Trix;

    }
}
