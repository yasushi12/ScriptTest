using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss {
	private int hp = 100;	// 体力
	private int power = 25;	// 攻撃力
	private int mp = 53; //魔力

	// 攻撃用の関数
	public void Attack(){
		Debug.Log (this.power + "のダメージを与えた");
	}

	// 魔法攻撃用の関数
	public void Magic(){
		if(this.mp>=5){
			this.mp -= 5;	// 残りmpを5減らす
			Debug.Log("魔法攻撃をした。 残りMPは"+ this.mp +"。");
		}else{
			Debug.Log("MPが足りないため魔法が使えない。");
		}
	}

	// 防御用の関数
	public void Defence(int damage){
		Debug.Log (damage + "のダメージを受けた");
		// 残りhpを減らす
		this.hp -= damage;
	}
}

public class Test : MonoBehaviour{

	void Start () {
		// Bossクラスの変数を宣言してインスタンスを代入
		Boss lastboss = new Boss();
		Boss midboss = new Boss ();

		// 攻撃用の関数を呼び出す
		lastboss.Attack();
		midboss.Attack ();
		//防御用の巻子を呼び出す
		lastboss.Defence(3);
		midboss.Defence (40);


		// 以下、課題内容

		//配列の宣言
		int[] array = {5,20,10,60,30};

		// 配列の各要素を順番に表示する
		for (int i = 0; i < array.Length; i++) {
			Debug.Log (array [i]);
		}

		// 配列各要素を逆順に表示する
		for (int i = array.Length - 1; i>=0 ; i--) {
			Debug.Log (array [i]);
		}

		// 魔法攻撃用の関数を呼び出す
		for (int i = 1; i <= 11; i++) {
			lastboss.Magic ();
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
