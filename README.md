# ballgame
unity学習vol1  
https://dotinstall.com/lessons/basic_unity_v2

# やったこと
- プロヘクトの作り方
- オブジェクトの作り方
- オブジェクトの配置方法
- materialの作り方と反映方法
- カメラの操作
- scriptの作成と反映
- デバッグの方法
- publicに変数を設定するとinspectorで値を変更できる
- プレハブの作り方
- プレハブの生成

# scriptメモ
- 形の変更や指定や取得
```
transform
```

- paddleを動かす処理
```
transform.position += new Vector3(Input.GetAxis("Horizontal"), 0f, 0f) * Time.deltaTime
Debug.Log(transform.position.x);
```
  
- 位置を変更する際に呼び出す値
```
transform.position
```

- ３方向のベクトルを変更する際のオブジェクト
```
new Vector3(x, y, z);
```
引数は３つ  

- 左右のキー入力を受け取る
```
Input.GetAxis("Horizontal")
```

- 小数点を含む数値
```
0f
```

- マシンスペックを考慮した処理回数の制御
```
Time.deltaTime
```

- デバッグ
```
Debug.Log(transform.position.x);
```

- インスタンスの生成
```
Instantiate(プレハブ名, 座標位置, 回転);
```

- リピート処理
```
InvokeRepea(リピートするメソッド, 何秒後から, 何秒間隔で）;
```

- 座標に関して
```
transform.position.y
```
インスペクターで設定されている値を取得する

- 衝突判定をするメソッド
```
OnCollisionEnter(Collision collision)
```
引数に衝突したオブジェクトが入る  
例：オブジェクトに衝突したら、消す処理
```
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Paddle"))
        {
            Destroy(gameObject);
        }
    }
```
gameObjectでPaddleのタグをもっているものと衝突したら、このオブジェクトを削除する

- ゲーム内の時間を止める
```
Time.timeScale = 0;
```

- 別のシーンを読み込む時の宣言
```
using UnityEngine.SceneManagement;
```

# エラー
```
The associated script can not be loaded. Please fix any compile errors and assign a valid script.(スクリプトがロード出来ませんでした。コンパイルエラーを修正し、有効なスクリプトを割り当てて下さい）と表示されます。
```
原因：クラス名とスクリプト名が一致していないと読み込まないらしい    
参考：http://tsubakit1.hateblo.jp/entry/2016/10/06/232628  

# 機能メモ
- プレハブ
指定したgameobjectを好きなタイミングで好きな数生成することができる  
画面にたくさん出てくる同じオブジェクトはこれで作らないとできない  
#16にて解説

- rigidbody
inspectorから重力や衝突の判定を受けるかどうかなどの物理挙動を設定する

- canvas scale with screen size
スクリーンの比でテキストサイズを変更してくれる機能

- 領域外のテキストを表示
horizontal overflowをoverflowに設定する

- sceneの登録
build settingsにて行う

- gameの書き出し
file > build and run より
