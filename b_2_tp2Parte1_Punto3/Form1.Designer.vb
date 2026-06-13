<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        cmdEjecutar = New Button()
        lstMuestra = New ListBox()
        lblMuestra = New Label()
        SuspendLayout()
        ' 
        ' cmdEjecutar
        ' 
        cmdEjecutar.Location = New Point(12, 12)
        cmdEjecutar.Name = "cmdEjecutar"
        cmdEjecutar.Size = New Size(271, 49)
        cmdEjecutar.TabIndex = 1
        cmdEjecutar.Text = "Presionar para ejecutar el programa"
        cmdEjecutar.UseVisualStyleBackColor = True
        ' 
        ' lstMuestra
        ' 
        lstMuestra.FormattingEnabled = True
        lstMuestra.Location = New Point(12, 87)
        lstMuestra.Name = "lstMuestra"
        lstMuestra.Size = New Size(115, 384)
        lstMuestra.TabIndex = 2
        ' 
        ' lblMuestra
        ' 
        lblMuestra.AutoSize = True
        lblMuestra.Location = New Point(12, 64)
        lblMuestra.Name = "lblMuestra"
        lblMuestra.Size = New Size(62, 20)
        lblMuestra.TabIndex = 3
        lblMuestra.Text = "Muestra"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(290, 474)
        Controls.Add(lblMuestra)
        Controls.Add(lstMuestra)
        Controls.Add(cmdEjecutar)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents cmdEjecutar As Button
    Friend WithEvents lstMuestra As ListBox
    Friend WithEvents lblMuestra As Label

End Class
