using UnityEngine;
using System.Collections;

public class EnemyDynamic : EnemyMain {
	public float boomRange;
	public float explodeTime;
    
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Vector3.Distance(thePlayer.transform.position, this.transform.position) < this.activateRadius && activated == false){
            activated = true;
            Debug.Log("Dynamic In");


        }
        if (activated == true && Vector3.Distance(thePlayer.transform.position, this.transform.position) > this.deactivateRadius){
            activated = false;
            Debug.Log("Dynamic Out");
        }

		if (activated == true) {
		

			if (Vector3.Distance(thePlayer.transform.position, this.transform.position) > boomRange){
				lookAtPlayer(enemyRotationSpeed);

				chase(enemySpeed + (2 / Vector3.Distance(thePlayer.transform.position, this.transform.position)));

				//Debug.Log (enemySpeed * (10 / Vector3.Distance(thePlayer.transform.position, this.transform.position)));
			}else{
				Invoke("explode", explodeTime);
			}
		
		}
	}

	void explode(){
		Debug.Log("*explosion*");
		Destroy (gameObject);
	}



}
