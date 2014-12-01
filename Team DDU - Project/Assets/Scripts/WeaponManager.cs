using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class WeaponManager : MonoBehaviour {
    private GameObject currentWeapon;
    public List<GameObject> weapons;    
	void Start () {
        for (int i = 0; i < weapons.Count; i++)
        {
            weapons[i] = (GameObject)Instantiate(weapons[i]);
            weapons[i].transform.parent = this.transform;
            weapons[i].SetActive(false);
        }
        currentWeapon = weapons[0];
        currentWeapon.SetActive(true);
	}
	
	void Update () {
       
	}

    public void changeWeapon(int number)
    {
        currentWeapon = weapons[number];
        currentWeapon.SetActive(true);
    }

    public GameObject getCurrentWep()
    {
        return currentWeapon;
    }
}
