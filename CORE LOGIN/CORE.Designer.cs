namespace CORE_LOGIN
{
    partial class CORE
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
            this.Evade = new System.Windows.Forms.CheckBox();
            this.Jinx = new System.Windows.Forms.RadioButton();
            this.Vayne = new System.Windows.Forms.RadioButton();
            this.Utilitarios = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Evade
            // 
            this.Evade.AutoSize = true;
            this.Evade.Location = new System.Drawing.Point(12, 426);
            this.Evade.Name = "Evade";
            this.Evade.Size = new System.Drawing.Size(57, 17);
            this.Evade.TabIndex = 1;
            this.Evade.Text = "Evade";
            this.Evade.UseVisualStyleBackColor = true;
            // 
            // Jinx
            // 
            this.Jinx.AutoSize = true;
            this.Jinx.Location = new System.Drawing.Point(6, 55);
            this.Jinx.Name = "Jinx";
            this.Jinx.Size = new System.Drawing.Size(43, 17);
            this.Jinx.TabIndex = 2;
            this.Jinx.TabStop = true;
            this.Jinx.Text = "Jinx";
            this.Jinx.UseVisualStyleBackColor = true;
            this.Jinx.CheckedChanged += new System.EventHandler(this.Jinx_CheckedChanged);
            // 
            // Vayne
            // 
            this.Vayne.AutoSize = true;
            this.Vayne.Location = new System.Drawing.Point(6, 32);
            this.Vayne.Name = "Vayne";
            this.Vayne.Size = new System.Drawing.Size(55, 17);
            this.Vayne.TabIndex = 3;
            this.Vayne.TabStop = true;
            this.Vayne.Text = "Vayne";
            this.Vayne.UseVisualStyleBackColor = true;
            this.Vayne.CheckedChanged += new System.EventHandler(this.Vayne_CheckedChanged);
            // 
            // Utilitarios
            // 
            this.Utilitarios.AutoSize = true;
            this.Utilitarios.Location = new System.Drawing.Point(29, 385);
            this.Utilitarios.Name = "Utilitarios";
            this.Utilitarios.Size = new System.Drawing.Size(49, 13);
            this.Utilitarios.TabIndex = 4;
            this.Utilitarios.Text = "Utilitarios";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Vayne);
            this.groupBox1.Controls.Add(this.Jinx);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(517, 346);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Campeões";
            // 
            // CORE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 612);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Utilitarios);
            this.Controls.Add(this.Evade);
            this.Name = "CORE";
            this.Text = "SyntheticCore";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox Evade;
        private System.Windows.Forms.RadioButton Jinx;
        private System.Windows.Forms.RadioButton Vayne;
        private System.Windows.Forms.Label Utilitarios;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}