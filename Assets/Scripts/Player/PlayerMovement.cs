using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Components
    private Animator animator;
    private Rigidbody2D rb;

    // Movement values
    private Vector2 movement;
    [SerializeField] private float speed;

    private void Start() {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }
    private void Update() {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");

        movement = new(x, y);
    }

    private void FixedUpdate() {
        if(movement != Vector2.zero){
            Vector3 toAdd = new Vector2(movement.x, movement.y) * speed * Time.fixedDeltaTime * 1000f;
            rb.AddForce(toAdd);
            animator.SetBool("moving", true);
            Rotate();
        }
        else{
            animator.SetBool("moving", false);
        }
    }
    private void Rotate(){
        float angle = Mathf.Atan2(movement.y, movement.x) * Mathf.Rad2Deg + 90f;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
    }
}
