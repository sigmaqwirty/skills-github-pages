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
            Execute = new Button();
            Clear = new Button();
            inject = new Button();
            richTextBox1 = new RichTextBox();
            SuspendLayout();
            // 
            // Execute
            // 
            Execute.Location = new Point(46, 366);
            Execute.Name = "Execute";
            Execute.Size = new Size(84, 23);
            Execute.TabIndex = 0;
            Execute.Text = "Execute";
            Execute.UseVisualStyleBackColor = true;
            Execute.Click += Execute_Click;
            // 
            // Clear
            // 
            Clear.Location = new Point(330, 370);
            Clear.Name = "Clear";
            Clear.Size = new Size(87, 23);
            Clear.TabIndex = 1;
            Clear.Text = "Clear";
            Clear.UseVisualStyleBackColor = true;
            Clear.Click += Clear_Click;
            // 
            // inject
            // 
            inject.Location = new Point(592, 366);
            inject.Name = "inject";
            inject.Size = new Size(104, 31);
            inject.TabIndex = 2;
            inject.Text = "inject";
            inject.UseVisualStyleBackColor = true;
            inject.Click += inject_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(65, 39);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(631, 305);
            richTextBox1.TabIndex = 3;
            richTextBox1.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(richTextBox1);
            Controls.Add(inject);
            Controls.Add(Clear);
            Controls.Add(Execute);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button Execute;
        private Button Clear;
        private Button inject;
        private RichTextBox richTextBox1;
    }
}
