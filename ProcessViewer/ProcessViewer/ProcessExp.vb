'***********************************************************************************************
'* File Name	: ProcessExp.vb
'* Description	: This class is main user interface elements, which provide all user interaction
'* 
'* Author		: Ashutosh Fouzdar, Software Engineer Ness Technologies India Ltd.
'* Date			: 08-June-2007
'* ***********************************************************************************************/
 
Imports Win32Process
Imports System.Diagnostics
Imports System.Windows.Forms
Imports System.ComponentModel

Public Class ProcessExp
    Private pr(10) As ProcessInfo
    Private Shared prctr As Byte = 0
    Private tbl As New DataTable()
    
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        If Me.txtProcessName.Text <> "" Then
            If prctr > 9 Or prctr < 0 Then
                MessageBox.Show("Only 10 applications can be monitored", "Limit Exceed", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            pr(prctr) = New ProcessInfo(Me.txtProcessName.Text, Me.txtMachineName.Text)
            AddHandler pr(prctr).Started, New ProcessInfo.StartedEventHandler(AddressOf Process_Started)
            AddHandler pr(prctr).Terminated, New ProcessInfo.TerminatedEventHandler(AddressOf Process_Stopped)
            Me.lstMonitor.Items.Add(Me.txtProcessName.Text)
            prctr += 1
        End If
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub
    
    Private Sub ProcessExp_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim ctr As Byte = 0
        For ctr = 0 To 9
            If Not (pr(ctr) Is Nothing) Then
                pr(ctr).Dispose()
            End If
        Next
        Application.Exit()
    End Sub
    
    Private Sub ProcessExp_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            tbl = ProcessInfo.LoadProcess()
            Me.DataGridView1.DataSource = tbl
            Me.DataGridView1.Columns(0).Width = 100
            Me.DataGridView1.Columns(1).Width = 200
            Me.DataGridView1.Columns(2).Width = 200
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Process Loading:", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

    End Sub
    Private Sub Process_Started(ByVal sender As System.Object, ByVal e As System.EventArgs)
    	Dim tmpProcess as ProcessInfo=CType(sender,ProcessInfo)
        Me.Systray.BalloonTipIcon=ToolTipIcon.Info
        Me.Systray.BalloonTipText="Process " + tmpProcess.AppName + " Started"
        Me.Systray.BalloonTipTitle="Alert"
        Me.Systray.ShowBalloonTip(5000)
    End Sub
    
    Private Sub Process_Stopped(ByVal sender As System.Object, ByVal e As System.EventArgs)
    	Dim tmpProcess as ProcessInfo=CType(sender,ProcessInfo)
        Me.Systray.BalloonTipIcon=ToolTipIcon.Info
        Me.Systray.BalloonTipText="Process " + tmpProcess.AppName + " Stopped"
        Me.Systray.BalloonTipTitle="Alert"
        Me.Systray.ShowBalloonTip(5000)
    End Sub
  
	Private Sub DataGridView1_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataGridView1.SelectionChanged
        If Me.DataGridView1.SelectedRows.Count > 0  Then
        	Me.txtProcessName.Text = Me.DataGridView1.SelectedRows(0).Cells(1).Value.ToString() + ".exe"
        End If
    End Sub
    
    Sub TmrTickTick(ByVal sender As Object, ByVal e As EventArgs)
    	 Try
            tbl = ProcessInfo.LoadProcess()
            Me.DataGridView1.DataSource = tbl
'            Me.DataGridView1.Columns(0).Width = 100
'            Me.DataGridView1.Columns(1).Width = 200
'            Me.DataGridView1.Columns(2).Width = 200
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Process Loading:", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub
End Class
