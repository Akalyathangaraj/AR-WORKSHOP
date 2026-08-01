using UnityEngine;

public class AutoColorChange : MonoBehaviour
{
    private Renderer rend;

    void Start()
    {
        rend = GetComponent<Renderer>();
        InvokeRepeating("ChangeColor", 0f, 1f);
    }

    void ChangeColor()
    {
        rend.material.color = new Color(Random.value, Random.value, Random.value);
    }
}
