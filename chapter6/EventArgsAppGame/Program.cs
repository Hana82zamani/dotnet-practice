using GameLibEventArgs;

Game game = new()
{
    Name = "Minecraft"
};
ScoreEventArgs scoreEventArgs = new()
{
    NewScore = 150
};
 void Game_ScoreChanged(object? sender, ScoreEventArgs e)
{
    if (sender is not Game game1) return; 

    Console.WriteLine($"{game.Name} is new score: {scoreEventArgs.NewScore}");
}
game.ScoreChanged+=Game_ScoreChanged;

game.ChangeScore(scoreEventArgs);
