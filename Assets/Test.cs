    using UnityEngine;
    using System.Collections;

        public class Boss  {
	
	    private int hp = 100;  //体力

	    private int power  = 25;  //攻撃力

	    private int mp = 53  ;     // 魔法ポイント

	    private int mpForMagicUse = 5;

        //攻撃用の関数
	    public void MagicAttack() {

		Debug.Log (this.power + "のダメージを与えた");
	}

	    //防御用の関数
	    public void Defence(int damage){
		Debug.Log (damage + "ダメージを受けた");
		 
		//残りhpを減らす
		this.hp -= damage;
	}
	    //mpを消費して魔法攻撃をするMagic関数
		public void Magic(){
			
		if (mp >= mpForMagicUse){ 
		
		mp -= mpForMagicUse;
		Debug.LogFormat("魔法攻撃をした。残りMPは{0}。", mp);

	} else {
		
		//mpが5未満だった場合の処理
		Debug.Log ("MPが足りないため魔法が使えない");
	}
		
	}
}

        public class Test : MonoBehaviour {

	    void Start () {
		// 配列を初期化する
		int[] array = { 1, 2, 3, 4, 5 };
	
		// 配列の要素数のぶんだけ処理を繰り返す
		for (int i = 0; i < array.Length; i++) {
			
			// 配列の要素を表示する
			Debug.Log (array [i]);
	}
		// 配列の要素数のぶんだけ処理を繰り返す
		for (int i = 4; i >= 0; i--) {

			// 配列の要素を表示する
			Debug.Log (array [i]);
	}
		//Bossクラスの変数を宣言してインスタンスを代入
		Boss lastboss = new Boss ();


		lastboss.MagicAttack ();

		lastboss.Defence (3);
		//魔法用の関数を呼び出す
		lastboss.Magic ();

		//9回Magic 関数を呼び出す
		for (int i = 0; i < 10; i++) {
			
			lastboss.Magic ();
			//更にMagic関数を呼び出すと、mpが足りないと表示される
			lastboss.Magic ();
	}
}
	     // Update is called once per frame
	     void Update () {
	}
}