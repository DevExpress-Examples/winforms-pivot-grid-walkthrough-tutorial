Namespace WinPivot_GettingStarted
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Dim differenceBinding1 As New DevExpress.XtraPivotGrid.DifferenceBinding()
			Dim dataSourceColumnBinding1 As New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
			Dim dataSourceColumnBinding2 As New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
			Dim dataSourceColumnBinding3 As New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
			Dim dataSourceColumnBinding4 As New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
			Dim dataSourceColumnBinding5 As New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
			Dim pivotGridFormatRule1 As New DevExpress.XtraPivotGrid.PivotGridFormatRule()
			Dim formatConditionRuleTopBottom1 As New DevExpress.XtraEditors.FormatConditionRuleTopBottom()
			Dim formatRuleFieldIntersectionSettings1 As New DevExpress.XtraPivotGrid.FormatRuleFieldIntersectionSettings()
			Dim pivotGridFormatRule2 As New DevExpress.XtraPivotGrid.PivotGridFormatRule()
			Dim formatConditionRuleValue1 As New DevExpress.XtraEditors.FormatConditionRuleValue()
			Dim formatRuleFieldIntersectionSettings2 As New DevExpress.XtraPivotGrid.FormatRuleFieldIntersectionSettings()
			Dim selectQuery1 As New DevExpress.DataAccess.Sql.SelectQuery()
			Dim column1 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression1 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim table1 As New DevExpress.DataAccess.Sql.Table()
			Dim column2 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression2 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim column3 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression3 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim column4 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression4 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
			Me.pivotGridField5 = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.pivotGridField4 = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.pivotGridField1 = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.pivotGridField3 = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.pivotGridField2 = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.pivotGridControl1 = New DevExpress.XtraPivotGrid.PivotGridControl()
			Me.sqlDataSource1 = New DevExpress.DataAccess.Sql.SqlDataSource(Me.components)
			CType(Me.pivotGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' pivotGridField5
			' 
			Me.pivotGridField5.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
			Me.pivotGridField5.AreaIndex = 1
			Me.pivotGridField5.Caption = "Difference Variation by Year"
			Me.pivotGridField5.CellFormat.FormatString = "p"
			Me.pivotGridField5.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
			differenceBinding1.DifferenceType = DevExpress.XtraPivotGrid.DifferenceType.Percentage
			dataSourceColumnBinding1.ColumnName = "ExtendedPrice"
			differenceBinding1.Source = dataSourceColumnBinding1
			Me.pivotGridField5.DataBinding = differenceBinding1
			Me.pivotGridField5.Name = "pivotGridField5"
			Me.pivotGridField5.Options.AllowHide = DevExpress.Utils.DefaultBoolean.True
			' 
			' pivotGridField4
			' 
			Me.pivotGridField4.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
			Me.pivotGridField4.AreaIndex = 0
			Me.pivotGridField4.Caption = "Order Date"
			dataSourceColumnBinding2.ColumnName = "OrderDate"
			dataSourceColumnBinding2.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateYear
			Me.pivotGridField4.DataBinding = dataSourceColumnBinding2
			Me.pivotGridField4.Name = "pivotGridField4"
			' 
			' pivotGridField1
			' 
			Me.pivotGridField1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
			Me.pivotGridField1.AreaIndex = 1
			Me.pivotGridField1.Caption = "Product Name"
			dataSourceColumnBinding3.ColumnName = "ProductName"
			Me.pivotGridField1.DataBinding = dataSourceColumnBinding3
			Me.pivotGridField1.Name = "pivotGridField1"
			Me.pivotGridField1.SortBySummaryInfo.Field = Me.pivotGridField3
			' 
			' pivotGridField3
			' 
			Me.pivotGridField3.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
			Me.pivotGridField3.AreaIndex = 0
			Me.pivotGridField3.Caption = "Extended Price"
			dataSourceColumnBinding4.ColumnName = "ExtendedPrice"
			Me.pivotGridField3.DataBinding = dataSourceColumnBinding4
			Me.pivotGridField3.Name = "pivotGridField3"
			' 
			' pivotGridField2
			' 
			Me.pivotGridField2.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
			Me.pivotGridField2.AreaIndex = 0
			Me.pivotGridField2.Caption = "Category Name"
			dataSourceColumnBinding5.ColumnName = "CategoryName"
			Me.pivotGridField2.DataBinding = dataSourceColumnBinding5
			Me.pivotGridField2.Name = "pivotGridField2"
			' 
			' pivotGridControl1
			' 
			Me.pivotGridControl1.Appearance.GrandTotalCell.BackColor = System.Drawing.Color.Azure
			Me.pivotGridControl1.Appearance.GrandTotalCell.Options.UseBackColor = True
			Me.pivotGridControl1.Appearance.TotalCell.BackColor = System.Drawing.Color.Azure
			Me.pivotGridControl1.Appearance.TotalCell.Options.UseBackColor = True
			Me.pivotGridControl1.DataMember = "SalesPerson"
			Me.pivotGridControl1.DataSource = Me.sqlDataSource1
			Me.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.pivotGridControl1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() { Me.pivotGridField1, Me.pivotGridField2, Me.pivotGridField3, Me.pivotGridField4, Me.pivotGridField5})
			pivotGridFormatRule1.Measure = Me.pivotGridField5
			pivotGridFormatRule1.Name = "Products with the Highest Increase in Sales "
			formatConditionRuleTopBottom1.Appearance.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(0)))), (CInt((CByte(192)))), (CInt((CByte(192)))))
			formatConditionRuleTopBottom1.Appearance.Options.UseBackColor = True
			formatConditionRuleTopBottom1.Rank = New Decimal(New Integer() { 20, 0, 0, 0})
			formatConditionRuleTopBottom1.RankType = DevExpress.XtraEditors.FormatConditionValueType.Percent
			pivotGridFormatRule1.Rule = formatConditionRuleTopBottom1
			formatRuleFieldIntersectionSettings1.Column = Me.pivotGridField4
			formatRuleFieldIntersectionSettings1.Row = Me.pivotGridField1
			pivotGridFormatRule1.Settings = formatRuleFieldIntersectionSettings1
			pivotGridFormatRule2.Measure = Me.pivotGridField5
			pivotGridFormatRule2.Name = "Highlight Annual Negative Sales Growth"
			formatConditionRuleValue1.Appearance.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(255)))), (CInt((CByte(128)))), (CInt((CByte(128)))))
			formatConditionRuleValue1.Appearance.Options.UseBackColor = True
			formatConditionRuleValue1.Condition = DevExpress.XtraEditors.FormatCondition.Less
			formatConditionRuleValue1.Value1 = "0"
			pivotGridFormatRule2.Rule = formatConditionRuleValue1
			formatRuleFieldIntersectionSettings2.Column = Me.pivotGridField4
			formatRuleFieldIntersectionSettings2.Row = Me.pivotGridField2
			pivotGridFormatRule2.Settings = formatRuleFieldIntersectionSettings2
			Me.pivotGridControl1.FormatRules.Add(pivotGridFormatRule1)
			Me.pivotGridControl1.FormatRules.Add(pivotGridFormatRule2)
			Me.pivotGridControl1.Location = New System.Drawing.Point(0, 0)
			Me.pivotGridControl1.Name = "pivotGridControl1"
			Me.pivotGridControl1.OptionsData.DataProcessingEngine = DevExpress.XtraPivotGrid.PivotDataProcessingEngine.Optimized
			Me.pivotGridControl1.OptionsMenu.EnableFormatRulesMenu = True
			Me.pivotGridControl1.Size = New System.Drawing.Size(800, 290)
			Me.pivotGridControl1.TabIndex = 0
			' 
			' sqlDataSource1
			' 
			Me.sqlDataSource1.ConnectionName = "nwind"
			Me.sqlDataSource1.Name = "sqlDataSource1"
			columnExpression1.ColumnName = "ProductName"
			table1.MetaSerializable = "<Meta X=""30"" Y=""30"" Width=""125"" Height=""303"" />"
			table1.Name = "SalesPerson"
			columnExpression1.Table = table1
			column1.Expression = columnExpression1
			columnExpression2.ColumnName = "CategoryName"
			columnExpression2.Table = table1
			column2.Expression = columnExpression2
			columnExpression3.ColumnName = "ExtendedPrice"
			columnExpression3.Table = table1
			column3.Expression = columnExpression3
			columnExpression4.ColumnName = "OrderDate"
			columnExpression4.Table = table1
			column4.Expression = columnExpression4
			selectQuery1.Columns.Add(column1)
			selectQuery1.Columns.Add(column2)
			selectQuery1.Columns.Add(column3)
			selectQuery1.Columns.Add(column4)
			selectQuery1.Name = "SalesPerson"
			selectQuery1.Tables.Add(table1)
			Me.sqlDataSource1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() { selectQuery1})
			Me.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable")
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(800, 290)
			Me.Controls.Add(Me.pivotGridControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
			CType(Me.pivotGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private pivotGridControl1 As DevExpress.XtraPivotGrid.PivotGridControl
		Private sqlDataSource1 As DevExpress.DataAccess.Sql.SqlDataSource
		Private pivotGridField1 As DevExpress.XtraPivotGrid.PivotGridField
		Private pivotGridField2 As DevExpress.XtraPivotGrid.PivotGridField
		Private pivotGridField3 As DevExpress.XtraPivotGrid.PivotGridField
		Private pivotGridField4 As DevExpress.XtraPivotGrid.PivotGridField
		Private pivotGridField5 As DevExpress.XtraPivotGrid.PivotGridField
	End Class
End Namespace

