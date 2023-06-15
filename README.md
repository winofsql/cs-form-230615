# subject-230615

### [ChatGpt で聞いた Form に関数処理](https://chat.openai.com/share/00494f66-40f7-4a02-984b-cfb64e612308)

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
