using UnityEngine;
using UnityEngine.Playables;

public class ElevatorTrigger : MonoBehaviour
{
    public PlayableDirector director;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            director.Play();
            gameObject.SetActive(false);
        }
    }
}

