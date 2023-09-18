using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform player; // Reference to the player object.
    public float sensitivity = 2.0f; // Mouse sensitivity.
    public float maxVerticalAngle = 80.0f; // Maximum camera tilt angle.
    public float minVerticalAngle = -80.0f; // Minimum camera tilt angle.

    private float rotationX = 0;
    private float rotationY = 0;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked; // Lock the cursor to the center of the screen.
        Cursor.visible = false; // Hide the cursor.
    }

    void Update()
    {
        // Capture mouse input for camera rotation.
        float mouseX = Input.GetAxis("Mouse X") * sensitivity;
        float mouseY = Input.GetAxis("Mouse Y") * sensitivity;

        // Rotate both the player and camera horizontally based on mouse input.
        rotationY += mouseX;
        rotationX -= mouseY;
        rotationX = Mathf.Clamp(rotationX, minVerticalAngle, maxVerticalAngle);

        // Apply the rotations to the player and camera.
        player.localRotation = Quaternion.Euler(0, rotationY, 0);
        transform.localRotation = Quaternion.Euler(rotationX, rotationY, 0);
    }
}
