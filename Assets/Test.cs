using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Boss{
	private int hp = 100;
	private int mp = 53;
	private int power = 25;


	public void Attack(){
		Debug.Log (this.power + "のダメージを与えた。");
	}

	public void Defence(int damage){
		Debug.Log (damage + "のダメージを受けた。");
		this.hp = hp - damage;
	}

	public void Magic(){
		

		if (mp < 5) {
			Debug.Log ("MPが足りないため魔法が使えない。");
		} else {
			this.mp = mp - 5;
			Debug.Log ("魔法攻撃をした。残りMPは" + mp + "。");
		}
	}

}



public class Test : MonoBehaviour {

	void Start(){
		Boss lastboss = new Boss ();
		// 攻撃用の関数を呼び出す
		lastboss.Attack();
		// 防御用の関数を呼び出す
		lastboss.Defence(3);
		// 魔法用の関数を呼び出す
		lastboss.Magic();
		lastboss.Magic();
		lastboss.Magic();
		lastboss.Magic();
		lastboss.Magic();
		lastboss.Magic();
		lastboss.Magic();
		lastboss.Magic();
		lastboss.Magic();
		lastboss.Magic();
		lastboss.Magic();





		int[] array = {10, 20, 30, 40, 50};

		for (int i = 0; i < array.Length; i++) {
			Debug.Log (array [i]);
		}
			
		for ( int i = array.Length - 1; 0 <= i; i-- )
		{
			Debug.Log (array [i]);
		}

		}
		
	
	// Update is called once per frame
	void Update () {
		
		
	}
}
