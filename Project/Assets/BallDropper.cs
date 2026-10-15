using UnityEngine;

public class BallDropper : MonoBehaviour
{
    public GameObject ballPrefab;
    public Transform spawnPoint;
    public GameManager gameManager;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(ballPrefab, spawnPoint.position, Quaternion.identity);
            gameManager.IncreaseScore();
        }
    }
}

