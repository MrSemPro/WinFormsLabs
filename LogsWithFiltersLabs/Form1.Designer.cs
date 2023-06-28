namespace WinFormsApp3
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
            StartTest = new Button();
            StartExam = new Button();
            StartQuestion = new Button();
            StartTrial = new Button();
            StopEvent = new Button();
            listBox1 = new ListBox();
            СlearFilters = new Button();
            OnlyTrials = new Button();
            OnlyQuestions = new Button();
            OnlyExams = new Button();
            OnlyTests = new Button();
            OnlyStart = new Button();
            OnlyStop = new Button();
            button1 = new Button();
            saveFileDialog1 = new SaveFileDialog();
            SuspendLayout();
            // 
            // StartTest
            // 
            StartTest.Location = new Point(322, 334);
            StartTest.Name = "StartTest";
            StartTest.Size = new Size(95, 49);
            StartTest.TabIndex = 0;
            StartTest.Text = "Start Test";
            StartTest.UseVisualStyleBackColor = true;
            StartTest.Click += button1_Click;
            // 
            // StartExam
            // 
            StartExam.Location = new Point(423, 334);
            StartExam.Name = "StartExam";
            StartExam.Size = new Size(109, 49);
            StartExam.TabIndex = 1;
            StartExam.Text = "Start Exam";
            StartExam.UseVisualStyleBackColor = true;
            StartExam.Click += StartExam_Click;
            // 
            // StartQuestion
            // 
            StartQuestion.Location = new Point(538, 334);
            StartQuestion.Name = "StartQuestion";
            StartQuestion.Size = new Size(135, 49);
            StartQuestion.TabIndex = 2;
            StartQuestion.Text = "Start Question";
            StartQuestion.UseVisualStyleBackColor = true;
            StartQuestion.Click += StartQuestion_Click;
            // 
            // StartTrial
            // 
            StartTrial.Location = new Point(679, 334);
            StartTrial.Name = "StartTrial";
            StartTrial.Size = new Size(109, 49);
            StartTrial.TabIndex = 3;
            StartTrial.Text = "Start Trial";
            StartTrial.UseVisualStyleBackColor = true;
            StartTrial.Click += button3_Click;
            // 
            // StopEvent
            // 
            StopEvent.Location = new Point(322, 389);
            StopEvent.Name = "StopEvent";
            StopEvent.Size = new Size(466, 49);
            StopEvent.TabIndex = 4;
            StopEvent.Text = "Stop Event";
            StopEvent.UseVisualStyleBackColor = true;
            StopEvent.Click += StopEvent_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(9, 122);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(779, 204);
            listBox1.TabIndex = 5;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // СlearFilters
            // 
            СlearFilters.Location = new Point(12, 12);
            СlearFilters.Name = "СlearFilters";
            СlearFilters.Size = new Size(776, 49);
            СlearFilters.TabIndex = 10;
            СlearFilters.Text = "Clear Filters";
            СlearFilters.UseVisualStyleBackColor = true;
            СlearFilters.Click += СlearFilters_Click;
            // 
            // OnlyTrials
            // 
            OnlyTrials.Location = new Point(405, 67);
            OnlyTrials.Name = "OnlyTrials";
            OnlyTrials.Size = new Size(123, 49);
            OnlyTrials.TabIndex = 9;
            OnlyTrials.Text = "OnlyTrials";
            OnlyTrials.UseVisualStyleBackColor = true;
            OnlyTrials.Click += OnlyTrials_Click;
            // 
            // OnlyQuestions
            // 
            OnlyQuestions.Location = new Point(256, 67);
            OnlyQuestions.Name = "OnlyQuestions";
            OnlyQuestions.Size = new Size(143, 49);
            OnlyQuestions.TabIndex = 8;
            OnlyQuestions.Text = "Only Questions";
            OnlyQuestions.UseVisualStyleBackColor = true;
            OnlyQuestions.Click += OnlyQuestions_Click;
            // 
            // OnlyExams
            // 
            OnlyExams.Location = new Point(128, 67);
            OnlyExams.Name = "OnlyExams";
            OnlyExams.Size = new Size(122, 49);
            OnlyExams.TabIndex = 7;
            OnlyExams.Text = "Only Exams";
            OnlyExams.UseVisualStyleBackColor = true;
            OnlyExams.Click += OnlyExams_Click;
            // 
            // OnlyTests
            // 
            OnlyTests.Location = new Point(12, 67);
            OnlyTests.Name = "OnlyTests";
            OnlyTests.Size = new Size(110, 49);
            OnlyTests.TabIndex = 6;
            OnlyTests.Text = "Only Tests";
            OnlyTests.UseVisualStyleBackColor = true;
            OnlyTests.Click += OnlyTests_Click;
            // 
            // OnlyStart
            // 
            OnlyStart.Location = new Point(534, 67);
            OnlyStart.Name = "OnlyStart";
            OnlyStart.Size = new Size(115, 49);
            OnlyStart.TabIndex = 11;
            OnlyStart.Text = "Only Start";
            OnlyStart.UseVisualStyleBackColor = true;
            OnlyStart.Click += OnlyStart_Click;
            // 
            // OnlyStop
            // 
            OnlyStop.Location = new Point(655, 67);
            OnlyStop.Name = "OnlyStop";
            OnlyStop.Size = new Size(133, 49);
            OnlyStop.TabIndex = 12;
            OnlyStop.Text = "Only Stop";
            OnlyStop.UseVisualStyleBackColor = true;
            OnlyStop.Click += OnlyStop_Click;
            // 
            // button1
            // 
            button1.Location = new Point(12, 334);
            button1.Name = "button1";
            button1.Size = new Size(304, 104);
            button1.TabIndex = 13;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(OnlyStop);
            Controls.Add(OnlyStart);
            Controls.Add(СlearFilters);
            Controls.Add(OnlyTrials);
            Controls.Add(OnlyQuestions);
            Controls.Add(OnlyExams);
            Controls.Add(OnlyTests);
            Controls.Add(listBox1);
            Controls.Add(StopEvent);
            Controls.Add(StartTrial);
            Controls.Add(StartQuestion);
            Controls.Add(StartExam);
            Controls.Add(StartTest);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button StartTest;
        private Button StartExam;
        private Button StartQuestion;
        private Button StartTrial;
        private Button StopEvent;
        private ListBox listBox1;
        private Button СlearFilters;
        private Button OnlyTrials;
        private Button OnlyQuestions;
        private Button OnlyExams;
        private Button OnlyTests;
        private Button OnlyStart;
        private Button OnlyStop;
        private Button button1;
        private SaveFileDialog saveFileDialog1;
    }
}