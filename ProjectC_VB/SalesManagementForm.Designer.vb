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
        DataGridView1 = New DataGridView()
        DataGridView2 = New DataGridView()
        btn_movetoMain = New Button()
        Label1 = New Label()
        Label2 = New Label()
        ListBox1 = New ListBox()
        Button1 = New Button()
        btnPrevious = New Button()
        btnNext = New Button()
        txtCurrentPageNum = New TextBox()
        txtMaxPage = New TextBox()
        Label3 = New Label()
        Button4 = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(12, 103)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(1087, 320)
        DataGridView1.TabIndex = 0
        ' 
        ' DataGridView2
        ' 
        DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView2.Location = New Point(12, 471)
        DataGridView2.Name = "DataGridView2"
        DataGridView2.Size = New Size(1087, 129)
        DataGridView2.TabIndex = 0
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
        Label1.AutoSize = True
        Label1.BackColor = Color.White
        Label1.Font = New Font("游ゴシック", 27.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        Label1.Location = New Point(433, 12)
        Label1.Name = "Label1"
        Label1.Size = New Size(242, 48)
        Label1.TabIndex = 4
        Label1.Text = "売上参照画面"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(722, 50)
        Label2.Name = "Label2"
        Label2.Size = New Size(51, 15)
        Label2.TabIndex = 14
        Label2.Text = "メッセージ"
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
        ListBox1.Location = New Point(724, 68)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(250, 29)
        ListBox1.TabIndex = 13
        ListBox1.TabStop = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.Highlight
        Button1.Font = New Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(128))
        Button1.ForeColor = Color.White
        Button1.Location = New Point(980, 68)
        Button1.Name = "Button1"
        Button1.Size = New Size(119, 29)
        Button1.TabIndex = 3
        Button1.Text = "詳細検索"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' btnPrevious
        ' 
        btnPrevious.Location = New Point(397, 429)
        btnPrevious.Name = "btnPrevious"
        btnPrevious.Size = New Size(67, 31)
        btnPrevious.TabIndex = 15
        btnPrevious.Text = "前ページへ"
        btnPrevious.UseVisualStyleBackColor = True
        ' 
        ' btnNext
        ' 
        btnNext.Location = New Point(639, 429)
        btnNext.Name = "btnNext"
        btnNext.Size = New Size(67, 31)
        btnNext.TabIndex = 15
        btnNext.Text = "次ページへ"
        btnNext.UseVisualStyleBackColor = True
        ' 
        ' txtCurrentPageNum
        ' 
        txtCurrentPageNum.Location = New Point(470, 429)
        txtCurrentPageNum.Multiline = True
        txtCurrentPageNum.Name = "txtCurrentPageNum"
        txtCurrentPageNum.Size = New Size(65, 31)
        txtCurrentPageNum.TabIndex = 16
        ' 
        ' txtMaxPage
        ' 
        txtMaxPage.Location = New Point(568, 429)
        txtMaxPage.Multiline = True
        txtMaxPage.Name = "txtMaxPage"
        txtMaxPage.Size = New Size(65, 31)
        txtMaxPage.TabIndex = 16
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Yu Gothic UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(128))
        Label3.Location = New Point(541, 429)
        Label3.Name = "Label3"
        Label3.Size = New Size(21, 30)
        Label3.TabIndex = 17
        Label3.Text = "/"
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(817, 21)
        Button4.Name = "Button4"
        Button4.Size = New Size(104, 29)
        Button4.TabIndex = 18
        Button4.Text = "test:全件表示"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' SalesManagementForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1111, 625)
        Controls.Add(Button4)
        Controls.Add(Label3)
        Controls.Add(txtMaxPage)
        Controls.Add(txtCurrentPageNum)
        Controls.Add(btnNext)
        Controls.Add(btnPrevious)
        Controls.Add(Label2)
        Controls.Add(ListBox1)
        Controls.Add(Label1)
        Controls.Add(Button1)
        Controls.Add(btn_movetoMain)
        Controls.Add(DataGridView2)
        Controls.Add(DataGridView1)
        Name = "SalesManagementForm"
        Text = "SalesManagementForm"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents btn_movetoMain As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Button1 As Button
    Friend WithEvents btnPrevious As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents txtCurrentPageNum As TextBox
    Friend WithEvents txtMaxPage As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Button4 As Button
End Class
