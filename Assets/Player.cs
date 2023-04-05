using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    CharacterController characterController;
    Animator animator;
    public float walkspeed = 3f ;
    public Vector3 moveDirection = Vector3.zero;
   // Rigidbody rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        characterController = GetComponent<CharacterController>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!characterController.isGrounded)
        {
            animator.SetBool("Walking",false);

            moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical"));
            moveDirection *= walkspeed;
            if (Input.GetAxis("Horizontal") != 0 || Input.GetAxis("Vertical") != 0 )
            {
                
                animator.SetBool("Walking",true);
                
            }
            if(Input.GetAxis("Vertical") < 0)
            {
                this.transform.rotation = Quaternion.Euler(0, 180, 0);
            }
            else if(Input.GetAxis("Horizontal") > 0)
            {
                this.transform.rotation = Quaternion.Euler(0, 90, 0);
            }
            else if (Input.GetAxis("Horizontal") < 0)
            {
                this.transform.rotation = Quaternion.Euler(0, -90, 0);
            }
            else if(Input.GetAxis("Vertical") > 0)
            {
                this.transform.rotation = Quaternion.Euler(0, 0, 0);

            }
            else if (Input.GetAxis("Vertical") < 0 && Input.GetAxis("Horizontal") > 0)
            {
                this.transform.rotation = Quaternion.Euler(0, 135, 0);

            }
            else if ((Input.GetAxis("Vertical") < 0 && Input.GetAxis("Horizontal") < 0))
            {
                this.transform.rotation = Quaternion.Euler(0, -135, 0);

            }
            else if ((Input.GetAxis("Vertical") > 0 && Input.GetAxis("Horizontal") < 0))
            {
                this.transform.rotation = Quaternion.Euler(0, -45, 0);

            }
            else if (Input.GetAxis("Vertical") > 0 && Input.GetAxis("Horizontal") > 0)
            {
                this.transform.rotation = Quaternion.Euler(0, 45, 0);

            }


        }
        characterController.Move(moveDirection * Time.deltaTime);
        
    }
}
