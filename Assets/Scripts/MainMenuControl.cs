using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuControl : MonoBehaviour
{
    public void StartSimulation()
    {
        SceneManager.LoadScene(1);
    }
}
