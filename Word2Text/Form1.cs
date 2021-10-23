using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Word;
using word = Microsoft.Office.Interop.Word;
namespace Word2Text
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_open_Click(object sender, EventArgs e)
        {
            lb_finish.Visible = false;
            string filter = rdo_txt.Checked ? "*.txt" : "*.doc;*.docx"; 
            //OpenFileDialogクラスのインスタンスを作成
            OpenFileDialog ofd = new OpenFileDialog();

            //[ファイルの種類]に表示される選択肢を指定する
            //指定しないとすべてのファイルが表示される
            ofd.Filter = filter + "|" + filter;
            //[ファイルの種類]ではじめに選択されるものを指定する
            ofd.FilterIndex = 1;
            //タイトルを設定する
            ofd.Title = "開くファイルを選択してください";
            //ダイアログボックスを閉じる前に現在のディレクトリを復元するようにする
            ofd.RestoreDirectory = true;
            //存在しないファイルの名前が指定されたとき警告を表示する
            //デフォルトでTrueなので指定する必要はない
            ofd.CheckFileExists = true;
            //存在しないパスが指定されたとき警告を表示する
            //デフォルトでTrueなので指定する必要はない
            ofd.CheckPathExists = true;

            //ダイアログを表示する
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                //OKボタンがクリックされたとき、選択されたファイル名を表示する
                txt_path.Text = ofd.FileName;
            }
        }

        private void btn_trans_txt_Click(object sender, EventArgs e)
        {
            string path = txt_path.Text;
            if (!File.Exists(path))
            {
                MessageBox.Show("ファイル存在しません。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Encoding sjisEnc = Encoding.GetEncoding("UTF-8");
            StreamReader reader = new StreamReader(path, sjisEnc);
            string r_txt = reader.ReadToEnd();
            string w_txt = r_txt.Replace("%K%P\r\n", "%K%P").Replace(" ", "");
            w_txt = w_txt.Replace("\r\n", "%K%P").Replace(" ", "");
            reader.Close();
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "テキストファイル|*.txt";
            saveFileDialog1.Title = "Save an Text File";
            saveFileDialog1.FileName = path.Split('\\').Last();
            saveFileDialog1.ShowDialog();
            if (saveFileDialog1.FileName != "")
            {
                System.IO.FileStream fs =
                    (System.IO.FileStream)saveFileDialog1.OpenFile();
                // Save File to .txt  
                StreamWriter m_WriterParameter = new StreamWriter(fs);
                m_WriterParameter.BaseStream.Seek(0, SeekOrigin.End);
                m_WriterParameter.Write(w_txt);
                m_WriterParameter.Flush();
                m_WriterParameter.Close();
                fs.Close();
                lb_finish.Visible = true;
            }
        }

        private void btn_trans_word_Click(object sender, EventArgs e)
        {
            string path = txt_path.Text;
            if (!File.Exists(path))
            {
                MessageBox.Show("ファイル存在しません。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            word.Application word = new word.Application();
            word.Document doc = new word.Document();

            object fileName = path;
            // Define an object to pass to the API for missing parameters
            object missing = System.Type.Missing;
            doc = word.Documents.Open(ref fileName,
                    ref missing, ref missing, ref missing, ref missing,
                    ref missing, ref missing, ref missing, ref missing,
                    ref missing, ref missing, ref missing, ref missing,
                    ref missing, ref missing, ref missing);

            string r_txt = string.Empty;
            foreach (word.Range tmpRange in doc.StoryRanges)
            {
                r_txt += tmpRange.Text;
            }
            ((_Document)doc).Close();
            ((_Application)word).Quit();
            string w_txt = r_txt.Replace("\r\n", "%K%P").Replace(" ", "");
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "テキストファイル|*.txt";
            saveFileDialog1.Title = "Save an Text File";
            saveFileDialog1.ShowDialog();
            if (saveFileDialog1.FileName != "")
            {
                System.IO.FileStream fs =
                    (System.IO.FileStream)saveFileDialog1.OpenFile();
                // Save File to .txt  
                StreamWriter m_WriterParameter = new StreamWriter(fs);
                m_WriterParameter.BaseStream.Seek(0, SeekOrigin.End);
                m_WriterParameter.Write(w_txt);
                m_WriterParameter.Flush();
                m_WriterParameter.Close();
                fs.Close();
                lb_finish.Visible = true;
            }
        }

        private void rdo_CheckedChanged(object sender, EventArgs e)
        {
            if (rdo_txt.Checked)
            {
                btn_trans_txt.Visible = true;
                btn_trans_word.Visible = false;
            }
            else
            {
                btn_trans_txt.Visible = false;
                btn_trans_word.Visible = true;
            }
        }
    }
}
