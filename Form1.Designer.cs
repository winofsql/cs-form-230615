namespace cs_form_230615
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            実行1_フォーム_CancelButton = new Button();
            実行2_フォーム_AcceptButton = new Button();
            初期カーソル用 = new TextBox();
            画像表示 = new PictureBox();
            コンテキストメニュー = new ContextMenuStrip(components);
            こんにちは_メニュー項目 = new ToolStripMenuItem();
            分岐用_メニュー項目_コンテキスト = new ToolStripMenuItem();
            今日はいい天気だ_メニュー項目 = new ToolStripMenuItem();
            さようなら_メニュー項目 = new ToolStripMenuItem();
            メインメニュー = new MenuStrip();
            分岐_メニュー項目_メイン = new ToolStripMenuItem();
            新規作成_メニュー項目 = new ToolStripMenuItem();
            ツールバー = new ToolStrip();
            ツールバー内ボタン = new ToolStripButton();
            ファイルを開く = new Button();
            テキストファイル内容表示 = new TextBox();
            ファイルを開くダイアログ = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)画像表示).BeginInit();
            コンテキストメニュー.SuspendLayout();
            メインメニュー.SuspendLayout();
            ツールバー.SuspendLayout();
            SuspendLayout();
            // 
            // 実行1_フォーム_CancelButton
            // 
            実行1_フォーム_CancelButton.Location = new Point(12, 107);
            実行1_フォーム_CancelButton.Name = "実行1_フォーム_CancelButton";
            実行1_フォーム_CancelButton.Size = new Size(177, 40);
            実行1_フォーム_CancelButton.TabIndex = 3;
            実行1_フォーム_CancelButton.Text = "実行1";
            実行1_フォーム_CancelButton.UseVisualStyleBackColor = true;
            実行1_フォーム_CancelButton.Click += 実行1_フォーム_CancelButton_Click;
            // 
            // 実行2_フォーム_AcceptButton
            // 
            実行2_フォーム_AcceptButton.Location = new Point(12, 168);
            実行2_フォーム_AcceptButton.Name = "実行2_フォーム_AcceptButton";
            実行2_フォーム_AcceptButton.Size = new Size(177, 40);
            実行2_フォーム_AcceptButton.TabIndex = 4;
            実行2_フォーム_AcceptButton.Text = "実行2";
            実行2_フォーム_AcceptButton.UseVisualStyleBackColor = true;
            実行2_フォーム_AcceptButton.Click += 実行2_フォーム_AcceptButton_Click;
            // 
            // 初期カーソル用
            // 
            初期カーソル用.Location = new Point(12, 63);
            初期カーソル用.Name = "初期カーソル用";
            初期カーソル用.Size = new Size(177, 23);
            初期カーソル用.TabIndex = 2;
            // 
            // 画像表示
            // 
            画像表示.BorderStyle = BorderStyle.FixedSingle;
            画像表示.Location = new Point(216, 63);
            画像表示.Name = "画像表示";
            画像表示.Size = new Size(511, 206);
            画像表示.SizeMode = PictureBoxSizeMode.AutoSize;
            画像表示.TabIndex = 3;
            画像表示.TabStop = false;
            // 
            // コンテキストメニュー
            // 
            コンテキストメニュー.Items.AddRange(new ToolStripItem[] { こんにちは_メニュー項目, 分岐用_メニュー項目_コンテキスト, さようなら_メニュー項目 });
            コンテキストメニュー.Name = "コンテキストメニュー";
            コンテキストメニュー.Size = new Size(132, 70);
            // 
            // こんにちは_メニュー項目
            // 
            こんにちは_メニュー項目.Name = "こんにちは_メニュー項目";
            こんにちは_メニュー項目.Size = new Size(131, 22);
            こんにちは_メニュー項目.Text = "こんにちは";
            こんにちは_メニュー項目.Click += こんにちは_Click;
            // 
            // 分岐用_メニュー項目_コンテキスト
            // 
            分岐用_メニュー項目_コンテキスト.DropDownItems.AddRange(new ToolStripItem[] { 今日はいい天気だ_メニュー項目 });
            分岐用_メニュー項目_コンテキスト.Name = "分岐用_メニュー項目_コンテキスト";
            分岐用_メニュー項目_コンテキスト.Size = new Size(131, 22);
            分岐用_メニュー項目_コンテキスト.Text = "分岐メニュー";
            // 
            // 今日はいい天気だ_メニュー項目
            // 
            今日はいい天気だ_メニュー項目.Name = "今日はいい天気だ_メニュー項目";
            今日はいい天気だ_メニュー項目.Size = new Size(161, 22);
            今日はいい天気だ_メニュー項目.Text = "今日はいい天気だ";
            今日はいい天気だ_メニュー項目.Click += 今日はいい天気だ_Click;
            // 
            // さようなら_メニュー項目
            // 
            さようなら_メニュー項目.Name = "さようなら_メニュー項目";
            さようなら_メニュー項目.Size = new Size(131, 22);
            さようなら_メニュー項目.Text = "さようなら";
            さようなら_メニュー項目.Click += さようなら_Click;
            // 
            // メインメニュー
            // 
            メインメニュー.Items.AddRange(new ToolStripItem[] { 分岐_メニュー項目_メイン });
            メインメニュー.Location = new Point(0, 0);
            メインメニュー.Name = "メインメニュー";
            メインメニュー.Size = new Size(755, 24);
            メインメニュー.TabIndex = 0;
            メインメニュー.Text = "menuStrip1";
            // 
            // 分岐_メニュー項目_メイン
            // 
            分岐_メニュー項目_メイン.DropDownItems.AddRange(new ToolStripItem[] { 新規作成_メニュー項目 });
            分岐_メニュー項目_メイン.Name = "分岐_メニュー項目_メイン";
            分岐_メニュー項目_メイン.Size = new Size(53, 20);
            分岐_メニュー項目_メイン.Text = "ファイル";
            // 
            // 新規作成_メニュー項目
            // 
            新規作成_メニュー項目.Name = "新規作成_メニュー項目";
            新規作成_メニュー項目.Size = new Size(122, 22);
            新規作成_メニュー項目.Text = "新規作成";
            新規作成_メニュー項目.Click += 新規作成_メニュー項目_Click;
            // 
            // ツールバー
            // 
            ツールバー.Items.AddRange(new ToolStripItem[] { ツールバー内ボタン });
            ツールバー.Location = new Point(0, 24);
            ツールバー.Name = "ツールバー";
            ツールバー.Size = new Size(755, 25);
            ツールバー.TabIndex = 1;
            ツールバー.Text = "toolStrip1";
            // 
            // ツールバー内ボタン
            // 
            ツールバー内ボタン.DisplayStyle = ToolStripItemDisplayStyle.Image;
            ツールバー内ボタン.Image = (Image)resources.GetObject("ツールバー内ボタン.Image");
            ツールバー内ボタン.ImageTransparentColor = Color.Magenta;
            ツールバー内ボタン.Name = "ツールバー内ボタン";
            ツールバー内ボタン.Size = new Size(23, 22);
            ツールバー内ボタン.Text = "ツールバー内ボタン";
            ツールバー内ボタン.Click += ツールバー内ボタン_Click;
            // 
            // ファイルを開く
            // 
            ファイルを開く.Location = new Point(12, 229);
            ファイルを開く.Name = "ファイルを開く";
            ファイルを開く.Size = new Size(177, 40);
            ファイルを開く.TabIndex = 5;
            ファイルを開く.Text = "ファイルを開く";
            ファイルを開く.UseVisualStyleBackColor = true;
            ファイルを開く.Click += ファイルを開く_Click;
            // 
            // テキストファイル内容表示
            // 
            テキストファイル内容表示.Location = new Point(216, 285);
            テキストファイル内容表示.Multiline = true;
            テキストファイル内容表示.Name = "テキストファイル内容表示";
            テキストファイル内容表示.Size = new Size(511, 208);
            テキストファイル内容表示.TabIndex = 6;
            // 
            // Form1
            // 
            AcceptButton = 実行2_フォーム_AcceptButton;
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = 実行1_フォーム_CancelButton;
            ClientSize = new Size(755, 529);
            ContextMenuStrip = コンテキストメニュー;
            Controls.Add(テキストファイル内容表示);
            Controls.Add(ファイルを開く);
            Controls.Add(ツールバー);
            Controls.Add(メインメニュー);
            Controls.Add(画像表示);
            Controls.Add(初期カーソル用);
            Controls.Add(実行2_フォーム_AcceptButton);
            Controls.Add(実行1_フォーム_CancelButton);
            MainMenuStrip = メインメニュー;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            DragDrop += Form1_DragDrop;
            DragEnter += Form1_DragEnter;
            ((System.ComponentModel.ISupportInitialize)画像表示).EndInit();
            コンテキストメニュー.ResumeLayout(false);
            メインメニュー.ResumeLayout(false);
            メインメニュー.PerformLayout();
            ツールバー.ResumeLayout(false);
            ツールバー.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button 実行1_フォーム_CancelButton;
        private Button 実行2_フォーム_AcceptButton;
        private TextBox 初期カーソル用;
        private PictureBox 画像表示;
        private ContextMenuStrip コンテキストメニュー;
        private ToolStripMenuItem こんにちは_メニュー項目;
        private ToolStripMenuItem 分岐用_メニュー項目_コンテキスト;
        private ToolStripMenuItem さようなら_メニュー項目;
        private ToolStripMenuItem 今日はいい天気だ_メニュー項目;
        private MenuStrip メインメニュー;
        private ToolStripMenuItem 分岐_メニュー項目_メイン;
        private ToolStripMenuItem 新規作成_メニュー項目;
        private ToolStrip ツールバー;
        private ToolStripButton ツールバー内ボタン;
        private Button ファイルを開く;
        private TextBox テキストファイル内容表示;
        private OpenFileDialog ファイルを開くダイアログ;
    }
}