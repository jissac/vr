using UnityEngine;
using System.Collections;

public class ScoreAbsorber : MonoBehaviour {

    public int score;

	// Use this for initialization
	void Start () {
        ScoreKeeper oldkeeper = FindObjectOfType<ScoreKeeper>();
        if(oldkeeper)
        {
			score = oldkeeper.score;
			Destroy(oldkeeper.gameObject);   
        }

	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
