using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class TimelineTrigger : MonoBehaviour
{
    public PlayableDirector timeline;

    private void OnTriggerEnter(Collider other)
    {
        if (timeline != null)
        {
            timeline.Play();
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (timeline != null)
        {
            timeline.Play();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (timeline != null)
        {
            timeline.Stop();
        }
    }
}
