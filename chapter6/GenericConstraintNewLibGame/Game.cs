namespace GameLibGenericConstraintNew;

public class Game
{
public string Name = "";
public int Players;

}
public class GameFactory
{
    public static T creat<T>()where T : new()
    {
        return new T();
    }
}