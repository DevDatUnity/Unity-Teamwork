using UnityEngine;
using System.Collections;

public class EnemyMain : MonoBehaviour {
    public GameObject thePlayer;
	public Transform playerPos;
    public float health;
    public float hitPoints;
    public float activateRadius;
    public float deactivateRadius;
    public float fireInterval;
	public float enemySpeed;
	//Pull out a knife and shank that ho!
	public float enemyRotationSpeed;
	protected bool tooClose;
    protected bool activated;

	

	public void lookAtPlayer(float rSpeed){
		Quaternion rotation = Quaternion.LookRotation (playerPos.position - transform.position);
		transform.rotation = Quaternion.Slerp (transform.rotation, rotation, Time.deltaTime * rSpeed);
	}


	public void chase(float moveSpeed){
		transform.Translate (Vector3.forward * moveSpeed * Time.deltaTime);
	}

}
