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
			transform.Translate(0.0f,-enemySpeed*Time.deltaTime,0.0f,Space.World);
			transform.LookAt(thePlayer.transform.position);
        }
        if (activated == true && Vector3.Distance(thePlayer.transform.position, this.transform.position) > this.deactivateRadius)
        {
            activated = false;
            Debug.Log("Out");
        }
	}
}
