using UnityEngine;

public class Player_movement : MonoBehaviour
{
    public Rigidbody rb;
    public float forward_force = 700f;
    public float sideways_force = 600f;
    public float jump_force = 100f;
    public bool jump_enabled = true;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Player_movement started !!!");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //rb.AddForce(0, 0, forward_force * 1);
        rb.AddForce(Vector3.forward * forward_force);
        if(Input.GetKey("d")) {
            rb.AddForce(Vector3.right * sideways_force);
        }
        if(Input.GetKey("a")) {
            rb.AddForce(Vector3.left * sideways_force);
        }
        if(Input.GetKey(KeyCode.Space)) {
            Debug.Log("Spacebar pressed");
            if (jump_enabled) {
                Debug.Log("Jumping");
                rb.AddForce(Vector3.up * jump_force, ForceMode.Impulse);
                Debug.Log("Jumped");
            }
            jump_enabled = false;
        }
    }
}
