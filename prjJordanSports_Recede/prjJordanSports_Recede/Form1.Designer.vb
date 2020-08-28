<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.lblAnnual = New System.Windows.Forms.Label()
        Me.txtAnnual = New System.Windows.Forms.TextBox()
        Me.lblWeekly = New System.Windows.Forms.Label()
        Me.txtWeekly = New System.Windows.Forms.TextBox()
        Me.lblBiweekly = New System.Windows.Forms.Label()
        Me.txtBiweekly = New System.Windows.Forms.TextBox()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.SuspendLayout()
        '
        'lblAnnual
        '
        Me.lblAnnual.AutoSize = True
        Me.lblAnnual.Location = New System.Drawing.Point(33, 32)
        Me.lblAnnual.Name = "lblAnnual"
        Me.lblAnnual.Size = New System.Drawing.Size(73, 13)
        Me.lblAnnual.TabIndex = 0
        Me.lblAnnual.Text = "&Annual salary:"
        '
        'txtAnnual
        '
        Me.txtAnnual.Location = New System.Drawing.Point(35, 49)
        Me.txtAnnual.Name = "txtAnnual"
        Me.txtAnnual.Size = New System.Drawing.Size(84, 20)
        Me.txtAnnual.TabIndex = 1
        '
        'lblWeekly
        '
        Me.lblWeekly.AutoSize = True
        Me.lblWeekly.Location = New System.Drawing.Point(146, 32)
        Me.lblWeekly.Name = "lblWeekly"
        Me.lblWeekly.Size = New System.Drawing.Size(66, 13)
        Me.lblWeekly.TabIndex = 2
        Me.lblWeekly.Text = "Weekly pay:"
        '
        'txtWeekly
        '
        Me.txtWeekly.Enabled = False
        Me.txtWeekly.Location = New System.Drawing.Point(148, 49)
        Me.txtWeekly.Name = "txtWeekly"
        Me.txtWeekly.Size = New System.Drawing.Size(89, 20)
        Me.txtWeekly.TabIndex = 3
        '
        'lblBiweekly
        '
        Me.lblBiweekly.AutoSize = True
        Me.lblBiweekly.Location = New System.Drawing.Point(266, 32)
        Me.lblBiweekly.Name = "lblBiweekly"
        Me.lblBiweekly.Size = New System.Drawing.Size(72, 13)
        Me.lblBiweekly.TabIndex = 4
        Me.lblBiweekly.Text = "Biweekly pay:"
        '
        'txtBiweekly
        '
        Me.txtBiweekly.Enabled = False
        Me.txtBiweekly.Location = New System.Drawing.Point(268, 49)
        Me.txtBiweekly.Name = "txtBiweekly"
        Me.txtBiweekly.Size = New System.Drawing.Size(85, 20)
        Me.txtBiweekly.TabIndex = 5
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(35, 111)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(75, 23)
        Me.btnCalc.TabIndex = 6
        Me.btnCalc.Text = "&Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(116, 111)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(75, 23)
        Me.btnPrint.TabIndex = 7
        Me.btnPrint.Text = "&Print"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(197, 111)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 8
        Me.btnClear.Text = "C&lear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(278, 111)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 9
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(392, 165)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.txtBiweekly)
        Me.Controls.Add(Me.lblBiweekly)
        Me.Controls.Add(Me.txtWeekly)
        Me.Controls.Add(Me.lblWeekly)
        Me.Controls.Add(Me.txtAnnual)
        Me.Controls.Add(Me.lblAnnual)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "                      Jordan Sports Store"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblAnnual As Label
    Friend WithEvents txtAnnual As TextBox
    Friend WithEvents lblWeekly As Label
    Friend WithEvents txtWeekly As TextBox
    Friend WithEvents lblBiweekly As Label
    Friend WithEvents txtBiweekly As TextBox
    Friend WithEvents btnCalc As Button
    Friend WithEvents btnPrint As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents PrintForm1 As PowerPacks.Printing.PrintForm
End Class
