using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float turnSpeed = 3.0f;
    public GameObject player;
    public float horizontalInput;
    public float forwardInput;
    public float speed = 20;
    private Rigidbody playerrb;
    public float jumpForce;
    public bool isOnGround = true;
    public float gravityModifier;
    private SceneController sc;
    // Start is called before the first frame update
    void Start()
    {
        playerrb = GetComponent<Rigidbody>();
        sc = GetComponent<SceneController>(); 
        Physics.gravity*=gravityModifier;
    }

    // Update is called once per frame
    void Update(){
        if (sc.state !=0){
            forwardInput=Input.GetAxis("Vertical");
            horizontalInput=Input.GetAxis("Horizontal");
            transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
            transform.Rotate(Vector3.up , turnSpeed * horizontalInput * Time.deltaTime);
            if (Input.GetKeyDown(KeyCode.Space)){
                playerrb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
                Debug.Log("Vertical Input: " + transform.position);
                isOnGround=false;
                Debug.Log("Jump");
            }
        }
    }
    private void OnCollisionEnter(Collision obj){
        if(obj.gameObject.tag.Equals("ground") == true ){
            isOnGround=true;
        }
    }
}
