using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public Player controller;
  public Animator animator;

	public float runSpeed = 40f;

	float horizontalMove = 0f;
	bool jump = false;
	bool crouch = false;

	// Update is called once per frame
	void Update () {

		horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

    movement();
    //animator.SetFloat("Speed", mathf.Abs(KeyCode.RightArrow));

		if (Input.GetKey(KeyCode.Space))
		{
			jump = true;
		}



		if (Input.GetButtonDown("Crouch"))
		{
			crouch = true;
		} else if (Input.GetButtonUp("Crouch"))
		{
			crouch = false;
		}

	}

	void FixedUpdate ()
	{
		// Move our character
		controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);
		jump = false;
	}

  void movement()
  {
      if(Input.GetKey(KeyCode.RightArrow))
      {
        transform.Translate(new Vector3(5 * Time.deltaTime, 0, 0));
      }
      if(Input.GetKey(KeyCode.LeftArrow))
      {
        transform.Translate(new Vector3( -5 * Time.deltaTime,0 ,0));
      }


  }

}
