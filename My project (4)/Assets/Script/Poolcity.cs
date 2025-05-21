using UnityEngine;
using UnityEngine.SceneManagement;

public class Poolcity : MonoBehaviour
{
    // Wissel op basis van naam
    public void LoadSceneByName(string Poolcity)
    {
        SceneManager.LoadScene(Poolcity);
    }

    // Wissel op basis van index
    public void LoadSceneByIndex(int index)
    {
        SceneManager.LoadScene(index);
    }
}
