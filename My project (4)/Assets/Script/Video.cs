using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;

public class CutsceneTrigger : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    public GameObject cutsceneUI;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            cutsceneUI.SetActive(true);
            videoPlayer.Play();
        }
    }
}
