using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FolderMaker {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btnBrowseDest_Click(object sender, EventArgs e) {

            folderBrowserDialog1.ShowNewFolderButton = true;

            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK) {
                txtDest.Text = folderBrowserDialog1.SelectedPath;
            }

        }

        private void button2_Click(object sender, EventArgs e) {
            openFileDialog1.Filter = "テキストファイル (*.txt)|.txt|リスト (*.list)|*.list|すべてのファイル|*.*";
            openFileDialog1.DefaultExt = "*.txt";
            openFileDialog1.FileName = "";

            //openFileDialog1.CheckPathExists = false;
            //openFileDialog1.CheckFileExists = false;
            String fileName;
            if (openFileDialog1.ShowDialog() == DialogResult.OK) {
                fileName = openFileDialog1.FileName;
            } else {
                return;
            }

            txtList.Text = fileName;

            btnRead.PerformClick();

        }

        private void btnGenerate_Click(object sender, EventArgs e) {
            const string MSG_COMPLETE = "フォルダ作成が {0} 件完了しました。";
            const string MSG_BLANKDEST = "フォルダの作成先を指定してください。";
            const string MSG_BLANKLIST = "リストに項目がありません。";
            const string MSG_IOE = "入出力エラーが発生しました。";
            const string MSG_NOTPROPERFOLDER = "フォルダ名を(正しく)指定してください。";
            const string MSG_TOOLONG = "パスが長すぎます。";
            const string MSG_ERROR = "エラーが発生しました。";





            if (txtDest.Text.Equals("")) {
                MessageBox.Show(MSG_BLANKDEST, "情報", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnBrowseDest.PerformClick();
                return;
            }

            if (dgvFolderList.RowCount==0) {
                MessageBox.Show(MSG_BLANKLIST, "情報", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            String DESTDIR = txtDest.Text;
            //IEnumerator<DataGridViewRow> enumerator = dgvFolderList.Rows.Cast<DataGridViewRow>().GetEnumerator();
            IEnumerator<DataGridViewRow> enumerator = dgvFolderList.Rows.Cast<DataGridViewRow>().GetEnumerator(); 

            int i = 1;
            while (enumerator.MoveNext()) {
                if (enumerator.Current.Cells[0].Value == null) { break; }
                string foldername = enumerator.Current.Cells[0].Value.ToString();
                if (chkSeq.Checked) {
                     foldername = String.Format("{0,0:D" + udDigit.Value+"}{1}{2}",i,txtSeparater.Text,foldername );
                }
                String folderpath = DESTDIR + "\\" + foldername;

                Console.WriteLine(folderpath);
                try {
                    Directory.CreateDirectory(folderpath);
               
                }catch (ArgumentNullException ex) {
                    MessageBox.Show(MSG_NOTPROPERFOLDER, "警告", MessageBoxButtons.OK, MessageBoxIcon.Error);

                } catch (PathTooLongException ex) {
                    MessageBox.Show(MSG_TOOLONG, "警告", MessageBoxButtons.OK, MessageBoxIcon.Error);

                } catch (DirectoryNotFoundException ex) {
                    MessageBox.Show(MSG_NOTPROPERFOLDER, "警告", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } catch (IOException ioe) {
                    MessageBox.Show(MSG_IOE, "警告", MessageBoxButtons.OK, MessageBoxIcon.Error);

                } catch (Exception ex) {
                    MessageBox.Show(MSG_ERROR + "\r\n" + ex.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                i++;
            }
            MessageBox.Show(String.Format(MSG_COMPLETE, dgvFolderList.RowCount), "完了", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnRead_Click(object sender, EventArgs e) {
            String fileName = txtList.Text;

            //List<FolderItem> folderItems = new List<FolderItem>();

            string line;
            using (StreamReader sr = new StreamReader(fileName, Encoding.GetEncoding("Shift_JIS"))) {
                while ((line = sr.ReadLine()) != null) {
                    int idx = dgvFolderList.Rows.Add();
                    dgvFolderList.Rows[idx].Cells[0].Value = line;
                    //folderItems.Add(new FolderItem(line));
                }
            }

            dgvFolderList.AllowUserToAddRows = true;
            dgvFolderList.AllowUserToDeleteRows = true;
            dgvFolderList.AllowUserToOrderColumns = true;

            //dgvFolderList.DataSource = null;
            //dgvFolderList.DataSource = folderItems;

        }

        private void Form1_Load(object sender, EventArgs e) {
            dgvFolderList.AllowUserToAddRows = true;
            dgvFolderList.AllowUserToDeleteRows = true;
            dgvFolderList.AllowUserToOrderColumns = true;

        }

        private void btnClear_Click(object sender, EventArgs e) {
            dgvFolderList.Rows.Clear();
        }
    }
}