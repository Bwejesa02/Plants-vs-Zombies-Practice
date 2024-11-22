using UnityEngine;

public class CrazyDave : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Transform[] lanes; 
    private int currentLane = 2; 

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow) && currentLane > 0)
        {
            currentLane--;
            MoveToLane();
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow) && currentLane < lanes.Length - 1)
        {
            currentLane++;
            MoveToLane();
        }
    }

    void MoveToLane()
    {
        transform.position = new Vector2(transform.position.x, lanes[currentLane].position.y);
    }
}
