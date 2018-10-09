using UnityEngine;
using System.Collections;
//using System.Collections.Generic;

public class  Boss {
	private int hp = 100;
	private int power = 25;
	private int mp = 53;

	public void Attack(){
		Debug.Log (this.power + "のダメージを与えた");
	}

	public void Defence(int damage){
		Debug.Log (damage + "のダメージを受けた");
		this.hp -= damage;
	}

	public void Magic(){

		//魔法を１０回使用
		for (int i = 0; i <= 10; i++) {

			//MPの消費
			mp = mp - 5;

			//MPの残量
			if ( mp >= 3) {
				Debug.Log ("魔法攻撃した。残りMPは" + mp);
			} else {
				Debug.Log ("MPが足りないため魔法が使えない。");
			}
		}
	}
}

public class TEST : MonoBehaviour {
	// Use this for initialization
	void Start(){
		Boss midboss = new Boss ();
		midboss.Attack ();
		midboss.Defence (7);
		midboss.Magic ();
	}
	// Update is called once per frame
	void Update () {
		
	}
}
