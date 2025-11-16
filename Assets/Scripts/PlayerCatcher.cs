using UnityEngine;

public class PlayerCatcher : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("OnTriggerEnter fired with: " + other.name);

        if (other.CompareTag("Player"))
        {
            Debug.Log("Player detected! Teleporting...");

            Vector3 targetPosition = new Vector3(10.35f, 0.9f, 0f);

            CharacterController cc = other.GetComponent<CharacterController>();
            if (cc != null)
            {
                cc.enabled = false;
            }

            other.transform.position = targetPosition;
            other.transform.rotation = Quaternion.identity;

            if (cc != null)
            {
                cc.enabled = true;
            }

            Debug.Log("Teleport complete! New position: " + other.transform.position);
        }
        else
        {
            Debug.Log("Collider is not the player: " + other.tag);
        }
    }
}



