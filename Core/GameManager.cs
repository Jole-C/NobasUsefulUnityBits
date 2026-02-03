using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// Basic GameManager class.
/// </summary>
/// 
public class GameManager : ServiceMonoBehaviour
{
    [SerializeField] string startingScene = "Menu";

    protected override void Awake()
    {
        ServiceLocator.RegisterService(this);
        DontDestroyOnLoad(this);
    }

    protected override void Start()
    {
        SceneManager.LoadScene(startingScene);
    }

    void OnDestroy()
    {
        ServiceLocator.UnregisterService<GameManager>();
    }
}
