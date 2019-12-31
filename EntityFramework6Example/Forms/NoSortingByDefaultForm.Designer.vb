Namespace Forms
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class NoSortingByDefaultForm
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
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.CurrentRowButton = New System.Windows.Forms.Button()
            Me.Button1 = New System.Windows.Forms.Button()
            Me.gridView = New System.Windows.Forms.DataGridView()
            Me.CompanyNameColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.FirstNameColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.LastNameColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.ContactTitleColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.AddressColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.CityColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.PostalCodeColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.CountyNameColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Panel1.SuspendLayout()
            CType(Me.gridView, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'Panel1
            '
            Me.Panel1.Controls.Add(Me.Label1)
            Me.Panel1.Controls.Add(Me.CurrentRowButton)
            Me.Panel1.Controls.Add(Me.Button1)
            Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Panel1.Location = New System.Drawing.Point(0, 383)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(889, 67)
            Me.Panel1.TabIndex = 0
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(117, 24)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(85, 13)
            Me.Label1.TabIndex = 7
            Me.Label1.Text = "Supports Sorting"
            '
            'CurrentRowButton
            '
            Me.CurrentRowButton.Location = New System.Drawing.Point(12, 19)
            Me.CurrentRowButton.Name = "CurrentRowButton"
            Me.CurrentRowButton.Size = New System.Drawing.Size(99, 23)
            Me.CurrentRowButton.TabIndex = 6
            Me.CurrentRowButton.Text = "Current row"
            Me.CurrentRowButton.UseVisualStyleBackColor = True
            '
            'Button1
            '
            Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Button1.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.Button1.Location = New System.Drawing.Point(802, 19)
            Me.Button1.Name = "Button1"
            Me.Button1.Size = New System.Drawing.Size(75, 23)
            Me.Button1.TabIndex = 0
            Me.Button1.Text = "Close"
            Me.Button1.UseVisualStyleBackColor = True
            '
            'gridView
            '
            Me.gridView.AllowUserToAddRows = False
            Me.gridView.AllowUserToDeleteRows = False
            Me.gridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.gridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CompanyNameColumn, Me.FirstNameColumn, Me.LastNameColumn, Me.ContactTitleColumn, Me.AddressColumn, Me.CityColumn, Me.PostalCodeColumn, Me.CountyNameColumn})
            Me.gridView.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gridView.Location = New System.Drawing.Point(0, 0)
            Me.gridView.Name = "gridView"
            Me.gridView.Size = New System.Drawing.Size(889, 383)
            Me.gridView.TabIndex = 1
            '
            'CompanyNameColumn
            '
            Me.CompanyNameColumn.DataPropertyName = "CompanyName"
            Me.CompanyNameColumn.HeaderText = "Company"
            Me.CompanyNameColumn.Name = "CompanyNameColumn"
            '
            'FirstNameColumn
            '
            Me.FirstNameColumn.DataPropertyName = "FirstName"
            Me.FirstNameColumn.HeaderText = "First name"
            Me.FirstNameColumn.Name = "FirstNameColumn"
            '
            'LastNameColumn
            '
            Me.LastNameColumn.DataPropertyName = "LastName"
            Me.LastNameColumn.HeaderText = "Last name"
            Me.LastNameColumn.Name = "LastNameColumn"
            '
            'ContactTitleColumn
            '
            Me.ContactTitleColumn.DataPropertyName = "ContactTitle"
            Me.ContactTitleColumn.HeaderText = "Title"
            Me.ContactTitleColumn.Name = "ContactTitleColumn"
            '
            'AddressColumn
            '
            Me.AddressColumn.DataPropertyName = "Address"
            Me.AddressColumn.HeaderText = "Street"
            Me.AddressColumn.Name = "AddressColumn"
            '
            'CityColumn
            '
            Me.CityColumn.DataPropertyName = "City"
            Me.CityColumn.HeaderText = "City"
            Me.CityColumn.Name = "CityColumn"
            '
            'PostalCodeColumn
            '
            Me.PostalCodeColumn.DataPropertyName = "PostalCode"
            Me.PostalCodeColumn.HeaderText = "Postal"
            Me.PostalCodeColumn.Name = "PostalCodeColumn"
            '
            'CountyNameColumn
            '
            Me.CountyNameColumn.DataPropertyName = "CountyName"
            Me.CountyNameColumn.HeaderText = "County"
            Me.CountyNameColumn.Name = "CountyNameColumn"
            '
            'NoSortingByDefaultForm
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(889, 450)
            Me.Controls.Add(Me.gridView)
            Me.Controls.Add(Me.Panel1)
            Me.Name = "NoSortingByDefaultForm"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "DataGridView from list - no sorting available"
            Me.Panel1.ResumeLayout(False)
            Me.Panel1.PerformLayout()
            CType(Me.gridView, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents Panel1 As Panel
        Friend WithEvents gridView As DataGridView
        Friend WithEvents CompanyNameColumn As DataGridViewTextBoxColumn
        Friend WithEvents FirstNameColumn As DataGridViewTextBoxColumn
        Friend WithEvents LastNameColumn As DataGridViewTextBoxColumn
        Friend WithEvents ContactTitleColumn As DataGridViewTextBoxColumn
        Friend WithEvents AddressColumn As DataGridViewTextBoxColumn
        Friend WithEvents CityColumn As DataGridViewTextBoxColumn
        Friend WithEvents PostalCodeColumn As DataGridViewTextBoxColumn
        Friend WithEvents CountyNameColumn As DataGridViewTextBoxColumn
        Friend WithEvents Button1 As Button
        Friend WithEvents CurrentRowButton As Button
        Friend WithEvents Label1 As Label
    End Class
End Namespace