namespace WinPivot_GettingStarted
{
    partial class Form1
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
            DevExpress.XtraPivotGrid.DifferenceBinding differenceBinding1 = new DevExpress.XtraPivotGrid.DifferenceBinding();
            DevExpress.XtraPivotGrid.DataSourceColumnBinding dataSourceColumnBinding1 = new DevExpress.XtraPivotGrid.DataSourceColumnBinding();
            DevExpress.XtraPivotGrid.DataSourceColumnBinding dataSourceColumnBinding2 = new DevExpress.XtraPivotGrid.DataSourceColumnBinding();
            DevExpress.XtraPivotGrid.DataSourceColumnBinding dataSourceColumnBinding3 = new DevExpress.XtraPivotGrid.DataSourceColumnBinding();
            DevExpress.XtraPivotGrid.DataSourceColumnBinding dataSourceColumnBinding4 = new DevExpress.XtraPivotGrid.DataSourceColumnBinding();
            DevExpress.XtraPivotGrid.DataSourceColumnBinding dataSourceColumnBinding5 = new DevExpress.XtraPivotGrid.DataSourceColumnBinding();
            DevExpress.XtraPivotGrid.PivotGridFormatRule pivotGridFormatRule1 = new DevExpress.XtraPivotGrid.PivotGridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleTopBottom formatConditionRuleTopBottom1 = new DevExpress.XtraEditors.FormatConditionRuleTopBottom();
            DevExpress.XtraPivotGrid.FormatRuleFieldIntersectionSettings formatRuleFieldIntersectionSettings1 = new DevExpress.XtraPivotGrid.FormatRuleFieldIntersectionSettings();
            DevExpress.XtraPivotGrid.PivotGridFormatRule pivotGridFormatRule2 = new DevExpress.XtraPivotGrid.PivotGridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleValue formatConditionRuleValue1 = new DevExpress.XtraEditors.FormatConditionRuleValue();
            DevExpress.XtraPivotGrid.FormatRuleFieldIntersectionSettings formatRuleFieldIntersectionSettings2 = new DevExpress.XtraPivotGrid.FormatRuleFieldIntersectionSettings();
            DevExpress.DataAccess.Sql.SelectQuery selectQuery1 = new DevExpress.DataAccess.Sql.SelectQuery();
            DevExpress.DataAccess.Sql.Column column1 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression1 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table1 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column2 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression2 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column3 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression3 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column4 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression4 = new DevExpress.DataAccess.Sql.ColumnExpression();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pivotGridField5 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridField4 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridField1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridField3 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridField2 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridControl1 = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // pivotGridField5
            // 
            this.pivotGridField5.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.pivotGridField5.AreaIndex = 1;
            this.pivotGridField5.Caption = "Difference Variation by Year";
            this.pivotGridField5.CellFormat.FormatString = "p";
            this.pivotGridField5.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            differenceBinding1.DifferenceType = DevExpress.XtraPivotGrid.DifferenceType.Percentage;
            dataSourceColumnBinding1.ColumnName = "ExtendedPrice";
            differenceBinding1.Source = dataSourceColumnBinding1;
            this.pivotGridField5.DataBinding = differenceBinding1;
            this.pivotGridField5.Name = "pivotGridField5";
            this.pivotGridField5.Options.AllowHide = DevExpress.Utils.DefaultBoolean.True;
            // 
            // pivotGridField4
            // 
            this.pivotGridField4.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.pivotGridField4.AreaIndex = 0;
            this.pivotGridField4.Caption = "Order Date";
            dataSourceColumnBinding2.ColumnName = "OrderDate";
            dataSourceColumnBinding2.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateYear;
            this.pivotGridField4.DataBinding = dataSourceColumnBinding2;
            this.pivotGridField4.Name = "pivotGridField4";
            // 
            // pivotGridField1
            // 
            this.pivotGridField1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.pivotGridField1.AreaIndex = 1;
            this.pivotGridField1.Caption = "Product Name";
            dataSourceColumnBinding3.ColumnName = "ProductName";
            this.pivotGridField1.DataBinding = dataSourceColumnBinding3;
            this.pivotGridField1.Name = "pivotGridField1";
            this.pivotGridField1.SortBySummaryInfo.Field = this.pivotGridField3;
            // 
            // pivotGridField3
            // 
            this.pivotGridField3.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.pivotGridField3.AreaIndex = 0;
            this.pivotGridField3.Caption = "Extended Price";
            dataSourceColumnBinding4.ColumnName = "ExtendedPrice";
            this.pivotGridField3.DataBinding = dataSourceColumnBinding4;
            this.pivotGridField3.Name = "pivotGridField3";
            // 
            // pivotGridField2
            // 
            this.pivotGridField2.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.pivotGridField2.AreaIndex = 0;
            this.pivotGridField2.Caption = "Category Name";
            dataSourceColumnBinding5.ColumnName = "CategoryName";
            this.pivotGridField2.DataBinding = dataSourceColumnBinding5;
            this.pivotGridField2.Name = "pivotGridField2";
            // 
            // pivotGridControl1
            // 
            this.pivotGridControl1.Appearance.GrandTotalCell.BackColor = System.Drawing.Color.Azure;
            this.pivotGridControl1.Appearance.GrandTotalCell.Options.UseBackColor = true;
            this.pivotGridControl1.Appearance.TotalCell.BackColor = System.Drawing.Color.Azure;
            this.pivotGridControl1.Appearance.TotalCell.Options.UseBackColor = true;
            this.pivotGridControl1.DataMember = "SalesPerson";
            this.pivotGridControl1.DataSource = this.sqlDataSource1;
            this.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pivotGridControl1.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.pivotGridField1,
            this.pivotGridField2,
            this.pivotGridField3,
            this.pivotGridField4,
            this.pivotGridField5});
            pivotGridFormatRule1.Measure = this.pivotGridField5;
            pivotGridFormatRule1.Name = "Products with the Highest Increase in Sales ";
            formatConditionRuleTopBottom1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            formatConditionRuleTopBottom1.Appearance.Options.UseBackColor = true;
            formatConditionRuleTopBottom1.Rank = new decimal(new int[] {
            20,
            0,
            0,
            0});
            formatConditionRuleTopBottom1.RankType = DevExpress.XtraEditors.FormatConditionValueType.Percent;
            pivotGridFormatRule1.Rule = formatConditionRuleTopBottom1;
            formatRuleFieldIntersectionSettings1.Column = this.pivotGridField4;
            formatRuleFieldIntersectionSettings1.Row = this.pivotGridField1;
            pivotGridFormatRule1.Settings = formatRuleFieldIntersectionSettings1;
            pivotGridFormatRule2.Measure = this.pivotGridField5;
            pivotGridFormatRule2.Name = "Highlight Annual Negative Sales Growth";
            formatConditionRuleValue1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            formatConditionRuleValue1.Appearance.Options.UseBackColor = true;
            formatConditionRuleValue1.Condition = DevExpress.XtraEditors.FormatCondition.Less;
            formatConditionRuleValue1.Value1 = "0";
            pivotGridFormatRule2.Rule = formatConditionRuleValue1;
            formatRuleFieldIntersectionSettings2.Column = this.pivotGridField4;
            formatRuleFieldIntersectionSettings2.Row = this.pivotGridField2;
            pivotGridFormatRule2.Settings = formatRuleFieldIntersectionSettings2;
            this.pivotGridControl1.FormatRules.Add(pivotGridFormatRule1);
            this.pivotGridControl1.FormatRules.Add(pivotGridFormatRule2);
            this.pivotGridControl1.Location = new System.Drawing.Point(0, 0);
            this.pivotGridControl1.Name = "pivotGridControl1";
            this.pivotGridControl1.OptionsData.DataProcessingEngine = DevExpress.XtraPivotGrid.PivotDataProcessingEngine.Optimized;
            this.pivotGridControl1.OptionsMenu.EnableFormatRulesMenu = true;
            this.pivotGridControl1.Size = new System.Drawing.Size(800, 290);
            this.pivotGridControl1.TabIndex = 0;
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "nwind";
            this.sqlDataSource1.Name = "sqlDataSource1";
            columnExpression1.ColumnName = "ProductName";
            table1.MetaSerializable = "<Meta X=\"30\" Y=\"30\" Width=\"125\" Height=\"303\" />";
            table1.Name = "SalesPerson";
            columnExpression1.Table = table1;
            column1.Expression = columnExpression1;
            columnExpression2.ColumnName = "CategoryName";
            columnExpression2.Table = table1;
            column2.Expression = columnExpression2;
            columnExpression3.ColumnName = "ExtendedPrice";
            columnExpression3.Table = table1;
            column3.Expression = columnExpression3;
            columnExpression4.ColumnName = "OrderDate";
            columnExpression4.Table = table1;
            column4.Expression = columnExpression4;
            selectQuery1.Columns.Add(column1);
            selectQuery1.Columns.Add(column2);
            selectQuery1.Columns.Add(column3);
            selectQuery1.Columns.Add(column4);
            selectQuery1.Name = "SalesPerson";
            selectQuery1.Tables.Add(table1);
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            selectQuery1});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 290);
            this.Controls.Add(this.pivotGridControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraPivotGrid.PivotGridControl pivotGridControl1;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField1;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField2;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField3;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField4;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField5;
    }
}

