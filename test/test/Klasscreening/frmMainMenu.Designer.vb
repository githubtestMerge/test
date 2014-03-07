<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMainMenu
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
        Me.btnLeerlingen = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnLeerlingen
        '
        Me.btnLeerlingen.Location = New System.Drawing.Point(12, 12)
        Me.btnLeerlingen.Name = "btnLeerlingen"
        Me.btnLeerlingen.Size = New System.Drawing.Size(151, 40)
        Me.btnLeerlingen.TabIndex = 0
        Me.btnLeerlingen.Text = "Leerlingen"
        Me.btnLeerlingen.UseVisualStyleBackColor = True
        '
        'frmMainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(754, 512)
        Me.Controls.Add(Me.btnLeerlingen)
        Me.Name = "frmMainMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Hoofdmenu"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnLeerlingen As System.Windows.Forms.Button
End Class
