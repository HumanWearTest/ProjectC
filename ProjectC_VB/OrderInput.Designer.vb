<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class OrderInput
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As DataGridViewCellStyle = New DataGridViewCellStyle()
        DataGridView1 = New DataGridView()
        行 = New DataGridViewTextBoxColumn()
        年月日 = New DataGridViewTextBoxColumn()
        顧客名 = New DataGridViewComboBoxColumn()
        商品名 = New DataGridViewComboBoxColumn()
        単価 = New DataGridViewTextBoxColumn()
        数量 = New DataGridViewTextBoxColumn()
        金額 = New DataGridViewTextBoxColumn()
        支店名 = New DataGridViewComboBoxColumn()
        付与ポイント = New DataGridViewTextBoxColumn()
        btn_movetoMain = New Button()
        Label1 = New Label()
        ListBox1 = New ListBox()
        btnSave = New Button()
        Label2 = New Label()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = SystemColors.Control
        DataGridViewCellStyle1.Font = New Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(128))
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {行, 年月日, 顧客名, 商品名, 単価, 数量, 金額, 支店名, 付与ポイント})
        DataGridView1.ImeMode = ImeMode.Disable
        DataGridView1.Location = New Point(17, 145)
        DataGridView1.MinimumSize = New Size(1235, 395)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersVisible = False
        DataGridView1.RowTemplate.Height = 36
        DataGridView1.Size = New Size(1235, 395)
        DataGridView1.TabIndex = 1
        ' 
        ' 行
        ' 
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.Font = New Font("メイリオ", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(128))
        行.DefaultCellStyle = DataGridViewCellStyle2
        行.Frozen = True
        行.HeaderText = "行"
        行.MaxInputLength = 2
        行.Name = "行"
        行.ReadOnly = True
        行.Width = 40
        ' 
        ' 年月日
        ' 
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.Font = New Font("メイリオ", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(128))
        DataGridViewCellStyle3.Format = "d"
        DataGridViewCellStyle3.NullValue = Nothing
        年月日.DefaultCellStyle = DataGridViewCellStyle3
        年月日.HeaderText = "年月日"
        年月日.MaxInputLength = 10
        年月日.Name = "年月日"
        年月日.Width = 135
        ' 
        ' 顧客名
        ' 
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.Font = New Font("メイリオ", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(128))
        顧客名.DefaultCellStyle = DataGridViewCellStyle4
        顧客名.DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox
        顧客名.DisplayStyleForCurrentCellOnly = True
        顧客名.HeaderText = "顧客名"
        顧客名.Name = "顧客名"
        顧客名.Width = 190
        ' 
        ' 商品名
        ' 
        DataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.Font = New Font("メイリオ", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(128))
        DataGridViewCellStyle5.WrapMode = DataGridViewTriState.False
        商品名.DefaultCellStyle = DataGridViewCellStyle5
        商品名.DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox
        商品名.DisplayStyleForCurrentCellOnly = True
        商品名.HeaderText = "商品名"
        商品名.Name = "商品名"
        商品名.Width = 250
        ' 
        ' 単価
        ' 
        DataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.Font = New Font("メイリオ", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(128))
        DataGridViewCellStyle6.Format = "C0"
        DataGridViewCellStyle6.NullValue = Nothing
        単価.DefaultCellStyle = DataGridViewCellStyle6
        単価.HeaderText = "単価"
        単価.MaxInputLength = 10
        単価.Name = "単価"
        単価.ReadOnly = True
        単価.Width = 110
        ' 
        ' 数量
        ' 
        DataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle7.Font = New Font("メイリオ", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(128))
        DataGridViewCellStyle7.Format = "#,##0"
        DataGridViewCellStyle7.NullValue = Nothing
        数量.DefaultCellStyle = DataGridViewCellStyle7
        数量.HeaderText = "数量"
        数量.MaxInputLength = 10
        数量.Name = "数量"
        数量.Width = 85
        ' 
        ' 金額
        ' 
        DataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle8.Font = New Font("メイリオ", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(128))
        DataGridViewCellStyle8.Format = "C0"
        DataGridViewCellStyle8.NullValue = Nothing
        金額.DefaultCellStyle = DataGridViewCellStyle8
        金額.HeaderText = "金額"
        金額.MaxInputLength = 10
        金額.Name = "金額"
        金額.ReadOnly = True
        金額.Width = 160
        ' 
        ' 支店名
        ' 
        DataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.Font = New Font("メイリオ", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(128))
        支店名.DefaultCellStyle = DataGridViewCellStyle9
        支店名.DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox
        支店名.DisplayStyleForCurrentCellOnly = True
        支店名.HeaderText = "支店名"
        支店名.Name = "支店名"
        支店名.Width = 150
        ' 
        ' 付与ポイント
        ' 
        DataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle10.Font = New Font("メイリオ", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(128))
        DataGridViewCellStyle10.Format = "#,##0"
        付与ポイント.DefaultCellStyle = DataGridViewCellStyle10
        付与ポイント.HeaderText = "付与ポイント"
        付与ポイント.MaxInputLength = 10
        付与ポイント.Name = "付与ポイント"
        付与ポイント.ReadOnly = True
        付与ポイント.Resizable = DataGridViewTriState.True
        付与ポイント.SortMode = DataGridViewColumnSortMode.NotSortable
        付与ポイント.Width = 110
        ' 
        ' btn_movetoMain
        ' 
        btn_movetoMain.BackColor = SystemColors.Highlight
        btn_movetoMain.Font = New Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(128))
        btn_movetoMain.ForeColor = Color.White
        btn_movetoMain.Location = New Point(12, 12)
        btn_movetoMain.Name = "btn_movetoMain"
        btn_movetoMain.Size = New Size(160, 42)
        btn_movetoMain.TabIndex = 2
        btn_movetoMain.Text = "メイン画面へ"
        btn_movetoMain.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.White
        Label1.Font = New Font("游ゴシック", 27.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        Label1.Location = New Point(497, 45)
        Label1.Name = "Label1"
        Label1.Size = New Size(242, 48)
        Label1.TabIndex = 3
        Label1.Text = "受注入力画面"
        ' 
        ' ListBox1
        ' 
        ListBox1.CausesValidation = False
        ListBox1.Enabled = False
        ListBox1.Font = New Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(128))
        ListBox1.ForeColor = Color.Black
        ListBox1.FormattingEnabled = True
        ListBox1.ImeMode = ImeMode.NoControl
        ListBox1.ItemHeight = 25
        ListBox1.Location = New Point(1002, 105)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(250, 29)
        ListBox1.TabIndex = 10
        ListBox1.TabStop = False
        ' 
        ' btnSave
        ' 
        btnSave.BackColor = Color.LightGreen
        btnSave.Font = New Font("Yu Gothic UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        btnSave.Location = New Point(585, 557)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(106, 42)
        btnSave.TabIndex = 11
        btnSave.Text = "登  録"
        btnSave.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(1000, 87)
        Label2.Name = "Label2"
        Label2.Size = New Size(51, 15)
        Label2.TabIndex = 12
        Label2.Text = "メッセージ"
        ' 
        ' OrderInput
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1264, 611)
        Controls.Add(Label2)
        Controls.Add(btnSave)
        Controls.Add(ListBox1)
        Controls.Add(Label1)
        Controls.Add(btn_movetoMain)
        Controls.Add(DataGridView1)
        MaximumSize = New Size(1280, 650)
        MinimumSize = New Size(1280, 650)
        Name = "OrderInput"
        Text = "受注入力画面"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btn_movetoMain As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents btnSave As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents 行 As DataGridViewTextBoxColumn
    Friend WithEvents 年月日 As DataGridViewTextBoxColumn
    Friend WithEvents 顧客名 As DataGridViewComboBoxColumn
    Friend WithEvents 商品名 As DataGridViewComboBoxColumn
    Friend WithEvents 単価 As DataGridViewTextBoxColumn
    Friend WithEvents 数量 As DataGridViewTextBoxColumn
    Friend WithEvents 金額 As DataGridViewTextBoxColumn
    Friend WithEvents 支店名 As DataGridViewComboBoxColumn
    Friend WithEvents 付与ポイント As DataGridViewTextBoxColumn

End Class
