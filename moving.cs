using UnityEngine;

public class InteractCube : MonoBehaviour
{
    public float moveHeight = 2f;
    private Vector3 originalPosition;
    private bool isUp = false;

    void Start()
    {
        originalPosition = transform.position;
    }

    void OnMouseDown()
    {
        if (!isUp)
        {
            transform.position = originalPosition + Vector3.up * moveHeight;
            isUp = true;
        }
        else
        {
            transform.position = originalPosition;
            isUp = false;
        }
    }
}