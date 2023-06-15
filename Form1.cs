using System.Diagnostics;

namespace cs_form_230615
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ���s1_�t�H�[��_CancelButton_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("ESC �������ꂽ");
        }

        private void ���s2_�t�H�[��_AcceptButton_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("Enter �������ꂽ");
        }

        // *****************************************
        // Form1.AllowDrop = true ���K�v��
        // Form1_DragEnter �̏������K�v�ł�
        // *****************************************
        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            Debug.WriteLine("Form1_DragDrop");

            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (files.Length > 0)
            {
                string imagePath = files[0];
                �摜�\��.Image = Image.FromFile(imagePath);
            }

        }

        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }


        private void ���悤�Ȃ�_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("���悤�Ȃ�");

        }

        private void �����͂����V�C��_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("�����͂����V�C��");

        }

        private void ����ɂ���_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("����ɂ���");

        }

        private void �V�K�쐬_���j���[����_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("�V�K�쐬");

        }

        private void �c�[���o�[���{�^��_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("�c�[���o�[");

        }

        private void �t�@�C�����J��_Click(object sender, EventArgs e)
        {

            �t�@�C�����J���_�C�A���O.Filter = "Text Files|*.txt";
            �t�@�C�����J���_�C�A���O.Title = "Select a Text File";

            if (�t�@�C�����J���_�C�A���O.ShowDialog() == DialogResult.OK)
            {
                Debug.WriteLine(�t�@�C�����J���_�C�A���O.FileName);

                StreamReader sr = new StreamReader(�t�@�C�����J���_�C�A���O.FileName);
                �e�L�X�g�t�@�C�����e�\��.Text = sr.ReadToEnd();
                sr.Close();
            }
        }
    }
}