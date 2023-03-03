using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private float moveSpeed = 3f;
    private Animator anim;
    private Vector3 movement;
    private Vector3 direction;

    private void Start()
    {
        anim = GetComponent<Animator>();
        direction = new Vector3(1, 1, 1);
    }
    void Update()
    {
        movement = new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"), 0);
        transform.position += movement.normalized * moveSpeed * Time.deltaTime;

        if (movement == Vector3.zero)
        {
            anim.Play("Idle");
        }
        else if (movement == Vector3.left)
        {
            transform.localScale = new Vector3(-1, 1, 1);
            direction = new Vector3(-1, 1, 1);
            anim.Play("Walking");
        }
        else if (movement == Vector3.right)
        {
            transform.localScale = new Vector3(1, 1, 1);
            direction = new Vector3(1, 1, 1);
            anim.Play("Walking");
        }
        else if (movement == Vector3.up)
        {
            transform.localScale = direction;
            anim.Play("Walking");
        }
        else if (movement == Vector3.down)
        {
            transform.localScale = direction;
            anim.Play("Walking");
        }
    }
}
