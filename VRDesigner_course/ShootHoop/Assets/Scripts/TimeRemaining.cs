using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TimeRemaining : MonoBehaviour {

    Text text;
    LevelManager levelmanager;
	// Use this for initialization
	void Start () {
        
        levelmanager = FindObjectOfType<LevelManager>();
        text = GetComponent<Text>();           
	
	}
	
	// Update is called once per frame
	void Update () {
        text.text = "Time Remaining: " + levelmanager.timeTillNextLevel;
	
	}
}
