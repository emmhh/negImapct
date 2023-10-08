using UnityEngine;
using UnityEngine.SceneManagement;

public class floorTrigger : MonoBehaviour
{
    // Store the respawn position
    //private Vector3 respawnPosition = new Vector3(7.49737453f, 1.82008123f, 9.57754993f);

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            RestartGame();
        }
    }

    public void RestartGame()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex);
        // Set the player's position to the respawn position
        //GameObject player = GameObject.FindGameObjectWithTag("Player");
        //if (player != null)
        //{
        //   player.transform.position = respawnPosition;
        // }
    }
}
