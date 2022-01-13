'***********************************************************************************************
'* File Name	: ProcessExp.Designer.vb
'* Description	: This class is main user interface elements, which provide all user interaction
'* 
'* Author		: Ashutosh Fouzdar, Software Engineer Ness Technologies India Ltd.
'* Date			: 08-June-2007
'* ***********************************************************************************************/
 


<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProcessExp
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
    	Me.components = New System.ComponentModel.Container
    	Dim dataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    	Dim dataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    	Dim dataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    	Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ProcessExp))
    	Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
    	Me.label2 = New System.Windows.Forms.Label
    	Me.txtMachineName = New System.Windows.Forms.TextBox
    	Me.txtProcessName = New System.Windows.Forms.TextBox
    	Me.Cancel_Button = New System.Windows.Forms.Button
    	Me.OK_Button = New System.Windows.Forms.Button
    	Me.label1 = New System.Windows.Forms.Label
    	Me.GroupBox1 = New System.Windows.Forms.GroupBox
    	Me.DataGridView1 = New System.Windows.Forms.DataGridView
    	Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel
    	Me.lstMonitor = New System.Windows.Forms.ListBox
    	Me.Systray = New System.Windows.Forms.NotifyIcon(Me.components)
    	Me.tmrTick = New System.Windows.Forms.Timer(Me.components)
    	Me.TableLayoutPanel1.SuspendLayout
    	Me.GroupBox1.SuspendLayout
    	CType(Me.DataGridView1,System.ComponentModel.ISupportInitialize).BeginInit
    	Me.TableLayoutPanel2.SuspendLayout
    	Me.SuspendLayout
    	'
    	'TableLayoutPanel1
    	'
    	Me.TableLayoutPanel1.ColumnCount = 3
    	Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150!))
    	Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
    	Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80!))
    	Me.TableLayoutPanel1.Controls.Add(Me.label2, 0, 1)
    	Me.TableLayoutPanel1.Controls.Add(Me.txtMachineName, 1, 1)
    	Me.TableLayoutPanel1.Controls.Add(Me.txtProcessName, 1, 0)
    	Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 2, 1)
    	Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 2, 0)
    	Me.TableLayoutPanel1.Controls.Add(Me.label1, 0, 0)
    	Me.TableLayoutPanel1.Location = New System.Drawing.Point(12, 344)
    	Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
    	Me.TableLayoutPanel1.RowCount = 2
    	Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50!))
    	Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50!))
    	Me.TableLayoutPanel1.Size = New System.Drawing.Size(454, 55)
    	Me.TableLayoutPanel1.TabIndex = 0
    	'
    	'label2
    	'
    	Me.label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
    	Me.label2.Location = New System.Drawing.Point(3, 29)
    	Me.label2.Name = "label2"
    	Me.label2.Size = New System.Drawing.Size(144, 23)
    	Me.label2.TabIndex = 5
    	Me.label2.Text = "Machine name :"
    	'
    	'txtMachineName
    	'
    	Me.txtMachineName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    	Me.txtMachineName.Location = New System.Drawing.Point(153, 30)
    	Me.txtMachineName.Name = "txtMachineName"
    	Me.txtMachineName.Size = New System.Drawing.Size(100, 20)
    	Me.txtMachineName.TabIndex = 3
    	'
    	'txtProcessName
    	'
    	Me.txtProcessName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    	Me.txtProcessName.Location = New System.Drawing.Point(153, 3)
    	Me.txtProcessName.Name = "txtProcessName"
    	Me.txtProcessName.Size = New System.Drawing.Size(194, 20)
    	Me.txtProcessName.TabIndex = 2
    	'
    	'Cancel_Button
    	'
    	Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
    	Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
    	Me.Cancel_Button.Location = New System.Drawing.Point(380, 30)
    	Me.Cancel_Button.Name = "Cancel_Button"
    	Me.Cancel_Button.Size = New System.Drawing.Size(67, 22)
    	Me.Cancel_Button.TabIndex = 1
    	Me.Cancel_Button.Text = "Close"
    	'
    	'OK_Button
    	'
    	Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
    	Me.OK_Button.Location = New System.Drawing.Point(380, 3)
    	Me.OK_Button.Name = "OK_Button"
    	Me.OK_Button.Size = New System.Drawing.Size(67, 21)
    	Me.OK_Button.TabIndex = 0
    	Me.OK_Button.Text = "Monitor"
    	'
    	'label1
    	'
    	Me.label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
    	Me.label1.Location = New System.Drawing.Point(3, 2)
    	Me.label1.Name = "label1"
    	Me.label1.Size = New System.Drawing.Size(144, 23)
    	Me.label1.TabIndex = 4
    	Me.label1.Text = "Process Executable :"
    	'
    	'GroupBox1
    	'
    	Me.GroupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
    	Me.GroupBox1.Controls.Add(Me.DataGridView1)
    	Me.GroupBox1.Location = New System.Drawing.Point(12, 2)
    	Me.GroupBox1.Name = "GroupBox1"
    	Me.GroupBox1.Size = New System.Drawing.Size(454, 336)
    	Me.GroupBox1.TabIndex = 1
    	Me.GroupBox1.TabStop = false
    	'
    	'DataGridView1
    	'
    	Me.DataGridView1.AllowUserToAddRows = false
    	Me.DataGridView1.AllowUserToDeleteRows = false
    	dataGridViewCellStyle1.BackColor = System.Drawing.Color.White
    	dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Navy
    	Me.DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1
    	Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
    	Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
    	Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken
    	dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    	dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
    	dataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
    	dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Navy
    	dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
    	dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
    	dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    	Me.DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2
    	Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    	dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    	dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(192,Byte),Integer))
    	dataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
    	dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
    	dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
    	dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
    	dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
    	Me.DataGridView1.DefaultCellStyle = dataGridViewCellStyle3
    	Me.DataGridView1.Location = New System.Drawing.Point(3, 16)
    	Me.DataGridView1.MultiSelect = false
    	Me.DataGridView1.Name = "DataGridView1"
    	Me.DataGridView1.ReadOnly = true
    	Me.DataGridView1.RowHeadersVisible = false
    	Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
    	Me.DataGridView1.Size = New System.Drawing.Size(449, 314)
    	Me.DataGridView1.TabIndex = 0
    	'
    	'TableLayoutPanel2
    	'
    	Me.TableLayoutPanel2.ColumnCount = 1
    	Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 531!))
    	Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20!))
    	Me.TableLayoutPanel2.Controls.Add(Me.lstMonitor, 0, 0)
    	Me.TableLayoutPanel2.Location = New System.Drawing.Point(12, 405)
    	Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
    	Me.TableLayoutPanel2.RowCount = 1
    	Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100!))
    	Me.TableLayoutPanel2.Size = New System.Drawing.Size(454, 103)
    	Me.TableLayoutPanel2.TabIndex = 2
    	'
    	'lstMonitor
    	'
    	Me.lstMonitor.FormattingEnabled = true
    	Me.lstMonitor.Location = New System.Drawing.Point(3, 3)
    	Me.lstMonitor.Name = "lstMonitor"
    	Me.lstMonitor.Size = New System.Drawing.Size(449, 95)
    	Me.lstMonitor.TabIndex = 0
    	'
    	'Systray
    	'
    	Me.Systray.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info
    	Me.Systray.Icon = CType(resources.GetObject("Systray.Icon"),System.Drawing.Icon)
    	Me.Systray.Text = "Process Monitor"
    	Me.Systray.Visible = true
    	'
    	'tmrTick
    	'
    	Me.tmrTick.Enabled = true
    	Me.tmrTick.Interval = 60000
    	AddHandler Me.tmrTick.Tick, AddressOf Me.TmrTickTick
    	'
    	'ProcessExp
    	'
    	Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
    	Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    	Me.ClientSize = New System.Drawing.Size(479, 512)
    	Me.Controls.Add(Me.TableLayoutPanel2)
    	Me.Controls.Add(Me.GroupBox1)
    	Me.Controls.Add(Me.TableLayoutPanel1)
    	Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
    	Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
    	Me.MaximizeBox = false
    	Me.Name = "ProcessExp"
    	Me.ShowInTaskbar = false
    	Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
    	Me.Text = "Process Monitor"
    	Me.TableLayoutPanel1.ResumeLayout(false)
    	Me.TableLayoutPanel1.PerformLayout
    	Me.GroupBox1.ResumeLayout(false)
    	CType(Me.DataGridView1,System.ComponentModel.ISupportInitialize).EndInit
    	Me.TableLayoutPanel2.ResumeLayout(false)
    	Me.ResumeLayout(false)
    End Sub
    Private tmrTick As System.Windows.Forms.Timer
    Private label1 As System.Windows.Forms.Label
    Private label2 As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents txtProcessName As System.Windows.Forms.TextBox
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lstMonitor As System.Windows.Forms.ListBox
    Friend WithEvents txtMachineName As System.Windows.Forms.TextBox
    Friend WithEvents Systray As System.Windows.Forms.NotifyIcon

End Class
