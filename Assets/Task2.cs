using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Task2 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		int[] array = { 10, 25, 70, 90, 40 };
		//値を順番に表示
		for (int i = 0; i < array.Length; i++) {
			Debug.Log (array [i]);
		
		}
	}
	// Update is called once per frame
	void Update () {
		
	}
}
