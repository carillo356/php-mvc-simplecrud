<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BasicCrud
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
        Me.UsersTable = New System.Windows.Forms.DataGridView()
        Me.btn_create = New System.Windows.Forms.Button()
        Me.txtBox_FirstName = New System.Windows.Forms.TextBox()
        Me.txtBox_middleName = New System.Windows.Forms.TextBox()
        Me.txtBox_LastName = New System.Windows.Forms.TextBox()
        Me.txtBox_Email = New System.Windows.Forms.TextBox()
        Me.btn_read = New System.Windows.Forms.Button()
        Me.btn_update = New System.Windows.Forms.Button()
        Me.txtBox_update_email = New System.Windows.Forms.TextBox()
        Me.txtBox_update_lastName = New System.Windows.Forms.TextBox()
        Me.txtBox_update_middleName = New System.Windows.Forms.TextBox()
        Me.txtBox_update_firstName = New System.Windows.Forms.TextBox()
        Me.txtBox_update_id = New System.Windows.Forms.TextBox()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.txtBox_delete_id = New System.Windows.Forms.TextBox()
        CType(Me.UsersTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UsersTable
        '
        Me.UsersTable.AllowUserToOrderColumns = True
        Me.UsersTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.UsersTable.Location = New System.Drawing.Point(19, 12)
        Me.UsersTable.Name = "UsersTable"
        Me.UsersTable.Size = New System.Drawing.Size(774, 202)
        Me.UsersTable.TabIndex = 0
        '
        'btn_create
        '
        Me.btn_create.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_create.Location = New System.Drawing.Point(19, 243)
        Me.btn_create.Name = "btn_create"
        Me.btn_create.Size = New System.Drawing.Size(189, 63)
        Me.btn_create.TabIndex = 1
        Me.btn_create.Text = "Create"
        Me.btn_create.UseVisualStyleBackColor = True
        '
        'txtBox_FirstName
        '
        Me.txtBox_FirstName.Location = New System.Drawing.Point(20, 338)
        Me.txtBox_FirstName.Name = "txtBox_FirstName"
        Me.txtBox_FirstName.Size = New System.Drawing.Size(188, 20)
        Me.txtBox_FirstName.TabIndex = 2
        Me.txtBox_FirstName.Text = "FirstName"
        '
        'txtBox_middleName
        '
        Me.txtBox_middleName.Location = New System.Drawing.Point(20, 364)
        Me.txtBox_middleName.Name = "txtBox_middleName"
        Me.txtBox_middleName.Size = New System.Drawing.Size(188, 20)
        Me.txtBox_middleName.TabIndex = 3
        Me.txtBox_middleName.Text = "MiddleName"
        '
        'txtBox_LastName
        '
        Me.txtBox_LastName.Location = New System.Drawing.Point(19, 390)
        Me.txtBox_LastName.Name = "txtBox_LastName"
        Me.txtBox_LastName.Size = New System.Drawing.Size(188, 20)
        Me.txtBox_LastName.TabIndex = 4
        Me.txtBox_LastName.Text = "LastName"
        '
        'txtBox_Email
        '
        Me.txtBox_Email.Location = New System.Drawing.Point(20, 312)
        Me.txtBox_Email.Name = "txtBox_Email"
        Me.txtBox_Email.Size = New System.Drawing.Size(188, 20)
        Me.txtBox_Email.TabIndex = 5
        Me.txtBox_Email.Text = "Email"
        '
        'btn_read
        '
        Me.btn_read.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_read.Location = New System.Drawing.Point(214, 243)
        Me.btn_read.Name = "btn_read"
        Me.btn_read.Size = New System.Drawing.Size(189, 63)
        Me.btn_read.TabIndex = 6
        Me.btn_read.Text = "Read"
        Me.btn_read.UseVisualStyleBackColor = True
        '
        'btn_update
        '
        Me.btn_update.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_update.Location = New System.Drawing.Point(409, 243)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(189, 63)
        Me.btn_update.TabIndex = 7
        Me.btn_update.Text = "Update"
        Me.btn_update.UseVisualStyleBackColor = True
        '
        'txtBox_update_email
        '
        Me.txtBox_update_email.Location = New System.Drawing.Point(409, 338)
        Me.txtBox_update_email.Name = "txtBox_update_email"
        Me.txtBox_update_email.Size = New System.Drawing.Size(188, 20)
        Me.txtBox_update_email.TabIndex = 11
        Me.txtBox_update_email.Text = "Email"
        '
        'txtBox_update_lastName
        '
        Me.txtBox_update_lastName.Location = New System.Drawing.Point(410, 416)
        Me.txtBox_update_lastName.Name = "txtBox_update_lastName"
        Me.txtBox_update_lastName.Size = New System.Drawing.Size(188, 20)
        Me.txtBox_update_lastName.TabIndex = 10
        Me.txtBox_update_lastName.Text = "LastName"
        '
        'txtBox_update_middleName
        '
        Me.txtBox_update_middleName.Location = New System.Drawing.Point(410, 390)
        Me.txtBox_update_middleName.Name = "txtBox_update_middleName"
        Me.txtBox_update_middleName.Size = New System.Drawing.Size(188, 20)
        Me.txtBox_update_middleName.TabIndex = 9
        Me.txtBox_update_middleName.Text = "MiddleName"
        '
        'txtBox_update_firstName
        '
        Me.txtBox_update_firstName.Location = New System.Drawing.Point(409, 364)
        Me.txtBox_update_firstName.Name = "txtBox_update_firstName"
        Me.txtBox_update_firstName.Size = New System.Drawing.Size(188, 20)
        Me.txtBox_update_firstName.TabIndex = 8
        Me.txtBox_update_firstName.Text = "FirstName"
        '
        'txtBox_update_id
        '
        Me.txtBox_update_id.Location = New System.Drawing.Point(410, 312)
        Me.txtBox_update_id.Name = "txtBox_update_id"
        Me.txtBox_update_id.Size = New System.Drawing.Size(188, 20)
        Me.txtBox_update_id.TabIndex = 12
        Me.txtBox_update_id.Text = "ID"
        '
        'btn_delete
        '
        Me.btn_delete.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_delete.Location = New System.Drawing.Point(604, 243)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(189, 63)
        Me.btn_delete.TabIndex = 13
        Me.btn_delete.Text = "Delete"
        Me.btn_delete.UseVisualStyleBackColor = True
        '
        'txtBox_delete_id
        '
        Me.txtBox_delete_id.Location = New System.Drawing.Point(605, 312)
        Me.txtBox_delete_id.Name = "txtBox_delete_id"
        Me.txtBox_delete_id.Size = New System.Drawing.Size(188, 20)
        Me.txtBox_delete_id.TabIndex = 14
        Me.txtBox_delete_id.Text = "ID"
        '
        'BasicCrud
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(805, 498)
        Me.Controls.Add(Me.txtBox_delete_id)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.txtBox_update_id)
        Me.Controls.Add(Me.txtBox_update_email)
        Me.Controls.Add(Me.txtBox_update_lastName)
        Me.Controls.Add(Me.txtBox_update_middleName)
        Me.Controls.Add(Me.txtBox_update_firstName)
        Me.Controls.Add(Me.btn_update)
        Me.Controls.Add(Me.btn_read)
        Me.Controls.Add(Me.txtBox_Email)
        Me.Controls.Add(Me.txtBox_LastName)
        Me.Controls.Add(Me.txtBox_middleName)
        Me.Controls.Add(Me.txtBox_FirstName)
        Me.Controls.Add(Me.btn_create)
        Me.Controls.Add(Me.UsersTable)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Name = "BasicCrud"
        Me.Text = "BasicCrud"
        CType(Me.UsersTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents UsersTable As DataGridView
    Friend WithEvents btn_create As Button
    Friend WithEvents txtBox_FirstName As TextBox
    Friend WithEvents txtBox_middleName As TextBox
    Friend WithEvents txtBox_LastName As TextBox
    Friend WithEvents txtBox_Email As TextBox
    Friend WithEvents btn_read As Button
    Friend WithEvents btn_update As Button
    Friend WithEvents txtBox_update_email As TextBox
    Friend WithEvents txtBox_update_lastName As TextBox
    Friend WithEvents txtBox_update_middleName As TextBox
    Friend WithEvents txtBox_update_firstName As TextBox
    Friend WithEvents txtBox_update_id As TextBox
    Friend WithEvents btn_delete As Button
    Friend WithEvents txtBox_delete_id As TextBox
End Class
