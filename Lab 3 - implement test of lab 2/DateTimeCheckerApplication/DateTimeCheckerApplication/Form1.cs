using System;
using System.Windows.Forms;

namespace DateTimeCheckerApplication {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e) {
            txtDay.Text = "";
            txtMonth.Text = "";
            txtYear.Text = "";
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e) {
            DialogResult result = MessageBox.Show(this, "Are you sure to exit?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            if(result != DialogResult.Yes) {
               e.Cancel = true;
            }
        }

        private bool validateInput() {
            int day, month, year;

            try {
                day = int.Parse(txtDay.Text);
            } catch (Exception) {
                MessageBox.Show(this, "Input data for Day is incorrect format!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if(day < 1 || day > 31) {
                MessageBox.Show(this, "Input data for Day is out of range!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            try {
                month = int.Parse(txtMonth.Text);
            } catch (Exception) {
                MessageBox.Show(this, "Input data for Month is incorrect format!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (month < 1 || month > 12) {
                MessageBox.Show(this, "Input data for Month is out of range!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            try {
                year = int.Parse(txtYear.Text);
            } catch (Exception) {
                MessageBox.Show(this, "Input data for Year is incorrect format!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (year < 1000 || year > 3000) {
                MessageBox.Show(this, "Input data for Year is out of range!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void btnCheck_Click(object sender, EventArgs e) {
            if(validateInput() == true) {
                byte day = byte.Parse(txtDay.Text);
                byte month = byte.Parse(txtMonth.Text);
                short year = short.Parse(txtYear.Text);

                if(Utilities.IsValidDate(year, month, day)) {
                    MessageBox.Show(this, string.Format("{0}/{1}/{2} is correct date time!", day, month, year), "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                } else {
                    MessageBox.Show(this, string.Format("{0}/{1}/{2} is NOT correct date time!", day, month, year), "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
