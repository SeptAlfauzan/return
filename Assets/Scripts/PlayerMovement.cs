using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{ 
    // public Transform transform;
    public SpriteRenderer spriteRenderer;
    public Vector2 speed = new Vector2(20, 20);
    public Animator PlayerAnimator;
    Vector2 input;
    public new Rigidbody2D rigidbody;
    bool isFlipped = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Update() {
        Debug.Log(Input.GetAxis("Fire1"));
        input.x = Input.GetAxis("Horizontal");
        input.y = Input.GetAxis("Vertical");

// change idle animation to run animation
        float animatorSpeed = GetSetSpeedAnimator(input);
        PlayerAnimator.SetFloat("Speed", animatorSpeed);

        if(Input.GetAxis("Horizontal") < 0){
            isFlipped = true;
            Flip(isFlipped);
        }
        if(Input.GetAxis("Horizontal") > 0){
            isFlipped = false;
            Flip(isFlipped);
        }

        Vector2 movement = new Vector2(speed.x * input.x, speed.y * input.y);
        movement *= Time.deltaTime;

        rigidbody.MovePosition(rigidbody.position + movement);
    }
        // Update is called once per frame
    void FixedUpdate() {
        
    }
    void Flip(bool isFlipped){
        spriteRenderer.flipX = isFlipped;
    }

    float GetSetSpeedAnimator(Vector2 inputAxis){
        if(Mathf.Abs(inputAxis.x) > 0 || Mathf.Abs(inputAxis.y) > 0){
            return 1;
        }
        return 0;
    }
}