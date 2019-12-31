<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.LoadNormalWithoutSortingButton = New System.Windows.Forms.Button()
        Me.LoadDataConvertToDataTableButton = New System.Windows.Forms.Button()
        Me.LoadDataSortWithBindingListButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LoadNormalWithoutSortingButton
        '
        Me.LoadNormalWithoutSortingButton.Location = New System.Drawing.Point(15, 20)
        Me.LoadNormalWithoutSortingButton.Name = "LoadNormalWithoutSortingButton"
        Me.LoadNormalWithoutSortingButton.Size = New System.Drawing.Size(206, 23)
        Me.LoadNormalWithoutSortingButton.TabIndex = 0
        Me.LoadNormalWithoutSortingButton.Text = "Load data without sorting capabilities"
        Me.LoadNormalWithoutSortingButton.UseVisualStyleBackColor = True
        '
        'LoadDataConvertToDataTableButton
        '
        Me.LoadDataConvertToDataTableButton.Location = New System.Drawing.Point(15, 49)
        Me.LoadDataConvertToDataTableButton.Name = "LoadDataConvertToDataTableButton"
        Me.LoadDataConvertToDataTableButton.Size = New System.Drawing.Size(206, 23)
        Me.LoadDataConvertToDataTableButton.TabIndex = 1
        Me.LoadDataConvertToDataTableButton.Text = "Load data sort from DataTable"
        Me.LoadDataConvertToDataTableButton.UseVisualStyleBackColor = True
        '
        'LoadDataSortWithBindingListButton
        '
        Me.LoadDataSortWithBindingListButton.Location = New System.Drawing.Point(15, 78)
        Me.LoadDataSortWithBindingListButton.Name = "LoadDataSortWithBindingListButton"
        Me.LoadDataSortWithBindingListButton.Size = New System.Drawing.Size(206, 23)
        Me.LoadDataSortWithBindingListButton.TabIndex = 2
        Me.LoadDataSortWithBindingListButton.Text = "Load data sort with BindingList"
        Me.LoadDataSortWithBindingListButton.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(250, 128)
        Me.Controls.Add(Me.LoadDataSortWithBindingListButton)
        Me.Controls.Add(Me.LoadDataConvertToDataTableButton)
        Me.Controls.Add(Me.LoadNormalWithoutSortingButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LoadNormalWithoutSortingButton As Button
    Friend WithEvents LoadDataConvertToDataTableButton As Button
    Friend WithEvents LoadDataSortWithBindingListButton As Button
End Class
