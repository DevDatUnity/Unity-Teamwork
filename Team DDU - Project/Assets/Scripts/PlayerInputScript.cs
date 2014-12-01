using UnityEngine;
using System.Collections;

public class PlayerInputScript : MonoBehaviour {

    private float movementSpeed;
    private float rotationSpeed;

    private bool movingLeft;
    private bool movingRight;
    private bool movingForward;
    private bool movingBack;

    private float timeAfterShoot = 3;
    private float timeToShoot = 3;
    private bool canShoot = true;

	void Start () {
        movementSpeed = GetComponent<PlayerPropertiesScript>().movementSpeed;
        rotationSpeed = GetComponent<PlayerPropertiesScript>().rotationalSpeed;
        movingLeft = movingRight = movingForward = movingBack = false;
	}
	
	void Update () {

        if (Input.GetMouseButton(0))
        {
            if (timeAfterShoot >= timeToShoot)
            { 
                timeAfterShoot = 0;
                this.GetComponent<WeaponManager>().getCurrentWep().GetComponent<WeaponBullet>().Shoot();
            }
        }
        timeAfterShoot += 0.1f;

        //rotation
        Plane playerPlane = new Plane(Vector3.up, transform.position);
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        float hitdist = 0.0f;
        if (playerPlane.Raycast(ray, out hitdist))
        {
            Vector3 targetPoint = ray.GetPoint(hitdist);
            Quaternion targetRotation = Quaternion.LookRotation(targetPoint - transform.position);
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);
        }

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
            transform.Translate(Vector3.left * movementSpeed * Time.deltaTime, Space.World);
        }
        else if (movingRight == true)
        {
            transform.Translate(Vector3.right * movementSpeed * Time.deltaTime, Space.World);
        }
        if (movingForward == true)
        {
            transform.Translate(Vector3.forward * movementSpeed * Time.deltaTime, Space.World);
        }
        else if (movingBack == true)
        {
            transform.Translate(Vector3.back * movementSpeed * Time.deltaTime, Space.World);
        }

        Vector3 tempVec = transform.position;
        tempVec.z = transform.position.z - 4;
        tempVec.y = transform.position.y + 4;
        Camera.main.transform.position = tempVec;
	}
}
