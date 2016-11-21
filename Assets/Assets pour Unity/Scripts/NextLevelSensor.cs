using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class NextLevelSensor : MonoBehaviour {
    public GameObject _interface;
	// Use this for initialization
	void Start () {
	
	}

    void OnTriggerEnter(Collider intruder)
    {
        if (intruder.tag == "Player")
        {
           _interface.GetComponent<GameInterface>().OnNextLevel();
        }
    }   
}
