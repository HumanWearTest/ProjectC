<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SalesManagementForm
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        DataGridView1 = New DataGridView()
        btn_movetoMain = New Button()
        Label1 = New Label()
        Button1 = New Button()
        btnPrevious = New Button()
        btnNext = New Button()
        txtCurrentPageNum = New TextBox()
        txtMaxPage = New TextBox()
        Label3 = New Label()
        Button3 = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        DataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = SystemColors.Control
        DataGridViewCellStyle1.Font = New Font("Yu Gothic UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        DataGridView1.ColumnHeadersHeight = 35
        DataGridView1.Location = New Point(12, 103)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.RowHeadersVisible = False
        DataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle2.Font = New Font("MS UI Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle2
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView1.Size = New Size(1016, 370)
        DataGridView1.TabIndex = 0
        ' 
        ' btn_movetoMain
        ' 
        btn_movetoMain.BackColor = SystemColors.Highlight
        btn_movetoMain.Font = New Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(128))
        btn_movetoMain.ForeColor = Color.White
        btn_movetoMain.Location = New Point(12, 12)
        btn_movetoMain.Name = "btn_movetoMain"
        btn_movetoMain.Size = New Size(160, 42)
        btn_movetoMain.TabIndex = 3
        btn_movetoMain.Text = "メイン画面へ"
        btn_movetoMain.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top
        Label1.AutoSize = True
        Label1.BackColor = Color.White
        Label1.Font = New Font("游ゴシック", 27.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        Label1.Location = New Point(400, 25)
        Label1.Name = "Label1"
        Label1.Size = New Size(242, 48)
        Label1.TabIndex = 4
        Label1.Text = "売上参照画面"
        ' 
        ' Button1
        ' 
        Button1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Button1.BackColor = SystemColors.Highlight
        Button1.Font = New Font("Yu Gothic UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        Button1.ForeColor = Color.White
        Button1.Location = New Point(906, 58)
        Button1.Name = "Button1"
        Button1.Size = New Size(122, 39)
        Button1.TabIndex = 3
        Button1.Text = "詳細検索"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' btnPrevious
        ' 
        btnPrevious.Anchor = AnchorStyles.Bottom
        btnPrevious.Location = New Point(360, 483)
        btnPrevious.Name = "btnPrevious"
        btnPrevious.Size = New Size(67, 31)
        btnPrevious.TabIndex = 15
        btnPrevious.Text = "前ページへ"
        btnPrevious.UseVisualStyleBackColor = True
        ' 
        ' btnNext
        ' 
        btnNext.Anchor = AnchorStyles.Bottom
        btnNext.Location = New Point(606, 483)
        btnNext.Name = "btnNext"
        btnNext.Size = New Size(67, 31)
        btnNext.TabIndex = 15
        btnNext.Text = "次ページへ"
        btnNext.UseVisualStyleBackColor = True
        ' 
        ' txtCurrentPageNum
        ' 
        txtCurrentPageNum.Anchor = AnchorStyles.Bottom
        txtCurrentPageNum.Font = New Font("Yu Gothic UI", 15.75F)
        txtCurrentPageNum.Location = New Point(452, 479)
        txtCurrentPageNum.Name = "txtCurrentPageNum"
        txtCurrentPageNum.Size = New Size(49, 35)
        txtCurrentPageNum.TabIndex = 16
        txtCurrentPageNum.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtMaxPage
        ' 
        txtMaxPage.Anchor = AnchorStyles.Bottom
        txtMaxPage.Font = New Font("Yu Gothic UI", 15.75F)
        txtMaxPage.Location = New Point(533, 479)
        txtMaxPage.Name = "txtMaxPage"
        txtMaxPage.Size = New Size(47, 35)
        txtMaxPage.TabIndex = 16
        txtMaxPage.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Bottom
        Label3.AutoSize = True
        Label3.Font = New Font("Yu Gothic UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(128))
        Label3.Location = New Point(505, 475)
        Label3.Name = "Label3"
        Label3.Size = New Size(28, 37)
        Label3.TabIndex = 17
        Label3.Text = "/"
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(225, 58)
        Button3.Name = "Button3"
        Button3.Size = New Size(109, 35)
        Button3.TabIndex = 18
        Button3.Text = "test: 表示調整"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' SalesManagementForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1034, 521)
        Controls.Add(Button3)
        Controls.Add(Label3)
        Controls.Add(txtMaxPage)
        Controls.Add(txtCurrentPageNum)
        Controls.Add(btnNext)
        Controls.Add(btnPrevious)
        Controls.Add(Label1)
        Controls.Add(Button1)
        Controls.Add(btn_movetoMain)
        Controls.Add(DataGridView1)
        MaximumSize = New Size(2000, 560)
        MinimumSize = New Size(1050, 350)
        Name = "SalesManagementForm"
        Text = "SalesManagementForm"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btn_movetoMain As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents btnPrevious As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents txtCurrentPageNum As TextBox
    Friend WithEvents txtMaxPage As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents Button3 As Button
End Class
