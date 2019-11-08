using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class variables : MonoBehaviour {

    public string name = "Carlos";
    public string weapon = "Iron Axe";
    int health = 10;
    public float speed = 5.5f;
    int enemyDamage = 2;

	// Use this for initialization
	void Start () {
        print("Welcome, " + name);
        print("The enemy found you because your speed is only " + speed.ToString());

        health -= enemyDamage;
        print("The enemy dealt you " + enemyDamage.ToString() + ". You now have " + health.ToString() + " remaining.");
        print("After much struggle, you were finally able to kill the enemy with your " + weapon.ToString() + "!");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
