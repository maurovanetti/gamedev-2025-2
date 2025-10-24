using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject projectilePrefab;
    public float horizontalInput;
    public float speed;
    public float xRange = 15.0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * speed *
            horizontalInput * Time.deltaTime);
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(
                -xRange,              // x
                transform.position.y, // y
                transform.position.z  // z
            );
        }
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(
                xRange,               // x
                transform.position.y, // y
                transform.position.z  // z
            );
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(
                projectilePrefab, 
                transform.position,
                transform.rotation
            );
        }
    }
}
