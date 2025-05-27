using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;

public class CutscenePlayer : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    public RawImage rawImage;

    void Start()
    {
        videoPlayer.Play();
    }

    void Update()
    {
        if (videoPlayer.texture != null)
        {
            rawImage.texture = videoPlayer.texture;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            videoPlayer.Stop();
            rawImage.gameObject.SetActive(false);
        }

        if (videoPlayer.isPrepared && !videoPlayer.isPlaying && videoPlayer.frame > 0)
        {
            rawImage.gameObject.SetActive(false);
        }
    }
}