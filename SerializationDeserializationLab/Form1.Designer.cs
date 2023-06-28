
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
            FromJSON = new System.Windows.Forms.Button();
            FromXML = new System.Windows.Forms.Button();
            FromCSV = new System.Windows.Forms.Button();
            FromXLSX = new System.Windows.Forms.Button();
            ToXLSX = new System.Windows.Forms.Button();
            ToXML = new System.Windows.Forms.Button();
            ToJSON = new System.Windows.Forms.Button();
            Open = new System.Windows.Forms.Button();
            Save = new System.Windows.Forms.Button();
            FileName = new System.Windows.Forms.TextBox();
            FileContent = new System.Windows.Forms.TextBox();
            openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ToCSV = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // FromJSON
            // 
            FromJSON.Location = new System.Drawing.Point(12, 12);
            FromJSON.Name = "FromJSON";
            FromJSON.Size = new System.Drawing.Size(216, 79);
            FromJSON.TabIndex = 0;
            FromJSON.Text = "DeserializeFromJSON";
            FromJSON.UseVisualStyleBackColor = true;
            FromJSON.Click += FromJSON_Click;
            // 
            // FromXML
            // 
            FromXML.Location = new System.Drawing.Point(11, 97);
            FromXML.Name = "FromXML";
            FromXML.Size = new System.Drawing.Size(216, 72);
            FromXML.TabIndex = 1;
            FromXML.Text = "DeserializeFromXML";
            FromXML.UseVisualStyleBackColor = true;
            FromXML.Click += FromXML_Click;
            // 
            // FromCSV
            // 
            FromCSV.Location = new System.Drawing.Point(11, 175);
            FromCSV.Name = "FromCSV";
            FromCSV.Size = new System.Drawing.Size(216, 72);
            FromCSV.TabIndex = 2;
            FromCSV.Text = "DeserializeFromCSV";
            FromCSV.UseVisualStyleBackColor = true;
            FromCSV.Click += FromCSV_Click;
            // 
            // FromXLSX
            // 
            FromXLSX.Location = new System.Drawing.Point(12, 253);
            FromXLSX.Name = "FromXLSX";
            FromXLSX.Size = new System.Drawing.Size(389, 62);
            FromXLSX.TabIndex = 3;
            FromXLSX.Text = "ImportFromXLSX";
            FromXLSX.UseVisualStyleBackColor = true;
            FromXLSX.Click += FromXLSX_Click;
            // 
            // ToXLSX
            // 
            ToXLSX.Location = new System.Drawing.Point(407, 253);
            ToXLSX.Name = "ToXLSX";
            ToXLSX.Size = new System.Drawing.Size(381, 62);
            ToXLSX.TabIndex = 7;
            ToXLSX.Text = "SaveAsXLSX";
            ToXLSX.UseVisualStyleBackColor = true;
            ToXLSX.Click += ToXLSX_Click;
            // 
            // ToXML
            // 
            ToXML.Location = new System.Drawing.Point(572, 97);
            ToXML.Name = "ToXML";
            ToXML.Size = new System.Drawing.Size(216, 72);
            ToXML.TabIndex = 5;
            ToXML.Text = "SerializeToXML";
            ToXML.UseVisualStyleBackColor = true;
            ToXML.Click += ToXML_Click;
            // 
            // ToJSON
            // 
            ToJSON.Location = new System.Drawing.Point(572, 12);
            ToJSON.Name = "ToJSON";
            ToJSON.Size = new System.Drawing.Size(216, 79);
            ToJSON.TabIndex = 4;
            ToJSON.Text = "SerializeToJSON";
            ToJSON.UseVisualStyleBackColor = true;
            ToJSON.Click += ToJSON_Click;
            // 
            // Open
            // 
            Open.Location = new System.Drawing.Point(107, 329);
            Open.Name = "Open";
            Open.Size = new System.Drawing.Size(138, 41);
            Open.TabIndex = 8;
            Open.Text = "Open";
            Open.UseVisualStyleBackColor = true;
            Open.Click += Open_Click;
            // 
            // Save
            // 
            Save.Location = new System.Drawing.Point(547, 329);
            Save.Name = "Save";
            Save.Size = new System.Drawing.Size(145, 41);
            Save.TabIndex = 9;
            Save.Text = "Save txt";
            Save.UseVisualStyleBackColor = true;
            Save.Click += Save_Click_1;
            // 
            // FileName
            // 
            FileName.Location = new System.Drawing.Point(234, 12);
            FileName.Name = "FileName";
            FileName.Size = new System.Drawing.Size(332, 31);
            FileName.TabIndex = 10;
            // 
            // FileContent
            // 
            FileContent.Location = new System.Drawing.Point(234, 49);
            FileContent.Multiline = true;
            FileContent.Name = "FileContent";
            FileContent.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            FileContent.Size = new System.Drawing.Size(332, 198);
            FileContent.TabIndex = 11;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // ToCSV
            // 
            ToCSV.Location = new System.Drawing.Point(572, 175);
            ToCSV.Name = "ToCSV";
            ToCSV.Size = new System.Drawing.Size(216, 72);
            ToCSV.TabIndex = 6;
            ToCSV.Text = "SerializeToCSV";
            ToCSV.UseVisualStyleBackColor = true;
            ToCSV.Click += ToCSV_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 403);
            Controls.Add(FileContent);
            Controls.Add(FileName);
            Controls.Add(Save);
            Controls.Add(Open);
            Controls.Add(ToXLSX);
            Controls.Add(ToCSV);
            Controls.Add(ToXML);
            Controls.Add(ToJSON);
            Controls.Add(FromXLSX);
            Controls.Add(FromCSV);
            Controls.Add(FromXML);
            Controls.Add(FromJSON);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button FromJSON;
        private System.Windows.Forms.Button FromXML;
        private System.Windows.Forms.Button FromCSV;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button ToXLSX;
        private System.Windows.Forms.Button ToXML;
        private System.Windows.Forms.Button ToJSON;
        private System.Windows.Forms.Button Open;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.TextBox FileName;
        private System.Windows.Forms.TextBox FileContent;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button ToCSV;
        private System.Windows.Forms.Button FromXLSX;
    }
}

