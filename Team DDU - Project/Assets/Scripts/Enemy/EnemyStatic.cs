using UnityEngine;
using System.Collections;

public class EnemyStatic : EnemyMain {
    
	void Start () {
    	
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
	}
}
