
namespace CS024DenTyden
{
    partial class CS024DenTydenForm
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.cisloDneLabel = new System.Windows.Forms.Label();
            this.cisloDenTexBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cisloDneLabel
            // 
            this.cisloDneLabel.AutoSize = true;
            this.cisloDneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cisloDneLabel.Location = new System.Drawing.Point(433, 209);
            this.cisloDneLabel.Name = "cisloDneLabel";
            this.cisloDneLabel.Size = new System.Drawing.Size(29, 31);
            this.cisloDneLabel.TabIndex = 0;
            this.cisloDneLabel.Text = "?";
            // 
            // cisloDenTexBox
            // 
            this.cisloDenTexBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cisloDenTexBox.Location = new System.Drawing.Point(398, 155);
            this.cisloDenTexBox.Name = "cisloDenTexBox";
            this.cisloDenTexBox.Size = new System.Drawing.Size(125, 38);
            this.cisloDenTexBox.TabIndex = 1;
            this.cisloDenTexBox.Text = "Číslo dne";
            this.cisloDenTexBox.TextChanged += new System.EventHandler(this.cisloDenTexBox_TextChanged);
            // 
            // CS024DenTydenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cisloDenTexBox);
            this.Controls.Add(this.cisloDneLabel);
            this.Name = "CS024DenTydenForm";
            this.Text = "CS024- Název dne ze zadaného čísla- Miler Vojtěch";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label cisloDneLabel;
        private System.Windows.Forms.TextBox cisloDenTexBox;
    }
}

