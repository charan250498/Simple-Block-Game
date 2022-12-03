using UnityEngine;

public class Player_movement : MonoBehaviour
{
    public Rigidbody rb;
    public float forward_force = 1000f;
    public float sideways_force = 1000f;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("hello World");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0,0,forward_force * Time.deltaTime);
        if(Input.GetKey("d")) {
            rb.AddForce(sideways_force * Time.deltaTime, 0, 0);
        }
        if(Input.GetKey("a")) {
            rb.AddForce(-1 * sideways_force * Time.deltaTime, 0, 0);
        }
    }
}
