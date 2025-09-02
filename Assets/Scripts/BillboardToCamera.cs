using UnityEngine;

public class BillboardToCamera : MonoBehaviour
{
    Camera cam;

    void Start()
    {
        cam = Camera.main;
        if (cam == null)
        {
            cam = FindObjectOfType<Camera>();
        }
    }

    void LateUpdate()
    {
        if (cam == null) return;
        Vector3 forward = transform.position - cam.transform.position;
        forward.y = 0f; 
        if (forward.sqrMagnitude > 0.001f)
            transform.rotation = Quaternion.LookRotation(forward, Vector3.up);
    }
}
