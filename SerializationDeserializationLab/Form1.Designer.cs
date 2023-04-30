
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
            this.FromJSON = new System.Windows.Forms.Button();
            this.FromXML = new System.Windows.Forms.Button();
            this.FromCSV = new System.Windows.Forms.Button();
            this.FromXLSX = new System.Windows.Forms.Button();
            this.ToXLSX = new System.Windows.Forms.Button();
            this.ToXML = new System.Windows.Forms.Button();
            this.ToJSON = new System.Windows.Forms.Button();
            this.Open = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.FileName = new System.Windows.Forms.TextBox();
            this.FileContent = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.ToCSV = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FromJSON
            // 
            this.FromJSON.Location = new System.Drawing.Point(12, 12);
            this.FromJSON.Name = "FromJSON";
            this.FromJSON.Size = new System.Drawing.Size(216, 79);
            this.FromJSON.TabIndex = 0;
            this.FromJSON.Text = "DeserializeFromJSON";
            this.FromJSON.UseVisualStyleBackColor = true;
            this.FromJSON.Click += new System.EventHandler(this.FromJSON_Click);
            // 
            // FromXML
            // 
            this.FromXML.Location = new System.Drawing.Point(11, 97);
            this.FromXML.Name = "FromXML";
            this.FromXML.Size = new System.Drawing.Size(216, 72);
            this.FromXML.TabIndex = 1;
            this.FromXML.Text = "DeserializeFromXML";
            this.FromXML.UseVisualStyleBackColor = true;
            this.FromXML.Click += new System.EventHandler(this.FromXML_Click);
            // 
            // FromCSV
            // 
            this.FromCSV.Location = new System.Drawing.Point(11, 175);
            this.FromCSV.Name = "FromCSV";
            this.FromCSV.Size = new System.Drawing.Size(216, 72);
            this.FromCSV.TabIndex = 2;
            this.FromCSV.Text = "DeserializeFromCSV";
            this.FromCSV.UseVisualStyleBackColor = true;
            this.FromCSV.Click += new System.EventHandler(this.FromCSV_Click);
            // 
            // FromXLSX
            // 
            this.FromXLSX.Location = new System.Drawing.Point(12, 253);
            this.FromXLSX.Name = "FromXLSX";
            this.FromXLSX.Size = new System.Drawing.Size(389, 62);
            this.FromXLSX.TabIndex = 3;
            this.FromXLSX.Text = "ImportFromXLSX";
            this.FromXLSX.UseVisualStyleBackColor = true;
            this.FromXLSX.Click += new System.EventHandler(this.FromXLSX_Click);
            // 
            // ToXLSX
            // 
            this.ToXLSX.Location = new System.Drawing.Point(407, 253);
            this.ToXLSX.Name = "ToXLSX";
            this.ToXLSX.Size = new System.Drawing.Size(381, 62);
            this.ToXLSX.TabIndex = 7;
            this.ToXLSX.Text = "SaveAsXLSX";
            this.ToXLSX.UseVisualStyleBackColor = true;
            this.ToXLSX.Click += new System.EventHandler(this.ToXLSX_Click);
            // 
            // ToXML
            // 
            this.ToXML.Location = new System.Drawing.Point(572, 97);
            this.ToXML.Name = "ToXML";
            this.ToXML.Size = new System.Drawing.Size(216, 72);
            this.ToXML.TabIndex = 5;
            this.ToXML.Text = "SerializeToXML";
            this.ToXML.UseVisualStyleBackColor = true;
            this.ToXML.Click += new System.EventHandler(this.ToXML_Click);
            // 
            // ToJSON
            // 
            this.ToJSON.Location = new System.Drawing.Point(572, 12);
            this.ToJSON.Name = "ToJSON";
            this.ToJSON.Size = new System.Drawing.Size(216, 79);
            this.ToJSON.TabIndex = 4;
            this.ToJSON.Text = "SerializeToJSON";
            this.ToJSON.UseVisualStyleBackColor = true;
            this.ToJSON.Click += new System.EventHandler(this.ToJSON_Click);
            // 
            // Open
            // 
            this.Open.Location = new System.Drawing.Point(107, 329);
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(138, 41);
            this.Open.TabIndex = 8;
            this.Open.Text = "Open txt";
            this.Open.UseVisualStyleBackColor = true;
            this.Open.Click += new System.EventHandler(this.Open_Click);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(547, 329);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(145, 41);
            this.Save.TabIndex = 9;
            this.Save.Text = "Save txt";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click_1);
            // 
            // FileName
            // 
            this.FileName.Location = new System.Drawing.Point(234, 12);
            this.FileName.Name = "FileName";
            this.FileName.Size = new System.Drawing.Size(332, 31);
            this.FileName.TabIndex = 10;
            // 
            // FileContent
            // 
            this.FileContent.Location = new System.Drawing.Point(234, 49);
            this.FileContent.Multiline = true;
            this.FileContent.Name = "FileContent";
            this.FileContent.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.FileContent.Size = new System.Drawing.Size(332, 198);
            this.FileContent.TabIndex = 11;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // ToCSV
            // 
            this.ToCSV.Location = new System.Drawing.Point(572, 175);
            this.ToCSV.Name = "ToCSV";
            this.ToCSV.Size = new System.Drawing.Size(216, 72);
            this.ToCSV.TabIndex = 6;
            this.ToCSV.Text = "SerializeToCSV";
            this.ToCSV.UseVisualStyleBackColor = true;
            this.ToCSV.Click += new System.EventHandler(this.ToCSV_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 403);
            this.Controls.Add(this.FileContent);
            this.Controls.Add(this.FileName);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.Open);
            this.Controls.Add(this.ToXLSX);
            this.Controls.Add(this.ToCSV);
            this.Controls.Add(this.ToXML);
            this.Controls.Add(this.ToJSON);
            this.Controls.Add(this.FromXLSX);
            this.Controls.Add(this.FromCSV);
            this.Controls.Add(this.FromXML);
            this.Controls.Add(this.FromJSON);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

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

