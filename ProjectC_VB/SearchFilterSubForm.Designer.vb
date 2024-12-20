<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SearchFilterSubForm
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
        chb1 = New CheckBox()
        txtStartDate = New TextBox()
        btnCheckAll = New Button()
        Label1 = New Label()
        chb3 = New CheckBox()
        txtCustomerName = New TextBox()
        chb4 = New CheckBox()
        txtPhoneNum = New TextBox()
        chb5 = New CheckBox()
        chb6 = New CheckBox()
        chb7 = New CheckBox()
        chb8 = New CheckBox()
        txtUpperLimit = New TextBox()
        chb9 = New CheckBox()
        txtLowerLimit = New TextBox()
        chb2 = New CheckBox()
        txtEndDate = New TextBox()
        chb10 = New CheckBox()
        TextBox10 = New TextBox()
        btnSearch = New Button()
        btnUnCheckAll = New Button()
        gbxCheckBox = New GroupBox()
        gbxFilterText = New GroupBox()
        comBranch = New ComboBox()
        comItem = New ComboBox()
        comCategory = New ComboBox()
        btnTextReset = New Button()
        gbxCheckBox.SuspendLayout()
        gbxFilterText.SuspendLayout()
        SuspendLayout()
        ' 
        ' chb1
        ' 
        chb1.AutoSize = True
        chb1.CheckAlign = ContentAlignment.MiddleRight
        chb1.Font = New Font("Yu Gothic UI", 14.25F)
        chb1.Location = New Point(105, 14)
        chb1.Name = "chb1"
        chb1.Size = New Size(108, 29)
        chb1.TabIndex = 0
        chb1.Text = "年月【自】"
        chb1.UseVisualStyleBackColor = True
        ' 
        ' txtStartDate
        ' 
        txtStartDate.Font = New Font("Yu Gothic UI", 14.25F)
        txtStartDate.ImeMode = ImeMode.Disable
        txtStartDate.Location = New Point(6, 13)
        txtStartDate.MaxLength = 7
        txtStartDate.Name = "txtStartDate"
        txtStartDate.PlaceholderText = "1900/01 ~ 2200/12 の範囲で入力"
        txtStartDate.Size = New Size(290, 33)
        txtStartDate.TabIndex = 1
        ' 
        ' btnCheckAll
        ' 
        btnCheckAll.Font = New Font("Yu Gothic UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(128))
        btnCheckAll.Location = New Point(12, 488)
        btnCheckAll.Name = "btnCheckAll"
        btnCheckAll.Size = New Size(86, 23)
        btnCheckAll.TabIndex = 12
        btnCheckAll.Text = "全て選択"
        btnCheckAll.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.YellowGreen
        Label1.BorderStyle = BorderStyle.FixedSingle
        Label1.Font = New Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(128))
        Label1.Location = New Point(215, 4)
        Label1.Name = "Label1"
        Label1.Size = New Size(112, 34)
        Label1.TabIndex = 3
        Label1.Text = "詳細検索"
        ' 
        ' chb3
        ' 
        chb3.AutoSize = True
        chb3.CheckAlign = ContentAlignment.MiddleRight
        chb3.Font = New Font("Yu Gothic UI", 14.25F)
        chb3.Location = New Point(5, 100)
        chb3.Name = "chb3"
        chb3.Size = New Size(208, 29)
        chb3.TabIndex = 0
        chb3.Text = "顧客名【あいまい検索】"
        chb3.UseVisualStyleBackColor = True
        ' 
        ' txtCustomerName
        ' 
        txtCustomerName.Font = New Font("Yu Gothic UI", 14.25F)
        txtCustomerName.Location = New Point(6, 99)
        txtCustomerName.MaxLength = 5
        txtCustomerName.Name = "txtCustomerName"
        txtCustomerName.PlaceholderText = "顧客名の一部 5文字以内"
        txtCustomerName.Size = New Size(290, 33)
        txtCustomerName.TabIndex = 3
        ' 
        ' chb4
        ' 
        chb4.AutoSize = True
        chb4.CheckAlign = ContentAlignment.MiddleRight
        chb4.Font = New Font("Yu Gothic UI", 14.25F)
        chb4.Location = New Point(10, 143)
        chb4.Name = "chb4"
        chb4.Size = New Size(203, 29)
        chb4.TabIndex = 0
        chb4.Text = "電話番号【完全一致】"
        chb4.UseVisualStyleBackColor = True
        ' 
        ' txtPhoneNum
        ' 
        txtPhoneNum.Font = New Font("Yu Gothic UI", 14.25F)
        txtPhoneNum.ImeMode = ImeMode.Disable
        txtPhoneNum.Location = New Point(6, 142)
        txtPhoneNum.MaxLength = 13
        txtPhoneNum.Name = "txtPhoneNum"
        txtPhoneNum.PlaceholderText = "ハイフン無し13桁以内"
        txtPhoneNum.Size = New Size(290, 33)
        txtPhoneNum.TabIndex = 4
        ' 
        ' chb5
        ' 
        chb5.AutoSize = True
        chb5.CheckAlign = ContentAlignment.MiddleRight
        chb5.Font = New Font("Yu Gothic UI", 14.25F)
        chb5.Location = New Point(29, 186)
        chb5.Name = "chb5"
        chb5.Size = New Size(184, 29)
        chb5.TabIndex = 0
        chb5.Text = "大分類名称【選択】"
        chb5.UseVisualStyleBackColor = True
        ' 
        ' chb6
        ' 
        chb6.AutoSize = True
        chb6.CheckAlign = ContentAlignment.MiddleRight
        chb6.Font = New Font("Yu Gothic UI", 14.25F)
        chb6.Location = New Point(67, 229)
        chb6.Name = "chb6"
        chb6.Size = New Size(146, 29)
        chb6.TabIndex = 0
        chb6.Text = "支店名【選択】"
        chb6.UseVisualStyleBackColor = True
        ' 
        ' chb7
        ' 
        chb7.AutoSize = True
        chb7.CheckAlign = ContentAlignment.MiddleRight
        chb7.Font = New Font("Yu Gothic UI", 14.25F)
        chb7.Location = New Point(48, 272)
        chb7.Name = "chb7"
        chb7.Size = New Size(165, 29)
        chb7.TabIndex = 0
        chb7.Text = "商品番号【選択】"
        chb7.UseVisualStyleBackColor = True
        ' 
        ' chb8
        ' 
        chb8.AutoSize = True
        chb8.CheckAlign = ContentAlignment.MiddleRight
        chb8.Font = New Font("Yu Gothic UI", 14.25F)
        chb8.Location = New Point(68, 315)
        chb8.Name = "chb8"
        chb8.Size = New Size(145, 29)
        chb8.TabIndex = 0
        chb8.Text = "ポイント【上限】"
        chb8.UseVisualStyleBackColor = True
        ' 
        ' txtUpperLimit
        ' 
        txtUpperLimit.Font = New Font("Yu Gothic UI", 14.25F)
        txtUpperLimit.Location = New Point(6, 314)
        txtUpperLimit.MaxLength = 9
        txtUpperLimit.Name = "txtUpperLimit"
        txtUpperLimit.Size = New Size(290, 33)
        txtUpperLimit.TabIndex = 8
        ' 
        ' chb9
        ' 
        chb9.AutoSize = True
        chb9.CheckAlign = ContentAlignment.MiddleRight
        chb9.Font = New Font("Yu Gothic UI", 14.25F)
        chb9.Location = New Point(68, 358)
        chb9.Name = "chb9"
        chb9.Size = New Size(145, 29)
        chb9.TabIndex = 0
        chb9.Text = "ポイント【下限】"
        chb9.UseVisualStyleBackColor = True
        ' 
        ' txtLowerLimit
        ' 
        txtLowerLimit.Font = New Font("Yu Gothic UI", 14.25F)
        txtLowerLimit.Location = New Point(6, 357)
        txtLowerLimit.MaxLength = 9
        txtLowerLimit.Name = "txtLowerLimit"
        txtLowerLimit.Size = New Size(290, 33)
        txtLowerLimit.TabIndex = 9
        ' 
        ' chb2
        ' 
        chb2.AutoSize = True
        chb2.CheckAlign = ContentAlignment.MiddleRight
        chb2.Font = New Font("Yu Gothic UI", 14.25F)
        chb2.Location = New Point(105, 57)
        chb2.Name = "chb2"
        chb2.Size = New Size(108, 29)
        chb2.TabIndex = 0
        chb2.Text = "年月【至】"
        chb2.UseVisualStyleBackColor = True
        ' 
        ' txtEndDate
        ' 
        txtEndDate.Font = New Font("Yu Gothic UI", 14.25F)
        txtEndDate.ImeMode = ImeMode.Disable
        txtEndDate.Location = New Point(6, 56)
        txtEndDate.MaxLength = 7
        txtEndDate.Name = "txtEndDate"
        txtEndDate.PlaceholderText = "1900/01 ~ 2200/12 の範囲で入力"
        txtEndDate.Size = New Size(290, 33)
        txtEndDate.TabIndex = 2
        ' 
        ' chb10
        ' 
        chb10.AutoSize = True
        chb10.CheckAlign = ContentAlignment.MiddleRight
        chb10.Font = New Font("Yu Gothic UI", 14.25F)
        chb10.Location = New Point(144, 401)
        chb10.Name = "chb10"
        chb10.Size = New Size(69, 29)
        chb10.TabIndex = 0
        chb10.Text = "未定"
        chb10.UseVisualStyleBackColor = True
        ' 
        ' TextBox10
        ' 
        TextBox10.Font = New Font("Yu Gothic UI", 14.25F)
        TextBox10.Location = New Point(6, 400)
        TextBox10.MaxLength = 15
        TextBox10.Name = "TextBox10"
        TextBox10.Size = New Size(290, 33)
        TextBox10.TabIndex = 10
        ' 
        ' btnSearch
        ' 
        btnSearch.Font = New Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(128))
        btnSearch.Location = New Point(199, 505)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(104, 33)
        btnSearch.TabIndex = 11
        btnSearch.Text = "検  索"
        btnSearch.UseVisualStyleBackColor = True
        ' 
        ' btnUnCheckAll
        ' 
        btnUnCheckAll.Font = New Font("Yu Gothic UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(128))
        btnUnCheckAll.Location = New Point(12, 515)
        btnUnCheckAll.Name = "btnUnCheckAll"
        btnUnCheckAll.Size = New Size(86, 23)
        btnUnCheckAll.TabIndex = 13
        btnUnCheckAll.Text = "選択解除"
        btnUnCheckAll.UseVisualStyleBackColor = True
        ' 
        ' gbxCheckBox
        ' 
        gbxCheckBox.Controls.Add(chb2)
        gbxCheckBox.Controls.Add(chb4)
        gbxCheckBox.Controls.Add(chb9)
        gbxCheckBox.Controls.Add(chb1)
        gbxCheckBox.Controls.Add(chb3)
        gbxCheckBox.Controls.Add(chb5)
        gbxCheckBox.Controls.Add(chb10)
        gbxCheckBox.Controls.Add(chb6)
        gbxCheckBox.Controls.Add(chb8)
        gbxCheckBox.Controls.Add(chb7)
        gbxCheckBox.Location = New Point(6, 41)
        gbxCheckBox.Name = "gbxCheckBox"
        gbxCheckBox.Size = New Size(219, 441)
        gbxCheckBox.TabIndex = 4
        gbxCheckBox.TabStop = False
        ' 
        ' gbxFilterText
        ' 
        gbxFilterText.Controls.Add(comBranch)
        gbxFilterText.Controls.Add(TextBox10)
        gbxFilterText.Controls.Add(comItem)
        gbxFilterText.Controls.Add(txtStartDate)
        gbxFilterText.Controls.Add(comCategory)
        gbxFilterText.Controls.Add(txtEndDate)
        gbxFilterText.Controls.Add(txtCustomerName)
        gbxFilterText.Controls.Add(txtPhoneNum)
        gbxFilterText.Controls.Add(txtLowerLimit)
        gbxFilterText.Controls.Add(txtUpperLimit)
        gbxFilterText.Location = New Point(229, 39)
        gbxFilterText.Name = "gbxFilterText"
        gbxFilterText.Size = New Size(308, 443)
        gbxFilterText.TabIndex = 5
        gbxFilterText.TabStop = False
        ' 
        ' comBranch
        ' 
        comBranch.Font = New Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(128))
        comBranch.FormattingEnabled = True
        comBranch.Location = New Point(6, 228)
        comBranch.Name = "comBranch"
        comBranch.Size = New Size(290, 33)
        comBranch.TabIndex = 14
        ' 
        ' comItem
        ' 
        comItem.Font = New Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(128))
        comItem.FormattingEnabled = True
        comItem.Location = New Point(6, 271)
        comItem.Name = "comItem"
        comItem.Size = New Size(290, 33)
        comItem.TabIndex = 14
        ' 
        ' comCategory
        ' 
        comCategory.Font = New Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(128))
        comCategory.FormattingEnabled = True
        comCategory.Location = New Point(6, 185)
        comCategory.Name = "comCategory"
        comCategory.Size = New Size(290, 33)
        comCategory.TabIndex = 14
        ' 
        ' btnTextReset
        ' 
        btnTextReset.Font = New Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(128))
        btnTextReset.Location = New Point(331, 505)
        btnTextReset.Name = "btnTextReset"
        btnTextReset.Size = New Size(104, 33)
        btnTextReset.TabIndex = 11
        btnTextReset.Text = "リセット"
        btnTextReset.UseVisualStyleBackColor = True
        ' 
        ' SearchFilterSubForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(554, 551)
        Controls.Add(gbxFilterText)
        Controls.Add(gbxCheckBox)
        Controls.Add(Label1)
        Controls.Add(btnTextReset)
        Controls.Add(btnSearch)
        Controls.Add(btnUnCheckAll)
        Controls.Add(btnCheckAll)
        MaximumSize = New Size(570, 590)
        MinimumSize = New Size(570, 590)
        Name = "SearchFilterSubForm"
        Text = "詳細検索"
        gbxCheckBox.ResumeLayout(False)
        gbxCheckBox.PerformLayout()
        gbxFilterText.ResumeLayout(False)
        gbxFilterText.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents chb1 As CheckBox
    Friend WithEvents txtStartDate As TextBox
    Friend WithEvents btnCheckAll As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents chb3 As CheckBox
    Friend WithEvents txtCustomerName As TextBox
    Friend WithEvents chb4 As CheckBox
    Friend WithEvents txtPhoneNum As TextBox
    Friend WithEvents chb5 As CheckBox
    Friend WithEvents chb6 As CheckBox
    Friend WithEvents chb7 As CheckBox
    Friend WithEvents chb8 As CheckBox
    Friend WithEvents txtUpperLimit As TextBox
    Friend WithEvents chb9 As CheckBox
    Friend WithEvents txtLowerLimit As TextBox
    Friend WithEvents chb2 As CheckBox
    Friend WithEvents txtEndDate As TextBox
    Friend WithEvents chb10 As CheckBox
    Friend WithEvents TextBox10 As TextBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnUnCheckAll As Button
    Friend WithEvents gbxCheckBox As GroupBox
    Friend WithEvents gbxFilterText As GroupBox
    Friend WithEvents btnTextReset As Button
    Friend WithEvents comCustomer As ComboBox
    Friend WithEvents comItem As ComboBox
    Friend WithEvents comBranch As ComboBox
    Friend WithEvents comCategory As ComboBox
End Class
