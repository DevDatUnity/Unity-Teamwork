using UnityEngine;
using System.Collections;

public class EnemyStatic : EnemyMain {
    
	void Start () {
		this.enemySpeed = 2.0f;
	}

	void Update () {
        if (Vector3.Distance(thePlayer.transform.position, this.transform.position) < this.activateRadius && activated == false)
        {
            activated = true;
            Debug.Log("In");
        }
        if (activated == true && Vector3.Distance(thePlayer.transform.position, this.transform.position) > this.deactivateRadius)
        {
            activated = false;
            Debug.Log("Out");
        }
		if (activated == true) {
			transform.LookAt(thePlayer.transform.position);
		}
	}
}
