using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using BayatGames.SaveGamePro;

public class GameManager : MonoBehaviour {


    public static GameManager instance1;

    public Text scoreText;


   

    int score = 0;
    int defaultScore = 0;


    private void Awake()
    {
        instance1 = this;
    }

    // Use this for initialization
    void Start () {
        Reload();
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    public void IncrementScore(){


            score++;
            scoreText.text = score.ToString();

    }

    public void SaveData(){

        SaveGame.Save<int>("score", score);
    }

    public void Reload(){

        int lastScore = SaveGame.Load<int>("score", defaultScore);
        score = lastScore;
        scoreText.text = lastScore.ToString();
    }

}
