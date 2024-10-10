namespace RegexTester {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose (bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent () {
            this.lblRegex = new Label();
            this.txtRegex = new TextBox();
            this.lblInput = new Label();
            this.txtInput = new TextBox();
            this.button1 = new Button();
            this.txtOutput = new TextBox();
            this.button2 = new Button();
            this.cbIgnoreCase = new CheckBox();
            this.cbTimeout = new CheckBox();
            this.txtTimeout = new TextBox();
            this.label1 = new Label();
            this.cbReplacement = new CheckBox();
            this.txtReplacement = new TextBox();
            this.SuspendLayout();
            // 
            // lblRegex
            // 
            this.lblRegex.AutoSize = true;
            this.lblRegex.Location = new Point(66, 15);
            this.lblRegex.Name = "lblRegex";
            this.lblRegex.Size = new Size(39, 15);
            this.lblRegex.TabIndex = 0;
            this.lblRegex.Text = "Regex";
            // 
            // txtRegex
            // 
            this.txtRegex.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            this.txtRegex.Location = new Point(111, 12);
            this.txtRegex.Name = "txtRegex";
            this.txtRegex.Size = new Size(237, 23);
            this.txtRegex.TabIndex = 1;
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.Location = new Point(36, 44);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new Size(69, 15);
            this.lblInput.TabIndex = 2;
            this.lblInput.Text = "Input String";
            // 
            // txtInput
            // 
            this.txtInput.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            this.txtInput.Location = new Point(111, 41);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new Size(237, 23);
            this.txtInput.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.button1.Location = new Point(211, 154);
            this.button1.Name = "button1";
            this.button1.Size = new Size(137, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Test Output";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += this.button1_Click;
            // 
            // txtOutput
            // 
            this.txtOutput.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            this.txtOutput.Location = new Point(14, 183);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ScrollBars = ScrollBars.Vertical;
            this.txtOutput.Size = new Size(334, 247);
            this.txtOutput.TabIndex = 0;
            this.txtOutput.TabStop = false;
            // 
            // button2
            // 
            this.button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            this.button2.Location = new Point(273, 436);
            this.button2.Name = "button2";
            this.button2.Size = new Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += this.button2_Click;
            // 
            // cbIgnoreCase
            // 
            this.cbIgnoreCase.AutoSize = true;
            this.cbIgnoreCase.Checked = true;
            this.cbIgnoreCase.CheckState = CheckState.Checked;
            this.cbIgnoreCase.Location = new Point(111, 126);
            this.cbIgnoreCase.Name = "cbIgnoreCase";
            this.cbIgnoreCase.Size = new Size(88, 19);
            this.cbIgnoreCase.TabIndex = 7;
            this.cbIgnoreCase.Text = "Ignore Case";
            this.cbIgnoreCase.UseVisualStyleBackColor = true;
            // 
            // cbTimeout
            // 
            this.cbTimeout.AutoSize = true;
            this.cbTimeout.Location = new Point(111, 101);
            this.cbTimeout.Name = "cbTimeout";
            this.cbTimeout.Size = new Size(92, 19);
            this.cbTimeout.TabIndex = 5;
            this.cbTimeout.Text = "Use Timeout";
            this.cbTimeout.UseVisualStyleBackColor = true;
            this.cbTimeout.CheckedChanged += this.cbTimeout_CheckedChanged;
            // 
            // txtTimeout
            // 
            this.txtTimeout.Enabled = false;
            this.txtTimeout.Location = new Point(209, 99);
            this.txtTimeout.Name = "txtTimeout";
            this.txtTimeout.Size = new Size(80, 23);
            this.txtTimeout.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new Point(295, 102);
            this.label1.Name = "label1";
            this.label1.Size = new Size(51, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "Seconds";
            // 
            // cbReplacement
            // 
            this.cbReplacement.AutoSize = true;
            this.cbReplacement.Location = new Point(14, 72);
            this.cbReplacement.Name = "cbReplacement";
            this.cbReplacement.Size = new Size(95, 19);
            this.cbReplacement.TabIndex = 3;
            this.cbReplacement.Text = "Replace With";
            this.cbReplacement.UseVisualStyleBackColor = true;
            this.cbReplacement.CheckedChanged += this.cbReplacement_CheckedChanged;
            // 
            // txtReplacement
            // 
            this.txtReplacement.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            this.txtReplacement.Enabled = false;
            this.txtReplacement.Location = new Point(111, 70);
            this.txtReplacement.Name = "txtReplacement";
            this.txtReplacement.Size = new Size(237, 23);
            this.txtReplacement.TabIndex = 4;
            // 
            // Form1
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(360, 471);
            this.Controls.Add(this.txtReplacement);
            this.Controls.Add(this.cbReplacement);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTimeout);
            this.Controls.Add(this.cbTimeout);
            this.Controls.Add(this.cbIgnoreCase);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.lblInput);
            this.Controls.Add(this.txtRegex);
            this.Controls.Add(this.lblRegex);
            this.MaximizeBox = false;
            this.MinimumSize = new Size(375, 510);
            this.Name = "Form1";
            this.SizeGripStyle = SizeGripStyle.Hide;
            this.Text = "Regex Tester";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private Label lblRegex;
        private TextBox txtRegex;
        private Label lblInput;
        private TextBox txtInput;
        private Button button1;
        private TextBox txtOutput;
        private Button button2;
        private CheckBox cbIgnoreCase;
        private CheckBox cbTimeout;
        private TextBox txtTimeout;
        private Label label1;
        private CheckBox cbReplacement;
        private TextBox txtReplacement;
    }
}
