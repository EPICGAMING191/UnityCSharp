using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class UIController : MonoBehaviour{
    public int score;
    public TextMeshProUGUI scoreText;
    private int newScore_02;
    public Button startButton;
    public int state = -1;
    public SkillUnlocker su;
    public UIController ui;
    public GameObject titleScreen;

    // Start is called before the first frame update
    void Start(){
        startButton=GetComponent<Button>();
        ui=FindObjectOfType<UIController>();
        su=FindObjectOfType<SkillUnlocker>();
        startButton.OnClick.AddListener(loadStoryMode)
        score=0;
        state=0;
        UpdateScore(0)
    }

    // Update is called once per frame
    void Update(){
       
    }

    void UpdateScore(int newScore){
        scoreText.text = "Score: " + newScore;
        score=newScore;
    }

    void AddPoints(int pointsToAdd){
        newScore_02=score + pointsToAdd;
        UpdateScore(newScore_02)
    }

    void loadStoryMode(){
        scs.gameState=1;
        titleScreen.GameObject.SetActive(false);
    }
}