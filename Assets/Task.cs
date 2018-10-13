using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class Task : MonoBehaviour {

	// Use this for initialization
	void Start () {
		//要素数５を準備
		int[] array = { 10, 25, 70, 90, 40 };

		//値をに逆順に表示
		for(int i = array.Length -1 ; 0 <= i ; i--){
				Debug.Log (array [i]);
			}
	}

	// Update is called once per frame
	void Update () {

	}
}
	