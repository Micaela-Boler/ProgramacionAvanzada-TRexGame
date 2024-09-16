using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private bool isMoving = true;
    [SerializeField] float jumpForce = 5f;
    [SerializeField] Rigidbody2D _playerRB;

    [Header("AUDIO AND ANIMATION")]
    [SerializeField] AudioSource jumpAudio;
    [SerializeField] Animator jumpAnimator;


    void Update()
    {
        Movement();
    }


    private void Movement()
    {
        jumpAnimator.SetBool("jump", isMoving);

        if (Input.GetKeyDown(KeyCode.Space) && isMoving)
        {
            _playerRB.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            isMoving = false;

            jumpAudio.Play();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        isMoving = true;
    }
}
