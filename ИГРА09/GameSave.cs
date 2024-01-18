namespace ИГРА09
{
    internal class GameSave
    {
        public int Score { get; internal set; }
        public int Level { get; internal set; }
        public bool GameOver { get; internal set; }

        internal void LoadGame(string v)
        {
            throw new NotImplementedException();
        }

        internal void SaveGame(string v)
        {
            throw new NotImplementedException();
        }
    }
}