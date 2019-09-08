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

# scriptメモ
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
new Vector3
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

# エラー
```
The associated script can not be loaded. Please fix any compile errors and assign a valid script.(スクリプトがロード出来ませんでした。コンパイルエラーを修正し、有効なスクリプトを割り当てて下さい）と表示されます。
```
原因：クラス名とスクリプト名が一致していないと読み込まないらしい  
参考：http://tsubakit1.hateblo.jp/entry/2016/10/06/232628  

