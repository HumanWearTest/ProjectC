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
        DataGridView1 = New DataGridView()
        btn_movetoMain = New Button()
        Label1 = New Label()
        Button2 = New Button()
        Button3 = New Button()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        Button1 = New Button()
        DataGridView2 = New DataGridView()
        Button5 = New Button()
        Button6 = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(12, 145)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(1147, 217)
        DataGridView1.TabIndex = 1
        ' 
        ' btn_movetoMain
        ' 
        btn_movetoMain.Location = New Point(12, 12)
        btn_movetoMain.Name = "btn_movetoMain"
        btn_movetoMain.Size = New Size(160, 42)
        btn_movetoMain.TabIndex = 2
        btn_movetoMain.Text = "メイン画面へ"
        btn_movetoMain.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.White
        Label1.Font = New Font("游ゴシック", 27.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        Label1.Location = New Point(256, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(242, 48)
        Label1.TabIndex = 3
        Label1.Text = "受注入力画面"
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(546, 34)
        Button2.Name = "Button2"
        Button2.Size = New Size(75, 23)
        Button2.TabIndex = 4
        Button2.Text = "test用データ表示"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(652, 34)
        Button3.Name = "Button3"
        Button3.Size = New Size(100, 23)
        Button3.TabIndex = 5
        Button3.Text = "列名追加テスト"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(546, 9)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(100, 23)
        TextBox1.TabIndex = 6
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(652, 9)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(100, 23)
        TextBox2.TabIndex = 6
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(652, 63)
        Button1.Name = "Button1"
        Button1.Size = New Size(100, 23)
        Button1.TabIndex = 8
        Button1.Text = "コンボ列追加"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' DataGridView2
        ' 
        DataGridView2.AllowUserToAddRows = False
        DataGridView2.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView2.Location = New Point(12, 380)
        DataGridView2.Name = "DataGridView2"
        DataGridView2.Size = New Size(1147, 218)
        DataGridView2.TabIndex = 1
        ' 
        ' Button5
        ' 
        Button5.Location = New Point(652, 116)
        Button5.Name = "Button5"
        Button5.Size = New Size(100, 23)
        Button5.TabIndex = 8
        Button5.Text = "未追加"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Button6
        ' 
        Button6.Location = New Point(633, 90)
        Button6.Name = "Button6"
        Button6.Size = New Size(136, 23)
        Button6.TabIndex = 8
        Button6.Text = "dttestからデータ移す"
        Button6.UseVisualStyleBackColor = True
        ' 
        ' OrderInput
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1171, 619)
        Controls.Add(Button5)
        Controls.Add(Button6)
        Controls.Add(Button1)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Label1)
        Controls.Add(btn_movetoMain)
        Controls.Add(DataGridView2)
        Controls.Add(DataGridView1)
        Name = "OrderInput"
        Text = "受注入力画面"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btn_movetoMain As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button

End Class
