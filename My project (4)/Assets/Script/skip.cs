using UnityEngine;
using UnityEngine.SceneManagement;

public class Cutscene : MonoBehaviour
{
    public void Skip()
    {
        SceneManager.LoadSceneAsync(4);
    }
}