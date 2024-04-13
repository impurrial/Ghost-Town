using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;
    public float Speed = 0.125f;
    public Vector3 offset;
    public float minX, maxX, minY, maxY, minZ, maxZ;
    void FixedUpdate()
    {
        Vector3 desiredPosition = player.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, Speed);
        
        smoothedPosition.x = Mathf.Clamp(smoothedPosition.x, minX, maxX);
        smoothedPosition.y = Mathf.Clamp(smoothedPosition.y, minY, maxY);
        smoothedPosition.z = Mathf.Clamp(smoothedPosition.z, minZ, maxZ);
        
        transform.position = smoothedPosition;
    }
}