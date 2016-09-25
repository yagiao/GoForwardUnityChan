using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeBGM : MonoBehaviour {
	private AudioSource sound01;


	void Start () {
		//AudioSourceコンポーネントを取得し、変数に格納
		sound01 = GetComponent<AudioSource>();

	}

	void Update () {
		
		}

	void OnCollisionEnter2D(Collision2D coll) {
		
		//障害物に衝突した場合
		if (coll.gameObject.tag == "blocktag" || coll.gameObject.tag == "groundtag") {
			sound01.PlayOneShot(sound01.clip);
		}
	}
}