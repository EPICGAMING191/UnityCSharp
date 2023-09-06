using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptTemplate : MonoBehaviour
{
    public int data_int;
    public string data_string;
    public float data_float;
    // Start is called before the first frame update
    void Start(){
        
    }

    // Update is called once per frame
    void Update(){
        
    }
    void str(val){
        return Char.ToString(val)
    }
    void SaveString(string name, string value){
        PlayerPrefs.SetString(name, value);
        Debug.Log("Value " + name + " has been set to " + value)
    }
    void SaveInt(string name2, int value2){
        PlayerPrefs.SetInt(name2, value2);
        Debug.Log("Value " + name2 + " has been set to " + str(value2))
    }
    void SaveFloat(string name3, float value3){
        PlayerPrefs.SetFloat(name3, value3);
        Debug.Log("Value " + name3 + " has been set to " + str(value3))
    }
    
    void LoadValue(string valname , string type){
	    if (PlayerPrefs.HasKey(valname)){
            if (type == "String"){
		        data_string = PlayerPrefs.GetString(valname);
                Debug.Log("Game value " + valname + "with value " +str(data_string)+ " loaded!");
            }
            else if (type == "Integer"){
                data_int = PlayerPrefs.GetInt(valname);
                Debug.Log("Game value " + valname + "with value " +str(data_int)+ " loaded!");
            }
            else if (type == "Float"){
                data_float = PlayerPrefs.GetFloat(valname);
                Debug.Log("Game value " + valname + "with value " +str(data_float)+ " loaded!");
            }
	    }
	    else{
		    Debug.LogError("There is no save data!");
            return false
        }
}
}