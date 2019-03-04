namespace Plusieurs_forms_avec_back
{
    partial class Examens
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Examens));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.errorfiliere = new MetroFramework.Controls.MetroLink();
            this.errormodule = new MetroFramework.Controls.MetroLink();
            this.filieres = new MetroFramework.Controls.MetroComboBox();
            this.modules = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.path = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.downoald = new MetroFramework.Controls.MetroLink();
            this.ListeExamen = new MetroFramework.Controls.MetroGrid();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CNE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Module = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filieres2 = new MetroFramework.Controls.MetroComboBox();
            this.modules2 = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.Refresh = new MetroFramework.Controls.MetroLink();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListeExamen)).BeginInit();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Location = new System.Drawing.Point(3, 50);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 1;
            this.metroTabControl1.Size = new System.Drawing.Size(1035, 611);
            this.metroTabControl1.TabIndex = 0;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.errorfiliere);
            this.metroTabPage1.Controls.Add(this.errormodule);
            this.metroTabPage1.Controls.Add(this.filieres);
            this.metroTabPage1.Controls.Add(this.modules);
            this.metroTabPage1.Controls.Add(this.metroLabel3);
            this.metroTabPage1.Controls.Add(this.metroLabel2);
            this.metroTabPage1.Controls.Add(this.metroTile1);
            this.metroTabPage1.Controls.Add(this.metroButton3);
            this.metroTabPage1.Controls.Add(this.metroButton2);
            this.metroTabPage1.Controls.Add(this.metroButton1);
            this.metroTabPage1.Controls.Add(this.path);
            this.metroTabPage1.Controls.Add(this.metroLabel1);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.metroTabPage1.Size = new System.Drawing.Size(1027, 569);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Add Examen";
            this.metroTabPage1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            this.metroTabPage1.Click += new System.EventHandler(this.metroTabPage1_Click);
            // 
            // errorfiliere
            // 
            this.errorfiliere.BackColor = System.Drawing.Color.Transparent;
            this.errorfiliere.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("errorfiliere.BackgroundImage")));
            this.errorfiliere.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.errorfiliere.ImageSize = 10;
            this.errorfiliere.Location = new System.Drawing.Point(457, 95);
            this.errorfiliere.Name = "errorfiliere";
            this.errorfiliere.Size = new System.Drawing.Size(17, 17);
            this.errorfiliere.TabIndex = 16;
            this.errorfiliere.UseMnemonic = false;
            this.errorfiliere.UseSelectable = true;
            this.errorfiliere.Visible = false;
            // 
            // errormodule
            // 
            this.errormodule.BackColor = System.Drawing.Color.Transparent;
            this.errormodule.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("errormodule.BackgroundImage")));
            this.errormodule.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.errormodule.ImageSize = 10;
            this.errormodule.Location = new System.Drawing.Point(736, 95);
            this.errormodule.Name = "errormodule";
            this.errormodule.Size = new System.Drawing.Size(17, 17);
            this.errormodule.TabIndex = 16;
            this.errormodule.UseMnemonic = false;
            this.errormodule.UseSelectable = true;
            this.errormodule.Visible = false;
            // 
            // filieres
            // 
            this.filieres.FormattingEnabled = true;
            this.filieres.ItemHeight = 23;
            this.filieres.Location = new System.Drawing.Point(315, 85);
            this.filieres.Name = "filieres";
            this.filieres.Size = new System.Drawing.Size(121, 29);
            this.filieres.TabIndex = 8;
            this.filieres.UseSelectable = true;
            this.filieres.SelectedIndexChanged += new System.EventHandler(this.filieres_SelectedIndexChanged);
            // 
            // modules
            // 
            this.modules.FormattingEnabled = true;
            this.modules.ItemHeight = 23;
            this.modules.Location = new System.Drawing.Point(599, 85);
            this.modules.Name = "modules";
            this.modules.Size = new System.Drawing.Size(121, 29);
            this.modules.TabIndex = 8;
            this.modules.UseSelectable = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(512, 95);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(54, 19);
            this.metroLabel3.TabIndex = 7;
            this.metroLabel3.Text = "Module";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(232, 95);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(44, 19);
            this.metroLabel2.TabIndex = 7;
            this.metroLabel2.Text = "Filiere";
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(233, 18);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(533, 45);
            this.metroTile1.TabIndex = 5;
            this.metroTile1.Text = "Add Path of CSV FILE";
            this.metroTile1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTile1.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile1.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroTile1.UseSelectable = true;
            // 
            // metroButton3
            // 
            this.metroButton3.Location = new System.Drawing.Point(436, 270);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(139, 24);
            this.metroButton3.TabIndex = 4;
            this.metroButton3.Text = "Reset";
            this.metroButton3.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton3.UseSelectable = true;
            this.metroButton3.Click += new System.EventHandler(this.metroButton3_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(436, 231);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(139, 24);
            this.metroButton2.TabIndex = 4;
            this.metroButton2.Text = "Insert";
            this.metroButton2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(436, 192);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(139, 23);
            this.metroButton1.TabIndex = 4;
            this.metroButton1.Text = "Import";
            this.metroButton1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // path
            // 
            // 
            // 
            // 
            this.path.CustomButton.Image = null;
            this.path.CustomButton.Location = new System.Drawing.Point(505, 2);
            this.path.CustomButton.Name = "";
            this.path.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.path.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.path.CustomButton.TabIndex = 1;
            this.path.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.path.CustomButton.UseSelectable = true;
            this.path.CustomButton.Visible = false;
            this.path.Lines = new string[0];
            this.path.Location = new System.Drawing.Point(232, 145);
            this.path.MaxLength = 32767;
            this.path.Name = "path";
            this.path.PasswordChar = '\0';
            this.path.PromptText = "Path";
            this.path.ReadOnly = true;
            this.path.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.path.SelectedText = "";
            this.path.SelectionLength = 0;
            this.path.SelectionStart = 0;
            this.path.ShortcutsEnabled = true;
            this.path.Size = new System.Drawing.Size(533, 30);
            this.path.TabIndex = 3;
            this.path.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.path.Theme = MetroFramework.MetroThemeStyle.Light;
            this.path.UseSelectable = true;
            this.path.WaterMark = "Path";
            this.path.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.path.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(409, 147);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(0, 0);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Black;
            this.metroLabel1.TabIndex = 2;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.downoald);
            this.metroTabPage2.Controls.Add(this.ListeExamen);
            this.metroTabPage2.Controls.Add(this.filieres2);
            this.metroTabPage2.Controls.Add(this.modules2);
            this.metroTabPage2.Controls.Add(this.metroLabel4);
            this.metroTabPage2.Controls.Add(this.metroLabel5);
            this.metroTabPage2.Controls.Add(this.metroTile2);
            this.metroTabPage2.Controls.Add(this.metroLabel6);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(1027, 569);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "List of Examen ";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // downoald
            // 
            this.downoald.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.downoald.Image = global::Plusieurs_forms_avec_back.Properties.Resources.iconfinder_download_103529;
            this.downoald.ImageSize = 32;
            this.downoald.Location = new System.Drawing.Point(690, 69);
            this.downoald.Name = "downoald";
            this.downoald.NoFocusImage = global::Plusieurs_forms_avec_back.Properties.Resources.iconfinder_download_103529;
            this.downoald.Size = new System.Drawing.Size(51, 47);
            this.downoald.TabIndex = 4;
            this.downoald.UseSelectable = true;
            this.downoald.Visible = false;
            this.downoald.Click += new System.EventHandler(this.downoald_Click);
            // 
            // ListeExamen
            // 
            this.ListeExamen.AllowUserToAddRows = false;
            this.ListeExamen.AllowUserToDeleteRows = false;
            this.ListeExamen.AllowUserToResizeRows = false;
            this.ListeExamen.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ListeExamen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListeExamen.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.ListeExamen.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ListeExamen.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.ListeExamen.ColumnHeadersHeight = 17;
            this.ListeExamen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nom,
            this.Prenom,
            this.CNE,
            this.Module,
            this.Note,
            this.Year});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ListeExamen.DefaultCellStyle = dataGridViewCellStyle5;
            this.ListeExamen.EnableHeadersVisualStyles = false;
            this.ListeExamen.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ListeExamen.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ListeExamen.Location = new System.Drawing.Point(159, 122);
            this.ListeExamen.MultiSelect = false;
            this.ListeExamen.Name = "ListeExamen";
            this.ListeExamen.ReadOnly = true;
            this.ListeExamen.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ListeExamen.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.ListeExamen.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.ListeExamen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ListeExamen.ShowCellErrors = false;
            this.ListeExamen.ShowCellToolTips = false;
            this.ListeExamen.Size = new System.Drawing.Size(647, 357);
            this.ListeExamen.TabIndex = 34;
            // 
            // Nom
            // 
            this.Nom.DataPropertyName = "nom";
            this.Nom.HeaderText = "Nom";
            this.Nom.Name = "Nom";
            this.Nom.ReadOnly = true;
            // 
            // Prenom
            // 
            this.Prenom.DataPropertyName = "prenom";
            this.Prenom.HeaderText = "Prenom";
            this.Prenom.Name = "Prenom";
            this.Prenom.ReadOnly = true;
            // 
            // CNE
            // 
            this.CNE.DataPropertyName = "cne";
            this.CNE.HeaderText = "CNE";
            this.CNE.Name = "CNE";
            this.CNE.ReadOnly = true;
            // 
            // Module
            // 
            this.Module.DataPropertyName = "nommodule";
            this.Module.HeaderText = "Module";
            this.Module.Name = "Module";
            this.Module.ReadOnly = true;
            // 
            // Note
            // 
            this.Note.DataPropertyName = "note";
            this.Note.HeaderText = "Note";
            this.Note.Name = "Note";
            this.Note.ReadOnly = true;
            // 
            // Year
            // 
            this.Year.DataPropertyName = "annee";
            this.Year.HeaderText = "Year";
            this.Year.Name = "Year";
            this.Year.ReadOnly = true;
            // 
            // filieres2
            // 
            this.filieres2.FormattingEnabled = true;
            this.filieres2.ItemHeight = 23;
            this.filieres2.Location = new System.Drawing.Point(283, 76);
            this.filieres2.Name = "filieres2";
            this.filieres2.Size = new System.Drawing.Size(121, 29);
            this.filieres2.TabIndex = 21;
            this.filieres2.UseSelectable = true;
            this.filieres2.SelectedIndexChanged += new System.EventHandler(this.filieres2_SelectedIndexChanged);
            // 
            // modules2
            // 
            this.modules2.FormattingEnabled = true;
            this.modules2.ItemHeight = 23;
            this.modules2.Location = new System.Drawing.Point(470, 76);
            this.modules2.Name = "modules2";
            this.modules2.Size = new System.Drawing.Size(121, 29);
            this.modules2.TabIndex = 22;
            this.modules2.UseSelectable = true;
            this.modules2.SelectedIndexChanged += new System.EventHandler(this.modules2_SelectedIndexChanged);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(410, 86);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(54, 19);
            this.metroLabel4.TabIndex = 19;
            this.metroLabel4.Text = "Module";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(233, 86);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(44, 19);
            this.metroLabel5.TabIndex = 20;
            this.metroLabel5.Text = "Filiere";
            // 
            // metroTile2
            // 
            this.metroTile2.ActiveControl = null;
            this.metroTile2.Location = new System.Drawing.Point(233, 18);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(533, 45);
            this.metroTile2.TabIndex = 18;
            this.metroTile2.Text = "List Of Examen";
            this.metroTile2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile2.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTile2.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile2.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroTile2.UseSelectable = true;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel6.Location = new System.Drawing.Point(381, 105);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(0, 0);
            this.metroLabel6.Style = MetroFramework.MetroColorStyle.Black;
            this.metroLabel6.TabIndex = 17;
            // 
            // Refresh
            // 
            this.Refresh.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.Refresh.Image = global::Plusieurs_forms_avec_back.Properties.Resources._3229643_1284;
            this.Refresh.ImageSize = 32;
            this.Refresh.Location = new System.Drawing.Point(1000, 3);
            this.Refresh.Name = "Refresh";
            this.Refresh.NoFocusImage = ((System.Drawing.Image)(resources.GetObject("Refresh.NoFocusImage")));
            this.Refresh.Size = new System.Drawing.Size(57, 40);
            this.Refresh.TabIndex = 3;
            this.Refresh.UseSelectable = true;
            this.Refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // Examens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Refresh);
            this.Controls.Add(this.metroTabControl1);
            this.Name = "Examens";
            this.Size = new System.Drawing.Size(1080, 677);
            this.Load += new System.EventHandler(this.Examens_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListeExamen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroButton metroButton3;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroTextBox path;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox filieres;
        private MetroFramework.Controls.MetroComboBox modules;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLink errorfiliere;
        private MetroFramework.Controls.MetroLink errormodule;
        private MetroFramework.Controls.MetroComboBox filieres2;
        private MetroFramework.Controls.MetroComboBox modules2;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTile metroTile2;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroGrid ListeExamen;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNE;
        private System.Windows.Forms.DataGridViewTextBoxColumn Module;
        private System.Windows.Forms.DataGridViewTextBoxColumn Note;
        private System.Windows.Forms.DataGridViewTextBoxColumn Year;
        private MetroFramework.Controls.MetroLink Refresh;
        private MetroFramework.Controls.MetroLink downoald;
    }
}
