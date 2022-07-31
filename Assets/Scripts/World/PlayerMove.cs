using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed = 10f;
    private Animator animator;
    void Start()
    {
        animator = GetComponent<Animator>();  
    }
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        float vertical = Input.GetAxis("Vertical") * Time.deltaTime * speed;
        if (horizontal > 0f)
        {
            if(!animator.GetBool("isRight")) animator.Play("Rotate Right");
            animator.SetBool("isRight", true);
            transform.Translate(horizontal, 0, 0, Space.World);
        }
        else if (horizontal < 0f)
        {
            if(animator.GetBool("isRight")) animator.Play("Rotate Left");
            animator.SetBool("isRight", false);
            transform.Translate(horizontal, 0, 0, Space.World);
        }
        if (animator.GetBool("isRight")) transform.Translate(0, 0, vertical, Space.World);
        else transform.Translate(0, 0, vertical, Space.World);
    }
}
