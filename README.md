# subject-230615

![image](https://github.com/winofsql/subject-230615/assets/1501327/e5b9107a-7202-4e15-8961-d334739796ef)



### [ChatGpt で聞いた Form に画像をドラッグして表示](https://chat.openai.com/share/00494f66-40f7-4a02-984b-cfb64e612308)


### ファイルを開くダイアログ( Bing に質問 )

![image](https://github.com/winofsql/subject-230615/assets/1501327/5109c151-bcac-4396-88dd-427db660f7eb)

```cs
OpenFileDialog openFileDialog1 = new OpenFileDialog();
openFileDialog1.Filter = "Text Files|*.txt";
openFileDialog1.Title = "Select a Text File";

if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
{
    System.IO.StreamReader sr = new System.IO.StreamReader(openFileDialog1.FileName);
    textBox1.Text = sr.ReadToEnd();
    sr.Close();
}
```
