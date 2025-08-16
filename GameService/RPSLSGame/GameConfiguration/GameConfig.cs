namespace RPSLSGame.GameConfiguration
{
    public static class GameConfig
    {
        public static readonly Dictionary<int, string> choiceMap = new() {
            { 1, "rock"},
            { 2, "paper"},
            { 3, "scissors"},
            { 4, "lizard"},
            { 5, "spock"}
        };

        public static readonly Dictionary<string, List<string>> winnerMap = new(){
            { "rock",     new List<string> { "scissors", "lizard" } },
            { "paper",    new List<string> { "rock", "spock" } },
            { "scissors", new List<string> { "paper", "lizard" } },
            { "lizard",   new List<string> { "spock", "paper" } },
            { "spock",    new List<string> { "scissors", "rock" } }
        };
    }
}
