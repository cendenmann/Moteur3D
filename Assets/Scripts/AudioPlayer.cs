using UnityEngine;
using System.Collections;

public class AudioPlayer : MonoBehaviour {

    private int triggerCount = 0;

    void OnTriggerEnter(Collider collider)
    {
        AudioSource ah = collider.gameObject.GetComponent<AudioSource>();

        if (ah != null)
        {
            //audio.clip = ah.playClip;
            ah.Play();
            //triggerCount++;
        }
    }

    void OnTriggerExit(Collider collider)
    {
        AudioSource ah = collider.gameObject.GetComponent<AudioSource>();

        if (ah != null)
        {
            triggerCount--;
            if (triggerCount <= 0)
            {
                ah.Stop();
            }
        }
    }
}
