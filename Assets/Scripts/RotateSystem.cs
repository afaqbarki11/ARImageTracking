using UnityEngine;

public class RotateSystem : MonoBehaviour
{
    public float speed = 20f; // Speed set karne ke liye variable

    void Update()
    {
        // Y-axis par rotate karega
        transform.Rotate(0, speed * Time.deltaTime, 0);
    }
}