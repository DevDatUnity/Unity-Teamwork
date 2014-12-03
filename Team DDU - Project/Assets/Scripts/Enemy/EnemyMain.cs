using UnityEngine;
using System.Collections;

public class EnemyMain : MonoBehaviour {
    public GameObject thePlayer;
    public float health;
    public float hitPoints;
    public float activateRadius;
    public float deactivateRadius;
    public float fireInterval;
	public float enemySpeed;
    protected bool activated;
}
