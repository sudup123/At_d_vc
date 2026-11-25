
using UnityEditor.Rendering.LookDev;
using UnityEngine;

public class AreaTremedeira : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            CameraShake cameraShake = FindFirstObjectByType<CameraShake>();

            if (cameraShake != null)
            {
                cameraShake.TremerCamera();
            }
        }
    }
}
