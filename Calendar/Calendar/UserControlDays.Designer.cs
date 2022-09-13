namespace Calendar
{
    partial class UserControlDays
    {
        /// <summary> 
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.dayButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dayButton
            // 
            this.dayButton.BackColor = System.Drawing.Color.Purple;
            this.dayButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dayButton.FlatAppearance.BorderSize = 0;
            this.dayButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dayButton.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dayButton.ForeColor = System.Drawing.Color.White;
            this.dayButton.Location = new System.Drawing.Point(0, 0);
            this.dayButton.Name = "dayButton";
            this.dayButton.Size = new System.Drawing.Size(130, 90);
            this.dayButton.TabIndex = 0;
            this.dayButton.Text = "00";
            this.dayButton.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.dayButton.UseVisualStyleBackColor = false;
            this.dayButton.Click += new System.EventHandler(this.dayButton_Click);
            // 
            // UserControlDays
            // 
            this.BackColor = System.Drawing.Color.Purple;
            this.Controls.Add(this.dayButton);
            this.Name = "UserControlDays";
            this.Size = new System.Drawing.Size(130, 90);
            this.Load += new System.EventHandler(this.UserControlDays_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button dayButton;
    }
}
