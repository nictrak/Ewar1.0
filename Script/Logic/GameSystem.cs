using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSystem : MonoBehaviour
{
    [SerializeField]
    private Player player1;
    [SerializeField]
    private Player player2;
    [SerializeField]
    private Player player3;
    [SerializeField]
    private Player player4;

    private Dictionary<int, Player> playerDict;

    public int NumberOfPlayer;
    public int InitialPopulation;
    public int InitialStatus;
    public int InitialDNA;
    public static GameSystem Instance;

    private int startTurnPlayer;
    private int currentPlayer;
    public enum GameState
    {
        Setup,
        Environment,
        Evole
    }

    private GameState state;

    private void Awake()
    {
        if (Instance != null) Destroy(this.gameObject);
        else Instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        //Test only code
        state = GameState.Setup;
        NumberOfPlayer = 4;
        //end test only
        playerDict = new Dictionary<int, Player>();
        playerDict.Add(1, player1);
        playerDict.Add(2, player2);
        playerDict.Add(3, player3);
        playerDict.Add(4, player4);
        startTurnPlayer = 1;
        currentPlayer = startTurnPlayer;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Setup(int numberOfPlayer)
    {
        NumberOfPlayer = numberOfPlayer;
        if(NumberOfPlayer <= 3)
        {
            player4.gameObject.SetActive(false);
        }
        if (NumberOfPlayer <= 2)
        {
            player3.gameObject.SetActive(false);
        }
    }
    private void ToNextStartTurnPlayer()
    {
        startTurnPlayer++;
        if (startTurnPlayer > NumberOfPlayer) startTurnPlayer = startTurnPlayer - NumberOfPlayer;
    }
}
