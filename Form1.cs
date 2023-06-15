using System.Diagnostics;

namespace cs_form_230615
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void 実行1_フォーム_CancelButton_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("ESC が押された");
        }

        private void 実行2_フォーム_AcceptButton_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("Enter が押された");
        }

        // *****************************************
        // Form1.AllowDrop = true が必要で
        // Form1_DragEnter の処理も必要です
        // *****************************************
        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            Debug.WriteLine("Form1_DragDrop");

            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (files.Length > 0)
            {
                string imagePath = files[0];
                画像表示.Image = Image.FromFile(imagePath);
            }

        }

        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }


        private void さようなら_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("さようなら");

        }

        private void 今日はいい天気だ_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("今日はいい天気だ");

        }

        private void こんにちは_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("こんにちは");

        }

        private void 新規作成_メニュー項目_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("新規作成");

        }

        private void ツールバー内ボタン_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("ツールバー");

        }

        private void ファイルを開く_Click(object sender, EventArgs e)
        {

            ファイルを開くダイアログ.Filter = "Text Files|*.txt";
            ファイルを開くダイアログ.Title = "Select a Text File";

            if (ファイルを開くダイアログ.ShowDialog() == DialogResult.OK)
            {
                Debug.WriteLine(ファイルを開くダイアログ.FileName);

                StreamReader sr = new StreamReader(ファイルを開くダイアログ.FileName);
                テキストファイル内容表示.Text = sr.ReadToEnd();
                sr.Close();
            }
        }
    }
}