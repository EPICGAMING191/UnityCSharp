using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLookUpdated : MonoBehaviour
{
    // Start is called before the first frame update
    public Quaternion rotation;
    public Vector3 relativePos;
    public GameObject player_head;
    public Vector3 mouse_location;
    public GameObject player;
    public float turn_speed = 4.0f;
    public double y;
    public double x
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        x = Input.GetAxis("Mouse X");
        y = Input.GetAxis("Mouse Y");
        mouse_location = new Vector3(x,y,0)
        relativePos = mouse_location - player.transform.position;
        rotation = Quaternion.LookRotation(relativePos, Vector3.up);
        player_head.transform.rotation = Quaternion.Lerp(transform.rotation, rotation, Time.time * turn_speed);

    }
}
