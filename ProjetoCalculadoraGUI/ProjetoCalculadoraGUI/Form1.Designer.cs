namespace ProjetoCalculadoraGUI
{
    partial class CalculadoraView
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtNumeroY = new TextBox();
            txtResultado = new TextBox();
            txtNumeroX = new TextBox();
            btnSomar = new Button();
            btnSubtrair = new Button();
            btnMultiplicar = new Button();
            btnDividir = new Button();
            btnLimpar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(52, 22);
            label1.Name = "label1";
            label1.Size = new Size(77, 20);
            label1.TabIndex = 0;
            label1.Text = "Número x:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(52, 76);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 1;
            label2.Text = "Número y:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(52, 125);
            label3.Name = "label3";
            label3.Size = new Size(78, 20);
            label3.TabIndex = 2;
            label3.Text = "Resultado:";
            // 
            // txtNumeroY
            // 
            txtNumeroY.Location = new Point(52, 99);
            txtNumeroY.Name = "txtNumeroY";
            txtNumeroY.Size = new Size(100, 27);
            txtNumeroY.TabIndex = 3;
            txtNumeroY.Text = "0";
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(52, 148);
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(100, 27);
            txtResultado.TabIndex = 5;
            // 
            // txtNumeroX
            // 
            txtNumeroX.Location = new Point(52, 45);
            txtNumeroX.Name = "txtNumeroX";
            txtNumeroX.Size = new Size(100, 27);
            txtNumeroX.TabIndex = 7;
            txtNumeroX.Text = "0";
            // 
            // btnSomar
            // 
            btnSomar.Location = new Point(321, 22);
            btnSomar.Name = "btnSomar";
            btnSomar.Size = new Size(75, 29);
            btnSomar.TabIndex = 8;
            btnSomar.Text = "+";
            btnSomar.UseVisualStyleBackColor = true;
            btnSomar.Click += button1_Click;
            // 
            // btnSubtrair
            // 
            btnSubtrair.Location = new Point(321, 73);
            btnSubtrair.Name = "btnSubtrair";
            btnSubtrair.Size = new Size(75, 23);
            btnSubtrair.TabIndex = 10;
            btnSubtrair.Text = "-";
            btnSubtrair.UseVisualStyleBackColor = true;
            btnSubtrair.Click += btnSubtrair_Click;
            // 
            // btnMultiplicar
            // 
            btnMultiplicar.Location = new Point(321, 122);
            btnMultiplicar.Name = "btnMultiplicar";
            btnMultiplicar.Size = new Size(75, 23);
            btnMultiplicar.TabIndex = 12;
            btnMultiplicar.Text = "*";
            btnMultiplicar.UseVisualStyleBackColor = true;
            btnMultiplicar.Click += btnMultiplicar_Click;
            // 
            // btnDividir
            // 
            btnDividir.Location = new Point(321, 164);
            btnDividir.Name = "btnDividir";
            btnDividir.Size = new Size(75, 23);
            btnDividir.TabIndex = 14;
            btnDividir.Text = "/";
            btnDividir.UseVisualStyleBackColor = true;
            btnDividir.Click += btnDividir_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(321, 208);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(75, 29);
            btnLimpar.TabIndex = 16;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // CalculadoraView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLimpar);
            Controls.Add(btnDividir);
            Controls.Add(btnMultiplicar);
            Controls.Add(btnSubtrair);
            Controls.Add(btnSomar);
            Controls.Add(txtNumeroX);
            Controls.Add(txtResultado);
            Controls.Add(txtNumeroY);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CalculadoraView";
            Text = "Calculadora Gráfica Simples";
            Load += CalculadoraView_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtNumeroY;
        private TextBox txtResultado;
        private TextBox txtNumeroX;
        private Button btnSomar;
        private Button btnSubtrair;
        private Button btnMultiplicar;
        private Button btnDividir;
        private Button btnLimpar;
    }
}
