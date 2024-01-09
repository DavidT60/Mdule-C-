
namespace ClassCombox
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
            this.comboBoxProvin = new System.Windows.Forms.ComboBox();
            this.GridViewProv = new System.Windows.Forms.DataGridView();
            this.municipios = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.distritos = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewProv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.municipios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.distritos)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxProvin
            // 
            this.comboBoxProvin.FormattingEnabled = true;
            this.comboBoxProvin.Location = new System.Drawing.Point(17, 74);
            this.comboBoxProvin.Name = "comboBoxProvin";
            this.comboBoxProvin.Size = new System.Drawing.Size(121, 23);
            this.comboBoxProvin.TabIndex = 0;
            this.comboBoxProvin.SelectedValueChanged += new System.EventHandler(this.comboBoxProvin_SelectedValueChanged);
            // 
            // GridViewProv
            // 
            this.GridViewProv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewProv.Location = new System.Drawing.Point(12, 112);
            this.GridViewProv.MultiSelect = false;
            this.GridViewProv.Name = "GridViewProv";
            this.GridViewProv.ReadOnly = true;
            this.GridViewProv.RowTemplate.Height = 25;
            this.GridViewProv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.GridViewProv.Size = new System.Drawing.Size(162, 241);
            this.GridViewProv.TabIndex = 1;
            // 
            // municipios
            // 
            this.municipios.BackgroundColor = System.Drawing.Color.Black;
            this.municipios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.municipios.GridColor = System.Drawing.Color.White;
            this.municipios.Location = new System.Drawing.Point(238, 107);
            this.municipios.Name = "municipios";
            this.municipios.ReadOnly = true;
            this.municipios.RowTemplate.Height = 25;
            this.municipios.Size = new System.Drawing.Size(324, 148);
            this.municipios.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 3;
            // 
            // distritos
            // 
            this.distritos.BackgroundColor = System.Drawing.Color.Black;
            this.distritos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.distritos.GridColor = System.Drawing.Color.White;
            this.distritos.Location = new System.Drawing.Point(238, 282);
            this.distritos.Name = "distritos";
            this.distritos.ReadOnly = true;
            this.distritos.RowHeadersWidth = 70;
            this.distritos.RowTemplate.Height = 25;
            this.distritos.Size = new System.Drawing.Size(324, 153);
            this.distritos.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(17, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 30);
            this.label2.TabIndex = 6;
            this.label2.Text = "Provincias";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(346, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 27);
            this.label3.TabIndex = 7;
            this.label3.Text = "Datos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(238, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = "Municipios";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(238, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 21);
            this.label5.TabIndex = 9;
            this.label5.Text = " Distritos";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.distritos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.municipios);
            this.Controls.Add(this.GridViewProv);
            this.Controls.Add(this.comboBoxProvin);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewProv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.municipios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.distritos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxProvin;
        private System.Windows.Forms.DataGridView GridViewProv;
        private System.Windows.Forms.DataGridView municipios;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView distritos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

