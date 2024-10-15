using UnityEngine;
using System;
using Unity.VisualScripting;

public class GameManager : MonoBehaviour
{
    public enum GameState {
        Start,
        Play,
        Pause,
        Quit
    }

    public enum SignageState {
        PlayWelcomeLoop,
        PlayContentOne,
        PlayContentTwo,
        PlayContentThree,
        PlayContentFour,
        PlayContentFive
    }

    //public delegate void StateChange();
    //public static StateChange onStateChange;

    public static event Action<GameState> StateChanged;
    private GameState m_state;
    public GameState GetGameState => m_state;

    public static event Action<SignageState> SignageChanged;
    private SignageState m_signageState;
    public SignageState GetSignageState => m_signageState;

    public static GameManager Instance { get; private set; }
    public static int myStaticCount = 0;

    [SerializeField]
    private GameObject m_playerObject;
    private Renderer m_playerRenderer;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Awake()
    {
        if(Instance == null) {
            Instance = this;
            myStaticCount += 1;
        } else {
            Destroy(gameObject);
            myStaticCount -=1;
        }
    }

    private void Start() {
        UpdateGameState(GameState.Start);
        UpdateSignageState(SignageState.PlayWelcomeLoop);
        m_playerRenderer = m_playerObject.GetComponent<Renderer>();

    }

    public void UpdateGameState(GameState gameState)
    {
        if (m_state == gameState) return;

        m_state = gameState;

        StateChanged?.Invoke(gameState);

        if(gameState == GameState.Play)
        {
            //Enter play state
        }
    }

    public void UpdateSignageState(SignageState signageState)
    {
        if (m_signageState == signageState) return;

        m_signageState = signageState;

        SignageChanged?.Invoke(signageState);

        switch (signageState) 
        {  
            case SignageState.PlayWelcomeLoop:
            Debug.Log("Play welcome loop");
            
            break;
            
            case SignageState.PlayContentOne:
            Debug.Log("Play content one");
            m_playerRenderer.material.SetColor("_BaseColor", Color.red);
            break;
            
            case SignageState.PlayContentTwo:
            Debug.Log("Play content two");
            m_playerRenderer.material.SetColor("_BaseColor", Color.green);
            break;
            
            case SignageState.PlayContentThree:
            Debug.Log("Play content three");
            m_playerRenderer.material.SetColor("_BaseColor", Color.blue);
            break;
            
            case SignageState.PlayContentFour:
            Debug.Log("Play content four");
            m_playerRenderer.material.SetColor("_BaseColor", Color.yellow);
            break;
            
            case SignageState.PlayContentFive:
            Debug.Log("Play content five");
            m_playerRenderer.material.SetColor("_BaseColor", Color.cyan);
            break;
        }
    }
}
