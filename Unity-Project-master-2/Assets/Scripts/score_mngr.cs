using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score_mngr : MonoBehaviour {
	public int num_lives;
	public long score_num;
	public Text lives;
	public Text score;
    public Text topMessage;
	public AudioSource hit;

	// Use this for initialization
	void Start () {
		score_num = 0;
		num_lives = 3;

		SetLivesText ();
		SetScoreText ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void increase_score() {
        Debug.Log("Updating score to " + score_num.ToString());
		score_num++;
		hit.Play ();
		SetScoreText ();
	}

	public void decrease_lives() {
		//Debug.Log ("In decrease lives.");
		num_lives--;
		SetLivesText ();
        if (num_lives == 0)
        {
            topMessage.text = "Game Over";
        }
	}

	public int getLives() {
		return num_lives; 
	}

	public long getScore() {
		return score_num;
	}

	void SetLivesText() {
		lives.text = "Lives: " + num_lives.ToString ();

	}

	void SetScoreText() {
		score.text = "Score: " + score_num.ToString ();
	}

}
