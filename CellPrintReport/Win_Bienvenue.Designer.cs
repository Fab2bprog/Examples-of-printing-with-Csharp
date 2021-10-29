namespace CellPrintReport
{
    partial class Win_Bienvenue
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Win_Bienvenue));
            this.Btn_PrintWithSelect = new System.Windows.Forms.Button();
            this.GBox_Exemples = new System.Windows.Forms.GroupBox();
            this.Rad_Exemple3 = new System.Windows.Forms.RadioButton();
            this.Txt_PathPicture = new System.Windows.Forms.TextBox();
            this.Btn_Navig = new System.Windows.Forms.Button();
            this.Rad_Exemple4 = new System.Windows.Forms.RadioButton();
            this.Rad_Exemple2 = new System.Windows.Forms.RadioButton();
            this.Rad_Exemple1 = new System.Windows.Forms.RadioButton();
            this.Btn_Preview = new System.Windows.Forms.Button();
            this.Btn_PrintDefault = new System.Windows.Forms.Button();
            this.GBox_Exemples.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn_PrintWithSelect
            // 
            this.Btn_PrintWithSelect.Location = new System.Drawing.Point(14, 253);
            this.Btn_PrintWithSelect.Name = "Btn_PrintWithSelect";
            this.Btn_PrintWithSelect.Size = new System.Drawing.Size(359, 23);
            this.Btn_PrintWithSelect.TabIndex = 0;
            this.Btn_PrintWithSelect.Text = "Impression avec selection d\'imprimante.";
            this.Btn_PrintWithSelect.UseVisualStyleBackColor = true;
            this.Btn_PrintWithSelect.Click += new System.EventHandler(this.Btn_PrintWithSelect_Click);
            // 
            // GBox_Exemples
            // 
            this.GBox_Exemples.Controls.Add(this.Rad_Exemple3);
            this.GBox_Exemples.Controls.Add(this.Txt_PathPicture);
            this.GBox_Exemples.Controls.Add(this.Btn_Navig);
            this.GBox_Exemples.Controls.Add(this.Rad_Exemple4);
            this.GBox_Exemples.Controls.Add(this.Rad_Exemple2);
            this.GBox_Exemples.Controls.Add(this.Rad_Exemple1);
            this.GBox_Exemples.Location = new System.Drawing.Point(13, 12);
            this.GBox_Exemples.Name = "GBox_Exemples";
            this.GBox_Exemples.Size = new System.Drawing.Size(359, 206);
            this.GBox_Exemples.TabIndex = 2;
            this.GBox_Exemples.TabStop = false;
            this.GBox_Exemples.Text = "Exemples d\'impression";
            this.GBox_Exemples.Enter += new System.EventHandler(this.GBox_Exemples_Enter);
            // 
            // Rad_Exemple3
            // 
            this.Rad_Exemple3.AutoSize = true;
            this.Rad_Exemple3.Location = new System.Drawing.Point(15, 111);
            this.Rad_Exemple3.Name = "Rad_Exemple3";
            this.Rad_Exemple3.Size = new System.Drawing.Size(305, 17);
            this.Rad_Exemple3.TabIndex = 5;
            this.Rad_Exemple3.TabStop = true;
            this.Rad_Exemple3.Text = "Exemple 3: Imprime un graphique en camenbert ( piechart ).";
            this.Rad_Exemple3.UseVisualStyleBackColor = true;
            // 
            // Txt_PathPicture
            // 
            this.Txt_PathPicture.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_PathPicture.Location = new System.Drawing.Point(15, 75);
            this.Txt_PathPicture.Name = "Txt_PathPicture";
            this.Txt_PathPicture.ReadOnly = true;
            this.Txt_PathPicture.Size = new System.Drawing.Size(257, 20);
            this.Txt_PathPicture.TabIndex = 4;
            // 
            // Btn_Navig
            // 
            this.Btn_Navig.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Navig.Location = new System.Drawing.Point(278, 73);
            this.Btn_Navig.Name = "Btn_Navig";
            this.Btn_Navig.Size = new System.Drawing.Size(75, 23);
            this.Btn_Navig.TabIndex = 3;
            this.Btn_Navig.Text = "Parcourir";
            this.Btn_Navig.UseVisualStyleBackColor = true;
            this.Btn_Navig.Click += new System.EventHandler(this.Btn_Navig_Click);
            // 
            // Rad_Exemple4
            // 
            this.Rad_Exemple4.AutoSize = true;
            this.Rad_Exemple4.Location = new System.Drawing.Point(15, 144);
            this.Rad_Exemple4.Name = "Rad_Exemple4";
            this.Rad_Exemple4.Size = new System.Drawing.Size(297, 56);
            this.Rad_Exemple4.TabIndex = 2;
            this.Rad_Exemple4.TabStop = true;
            this.Rad_Exemple4.Text = resources.GetString("Rad_Exemple4.Text");
            this.Rad_Exemple4.UseVisualStyleBackColor = true;
            this.Rad_Exemple4.CheckedChanged += new System.EventHandler(this.Rad_Exemple4_CheckedChanged);
            // 
            // Rad_Exemple2
            // 
            this.Rad_Exemple2.AutoSize = true;
            this.Rad_Exemple2.Location = new System.Drawing.Point(15, 53);
            this.Rad_Exemple2.Name = "Rad_Exemple2";
            this.Rad_Exemple2.Size = new System.Drawing.Size(314, 17);
            this.Rad_Exemple2.TabIndex = 1;
            this.Rad_Exemple2.TabStop = true;
            this.Rad_Exemple2.Text = "Exemple 2 : imprime une image de votre choix (jpeg ou png). :";
            this.Rad_Exemple2.UseVisualStyleBackColor = true;
            // 
            // Rad_Exemple1
            // 
            this.Rad_Exemple1.AutoSize = true;
            this.Rad_Exemple1.Location = new System.Drawing.Point(15, 20);
            this.Rad_Exemple1.Name = "Rad_Exemple1";
            this.Rad_Exemple1.Size = new System.Drawing.Size(319, 17);
            this.Rad_Exemple1.TabIndex = 0;
            this.Rad_Exemple1.TabStop = true;
            this.Rad_Exemple1.Text = "Exemple 1: Imprime un texte simple avec une ligne horizontale.";
            this.Rad_Exemple1.UseVisualStyleBackColor = true;
            // 
            // Btn_Preview
            // 
            this.Btn_Preview.Location = new System.Drawing.Point(13, 224);
            this.Btn_Preview.Name = "Btn_Preview";
            this.Btn_Preview.Size = new System.Drawing.Size(359, 23);
            this.Btn_Preview.TabIndex = 3;
            this.Btn_Preview.Text = "Previsualisation.";
            this.Btn_Preview.UseVisualStyleBackColor = true;
            this.Btn_Preview.Click += new System.EventHandler(this.Btn_Preview_Click);
            // 
            // Btn_PrintDefault
            // 
            this.Btn_PrintDefault.Location = new System.Drawing.Point(14, 282);
            this.Btn_PrintDefault.Name = "Btn_PrintDefault";
            this.Btn_PrintDefault.Size = new System.Drawing.Size(359, 23);
            this.Btn_PrintDefault.TabIndex = 4;
            this.Btn_PrintDefault.Text = "Impression sur imprimante par defaut.";
            this.Btn_PrintDefault.UseVisualStyleBackColor = true;
            this.Btn_PrintDefault.Click += new System.EventHandler(this.Btn_PrintDefault_Click);
            // 
            // Win_Bienvenue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 318);
            this.Controls.Add(this.Btn_PrintDefault);
            this.Controls.Add(this.Btn_Preview);
            this.Controls.Add(this.GBox_Exemples);
            this.Controls.Add(this.Btn_PrintWithSelect);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Win_Bienvenue";
            this.Text = "Exemple impression";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GBox_Exemples.ResumeLayout(false);
            this.GBox_Exemples.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_PrintWithSelect;
        private System.Windows.Forms.GroupBox GBox_Exemples;
        private System.Windows.Forms.RadioButton Rad_Exemple4;
        private System.Windows.Forms.RadioButton Rad_Exemple2;
        private System.Windows.Forms.Button Btn_Preview;
        private System.Windows.Forms.Button Btn_PrintDefault;
        private System.Windows.Forms.TextBox Txt_PathPicture;
        private System.Windows.Forms.Button Btn_Navig;
        private System.Windows.Forms.RadioButton Rad_Exemple3;
        private System.Windows.Forms.RadioButton Rad_Exemple1;
    }
}

