using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player_Move : MonoBehaviour
{
    // Start is called before the first frame update

    public float speed = 10f;

    public Animator animator;

    Vector2 mov;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;
        animator.SetFloat("S",0);
        animator.SetFloat("H", 0);
        animator.SetFloat("V", 0);

        if (Input.GetKey("w"))
        {
            pos.y += speed * Time.deltaTime;
            animator.SetFloat("V", 1);
            animator.SetFloat("S",1);
        }
        if (Input.GetKey("a"))
        {
            pos.x -= speed * Time.deltaTime;
            animator.SetFloat("H",-1 );
            animator.SetFloat("S",1);
        }
        if (Input.GetKey("s"))
        {
            pos.y -= speed * Time.deltaTime;
            animator.SetFloat("V",-1 );
            animator.SetFloat("S",1);

        }
        if (Input.GetKey("d"))
        {
            pos.x += speed * Time.deltaTime;
            animator.SetFloat("H", 1);
            animator.SetFloat("S",1);
        }
        transform.position = pos;

     
    }
}
