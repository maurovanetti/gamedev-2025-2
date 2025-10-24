using UnityEditor.ShaderGraph.Internal;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound = 30;
    private float bottomBound = -10;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > topBound ||
            transform.position.z < bottomBound)
        {
            Destroy(gameObject);
        }        
    }
}
