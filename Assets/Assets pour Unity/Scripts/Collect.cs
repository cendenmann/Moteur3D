using UnityEngine;
using System.Collections;

public class Collect : MonoBehaviour {

    public int scoreValue = 1;

    void Start()
    {

    }

    void OnTriggerEnter(Collider intruder)
    {
        if (intruder.tag == "Player")
        {
            //this.gameObject.SetActive(false);
            intruder.GetComponent<PlayerBehaviourScript>().AddScore(scoreValue);
            Destroy(this.gameObject);
        }
    }   
}
