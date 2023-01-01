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
        Me.TxtPdfText = New System.Windows.Forms.TextBox()
        Me.BtnBrowse = New System.Windows.Forms.Button()
        Me.label1 = New System.Windows.Forms.Label()
        Me.TxtPDFPath = New System.Windows.Forms.TextBox()
        Me.openFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.BtnStart = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TxtPdfText
        '
        Me.TxtPdfText.Location = New System.Drawing.Point(16, 88)
        Me.TxtPdfText.Multiline = True
        Me.TxtPdfText.Name = "TxtPdfText"
        Me.TxtPdfText.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TxtPdfText.Size = New System.Drawing.Size(694, 418)
        Me.TxtPdfText.TabIndex = 8
        '
        'BtnBrowse
        '
        Me.BtnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BtnBrowse.Location = New System.Drawing.Point(615, 22)
        Me.BtnBrowse.Name = "BtnBrowse"
        Me.BtnBrowse.Size = New System.Drawing.Size(95, 23)
        Me.BtnBrowse.TabIndex = 6
        Me.BtnBrowse.Text = "Browse"
        Me.BtnBrowse.UseVisualStyleBackColor = True
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(12, 23)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(82, 20)
        Me.label1.TabIndex = 5
        Me.label1.Text = "PDF Path:"
        '
        'TxtPDFPath
        '
        Me.TxtPDFPath.Location = New System.Drawing.Point(100, 20)
        Me.TxtPDFPath.Name = "TxtPDFPath"
        Me.TxtPDFPath.Size = New System.Drawing.Size(509, 26)
        Me.TxtPDFPath.TabIndex = 4
        '
        'openFileDialog1
        '
        Me.openFileDialog1.FileName = "openFileDialog1"
        '
        'BtnStart
        '
        Me.BtnStart.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BtnStart.Location = New System.Drawing.Point(317, 523)
        Me.BtnStart.Name = "BtnStart"
        Me.BtnStart.Size = New System.Drawing.Size(119, 45)
        Me.BtnStart.TabIndex = 7
        Me.BtnStart.Text = "Start"
        Me.BtnStart.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(722, 589)
        Me.Controls.Add(Me.TxtPdfText)
        Me.Controls.Add(Me.BtnBrowse)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.TxtPDFPath)
        Me.Controls.Add(Me.BtnStart)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents TxtPdfText As TextBox
    Private WithEvents BtnBrowse As Button
    Private WithEvents label1 As Label
    Private WithEvents TxtPDFPath As TextBox
    Private WithEvents openFileDialog1 As OpenFileDialog
    Private WithEvents BtnStart As Button
End Class
