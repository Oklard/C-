
namespace Arrays
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
            this.testeVetor = new System.Windows.Forms.Button();
            this.btnVetorTexto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // testeVetor
            // 
            this.testeVetor.Location = new System.Drawing.Point(305, 108);
            this.testeVetor.Name = "testeVetor";
            this.testeVetor.Size = new System.Drawing.Size(135, 88);
            this.testeVetor.TabIndex = 0;
            this.testeVetor.Text = "Teste vetor";
            this.testeVetor.UseVisualStyleBackColor = true;
            this.testeVetor.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnVetorTexto
            // 
            this.btnVetorTexto.Location = new System.Drawing.Point(305, 227);
            this.btnVetorTexto.Name = "btnVetorTexto";
            this.btnVetorTexto.Size = new System.Drawing.Size(135, 88);
            this.btnVetorTexto.TabIndex = 1;
            this.btnVetorTexto.Text = "Vetor texto";
            this.btnVetorTexto.UseVisualStyleBackColor = true;
            this.btnVetorTexto.Click += new System.EventHandler(this.btnVetorTexto_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVetorTexto);
            this.Controls.Add(this.testeVetor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button testeVetor;
        private System.Windows.Forms.Button btnVetorTexto;
    }
}

