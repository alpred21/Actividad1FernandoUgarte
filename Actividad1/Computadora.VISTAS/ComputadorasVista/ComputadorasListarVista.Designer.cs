namespace Computadora.VISTAS.Computadora
{
    partial class ComputadoraListarVista
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
            eliminar_btn = new Button();
            editar_btn = new Button();
            Agregar_btn = new Button();
            btn_Seleccionar = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // eliminar_btn
            // 
            eliminar_btn.Location = new Point(295, 359);
            eliminar_btn.Name = "eliminar_btn";
            eliminar_btn.Size = new Size(114, 29);
            eliminar_btn.TabIndex = 9;
            eliminar_btn.Text = "Eliminar";
            eliminar_btn.UseVisualStyleBackColor = true;
            // 
            // editar_btn
            // 
            editar_btn.Location = new Point(162, 359);
            editar_btn.Name = "editar_btn";
            editar_btn.Size = new Size(114, 29);
            editar_btn.TabIndex = 8;
            editar_btn.Text = "Editar";
            editar_btn.UseVisualStyleBackColor = true;
            // 
            // Agregar_btn
            // 
            Agregar_btn.Location = new Point(29, 359);
            Agregar_btn.Name = "Agregar_btn";
            Agregar_btn.Size = new Size(114, 29);
            Agregar_btn.TabIndex = 7;
            Agregar_btn.Text = "Agregar";
            Agregar_btn.UseVisualStyleBackColor = true;
            // 
            // btn_Seleccionar
            // 
            btn_Seleccionar.Location = new Point(431, 359);
            btn_Seleccionar.Name = "btn_Seleccionar";
            btn_Seleccionar.Size = new Size(110, 29);
            btn_Seleccionar.TabIndex = 6;
            btn_Seleccionar.Text = "Seleccionar";
            btn_Seleccionar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(529, 331);
            dataGridView1.TabIndex = 5;
            // 
            // ComputadoraListarVista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(561, 403);
            Controls.Add(eliminar_btn);
            Controls.Add(editar_btn);
            Controls.Add(Agregar_btn);
            Controls.Add(btn_Seleccionar);
            Controls.Add(dataGridView1);
            Name = "ComputadoraListarVista";
            Text = "ComputadoraListarVista";
            Load += ComputadoraListarVista_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button eliminar_btn;
        private Button editar_btn;
        private Button Agregar_btn;
        private Button btn_Seleccionar;
        private DataGridView dataGridView1;
    }
}