    using UnityEngine;
    using System.Collections;

	public class Boss {
	       private int mp = 53;    // マインドポイント
	     
	    //魔法攻撃の関数
	public void Attack1() { 
		Debug.Log("mp5を消費して魔法攻撃をする" );
	}
		// 魔法攻撃の関数
	    public void Attack2() { 
		       Debug.Log( "魔法攻撃をした。残りMPは48。" );
	}

	    // マインドポイントの関数
	public  void Defence(int mp) { 
			    Debug.Log( "MPが足りないため魔法攻撃を使えない" );
	}

	    //魔法の関数
	    public void Magic1() { 
		         Debug.Log("魔法を使った");
	}
	    //魔法の関数
	    public void Magic2() { 
		         Debug.Log("魔法を使った");   
	}
	    //魔法の関数
	    public void Magic3() { 
		         Debug.Log("魔法を使った");
    } 
	    //魔法の関数
	    public void Magic4() { 
		         Debug.Log("魔法を使った");
	} 
	    //魔法の関数
	    public void Magic5() { 
		         Debug.Log ("魔法を使った");
	} 
        //魔法の関数
        public void Magic6() { 
	             Debug.Log("魔法を使った");
    }
	    //魔法の関数
	    public void Magic7() { 
		         Debug.Log("魔法を使った");
	} 
	    //魔法の関数
	    public void Magic8() { 
		         Debug.Log ("魔法を使った");
	}
	    //魔法の関数
	    public void Magic9() { 
		         Debug.Log ("魔法を使った");
	}
	    //魔法の関数
	    public void Magic10() { 
		         Debug.Log ("魔法を使った");
    }
	    //魔法の関数
	    public void Magic11(int mp) { 
		         Debug.Log (mp+"mpが足りない");
		         // 残りmpを減らす
		         this.mp -= mp;
	}
}
	public class Test : MonoBehaviour {

	        void Start (){
		// 配列を初期化する
		int[] array = { 30, 20, 50, 10, 80, 15, 60, 100, };

		// 配列の要素数のぶんだけ処理を繰り返す
		for (int i = 0; i < array.Length; i++) {
			// 配列の要素が50以上の場合
			if (array [i] >= 50) {
				// 配列の要素を表示する
				Debug.Log (array [i]);
			}
	}
			
			// 配列を初期化する
			int[] last = { 100, 60, 15, 80, 10, 50, 20, 30, };

			// 配列の要素数のぶんだけ処理を繰り返す
			for (int l = 0; l < last.Length; l++) {
				// 配列の要素が50以上の場合
				if (last [l] >= 50) {
					// 配列の要素を表示する
					Debug.Log (last [l]);
			} 
	}
		// Bossクラスの変数を宣言してインスタンスを代入
		Boss midboss = new Boss ();

		//　魔法攻撃用の関数を呼び出す
		midboss.Attack1 ();
		//　魔法攻撃用の関数を呼び出す
		midboss.Attack2 ();
		// マインドポイント用の関数を呼び出す
		midboss.Defence(53);
		// 魔法の関数を呼び出す
		midboss.Magic1 ();
		// 魔法の関数を呼び出す
		midboss.Magic2 ();
		// 魔法の関数を呼び出す
		midboss.Magic3 ();
		// 魔法の関数を呼び出す
		midboss.Magic4 ();
	    // 魔法の関数を呼び出す
	    midboss.Magic5 ();
		// 魔法の関数を呼び出す
		midboss.Magic6 ();
		// 魔法の関数を呼び出す
		midboss.Magic7 ();
		// 魔法の関数を呼び出す
		midboss.Magic8 ();
		// 魔法の関数を呼び出す
		midboss.Magic9 ();
		// 魔法の関数を呼び出す
		midboss.Magic10 ();
		// 魔法の関数を呼び出す
		midboss.Magic11 (3);
	   }
	// Update is called once per frame
	void Update () {
      }
	}