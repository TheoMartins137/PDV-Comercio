namespace PDVOsPingas
{
    partial class PVDVenda
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
            LSTItens = new ListView();
            txtPesquisa = new TextBox();
            txtQuantidade = new RichTextBox();
            lblQuantidade = new Label();
            lblPreco = new Label();
            txtPreco = new RichTextBox();
            lblTotalItem = new Label();
            txtTotalItem = new RichTextBox();
            lblValorTotal = new Label();
            txtValorTotal = new RichTextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // LSTItens
            // 
            LSTItens.Location = new Point(12, 59);
            LSTItens.Name = "LSTItens";
            LSTItens.Size = new Size(552, 474);
            LSTItens.TabIndex = 0;
            LSTItens.UseCompatibleStateImageBehavior = false;
            // 
            // txtPesquisa
            // 
            txtPesquisa.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPesquisa.Location = new Point(12, 12);
            txtPesquisa.Multiline = true;
            txtPesquisa.Name = "txtPesquisa";
            txtPesquisa.Size = new Size(552, 41);
            txtPesquisa.TabIndex = 1;
            txtPesquisa.Text = "asdasdweq";
            // 
            // txtQuantidade
            // 
            txtQuantidade.BorderStyle = BorderStyle.FixedSingle;
            txtQuantidade.Location = new Point(12, 569);
            txtQuantidade.Multiline = false;
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.RightToLeft = RightToLeft.Yes;
            txtQuantidade.Size = new Size(133, 46);
            txtQuantidade.TabIndex = 2;
            txtQuantidade.Text = "3";
            txtQuantidade.ZoomFactor = 2.4F;
            // 
            // lblQuantidade
            // 
            lblQuantidade.AutoSize = true;
            lblQuantidade.Location = new Point(12, 551);
            lblQuantidade.Name = "lblQuantidade";
            lblQuantidade.Size = new Size(72, 15);
            lblQuantidade.TabIndex = 3;
            lblQuantidade.Text = "Quantidade:";
            lblQuantidade.Click += lblQuantidade_Click;
            // 
            // lblPreco
            // 
            lblPreco.AutoSize = true;
            lblPreco.Location = new Point(151, 550);
            lblPreco.Name = "lblPreco";
            lblPreco.Size = new Size(40, 15);
            lblPreco.TabIndex = 5;
            lblPreco.Text = "Preço:";
            // 
            // txtPreco
            // 
            txtPreco.Location = new Point(151, 568);
            txtPreco.Name = "txtPreco";
            txtPreco.RightToLeft = RightToLeft.Yes;
            txtPreco.Size = new Size(224, 46);
            txtPreco.TabIndex = 4;
            txtPreco.Text = "";
            txtPreco.ZoomFactor = 2.4F;
            // 
            // lblTotalItem
            // 
            lblTotalItem.AutoSize = true;
            lblTotalItem.Location = new Point(381, 550);
            lblTotalItem.Name = "lblTotalItem";
            lblTotalItem.Size = new Size(62, 15);
            lblTotalItem.TabIndex = 7;
            lblTotalItem.Text = "Total Item:";
            // 
            // txtTotalItem
            // 
            txtTotalItem.Location = new Point(381, 568);
            txtTotalItem.Name = "txtTotalItem";
            txtTotalItem.RightToLeft = RightToLeft.Yes;
            txtTotalItem.Size = new Size(231, 46);
            txtTotalItem.TabIndex = 6;
            txtTotalItem.Text = "";
            txtTotalItem.ZoomFactor = 2.4F;
            // 
            // lblValorTotal
            // 
            lblValorTotal.AutoSize = true;
            lblValorTotal.Location = new Point(618, 550);
            lblValorTotal.Name = "lblValorTotal";
            lblValorTotal.Size = new Size(64, 15);
            lblValorTotal.TabIndex = 9;
            lblValorTotal.Text = "Valor Total:";
            lblValorTotal.Click += label1_Click;
            // 
            // txtValorTotal
            // 
            txtValorTotal.Location = new Point(618, 569);
            txtValorTotal.Name = "txtValorTotal";
            txtValorTotal.RightToLeft = RightToLeft.Yes;
            txtValorTotal.Size = new Size(280, 46);
            txtValorTotal.TabIndex = 8;
            txtValorTotal.Text = "";
            txtValorTotal.ZoomFactor = 2.4F;
            // 
            // button1
            // 
            button1.Location = new Point(618, 59);
            button1.Name = "button1";
            button1.Size = new Size(280, 49);
            button1.TabIndex = 10;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(618, 153);
            button2.Name = "button2";
            button2.Size = new Size(280, 49);
            button2.TabIndex = 11;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(618, 243);
            button3.Name = "button3";
            button3.Size = new Size(280, 49);
            button3.TabIndex = 12;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // PVDVenda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(910, 625);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(lblValorTotal);
            Controls.Add(txtValorTotal);
            Controls.Add(lblTotalItem);
            Controls.Add(txtTotalItem);
            Controls.Add(lblPreco);
            Controls.Add(txtPreco);
            Controls.Add(lblQuantidade);
            Controls.Add(txtQuantidade);
            Controls.Add(txtPesquisa);
            Controls.Add(LSTItens);
            MaximizeBox = false;
            Name = "PVDVenda";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PVDVenda";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView LSTItens;
        private TextBox txtPesquisa;
        private RichTextBox txtQuantidade;
        private Label lblQuantidade;
        private Label lblPreco;
        private RichTextBox txtPreco;
        private Label lblTotalItem;
        private RichTextBox txtTotalItem;
        private Label lblValorTotal;
        private RichTextBox txtValorTotal;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}