using UnityEngine;
using System.Collections;

public class PlayerInputScript : MonoBehaviour {

    private float movementSpeed;
    private float rotationalSpeed;

    private bool movingLeft;
    private bool movingRight;
    private bool movingForward;
    private bool movingBack;

	void Start () {
        movementSpeed = GetComponent<PlayerPropertiesScript>().movementSpeed;
        rotationalSpeed = GetComponent<PlayerPropertiesScript>().rotationalSpeed;
        movingLeft = movingRight = movingForward = movingBack = false;
	}
	
	void Update () {

        //movement
        if (Input.GetKeyDown(KeyCode.A))
            movingLeft = true;
        else if (Input.GetKeyDown(KeyCode.D))
            movingRight = true;
        if (Input.GetKeyDown(KeyCode.W))
            movingForward = true;
        else if (Input.GetKeyDown(KeyCode.S))
            movingBack = true;

        if (Input.GetKeyUp(KeyCode.A))
            movingLeft = false;
        if (Input.GetKeyUp(KeyCode.D))
            movingRight = false;
        if (Input.GetKeyUp(KeyCode.W))
            movingForward = false;
        if (Input.GetKeyUp(KeyCode.S))
            movingBack = false;

        if (movingLeft == true)
        {
            transform.Translate(Vector3.left * movementSpeed * Time.deltaTime);
        }
        else if (movingRight == true)
        {
            transform.Translate(Vector3.right * movementSpeed * Time.deltaTime);
        }
        if (movingForward == true)
        {
            transform.Translate(Vector3.forward * movementSpeed * Time.deltaTime);
        }
        else if (movingBack == true)
        {
            transform.Translate(Vector3.back * movementSpeed * Time.deltaTime);
        }

        Vector3 tempVec = transform.position;
        tempVec.z = transform.position.z - 4;
        tempVec.y = transform.position.y + 4;
        Camera.main.transform.position = tempVec;
	}
}
