namespace PerzoneFalze
{
    partial class frmNewGrigliaPerzone
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
            this.components = new System.ComponentModel.Container();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.GCPerzoneFalze = new DevExpress.XtraGrid.GridControl();
            this.xpViewGenerale = new DevExpress.Xpo.XPView(this.components);
            this.unitOfWorkGenerale = new DevExpress.Xpo.UnitOfWork(this.components);
            this.GVPerzoneFalze = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colPerzonaID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSurname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBirthDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStateOfMind = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LayoutControlGenerale = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GCPerzoneFalze)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpViewGenerale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitOfWorkGenerale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GVPerzoneFalze)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LayoutControlGenerale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.simpleButton1);
            this.layoutControl1.Controls.Add(this.GCPerzoneFalze);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsPrint.AppearanceGroupCaption.BackColor = System.Drawing.Color.LightGray;
            this.layoutControl1.OptionsPrint.AppearanceGroupCaption.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.layoutControl1.OptionsPrint.AppearanceGroupCaption.Options.UseBackColor = true;
            this.layoutControl1.OptionsPrint.AppearanceGroupCaption.Options.UseFont = true;
            this.layoutControl1.OptionsPrint.AppearanceGroupCaption.Options.UseTextOptions = true;
            this.layoutControl1.OptionsPrint.AppearanceGroupCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.layoutControl1.OptionsPrint.AppearanceGroupCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.layoutControl1.OptionsPrint.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutControl1.OptionsPrint.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.layoutControl1.OptionsPrint.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.layoutControl1.Root = this.LayoutControlGenerale;
            this.layoutControl1.Size = new System.Drawing.Size(784, 361);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // GCPerzoneFalze
            // 
            this.GCPerzoneFalze.DataSource = this.xpViewGenerale;
            this.GCPerzoneFalze.Location = new System.Drawing.Point(12, 38);
            this.GCPerzoneFalze.MainView = this.GVPerzoneFalze;
            this.GCPerzoneFalze.Name = "GCPerzoneFalze";
            this.GCPerzoneFalze.Size = new System.Drawing.Size(760, 311);
            this.GCPerzoneFalze.TabIndex = 4;
            this.GCPerzoneFalze.UseEmbeddedNavigator = true;
            this.GCPerzoneFalze.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GVPerzoneFalze});
            // 
            // xpViewGenerale
            // 
            this.xpViewGenerale.ObjectType = typeof(PerzoneFalze.Database.Tables.ListaContatti);
            this.xpViewGenerale.Properties.AddRange(new DevExpress.Xpo.ViewProperty[] {
            new DevExpress.Xpo.ViewProperty("PerzonaID", DevExpress.Xpo.SortDirection.None, "[PerzonaID]", false, true),
            new DevExpress.Xpo.ViewProperty("Surname", DevExpress.Xpo.SortDirection.None, "[Surname]", false, true),
            new DevExpress.Xpo.ViewProperty("Name", DevExpress.Xpo.SortDirection.None, "[Name]", false, true),
            new DevExpress.Xpo.ViewProperty("BirthDate", DevExpress.Xpo.SortDirection.None, "[BirthDate]", false, true),
            new DevExpress.Xpo.ViewProperty("StateOfMind", DevExpress.Xpo.SortDirection.None, "[StateOfMind]", false, true)});
            this.xpViewGenerale.Session = this.unitOfWorkGenerale;
            // 
            // unitOfWorkGenerale
            // 
            this.unitOfWorkGenerale.AutoCreateOption = DevExpress.Xpo.DB.AutoCreateOption.SchemaAlreadyExists;
            this.unitOfWorkGenerale.IsObjectModifiedOnNonPersistentPropertyChange = null;
            this.unitOfWorkGenerale.TrackPropertiesModifications = false;
            // 
            // GVPerzoneFalze
            // 
            this.GVPerzoneFalze.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colPerzonaID,
            this.colSurname,
            this.colName,
            this.colBirthDate,
            this.colStateOfMind});
            this.GVPerzoneFalze.GridControl = this.GCPerzoneFalze;
            this.GVPerzoneFalze.Name = "GVPerzoneFalze";
            this.GVPerzoneFalze.OptionsBehavior.Editable = false;
            this.GVPerzoneFalze.OptionsBehavior.ReadOnly = true;
            this.GVPerzoneFalze.OptionsFind.AlwaysVisible = true;
            this.GVPerzoneFalze.OptionsView.ShowAutoFilterRow = true;
            this.GVPerzoneFalze.OptionsView.ShowGroupPanel = false;
            this.GVPerzoneFalze.RowStyle += new DevExpress.XtraGrid.Views.Grid.RowStyleEventHandler(this.GVPerzoneFalze_RowStyle);
            // 
            // colPerzonaID
            // 
            this.colPerzonaID.FieldName = "PerzonaID";
            this.colPerzonaID.Name = "colPerzonaID";
            // 
            // colSurname
            // 
            this.colSurname.AppearanceHeader.Options.UseTextOptions = true;
            this.colSurname.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSurname.FieldName = "Surname";
            this.colSurname.Name = "colSurname";
            this.colSurname.Visible = true;
            this.colSurname.VisibleIndex = 0;
            // 
            // colName
            // 
            this.colName.AppearanceHeader.Options.UseTextOptions = true;
            this.colName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 1;
            // 
            // colBirthDate
            // 
            this.colBirthDate.AppearanceHeader.Options.UseTextOptions = true;
            this.colBirthDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBirthDate.FieldName = "BirthDate";
            this.colBirthDate.Name = "colBirthDate";
            this.colBirthDate.Visible = true;
            this.colBirthDate.VisibleIndex = 2;
            // 
            // colStateOfMind
            // 
            this.colStateOfMind.AppearanceHeader.Options.UseTextOptions = true;
            this.colStateOfMind.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colStateOfMind.Caption = "State of Mind";
            this.colStateOfMind.FieldName = "StateOfMind";
            this.colStateOfMind.Name = "colStateOfMind";
            this.colStateOfMind.Visible = true;
            this.colStateOfMind.VisibleIndex = 3;
            // 
            // LayoutControlGenerale
            // 
            this.LayoutControlGenerale.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.LayoutControlGenerale.GroupBordersVisible = false;
            this.LayoutControlGenerale.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2});
            this.LayoutControlGenerale.Location = new System.Drawing.Point(0, 0);
            this.LayoutControlGenerale.Name = "LayoutControlGenerale";
            this.LayoutControlGenerale.Size = new System.Drawing.Size(784, 361);
            this.LayoutControlGenerale.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.GCPerzoneFalze;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 26);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(764, 315);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(12, 12);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(760, 22);
            this.simpleButton1.StyleController = this.layoutControl1;
            this.simpleButton1.TabIndex = 5;
            this.simpleButton1.Text = "simpleButton1";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.simpleButton1;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(764, 26);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // frmNewGrigliaPerzone
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 361);
            this.Controls.Add(this.layoutControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(800, 400);
            this.Name = "frmNewGrigliaPerzone";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Elenco Perzone";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GCPerzoneFalze)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpViewGenerale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitOfWorkGenerale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GVPerzoneFalze)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LayoutControlGenerale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup LayoutControlGenerale;
        private DevExpress.XtraGrid.GridControl GCPerzoneFalze;
        private DevExpress.XtraGrid.Views.Grid.GridView GVPerzoneFalze;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.Xpo.XPView xpViewGenerale;
        private DevExpress.Xpo.UnitOfWork unitOfWorkGenerale;
        private DevExpress.XtraGrid.Columns.GridColumn colPerzonaID;
        private DevExpress.XtraGrid.Columns.GridColumn colSurname;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colBirthDate;
        private DevExpress.XtraGrid.Columns.GridColumn colStateOfMind;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
    }
}