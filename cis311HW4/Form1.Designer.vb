<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lstAllDishes = New System.Windows.Forms.ListBox()
        Me.lstItemsInSelected = New System.Windows.Forms.ListBox()
        Me.lstRawInSelected = New System.Windows.Forms.ListBox()
        Me.lstAllPrepped = New System.Windows.Forms.ListBox()
        Me.lstAllRaw = New System.Windows.Forms.ListBox()
        Me.btnAddNewDish = New System.Windows.Forms.Button()
        Me.btnAddNewPrepped = New System.Windows.Forms.Button()
        Me.btnAddNewRaw = New System.Windows.Forms.Button()
        Me.btnRmvPreppedItem = New System.Windows.Forms.Button()
        Me.btnPreppedToSelected = New System.Windows.Forms.Button()
        Me.btnRawtoPrepped = New System.Windows.Forms.Button()
        Me.btnRmvRaw = New System.Windows.Forms.Button()
        Me.txtDish = New System.Windows.Forms.TextBox()
        Me.txtPrepped = New System.Windows.Forms.TextBox()
        Me.txtRaw = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "List of all Dishes:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 151)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(172, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Prepped Items in Selected Dish:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 334)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(221, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Raw Ingreients in Selected Prepped Item:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(429, 151)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(136, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "List of all Prepped Items:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(429, 334)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(144, 15)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "List of all Raw Ingredients:"
        '
        'lstAllDishes
        '
        Me.lstAllDishes.FormattingEnabled = True
        Me.lstAllDishes.ItemHeight = 15
        Me.lstAllDishes.Location = New System.Drawing.Point(12, 27)
        Me.lstAllDishes.Name = "lstAllDishes"
        Me.lstAllDishes.Size = New System.Drawing.Size(687, 64)
        Me.lstAllDishes.TabIndex = 5
        '
        'lstItemsInSelected
        '
        Me.lstItemsInSelected.FormattingEnabled = True
        Me.lstItemsInSelected.ItemHeight = 15
        Me.lstItemsInSelected.Location = New System.Drawing.Point(12, 169)
        Me.lstItemsInSelected.Name = "lstItemsInSelected"
        Me.lstItemsInSelected.Size = New System.Drawing.Size(270, 94)
        Me.lstItemsInSelected.TabIndex = 6
        '
        'lstRawInSelected
        '
        Me.lstRawInSelected.FormattingEnabled = True
        Me.lstRawInSelected.ItemHeight = 15
        Me.lstRawInSelected.Location = New System.Drawing.Point(12, 352)
        Me.lstRawInSelected.Name = "lstRawInSelected"
        Me.lstRawInSelected.Size = New System.Drawing.Size(270, 94)
        Me.lstRawInSelected.TabIndex = 7
        '
        'lstAllPrepped
        '
        Me.lstAllPrepped.FormattingEnabled = True
        Me.lstAllPrepped.ItemHeight = 15
        Me.lstAllPrepped.Location = New System.Drawing.Point(429, 169)
        Me.lstAllPrepped.Name = "lstAllPrepped"
        Me.lstAllPrepped.Size = New System.Drawing.Size(270, 94)
        Me.lstAllPrepped.TabIndex = 8
        '
        'lstAllRaw
        '
        Me.lstAllRaw.FormattingEnabled = True
        Me.lstAllRaw.ItemHeight = 15
        Me.lstAllRaw.Location = New System.Drawing.Point(429, 352)
        Me.lstAllRaw.Name = "lstAllRaw"
        Me.lstAllRaw.Size = New System.Drawing.Size(270, 94)
        Me.lstAllRaw.TabIndex = 9
        '
        'btnAddNewDish
        '
        Me.btnAddNewDish.Location = New System.Drawing.Point(429, 97)
        Me.btnAddNewDish.Name = "btnAddNewDish"
        Me.btnAddNewDish.Size = New System.Drawing.Size(69, 40)
        Me.btnAddNewDish.TabIndex = 10
        Me.btnAddNewDish.Text = "Add New Dish"
        Me.btnAddNewDish.UseVisualStyleBackColor = True
        '
        'btnAddNewPrepped
        '
        Me.btnAddNewPrepped.Location = New System.Drawing.Point(429, 269)
        Me.btnAddNewPrepped.Name = "btnAddNewPrepped"
        Me.btnAddNewPrepped.Size = New System.Drawing.Size(69, 53)
        Me.btnAddNewPrepped.TabIndex = 11
        Me.btnAddNewPrepped.Text = "Add New Prepped Item"
        Me.btnAddNewPrepped.UseVisualStyleBackColor = True
        '
        'btnAddNewRaw
        '
        Me.btnAddNewRaw.Location = New System.Drawing.Point(429, 452)
        Me.btnAddNewRaw.Name = "btnAddNewRaw"
        Me.btnAddNewRaw.Size = New System.Drawing.Size(64, 40)
        Me.btnAddNewRaw.TabIndex = 12
        Me.btnAddNewRaw.Text = "Add New Raw Ingr"
        Me.btnAddNewRaw.UseVisualStyleBackColor = True
        '
        'btnRmvPreppedItem
        '
        Me.btnRmvPreppedItem.Location = New System.Drawing.Point(318, 223)
        Me.btnRmvPreppedItem.Name = "btnRmvPreppedItem"
        Me.btnRmvPreppedItem.Size = New System.Drawing.Size(72, 40)
        Me.btnRmvPreppedItem.TabIndex = 13
        Me.btnRmvPreppedItem.Text = "->"
        Me.btnRmvPreppedItem.UseVisualStyleBackColor = True
        '
        'btnPreppedToSelected
        '
        Me.btnPreppedToSelected.Location = New System.Drawing.Point(318, 169)
        Me.btnPreppedToSelected.Name = "btnPreppedToSelected"
        Me.btnPreppedToSelected.Size = New System.Drawing.Size(72, 40)
        Me.btnPreppedToSelected.TabIndex = 14
        Me.btnPreppedToSelected.Text = "<-"
        Me.btnPreppedToSelected.UseVisualStyleBackColor = True
        '
        'btnRawtoPrepped
        '
        Me.btnRawtoPrepped.Location = New System.Drawing.Point(318, 352)
        Me.btnRawtoPrepped.Name = "btnRawtoPrepped"
        Me.btnRawtoPrepped.Size = New System.Drawing.Size(72, 40)
        Me.btnRawtoPrepped.TabIndex = 15
        Me.btnRawtoPrepped.Text = "<-"
        Me.btnRawtoPrepped.UseVisualStyleBackColor = True
        '
        'btnRmvRaw
        '
        Me.btnRmvRaw.Location = New System.Drawing.Point(318, 406)
        Me.btnRmvRaw.Name = "btnRmvRaw"
        Me.btnRmvRaw.Size = New System.Drawing.Size(72, 40)
        Me.btnRmvRaw.TabIndex = 16
        Me.btnRmvRaw.Text = "->"
        Me.btnRmvRaw.UseVisualStyleBackColor = True
        '
        'txtDish
        '
        Me.txtDish.Location = New System.Drawing.Point(504, 107)
        Me.txtDish.Name = "txtDish"
        Me.txtDish.Size = New System.Drawing.Size(195, 23)
        Me.txtDish.TabIndex = 17
        '
        'txtPrepped
        '
        Me.txtPrepped.Location = New System.Drawing.Point(504, 285)
        Me.txtPrepped.Name = "txtPrepped"
        Me.txtPrepped.Size = New System.Drawing.Size(195, 23)
        Me.txtPrepped.TabIndex = 18
        '
        'txtRaw
        '
        Me.txtRaw.Location = New System.Drawing.Point(499, 462)
        Me.txtRaw.Name = "txtRaw"
        Me.txtRaw.Size = New System.Drawing.Size(200, 23)
        Me.txtRaw.TabIndex = 19
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(717, 520)
        Me.Controls.Add(Me.txtRaw)
        Me.Controls.Add(Me.txtPrepped)
        Me.Controls.Add(Me.txtDish)
        Me.Controls.Add(Me.btnRmvRaw)
        Me.Controls.Add(Me.btnRawtoPrepped)
        Me.Controls.Add(Me.btnPreppedToSelected)
        Me.Controls.Add(Me.btnRmvPreppedItem)
        Me.Controls.Add(Me.btnAddNewRaw)
        Me.Controls.Add(Me.btnAddNewPrepped)
        Me.Controls.Add(Me.btnAddNewDish)
        Me.Controls.Add(Me.lstAllRaw)
        Me.Controls.Add(Me.lstAllPrepped)
        Me.Controls.Add(Me.lstRawInSelected)
        Me.Controls.Add(Me.lstItemsInSelected)
        Me.Controls.Add(Me.lstAllDishes)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lstAllDishes As ListBox
    Friend WithEvents lstItemsInSelected As ListBox
    Friend WithEvents lstRawInSelected As ListBox
    Friend WithEvents lstAllPrepped As ListBox
    Friend WithEvents lstAllRaw As ListBox
    Friend WithEvents btnAddNewDish As Button
    Friend WithEvents btnAddNewPrepped As Button
    Friend WithEvents btnAddNewRaw As Button
    Friend WithEvents btnRmvPreppedItem As Button
    Friend WithEvents btnPreppedToSelected As Button
    Friend WithEvents btnRawtoPrepped As Button
    Friend WithEvents btnRmvRaw As Button
    Friend WithEvents txtDish As TextBox
    Friend WithEvents txtPrepped As TextBox
    Friend WithEvents txtRaw As TextBox
End Class
