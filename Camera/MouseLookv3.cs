float mouseX = Input.GetAxis("Mouse X") * sensitivity;
float mouseY = Input.GetAxis("Mouse Y") * sensitivity;

// Rotate both the player and camera horizontally based on mouse input.
rotationY += mouseX;
rotationX -= mouseY;
rotationX = Mathf.Clamp(rotationX, minVerticalAngle, maxVerticalAngle);

// Apply the rotations to the player and camera.
player.localRotation = Quaternion.Euler(0, rotationY, 0);
transform.localRotation = Quaternion.Euler(rotationX, rotationY, 0);
