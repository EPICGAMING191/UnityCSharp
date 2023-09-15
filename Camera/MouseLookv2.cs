using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLookv2 : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject camera;
    public GameObject player;
    public float sensitivityX = 2.0f;
    public float sensitivityY = 2.0f;
    public float minimumY = -90.0f;
    public float maximumY = 90.0f;

    void Start(){
     
    }

    // Update is called once per frame
    void Update()
    {
	float mouseX = Input.GetAxis("Mouse X");
    float mouseY = Input.GetAxis("Mouse Y");

    // Rotate the player horizontally
    transform.Rotate(Vector3.up * mouseX * sensitivityX);

    // Rotate the camera vertically with limits
    rotationX -= mouseY * sensitivityY;
    rotationX = Mathf.Clamp(rotationX, minimumY, maximumY);

    // Apply vertical rotation to the camera
    camera.transform.rotation = Quaternion.Euler(rotationX, 0, 0);
    camera.transform.position = player.transform.position + new Vector3(0f,2.5f,0f) 


    }
}