using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillUnlocker : MonoBehaviour
{
    public float playerSpeed = 20;
    public float player_health=10;
    public float double_jump_level;
    public bool bow_and_arrow;
    public int health_level = 1;
    public float bow_and_arrow_level;
    // Start is called before the first frame update
    void Start(){
        
    }

    // Update is called once per frame
    void Update(){
       
    }
    void print(str strtoprint){
        Debug.Log(strtoprint)
    }
    //1 = Double Jump
    //2 = Player Speed
    //3 = Player Health
    //4 = Unlocks Bow & Arrow
    void Upgrade(int skill){
        if (skill == 1){
            double_jump_level = double_jump_level + 1;
        }
        else if (skill == 2){
            playerSpeed=playerSpeed + 10;
        }
        else if (skill == 3){
            player_health=player_health + (health_level * 10);
            health_level=health_level + 1;
        }
        else if (skill == 4){
            if (bow_and_arrow != true){
                bow_and_arrow = true;
                bow_and_arrow_level = 1;
            }
            else{
                bow_and_arrow_level=bow_and_arrow_level + 1
            }
        }
    }

}