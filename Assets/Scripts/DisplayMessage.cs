using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class DisplayMessage : MonoBehaviour {

	public GameObject _messagePanel;
	public Image message;

	private float time;
	private bool run;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (run) {
			time -= Time.deltaTime;
			UpdateTime (time);
		}
	}

	//
	public void AppearMessage() {
		_messagePanel.SetActive (true);
		time = 0.5f;
		run = true;
	}

	//
	public void UpdateTime(float t) {
		if (t <= 0) {
			_messagePanel.SetActive (false);
			run = false;
		}
	}
}
