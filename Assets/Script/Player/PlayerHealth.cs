using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public GameOver screen;
    bool isDead = false;
    Animator animator;


    void Start()
    {
       animator = GetComponent<Animator>();
    }
 

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            isDead = true;
            animator.SetBool("dead", isDead);

            screen.activeScreen();
        }    
    }
}
