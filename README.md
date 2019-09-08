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
