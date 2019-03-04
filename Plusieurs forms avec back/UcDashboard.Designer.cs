namespace Plusieurs_forms_avec_back
{
    partial class UcDashboard
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

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcDashboard));
            this.MbCatgeory = new MetroFramework.Controls.MetroTile();
            this.MbProduct = new MetroFramework.Controls.MetroTile();
            this.metroContextMenu1 = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.metroStyleExtender1 = new MetroFramework.Components.MetroStyleExtender(this.components);
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.metroStyleExtender2 = new MetroFramework.Components.MetroStyleExtender(this.components);
            this.Teacher = new MetroFramework.Controls.MetroTile();
            this.formation = new MetroFramework.Controls.MetroTile();
            this.metroStyleExtender3 = new MetroFramework.Components.MetroStyleExtender(this.components);
            this.Examens = new MetroFramework.Controls.MetroTile();
            this.decconexion = new MetroFramework.Controls.MetroLink();
            this.metroContextMenu1.SuspendLayout();
            this.metroTile1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MbCatgeory
            // 
            this.MbCatgeory.ActiveControl = null;
            this.MbCatgeory.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.MbCatgeory.Location = new System.Drawing.Point(431, 331);
            this.MbCatgeory.Name = "MbCatgeory";
            this.MbCatgeory.Size = new System.Drawing.Size(159, 162);
            this.MbCatgeory.TabIndex = 0;
            this.MbCatgeory.Text = "Administration";
            this.MbCatgeory.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.MbCatgeory.TileImage = ((System.Drawing.Image)(resources.GetObject("MbCatgeory.TileImage")));
            this.MbCatgeory.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.MbCatgeory.UseSelectable = true;
            this.MbCatgeory.UseTileImage = true;
            this.MbCatgeory.Click += new System.EventHandler(this.MbCatgeory_Click);
            // 
            // MbProduct
            // 
            this.MbProduct.ActiveControl = null;
            this.MbProduct.BackColor = System.Drawing.Color.Silver;
            this.MbProduct.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.MbProduct.Location = new System.Drawing.Point(642, 72);
            this.MbProduct.Name = "MbProduct";
            this.MbProduct.Size = new System.Drawing.Size(159, 162);
            this.MbProduct.TabIndex = 0;
            this.MbProduct.Text = "Gerer Students";
            this.MbProduct.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.MbProduct.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.MbProduct.TileImage = ((System.Drawing.Image)(resources.GetObject("MbProduct.TileImage")));
            this.MbProduct.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.MbProduct.UseSelectable = true;
            this.MbProduct.UseTileImage = true;
            this.MbProduct.Click += new System.EventHandler(this.MbProduct_Click);
            // 
            // metroContextMenu1
            // 
            this.metroContextMenu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.metroContextMenu1.Name = "metroContextMenu1";
            this.metroContextMenu1.Size = new System.Drawing.Size(110, 114);
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.newToolStripMenuItem.Text = "New";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.searchToolStripMenuItem.Text = "Search";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.deleteToolStripMenuItem.Text = "delete";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Controls.Add(this.metroTile2);
            this.metroTile1.Location = new System.Drawing.Point(642, 331);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(159, 162);
            this.metroTile1.TabIndex = 1;
            this.metroTile1.Text = "Gerer Utilisateurs";
            this.metroTile1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroTile1.TileImage = global::Plusieurs_forms_avec_back.Properties.Resources.if_LinkedIn_UI_06_2335593;
            this.metroTile1.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile1.UseSelectable = true;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // metroTile2
            // 
            this.metroTile2.ActiveControl = null;
            this.metroTile2.Location = new System.Drawing.Point(0, 0);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(75, 23);
            this.metroTile2.TabIndex = 0;
            this.metroTile2.Text = "metroTile2";
            this.metroTile2.UseSelectable = true;
            // 
            // Teacher
            // 
            this.Teacher.ActiveControl = null;
            this.Teacher.Location = new System.Drawing.Point(431, 72);
            this.Teacher.Name = "Teacher";
            this.Teacher.Size = new System.Drawing.Size(159, 162);
            this.Teacher.TabIndex = 2;
            this.Teacher.Text = "Teachers";
            this.Teacher.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Teacher.TileImage = ((System.Drawing.Image)(resources.GetObject("Teacher.TileImage")));
            this.Teacher.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Teacher.UseSelectable = true;
            this.Teacher.UseTileImage = true;
            this.Teacher.Click += new System.EventHandler(this.Teacher_Click);
            // 
            // formation
            // 
            this.formation.ActiveControl = null;
            this.formation.Location = new System.Drawing.Point(211, 72);
            this.formation.Name = "formation";
            this.formation.Size = new System.Drawing.Size(159, 162);
            this.formation.TabIndex = 0;
            this.formation.Text = "Formations";
            this.formation.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.formation.UseSelectable = true;
            this.formation.Click += new System.EventHandler(this.formation_Click);
            // 
            // Examens
            // 
            this.Examens.ActiveControl = null;
            this.Examens.Location = new System.Drawing.Point(211, 331);
            this.Examens.Name = "Examens";
            this.Examens.Size = new System.Drawing.Size(159, 162);
            this.Examens.TabIndex = 0;
            this.Examens.Text = "Examnes";
            this.Examens.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Examens.TileImage = ((System.Drawing.Image)(resources.GetObject("Examens.TileImage")));
            this.Examens.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Examens.UseSelectable = true;
            this.Examens.UseTileImage = true;
            this.Examens.Click += new System.EventHandler(this.Examens_Click);
            // 
            // decconexion
            // 
            this.decconexion.BackColor = System.Drawing.Color.Transparent;
            this.decconexion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("decconexion.BackgroundImage")));
            this.decconexion.ImageSize = 50;
            this.decconexion.Location = new System.Drawing.Point(969, 512);
            this.decconexion.Name = "decconexion";
            this.decconexion.Size = new System.Drawing.Size(30, 33);
            this.decconexion.TabIndex = 3;
            this.decconexion.UseMnemonic = false;
            this.decconexion.UseSelectable = true;
            this.decconexion.Click += new System.EventHandler(this.decconexion_Click);
            // 
            // UcDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = global::Plusieurs_forms_avec_back.Properties.Resources.oo2;
            this.Controls.Add(this.decconexion);
            this.Controls.Add(this.Examens);
            this.Controls.Add(this.formation);
            this.Controls.Add(this.Teacher);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.MbProduct);
            this.Controls.Add(this.MbCatgeory);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UcDashboard";
            this.Size = new System.Drawing.Size(1023, 574);
            this.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Load += new System.EventHandler(this.UcDashboard_Load);
            this.metroContextMenu1.ResumeLayout(false);
            this.metroTile1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile MbCatgeory;
        private MetroFramework.Controls.MetroTile MbProduct;
        private MetroFramework.Controls.MetroContextMenu metroContextMenu1;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private MetroFramework.Components.MetroStyleExtender metroStyleExtender1;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroTile metroTile2;
        private MetroFramework.Components.MetroStyleExtender metroStyleExtender2;
        private MetroFramework.Controls.MetroTile Teacher;
        private MetroFramework.Controls.MetroTile formation;
        private MetroFramework.Components.MetroStyleExtender metroStyleExtender3;
        private MetroFramework.Controls.MetroTile Examens;
        private MetroFramework.Controls.MetroLink decconexion;
    }
}
