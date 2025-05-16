using UnityEngine;

public class CameraFollow1 : MonoBehaviour
{
    public Transform target; // Dit is je speler
    public Vector3 offset;   // Eventueel afstand tot speler

    void Update()
    {
        if (target != null)
        {
            transform.position = new Vector3(
                target.position.x + offset.x,
                target.position.y + offset.y,
                transform.position.z  // Z blijft hetzelfde voor 2D
            );
        }
    }
}
