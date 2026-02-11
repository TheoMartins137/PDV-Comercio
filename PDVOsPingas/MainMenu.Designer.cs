namespace PDVOsPingas
{
    partial class MainMenu
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
            lstTeste = new ListView();
            txtPesquisar = new TextBox();
            button2 = new Button();
            button1 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            SuspendLayout();
            // 
            // lstTeste
            // 
            lstTeste.Location = new Point(624, 61);
            lstTeste.Name = "lstTeste";
            lstTeste.Size = new Size(688, 560);
            lstTeste.TabIndex = 1;
            lstTeste.UseCompatibleStateImageBehavior = false;
            lstTeste.ItemSelectionChanged += lstTeste_ItemSelectionChanged;
            lstTeste.SelectedIndexChanged += lstTeste_SelectedIndexChanged;
            // 
            // txtPesquisar
            // 
            txtPesquisar.Location = new Point(624, 12);
            txtPesquisar.Multiline = true;
            txtPesquisar.Name = "txtPesquisar";
            txtPesquisar.Size = new Size(688, 43);
            txtPesquisar.TabIndex = 2;
            // 
            // button2
            // 
            button2.Location = new Point(245, 271);
            button2.Name = "button2";
            button2.Size = new Size(140, 88);
            button2.TabIndex = 3;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(54, 271);
            button1.Name = "button1";
            button1.Size = new Size(140, 88);
            button1.TabIndex = 7;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(435, 271);
            button3.Name = "button3";
            button3.Size = new Size(140, 88);
            button3.TabIndex = 8;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(435, 41);
            button4.Name = "button4";
            button4.Size = new Size(140, 88);
            button4.TabIndex = 11;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(54, 41);
            button5.Name = "button5";
            button5.Size = new Size(140, 88);
            button5.TabIndex = 10;
            button5.Text = "button5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(245, 41);
            button6.Name = "button6";
            button6.Size = new Size(140, 88);
            button6.TabIndex = 9;
            button6.Text = "button6";
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(435, 533);
            button7.Name = "button7";
            button7.Size = new Size(140, 88);
            button7.TabIndex = 14;
            button7.Text = "button7";
            button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Location = new Point(54, 533);
            button8.Name = "button8";
            button8.Size = new Size(140, 88);
            button8.TabIndex = 13;
            button8.Text = "button8";
            button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            button9.Location = new Point(245, 533);
            button9.Name = "button9";
            button9.Size = new Size(140, 88);
            button9.TabIndex = 12;
            button9.Text = "button9";
            button9.UseVisualStyleBackColor = true;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1324, 633);
            Controls.Add(button7);
            Controls.Add(button8);
            Controls.Add(button9);
            Controls.Add(button4);
            Controls.Add(button5);
            Controls.Add(button6);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(txtPesquisar);
            Controls.Add(lstTeste);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "MainMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MenuInicial";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ListView lstTeste;
        private TextBox txtPesquisar;
        private Button button2;
        private Button button1;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
    }
}
