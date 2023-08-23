using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimations : MonoBehaviour
{

    [SerializeField] private Animator anim;

    [SerializeField] private PlayerMovement pMove;

    [SerializeField] private PlayerExplode pExplode;

    // Update is called once per frame
    void Update()
    {
        playerWalk();
        playerExploding();
    }

    private void playerWalk()
    {
        if (Input.GetAxisRaw("Horizontal") != 0 && pMove.IsGrounded())
        {
            anim.SetBool("Movement", true);
        }
        else
        {
            anim.SetBool("Movement", false);
        }
    }

    private void playerExploding()
    {
        if (pExplode.timerStarted)
        {
            anim.SetBool("IsExploding", true);
        }
        

    }
}
