using UnityEngine;
using System.Collections;

public class EnemyAdvanced : EnemyMain {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
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
