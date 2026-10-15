using UnityEngine;

public class PlankController : MonoBehaviour
{
    public float moveSpeed = 2f;

    void Update()
    {
        float x = Mathf.PingPong(Time.time * moveSpeed, 4) - 2;
        transform.position = new Vector3(x, transform.position.y, 0);
    }
}
