
namespace UnityExample
{
    public class Trivial : IGame
    {
        private string _status;

        public Trivial()
        {
            Name = "Trivial ";
            CurrentPlayers = 0;
            MinPlayers = 2;
            MaxPlayers = 8;
            _status = "No active games";

        }


        public string Name { get; set; }

        public int CurrentPlayers { get; set; }

        public int MinPlayers { get; set; }

        public int MaxPlayers { get; set; }

        public void AddPlayer()
        {
            CurrentPlayers++;
        }

        public void Play()
        {
            if ((CurrentPlayers > MaxPlayers) || (CurrentPlayers < MinPlayers))
                _status = string.Format("{0}: No se puede jugar con {1} jugador.", Name, CurrentPlayers);
            else
                _status = string.Format("{0}: jugando con{1} jugadores.", Name, CurrentPlayers);
        }

        public void RemovePlayer()
        {
            CurrentPlayers--;
        }

        public string Result()
        {
            return _status;
        }
    }
}
