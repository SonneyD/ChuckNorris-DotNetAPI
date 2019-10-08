namespace ChuckNorrisForm
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_JokeGenerator = new System.Windows.Forms.Button();
            this.txt_JokeResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_JokeGenerator
            // 
            this.btn_JokeGenerator.Location = new System.Drawing.Point(43, 61);
            this.btn_JokeGenerator.Name = "btn_JokeGenerator";
            this.btn_JokeGenerator.Size = new System.Drawing.Size(115, 53);
            this.btn_JokeGenerator.TabIndex = 0;
            this.btn_JokeGenerator.Text = "Generate A Joke";
            this.btn_JokeGenerator.UseVisualStyleBackColor = true;
            this.btn_JokeGenerator.Click += new System.EventHandler(this.btn_JokeGenerator_Click);
            // 
            // txt_JokeResult
            // 
            this.txt_JokeResult.Location = new System.Drawing.Point(186, 61);
            this.txt_JokeResult.Multiline = true;
            this.txt_JokeResult.Name = "txt_JokeResult";
            this.txt_JokeResult.Size = new System.Drawing.Size(418, 53);
            this.txt_JokeResult.TabIndex = 1;
            this.txt_JokeResult.TextChanged += new System.EventHandler(this.txt_JokeResult_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 158);
            this.Controls.Add(this.txt_JokeResult);
            this.Controls.Add(this.btn_JokeGenerator);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_JokeGenerator;
        private System.Windows.Forms.TextBox txt_JokeResult;
    }
}

