using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float turnSpeed = 3.0f;
    public GameObject player;
    public float horizontalInput;
    public float forwardInput;
    public float speed;
    private Rigidbody playerrb;
    public float jumpForce;
    public bool isOnGround = true;
    public float gravityModifier = 1;
    public SkillUnlocker su;
    // Start is called before the first frame update
    void Start()
    {
        SceneController sc = FindObjectOfType<SceneController>(); 
        speed=su.playerSpeed;
        Debug.Log("Player Speed: " + speed);
        playerrb = GetComponent<Rigidbody>();
        sc = GetComponent<SceneController>(); 
        Physics.gravity*=gravityModifier;
    }

    // Update is called once per frame
    void Update(){
        speed=su.playerSpeed;
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
        else if(obj.gameObject.tag.Equals("platform") == true){
            isOnGround = true;
        }
    }
}
