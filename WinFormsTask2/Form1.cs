using System.Windows.Forms;

namespace WinFormsTask2
{
    public partial class Form1 : Form
    {
        private string currentFilePath = string.Empty;

        public Form1()
        {
            InitializeComponent();

        }

        private void InitializeMenuAndToolbar()
        {
            
        }

        private void InitializeContextMenu()
        {
           
        }

        private void OpenFile()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    currentFilePath = openFileDialog.FileName;
                    richTextBox1.Text = File.ReadAllText(currentFilePath);
                    this.Text = currentFilePath;
                }
            }
        }

        private void SaveFile()
        {
            if (string.IsNullOrEmpty(currentFilePath))
            {
                SaveFileAs();
            }
            else
            {
                File.WriteAllText(currentFilePath, richTextBox1.Text);
            }
        }

        private void SaveFileAs()
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    currentFilePath = saveFileDialog.FileName;
                    File.WriteAllText(currentFilePath, richTextBox1.Text);
                    this.Text = currentFilePath;
                }
            }
        }

        private void NewDocument()
        {
            richTextBox1.Clear();
            currentFilePath = string.Empty;
            this.Text = "Новий документ";
        }

        private void OpenEditorSettings()
        {

            using (FontDialog fontDialog = new FontDialog())
            {
                if (fontDialog.ShowDialog() == DialogResult.OK)
                {
                    richTextBox1.Font = fontDialog.Font;
                }
            }


            using (ColorDialog colorDialog = new ColorDialog())
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    richTextBox1.BackColor = colorDialog.Color;
                }
            }

            using (ColorDialog colorDialog = new ColorDialog())
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    richTextBox1.ForeColor = colorDialog.Color;
                }
            }
        }
    }
}
