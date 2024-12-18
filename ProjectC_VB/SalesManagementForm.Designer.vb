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
        Button2 = New Button()
        Button3 = New Button()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        Label3 = New Label()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
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
        ' Button2
        ' 
        Button2.Location = New Point(397, 429)
        Button2.Name = "Button2"
        Button2.Size = New Size(67, 31)
        Button2.TabIndex = 15
        Button2.Text = "前ページへ"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(639, 429)
        Button3.Name = "Button3"
        Button3.Size = New Size(67, 31)
        Button3.TabIndex = 15
        Button3.Text = "次ページへ"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(470, 429)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(65, 31)
        TextBox1.TabIndex = 16
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(568, 429)
        TextBox2.Multiline = True
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(65, 31)
        TextBox2.TabIndex = 16
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
        ' SalesManagementForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1111, 625)
        Controls.Add(Label3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Button3)
        Controls.Add(Button2)
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
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label3 As Label
End Class
