using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public Player_movement movement;
    void OnCollisionEnter (Collision collision_info) {
        Debug.Log(collision_info.collider.tag);
        if (collision_info.collider.tag == "Obstacle") {
            Debug.Log("collision occured");
            movement.enabled = false;
        }
        if (collision_info.collider.tag == "Ground") {
            Debug.Log("Jump enabled");
            movement.jump_enabled = true;
        }
    }
}
