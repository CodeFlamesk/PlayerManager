namespace PlayerManagerApp;

public class Player
{
    private readonly int _idPlayer;
    private int _numberPlayer;
    private string _namePlayer;
    private byte _levelPlayer; //використав байт бо він займає 1 байт і я поставив умову що лвл буде >100, якшо заказчик захоче збільшити лвл то gg, на що більше звертати уваги, на продуктивність чи на динамічність? ; 
    private bool _flag;

    public Player(int idPlayer, int numberPlayer, string namePlayer, byte levelPlayer, bool flag)
    {
       IdPlayer = idPlayer; 
       NumberPlayer = numberPlayer;
       NamePlayer = namePlayer;
       LevelPlayer = levelPlayer;
       Flag = flag;
    }
    public int IdPlayer { get; }

    public string NamePlayer
    {
        get { return _namePlayer; }
        set
        {
            if (!string.IsNullOrWhiteSpace(value) && value.Length < 10)
            {
                _namePlayer = value;
            }
            else
            {
                Console.WriteLine("NamePlayer is too long or empty");
            }
        }
    }

    public byte LevelPlayer
    {
        get { return _levelPlayer; }
        set
        {
            if (value < 100)
            {
                _levelPlayer = value;
            }
            else
            {
                Console.WriteLine("The _levelPlayer value is too high ");
            }
        }
    }

    public int NumberPlayer
    {
        get { return _numberPlayer; }
        set
        {
            if (value > 0)
            {
                _numberPlayer = value;
            }
            else
            {
                Console.WriteLine("Error numberPlayer, value < 0");
            }
        }
    }
    public bool Flag { get; set; }
    public override string ToString()
    {
        return $"ID: {IdPlayer}, Number: {NumberPlayer}, Name: {NamePlayer}, Level: {LevelPlayer}, Banned: {Flag}";
    }

}