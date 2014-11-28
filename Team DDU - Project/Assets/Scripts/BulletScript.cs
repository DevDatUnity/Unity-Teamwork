using UnityEngine;
using System.Collections;

public class BulletScript : MonoBehaviour {
    public float timePeriod;
    private float currentTime;
    public float timeBeforeDestroy;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        currentTime += timePeriod;
        if (currentTime >= timeBeforeDestroy)
        {
            Destroy(this.gameObject);
        }
	}
}
