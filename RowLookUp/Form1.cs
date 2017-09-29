using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RowLookUp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void OpenButton_Click(object sender, EventArgs e)
        {
            SourceFileDialog.ShowDialog();
        }

        private void SourceFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
                DialogOKing(SourceFileDialog, SourceLocationTextBox);
            if(tabControl1.SelectedIndex == 1)
                DialogOKing(SourceFileDialog, RRSourceTextBox);
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog.ShowDialog();
        }

        private void SaveFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
                DialogOKing(SaveFileDialog, SaveLocationTextBox);
            if(tabControl1.SelectedIndex == 1)
                DialogOKing(SaveFileDialog, RRSaveTextBox);
        }


        private void DialogOKing(FileDialog FD, TextBox TX)
        {
            TX.Text = FD.FileName;
        }

        private void ExecuteGOButton_Click(object sender, EventArgs e)
        {
            int RowStart = 1;
            int RowEnd = 10;
            string SourceLocation = string.Empty;
            string DestinationLocation = string.Empty;
            if (tabControl1.SelectedIndex == 0)
            {
                TextBoxFileLocationValidation(SourceLocationTextBox, SaveLocationTextBox);
                SourceLocation = SourceLocationTextBox.Text;
                DestinationLocation = SaveLocationTextBox.Text;
            }
            else
            {
                TextBoxFileLocationValidation(RRSourceTextBox, RRSaveTextBox);
                SourceLocation = RRSourceTextBox.Text;
                DestinationLocation = RRSaveTextBox.Text;
                RowStart = int.Parse(RangeStartTextBox.Text);
                RowEnd = int.Parse(RangeEndTextBox.Text);
            }
            FileLookUp FLU = new FileLookUp(SourceLocation, DestinationLocation, RowStart, RowEnd);
            FLU.TransferData();
            MessageBox.Show("File has been processed and saved.");
        }

        private void TextBoxFileLocationValidation(TextBox asdf, TextBox DD)
        {
            if (!System.IO.File.Exists(asdf.Text))
                throw new System.IO.FileNotFoundException(asdf.Text + " does not exist.");
            if (string.IsNullOrWhiteSpace(DD.Text))
                throw new Exception(DD.Text + " is not a valid save location");
        }

        private void Tab2Validation()
        {
            if(!IsStringNumeric(RangeStartTextBox.Text))
                throw new ArgumentOutOfRangeException("\"" + RangeStartTextBox.Text + "\" is not a number.");
            if (!IsStringNumeric(RangeEndTextBox.Text))
                throw new ArgumentOutOfRangeException("\"" + RangeEndTextBox.Text + "\" is not a number.");
            if (int.Parse(RangeStartTextBox.Text) > int.Parse(RangeEndTextBox.Text))
                throw new Exception(RangeStartTextBox.Text + " cannot be greater than " + RangeEndTextBox.Text);
        }

        private bool IsStringNumeric(string Input)
        {
            int temp;
            return int.TryParse(Input, out temp);
        }

        private void RROpenFileButton_Click(object sender, EventArgs e)
        {
            SourceFileDialog.ShowDialog();
        }

        private void RRSaveButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog.ShowDialog();
        }

    }
}
