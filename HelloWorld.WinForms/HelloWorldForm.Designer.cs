﻿namespace HelloWorld.WinForms
{
    partial class HelloWorldForm
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
            lblHelloWorld = new Label();
            SuspendLayout();
            // 
            // lblHelloWorld
            // 
            lblHelloWorld.Dock = DockStyle.Fill;
            lblHelloWorld.Location = new Point(0, 0);
            lblHelloWorld.Name = "lblHelloWorld";
            lblHelloWorld.Size = new Size(153, 133);
            lblHelloWorld.TabIndex = 0;
            lblHelloWorld.Text = "Hello, World!";
            lblHelloWorld.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // HelloWorldForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(153, 133);
            Controls.Add(lblHelloWorld);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "HelloWorldForm";
            ResumeLayout(false);
        }

        #endregion

        private Label lblHelloWorld;
    }
}
