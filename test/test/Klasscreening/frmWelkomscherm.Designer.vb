<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWelkomscherm
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
        Me.lblIkBenEen = New System.Windows.Forms.Label()
        Me.btnJufMeester = New System.Windows.Forms.Button()
        Me.btnLeerling = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblIkBenEen
        '
        Me.lblIkBenEen.AutoSize = True
        Me.lblIkBenEen.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIkBenEen.Location = New System.Drawing.Point(122, 23)
        Me.lblIkBenEen.Name = "lblIkBenEen"
        Me.lblIkBenEen.Size = New System.Drawing.Size(110, 26)
        Me.lblIkBenEen.TabIndex = 0
        Me.lblIkBenEen.Text = "Ik ben een:"
        '
        'btnJufMeester
        '
        Me.btnJufMeester.Location = New System.Drawing.Point(34, 73)
        Me.btnJufMeester.Name = "btnJufMeester"
        Me.btnJufMeester.Size = New System.Drawing.Size(145, 44)
        Me.btnJufMeester.TabIndex = 1
        Me.btnJufMeester.Text = "JUF / MEESTER"
        Me.btnJufMeester.UseVisualStyleBackColor = True
        '
        'btnLeerling
        '
        Me.btnLeerling.Location = New System.Drawing.Point(185, 73)
        Me.btnLeerling.Name = "btnLeerling"
        Me.btnLeerling.Size = New System.Drawing.Size(145, 44)
        Me.btnLeerling.TabIndex = 2
        Me.btnLeerling.Text = "LEERLING"
        Me.btnLeerling.UseVisualStyleBackColor = True
        '
        'frmWelkomscherm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(372, 154)
        Me.Controls.Add(Me.btnLeerling)
        Me.Controls.Add(Me.btnJufMeester)
        Me.Controls.Add(Me.lblIkBenEen)
        Me.Name = "frmWelkomscherm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Welkom op de Klasscreeningstool!"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblIkBenEen As System.Windows.Forms.Label
    Friend WithEvents btnJufMeester As System.Windows.Forms.Button
    Friend WithEvents btnLeerling As System.Windows.Forms.Button

End Class
