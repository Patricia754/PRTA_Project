using UnityEngine;

public class PlayerSpawn : MonoBehaviour
{
    void Start()
    {
        if (GameManager.instance != null && GameManager.instance.useCustomSpawn)
        {
            transform.position = GameManager.instance.spawnPosition;
            GameManager.instance.useCustomSpawn = false; // reset
        }
    }
}