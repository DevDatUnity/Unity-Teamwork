using UnityEngine;
using System.Collections;

public class WeaponBullet : WeaponMain {
    public GameObject bulletPrefab;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void Shoot()
    {
        for (int i = 0; i < this.transform.childCount; i++)
        {
            GameObject tempBullet = (GameObject)Instantiate(bulletPrefab,
                    this.transform.GetChild(i).transform.position, this.transform.GetChild(i).transform.rotation);
            tempBullet.rigidbody.AddForce(this.transform.GetChild(i).transform.forward * 300f);   
        }
    }
}
