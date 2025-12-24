using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    void Start()
    {
        // Carica le scene in modo additivo così si vedono tutte insieme
        SceneManager.LoadScene("Environment", LoadSceneMode.Additive);
        SceneManager.LoadScene("Props", LoadSceneMode.Additive);
        SceneManager.LoadScene("Lighting", LoadSceneMode.Additive);
        SceneManager.LoadScene("Audio", LoadSceneMode.Additive);
    }
}
