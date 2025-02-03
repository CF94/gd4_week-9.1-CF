using UnityEngine;

public class Player : MonoBehaviour
{
    GameObject player;
    public bool playerActive;
    private void Start()
    {
        playerActive = true;
    }

    private void Update()
    {
        if (playerActive == false)
        {
            player.SetActive(false);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("TimelineStart"))
        {
            playerActive = false;
        }
    }
}
