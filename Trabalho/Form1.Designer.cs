
namespace Trabalho
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_cadastro = new System.Windows.Forms.Button();
            this.btn_login = new System.Windows.Forms.Button();
            this.btn_home = new System.Windows.Forms.Button();
            this.btn_shop = new System.Windows.Forms.Button();
            this.btn_conta = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_cadastro
            // 
            this.btn_cadastro.Location = new System.Drawing.Point(34, 202);
            this.btn_cadastro.Name = "btn_cadastro";
            this.btn_cadastro.Size = new System.Drawing.Size(132, 52);
            this.btn_cadastro.TabIndex = 0;
            this.btn_cadastro.Text = "Cadastro";
            this.btn_cadastro.UseVisualStyleBackColor = true;
            this.btn_cadastro.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(34, 279);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(132, 45);
            this.btn_login.TabIndex = 1;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = true;
            // 
            // btn_home
            // 
            this.btn_home.Location = new System.Drawing.Point(396, 42);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(132, 41);
            this.btn_home.TabIndex = 2;
            this.btn_home.Text = "Shop";
            this.btn_home.UseVisualStyleBackColor = true;
            this.btn_home.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_shop
            // 
            this.btn_shop.Location = new System.Drawing.Point(220, 42);
            this.btn_shop.Name = "btn_shop";
            this.btn_shop.Size = new System.Drawing.Size(126, 40);
            this.btn_shop.TabIndex = 3;
            this.btn_shop.Text = "Home";
            this.btn_shop.UseVisualStyleBackColor = true;
            // 
            // btn_conta
            // 
            this.btn_conta.Location = new System.Drawing.Point(591, 42);
            this.btn_conta.Name = "btn_conta";
            this.btn_conta.Size = new System.Drawing.Size(134, 40);
            this.btn_conta.TabIndex = 4;
            this.btn_conta.Text = "Minha Conta";
            this.btn_conta.UseVisualStyleBackColor = true;
            this.btn_conta.Click += new System.EventHandler(this.btn_conta_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(-74, -43);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(288, 208);
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.btn_conta);
            this.Controls.Add(this.btn_shop);
            this.Controls.Add(this.btn_home);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.btn_cadastro);
            this.Name = "Form1";
            this.Text = "Pagina Inicial";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_cadastro;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.Button btn_shop;
        private System.Windows.Forms.Button btn_conta;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

