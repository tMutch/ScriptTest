using UnityEngine;
using System.Collections;
//using System.Collections.Generic;

public class  Boss {
	private int hp = 100;
	private int power = 25;

	public void Attack(){
		Debug.Log (this.power + "のダメージを与えた");
	}

	public void Defence(int damage){
		Debug.Log (damage + "のダメージを受けた");
		this.hp -= damage;
	}
}

public class TEST : MonoBehaviour {
	// Use this for initialization
	void Start(){
		Boss midboss = new Boss ();
		midboss.Attack ();
		midboss.Defence (7);
	}
	// Update is called once per frame
	void Update () {
		
	}
}
