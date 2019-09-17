using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PopnChartCalculator
{
    public partial class PopnChartCaluclatorForm : Form
    {
        public PopnChartCaluclatorForm()
        {
            InitializeComponent();
        }

        private void CalcButton_Click(object sender, EventArgs e)
        {
            Double pixelQuarterNote, pixel16thnote, pixel128thNote = 0;
            int pixelNumeric = 2;

            //NumericUpDownから表示する幅を取得（128分）
            pixelNumeric = Decimal.ToInt32(DisplayPixelWidth_NumericUpDown.Value);
            //テキストボックスの値は英数字のみ受け付ける
            if (!Double.TryParse(pixel4thNoteTextBox.Text, out pixelQuarterNote)) return;
            if (0 >= pixelQuarterNote) return;

            //計算
            pixel16thNotesListBox.Items.Clear();
            pixel128thNotesListBox.Items.Clear();

            pixel128thNote = pixelQuarterNote / 32;
            pixel16thnote = pixelQuarterNote / 4;

            //ラベルに128分の値を表示
            pixel128thNoteLabel.Text = "128分 = " + pixel128thNote + "px";

            // リストボックスに各値を表示
            for (int i = 1; i <= 20; i++)
            {
                pixel16thNotesListBox.Items.Add(i + "個 = " + (pixel16thnote * i));
            }
            for (int i = 0; i <= pixelQuarterNote; i += pixelNumeric)
            {
                pixel128thNotesListBox.Items.Add(i + "px = " + (i / pixel128thNote));
            }
        }

        private void copyPixel16thNotesListBoxItem_Click(object sender, EventArgs e)
        {
            //左のリストボックスから値をコピー
            string text = pixel16thNotesListBox.SelectedItem.ToString();
            text = text.Substring(text.IndexOf("= ") + 2);
            if (text != "")
            {
                Clipboard.SetText(text);
                MessageBox.Show("コピーしためう！");
            }
        }

        private void copyPixel128thNotesListBoxItem_Click(object sender, EventArgs e)
        {
            //右のリストボックスから値をコピー
            string text = pixel128thNotesListBox.SelectedItem.ToString();
            text = text.Substring(text.IndexOf("= ") + 2);
            if (text != "")
            {
                Clipboard.SetText(text);
                MessageBox.Show("コピーしためう！");
            }
        }
    }
}
