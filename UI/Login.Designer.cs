
namespace Registro_Detalle.UI
{
    partial class Login
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label1 = new System.Windows.Forms.Label();
            this.EmailtextBox = new System.Windows.Forms.TextBox();
            this.PasswordtextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Iniciarsesionbutton = new System.Windows.Forms.Button();
            this.Registrarsebutton = new System.Windows.Forms.Button();
            this.ErroreserrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ErroreserrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(163, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Email";
            // 
            // EmailtextBox
            // 
            this.EmailtextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EmailtextBox.Location = new System.Drawing.Point(103, 40);
            this.EmailtextBox.Name = "EmailtextBox";
            this.EmailtextBox.Size = new System.Drawing.Size(164, 23);
            this.EmailtextBox.TabIndex = 1;
            // 
            // PasswordtextBox
            // 
            this.PasswordtextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PasswordtextBox.Location = new System.Drawing.Point(103, 95);
            this.PasswordtextBox.Name = "PasswordtextBox";
            this.PasswordtextBox.PasswordChar = '*';
            this.PasswordtextBox.Size = new System.Drawing.Size(164, 23);
            this.PasswordtextBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(152, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Contraseña";
            // 
            // Iniciarsesionbutton
            // 
            this.Iniciarsesionbutton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Iniciarsesionbutton.Location = new System.Drawing.Point(139, 136);
            this.Iniciarsesionbutton.Name = "Iniciarsesionbutton";
            this.Iniciarsesionbutton.Size = new System.Drawing.Size(91, 29);
            this.Iniciarsesionbutton.TabIndex = 4;
            this.Iniciarsesionbutton.Text = "Iniciar sesion";
            this.Iniciarsesionbutton.UseVisualStyleBackColor = true;
            this.Iniciarsesionbutton.Click += new System.EventHandler(this.Iniciarsesionbutton_Click);
            // 
            // Registrarsebutton
            // 
            this.Registrarsebutton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Registrarsebutton.Location = new System.Drawing.Point(139, 171);
            this.Registrarsebutton.Name = "Registrarsebutton";
            this.Registrarsebutton.Size = new System.Drawing.Size(91, 29);
            this.Registrarsebutton.TabIndex = 5;
            this.Registrarsebutton.Text = "Registrarse";
            this.Registrarsebutton.UseVisualStyleBackColor = true;
            this.Registrarsebutton.Click += new System.EventHandler(this.Registrarsebutton_Click);
            // 
            // ErroreserrorProvider
            // 
            this.ErroreserrorProvider.ContainerControl = this;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(371, 222);
            this.Controls.Add(this.Registrarsebutton);
            this.Controls.Add(this.Iniciarsesionbutton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PasswordtextBox);
            this.Controls.Add(this.EmailtextBox);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(387, 261);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.ErroreserrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox EmailtextBox;
        private System.Windows.Forms.TextBox PasswordtextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Iniciarsesionbutton;
        private System.Windows.Forms.Button Registrarsebutton;
        private System.Windows.Forms.ErrorProvider ErroreserrorProvider;
    }
}