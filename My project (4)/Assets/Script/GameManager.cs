using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public Vector3 spawnPosition;
    public bool useCustomSpawn = false;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject); // Blijf bestaan tussen scenes
        }
        else
        {
            Destroy(gameObject); // voorkom dubbele managers
        }
    }
}
