using UnityEngine;

public class MinimapFollow : MonoBehaviour
{
    public Transform player;

    void LateUpdate()
    {
        if (player != null)
        {
            // Houd Z gelijk zodat de camera op hoogte blijft
            transform.position = new Vector3(player.position.x, player.position.y, transform.position.z);
        }
    }
}
