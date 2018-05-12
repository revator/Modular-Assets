using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour {

    CharacterController charControl;
    public float walkSpeed;
    public float sprintSpeed;

    void Awake()
    {
        charControl = GetComponent<CharacterController>();
    }
	
	// Update is called once per frame
	void Update () {
        MovePlayer();
	}

    void MovePlayer()
    {
        float horiz = Input.GetAxis("Horizontal");
        float verti = Input.GetAxis("Vertical");

        float maxSpeed = walkSpeed;

        if (Input.GetKey(KeyCode.LeftShift))
        {
            maxSpeed += walkSpeed;
        }
        Vector3 moveDirSide = transform.right * horiz * maxSpeed;
        Vector3 moveDirForwards = transform.forward * verti * maxSpeed;
        Debug.Log(maxSpeed);


        charControl.SimpleMove(moveDirSide);
        charControl.SimpleMove(moveDirForwards);
    }
}
