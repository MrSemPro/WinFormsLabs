namespace WinFormsApp1
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
            Start = new Button();
            Stop = new Button();
            Clear = new Button();
            listBox1 = new ListBox();
            button1 = new Button();
            textBox1 = new TextBox();
            Show = new Button();
            SaveTXT = new Button();
            SaveXML = new Button();
            saveFileDialog1 = new SaveFileDialog();
            SuspendLayout();
            // 
            // Start
            // 
            Start.Location = new Point(400, 365);
            Start.Name = "Start";
            Start.Size = new Size(183, 58);
            Start.TabIndex = 0;
            Start.Text = "Resume Generation";
            Start.UseVisualStyleBackColor = true;
            Start.Click += Start_Click;
            // 
            // Stop
            // 
            Stop.Location = new Point(12, 365);
            Stop.Name = "Stop";
            Stop.Size = new Size(180, 58);
            Stop.TabIndex = 1;
            Stop.Text = "Stop Generation";
            Stop.UseVisualStyleBackColor = true;
            Stop.Click += Stop_Click;
            // 
            // Clear
            // 
            Clear.Location = new Point(198, 365);
            Clear.Name = "Clear";
            Clear.Size = new Size(196, 58);
            Clear.TabIndex = 3;
            Clear.Text = "Clear All";
            Clear.UseVisualStyleBackColor = true;
            Clear.Click += Clear_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(12, 12);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(776, 104);
            listBox1.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(589, 365);
            button1.Name = "button1";
            button1.Size = new Size(199, 58);
            button1.TabIndex = 5;
            button1.Text = "New Generation";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 122);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ScrollBars = ScrollBars.Vertical;
            textBox1.Size = new Size(571, 237);
            textBox1.TabIndex = 6;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // Show
            // 
            Show.Location = new Point(589, 122);
            Show.Name = "Show";
            Show.Size = new Size(199, 58);
            Show.TabIndex = 7;
            Show.Text = "Show Logs";
            Show.UseVisualStyleBackColor = true;
            Show.Click += Show_Click;
            // 
            // SaveTXT
            // 
            SaveTXT.Location = new Point(589, 203);
            SaveTXT.Name = "SaveTXT";
            SaveTXT.Size = new Size(199, 58);
            SaveTXT.TabIndex = 8;
            SaveTXT.Text = "Save Logs as TXT";
            SaveTXT.UseVisualStyleBackColor = true;
            SaveTXT.Click += SaveTXT_Click;
            // 
            // SaveXML
            // 
            SaveXML.Location = new Point(589, 284);
            SaveXML.Name = "SaveXML";
            SaveXML.Size = new Size(199, 58);
            SaveXML.TabIndex = 9;
            SaveXML.Text = "Save Logs as XLSX";
            SaveXML.UseVisualStyleBackColor = true;
            SaveXML.Click += SaveXML_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(SaveXML);
            Controls.Add(SaveTXT);
            Controls.Add(Show);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(listBox1);
            Controls.Add(Clear);
            Controls.Add(Stop);
            Controls.Add(Start);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Start;
        private Button Stop;
        private Button Clear;
        private ListBox listBox1;
        private Button button1;
        private TextBox textBox1;
        private Button Show;
        private Button SaveTXT;
        private Button SaveXML;
        private SaveFileDialog saveFileDialog1;
    }
}