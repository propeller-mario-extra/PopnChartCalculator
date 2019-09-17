# PopnChartCalculator
----

ポップンミュージックの譜面を作成する際に使うと多少譜面の作成が楽になる計算機ソフトです。

## 詳細な説明
4分のピクセルの値をテキストボックスに入力して「計算」ボタンを押すと、他の16分や8分のピクセルの値がリストボックスにズラっと一気に並んで表示されるのでいちいち手動で計算する手間を省くことが出来ます。

左側のリストボックスには何pxで16分が何個かが、右側のリストボックスには何pxで128分が何個かが表示されます。

8分の値=16分2個、4分の値=16分4個なので、これらのピクセルの値は左側のリストボックスから知ることができます。

また、ズレ配置などのノーツを配置する際に調べる128分のピクセルの値は、右側のリストボックスから知ることができます。
（小数点まで表示されるのでこの値を参考にしながら四捨五入するか切り捨てるかなどは、各自で決めてください。）

## デモ
![demo](https://user-images.githubusercontent.com/55413970/65009020-387a7b80-d946-11e9-92ea-6617682b44c0.gif)

## 動作環境
Windows XP以降（※ Windows10でのみ動作確認）

## 使い方
PopnChartCalculator\obj\Releaseフォルダ内にある、PopnChartCalculator.exeを実行すれば「ポップン譜面作成用計算機」が動作します。

## インストール方法（＆アンインストール方法）
右上のダウンロードボタンからダウンロードしてください。
アンインストールは解凍したフォルダを消すだけで大丈夫です。

## ライセンス
MIT

## 作者
propeller-mario-extra
