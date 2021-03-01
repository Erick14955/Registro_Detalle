
namespace Registro_Detalle
{
    partial class rRoles
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rRoles));
            this.RolIdlabel = new System.Windows.Forms.Label();
            this.Nombrelabel = new System.Windows.Forms.Label();
            this.IDnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.DescripciontextBox = new System.Windows.Forms.TextBox();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.ErroreserrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.EsActivocheckBox = new System.Windows.Forms.CheckBox();
            this.DetallegroupBox = new System.Windows.Forms.GroupBox();
            this.EliminarPermisobutton = new System.Windows.Forms.Button();
            this.DetalledataGridView = new System.Windows.Forms.DataGridView();
            this.Agregarbutton = new System.Windows.Forms.Button();
            this.AsignadocheckBox = new System.Windows.Forms.CheckBox();
            this.PermisoscomboBox = new System.Windows.Forms.ComboBox();
            this.PermisoIdlabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.IDnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErroreserrorProvider)).BeginInit();
            this.DetallegroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DetalledataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // RolIdlabel
            // 
            this.RolIdlabel.AutoSize = true;
            this.RolIdlabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RolIdlabel.Location = new System.Drawing.Point(12, 28);
            this.RolIdlabel.Name = "RolIdlabel";
            this.RolIdlabel.Size = new System.Drawing.Size(47, 19);
            this.RolIdlabel.TabIndex = 0;
            this.RolIdlabel.Text = "Rol Id";
            // 
            // Nombrelabel
            // 
            this.Nombrelabel.AutoSize = true;
            this.Nombrelabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Nombrelabel.Location = new System.Drawing.Point(12, 66);
            this.Nombrelabel.Name = "Nombrelabel";
            this.Nombrelabel.Size = new System.Drawing.Size(60, 19);
            this.Nombrelabel.TabIndex = 1;
            this.Nombrelabel.Text = "Nombre";
            // 
            // IDnumericUpDown
            // 
            this.IDnumericUpDown.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IDnumericUpDown.Location = new System.Drawing.Point(91, 25);
            this.IDnumericUpDown.Name = "IDnumericUpDown";
            this.IDnumericUpDown.ReadOnly = true;
            this.IDnumericUpDown.Size = new System.Drawing.Size(70, 22);
            this.IDnumericUpDown.TabIndex = 2;
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.Image = ((System.Drawing.Image)(resources.GetObject("Buscarbutton.Image")));
            this.Buscarbutton.Location = new System.Drawing.Point(167, 25);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(69, 23);
            this.Buscarbutton.TabIndex = 3;
            this.Buscarbutton.Text = "Buscar";
            this.Buscarbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // DescripciontextBox
            // 
            this.DescripciontextBox.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DescripciontextBox.Location = new System.Drawing.Point(91, 66);
            this.DescripciontextBox.Name = "DescripciontextBox";
            this.DescripciontextBox.Size = new System.Drawing.Size(257, 22);
            this.DescripciontextBox.TabIndex = 4;
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.Image = ((System.Drawing.Image)(resources.GetObject("Nuevobutton.Image")));
            this.Nuevobutton.Location = new System.Drawing.Point(27, 345);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(80, 28);
            this.Nuevobutton.TabIndex = 5;
            this.Nuevobutton.Text = "Nuevo";
            this.Nuevobutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Nuevobutton.UseVisualStyleBackColor = true;
            this.Nuevobutton.Click += new System.EventHandler(this.Nuevobutton_Click);
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.Image = ((System.Drawing.Image)(resources.GetObject("Guardarbutton.Image")));
            this.Guardarbutton.Location = new System.Drawing.Point(134, 345);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(80, 28);
            this.Guardarbutton.TabIndex = 6;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Guardarbutton.UseVisualStyleBackColor = true;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click);
            // 
            // Eliminarbutton
            // 
            this.Eliminarbutton.Image = ((System.Drawing.Image)(resources.GetObject("Eliminarbutton.Image")));
            this.Eliminarbutton.Location = new System.Drawing.Point(242, 345);
            this.Eliminarbutton.Name = "Eliminarbutton";
            this.Eliminarbutton.Size = new System.Drawing.Size(84, 28);
            this.Eliminarbutton.TabIndex = 7;
            this.Eliminarbutton.Text = "Eliminar";
            this.Eliminarbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Eliminarbutton.UseVisualStyleBackColor = true;
            this.Eliminarbutton.Click += new System.EventHandler(this.Eliminarbutton_Click);
            // 
            // ErroreserrorProvider
            // 
            this.ErroreserrorProvider.ContainerControl = this;
            // 
            // EsActivocheckBox
            // 
            this.EsActivocheckBox.AutoSize = true;
            this.EsActivocheckBox.Location = new System.Drawing.Point(288, 28);
            this.EsActivocheckBox.Name = "EsActivocheckBox";
            this.EsActivocheckBox.Size = new System.Drawing.Size(60, 19);
            this.EsActivocheckBox.TabIndex = 8;
            this.EsActivocheckBox.Text = "Activo";
            this.EsActivocheckBox.UseVisualStyleBackColor = true;
            // 
            // DetallegroupBox
            // 
            this.DetallegroupBox.Controls.Add(this.EliminarPermisobutton);
            this.DetallegroupBox.Controls.Add(this.DetalledataGridView);
            this.DetallegroupBox.Controls.Add(this.Agregarbutton);
            this.DetallegroupBox.Controls.Add(this.AsignadocheckBox);
            this.DetallegroupBox.Controls.Add(this.PermisoscomboBox);
            this.DetallegroupBox.Controls.Add(this.PermisoIdlabel);
            this.DetallegroupBox.Location = new System.Drawing.Point(27, 94);
            this.DetallegroupBox.Name = "DetallegroupBox";
            this.DetallegroupBox.Size = new System.Drawing.Size(386, 245);
            this.DetallegroupBox.TabIndex = 9;
            this.DetallegroupBox.TabStop = false;
            this.DetallegroupBox.Text = "Detalle";
            // 
            // EliminarPermisobutton
            // 
            this.EliminarPermisobutton.Image = ((System.Drawing.Image)(resources.GetObject("EliminarPermisobutton.Image")));
            this.EliminarPermisobutton.Location = new System.Drawing.Point(6, 206);
            this.EliminarPermisobutton.Name = "EliminarPermisobutton";
            this.EliminarPermisobutton.Size = new System.Drawing.Size(92, 27);
            this.EliminarPermisobutton.TabIndex = 5;
            this.EliminarPermisobutton.Text = "Remover";
            this.EliminarPermisobutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.EliminarPermisobutton.UseVisualStyleBackColor = true;
            this.EliminarPermisobutton.Click += new System.EventHandler(this.EliminarPermisobutton_Click);
            // 
            // DetalledataGridView
            // 
            this.DetalledataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DetalledataGridView.Location = new System.Drawing.Point(6, 50);
            this.DetalledataGridView.Name = "DetalledataGridView";
            this.DetalledataGridView.RowTemplate.Height = 25;
            this.DetalledataGridView.Size = new System.Drawing.Size(374, 150);
            this.DetalledataGridView.TabIndex = 4;
            // 
            // Agregarbutton
            // 
            this.Agregarbutton.Image = ((System.Drawing.Image)(resources.GetObject("Agregarbutton.Image")));
            this.Agregarbutton.Location = new System.Drawing.Point(297, 18);
            this.Agregarbutton.Name = "Agregarbutton";
            this.Agregarbutton.Size = new System.Drawing.Size(73, 27);
            this.Agregarbutton.TabIndex = 3;
            this.Agregarbutton.Text = "Agregar";
            this.Agregarbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Agregarbutton.UseVisualStyleBackColor = true;
            this.Agregarbutton.Click += new System.EventHandler(this.Agregarbutton_Click);
            // 
            // AsignadocheckBox
            // 
            this.AsignadocheckBox.AutoSize = true;
            this.AsignadocheckBox.Location = new System.Drawing.Point(215, 25);
            this.AsignadocheckBox.Name = "AsignadocheckBox";
            this.AsignadocheckBox.Size = new System.Drawing.Size(76, 19);
            this.AsignadocheckBox.TabIndex = 2;
            this.AsignadocheckBox.Text = "Asignado";
            this.AsignadocheckBox.UseVisualStyleBackColor = true;
            // 
            // PermisoscomboBox
            // 
            this.PermisoscomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PermisoscomboBox.FormattingEnabled = true;
            this.PermisoscomboBox.Location = new System.Drawing.Point(75, 21);
            this.PermisoscomboBox.Name = "PermisoscomboBox";
            this.PermisoscomboBox.Size = new System.Drawing.Size(134, 23);
            this.PermisoscomboBox.TabIndex = 1;
            // 
            // PermisoIdlabel
            // 
            this.PermisoIdlabel.AutoSize = true;
            this.PermisoIdlabel.Location = new System.Drawing.Point(6, 24);
            this.PermisoIdlabel.Name = "PermisoIdlabel";
            this.PermisoIdlabel.Size = new System.Drawing.Size(63, 15);
            this.PermisoIdlabel.TabIndex = 0;
            this.PermisoIdlabel.Text = "Permiso Id";
            // 
            // rRoles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(439, 393);
            this.Controls.Add(this.DetallegroupBox);
            this.Controls.Add(this.EsActivocheckBox);
            this.Controls.Add(this.Eliminarbutton);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.Nuevobutton);
            this.Controls.Add(this.DescripciontextBox);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(this.IDnumericUpDown);
            this.Controls.Add(this.Nombrelabel);
            this.Controls.Add(this.RolIdlabel);
            this.Name = "rRoles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Roles";
            this.Load += new System.EventHandler(this.rRoles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.IDnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErroreserrorProvider)).EndInit();
            this.DetallegroupBox.ResumeLayout(false);
            this.DetallegroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DetalledataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label RolIdlabel;
        private System.Windows.Forms.Label Nombrelabel;
        private System.Windows.Forms.NumericUpDown IDnumericUpDown;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.TextBox DescripciontextBox;
        private System.Windows.Forms.Button Nuevobutton;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Button Eliminarbutton;
        private System.Windows.Forms.ErrorProvider ErroreserrorProvider;
        private System.Windows.Forms.CheckBox EsActivocheckBox;
        private System.Windows.Forms.GroupBox DetallegroupBox;
        private System.Windows.Forms.Button EliminarPermisobutton;
        private System.Windows.Forms.DataGridView DetalledataGridView;
        private System.Windows.Forms.Button Agregarbutton;
        private System.Windows.Forms.CheckBox AsignadocheckBox;
        private System.Windows.Forms.ComboBox PermisoscomboBox;
        private System.Windows.Forms.Label PermisoIdlabel;
    }
}

