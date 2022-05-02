namespace TemplateIntegration.Interface
{
    partial class MainPanel
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.poisonStyleManager = new ReaLTaiizor.Manager.PoisonStyleManager(this.components);
            this.poisonToolTip = new ReaLTaiizor.Controls.PoisonToolTip();
            this.poisonStyleExtender = new ReaLTaiizor.Controls.PoisonStyleExtender(this.components);
            this.materialCheckBox1 = new ReaLTaiizor.Controls.MaterialCheckBox();
            this.materialCheckBox2 = new ReaLTaiizor.Controls.MaterialCheckBox();
            this.bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            ((System.ComponentModel.ISupportInitialize)(this.poisonStyleManager)).BeginInit();
            this.SuspendLayout();
            // 
            // poisonStyleManager
            // 
            this.poisonStyleManager.Owner = this;
            this.poisonStyleManager.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Magenta;
            this.poisonStyleManager.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            // 
            // poisonToolTip
            // 
            this.poisonToolTip.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Blue;
            this.poisonToolTip.StyleManager = null;
            this.poisonToolTip.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            // 
            // poisonStyleExtender
            // 
            this.poisonStyleExtender.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            // 
            // materialCheckBox1
            // 
            this.materialCheckBox1.AutoSize = true;
            this.materialCheckBox1.Depth = 0;
            this.materialCheckBox1.Location = new System.Drawing.Point(0, 0);
            this.materialCheckBox1.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckBox1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckBox1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.materialCheckBox1.Name = "materialCheckBox1";
            this.materialCheckBox1.Ripple = true;
            this.materialCheckBox1.Size = new System.Drawing.Size(10, 10);
            this.materialCheckBox1.TabIndex = 0;
            this.materialCheckBox1.Text = "Log";
            this.materialCheckBox1.UseVisualStyleBackColor = true;
            // 
            // materialCheckBox2
            // 
            this.materialCheckBox2.AutoSize = true;
            this.materialCheckBox2.Depth = 0;
            this.materialCheckBox2.Location = new System.Drawing.Point(0, 0);
            this.materialCheckBox2.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckBox2.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckBox2.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.materialCheckBox2.Name = "materialCheckBox2";
            this.materialCheckBox2.Ripple = true;
            this.materialCheckBox2.Size = new System.Drawing.Size(10, 10);
            this.materialCheckBox2.TabIndex = 0;
            this.materialCheckBox2.Text = "Log1";
            this.materialCheckBox2.UseVisualStyleBackColor = true;
            // 
            // bigLabel1
            // 
            this.bigLabel1.AutoSize = true;
            this.bigLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel1.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bigLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.bigLabel1.Location = new System.Drawing.Point(127, 78);
            this.bigLabel1.Name = "bigLabel1";
            this.bigLabel1.Size = new System.Drawing.Size(473, 46);
            this.bigLabel1.TabIndex = 0;
            this.bigLabel1.Text = "Template Integration Interface";
            // 
            // MainPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.bigLabel1);
            this.Name = "MainPanel";
            this.Size = new System.Drawing.Size(720, 382);
            this.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Magenta;
            this.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            ((System.ComponentModel.ISupportInitialize)(this.poisonStyleManager)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private PoisonStyleManager poisonStyleManager;
        private PoisonToolTip poisonToolTip;
        private PoisonStyleExtender poisonStyleExtender;
        private MaterialCheckBox materialCheckBox1;
        private MaterialCheckBox materialCheckBox2;
        private BigLabel bigLabel1;
    }
}
