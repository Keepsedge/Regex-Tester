using System.Text.RegularExpressions;

namespace RegexTester {
    public partial class Form1 : Form {
        public Form1 () {
            InitializeComponent();
        }

        private bool validateInputs () {
            string pattern = txtRegex.Text;
            string input = txtInput.Text;
            if (String.IsNullOrEmpty(pattern)) {
                lblRegex.ForeColor = Color.Red;
                return false;
            } else {
                lblRegex.ForeColor = Color.Black;
            }

            if (String.IsNullOrEmpty(input)) {
                lblInput.ForeColor = Color.Red;
                return false;
            } else {
                lblInput.ForeColor = Color.Black;
            }
            return true;
        }

        private void button1_Click (object sender, EventArgs e) {
            if (!validateInputs()) {
                return;
            }
            string filteredOutput = txtInput.Text;
            RegexOptions options = (cbIgnoreCase.Checked) ? RegexOptions.IgnoreCase : RegexOptions.None;
            TimeSpan tsRegex = new TimeSpan(0, 0, 1);
            if (cbTimeout.Checked) {
                if(String.IsNullOrEmpty(txtTimeout.Text)) { txtTimeout.Text = "1"; }
                string tmpTs = txtTimeout.Text;
                int timespan = 0;
                if (Int32.TryParse(tmpTs, out timespan)) {
                    if (timespan <= 0) { timespan = 1; }
                    tsRegex = new TimeSpan(0, 0, timespan);
                }

                tsRegex = new TimeSpan(0, 0, timespan);
            } else {
                tsRegex = new TimeSpan(0,0,1);
            }
            Match match = Regex.Match(filteredOutput, txtRegex.Text, options, tsRegex);
            while (match.Success) {
                if (cbReplacement.Checked) {
                    filteredOutput = filteredOutput.Replace(match.Value, txtReplacement.Text);
                } else {
                    if (match.Value == String.Empty) { break; }
                    filteredOutput = filteredOutput.Replace(match.Value, String.Format("*{0}*", match.Value));
                }
                match = match.NextMatch();
            }
            txtOutput.AppendText(filteredOutput + "\r\n");
        }

        private void button2_Click (object sender, EventArgs e) {
            txtOutput.Clear();
        }

        private void cbTimeout_CheckedChanged (object sender, EventArgs e) {
            if (((CheckBox)sender).Checked) {
                txtTimeout.Enabled = true;
            } else {
                txtTimeout.Enabled = false;
            }
        }

        private void cbReplacement_CheckedChanged (object sender, EventArgs e) {
            if (cbReplacement.Checked) {
                txtReplacement.Enabled = true;
            } else {
                txtReplacement.Enabled = false;
            }
        }
    }
}
