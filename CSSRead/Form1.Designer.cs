namespace CSSRead
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
            this.DataList = new System.Windows.Forms.ListView();
            this.Path = new System.Windows.Forms.TextBox();
            this.OpenButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DataList
            // 
            this.DataList.Location = new System.Drawing.Point(147, 123);
            this.DataList.Name = "DataList";
            this.DataList.Size = new System.Drawing.Size(416, 266);
            this.DataList.TabIndex = 0;
            this.DataList.UseCompatibleStateImageBehavior = false;
            // 
            // Path
            // 
            this.Path.Location = new System.Drawing.Point(143, 33);
            this.Path.Name = "Path";
            this.Path.Size = new System.Drawing.Size(325, 23);
            this.Path.TabIndex = 1;
            // 
            // OpenButton
            // 
            this.OpenButton.Location = new System.Drawing.Point(506, 33);
            this.OpenButton.Name = "OpenButton";
            this.OpenButton.Size = new System.Drawing.Size(75, 23);
            this.OpenButton.TabIndex = 2;
            this.OpenButton.Text = "Open";
            this.OpenButton.UseVisualStyleBackColor = true;
            this.OpenButton.Click += new System.EventHandler(this.OpenButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.OpenButton);
            this.Controls.Add(this.Path);
            this.Controls.Add(this.DataList);
            this.Name = "Form1";
            this.Text = "CSS Class Name Read";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListView DataList;
        private TextBox Path;
        private Button OpenButton;
    }
}