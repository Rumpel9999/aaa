using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameScript : MonoBehaviour {

	public Text timeLabel;
	public Text countLabel;
	int counter = 0;
	float timer = 0.0f;
	int flag = 0;
	int stopper = 0;


	// Use this for initialization
	void Start () {
		timeLabel.text = "ぴったり３秒で止めよう！";
	}
	
	// Update is called once per frame
	void Update () {
		if (flag == 1) {
			timer += Time.deltaTime;
			timeLabel.text = timer.ToString ("F1");
			transform.localScale = new Vector3 (1, 1, 1) * timer;
		}
	}

	public void StartButton(){
		flag = 1;
		stopper = 0;
		timer = 0.0f;
	}

	public void StopButton(){
		flag = 0;
		if (2.95f < timer && timer < 3.05f && stopper == 0) {
			timeLabel.text = "成功！";
			counter += 1;
			countLabel.text = counter.ToString();
			stopper = 1;
		} else {
			timeLabel.text = "もう一回！";
		}
	}

}
