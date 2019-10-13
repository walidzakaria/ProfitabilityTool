﻿Imports System.ComponentModel.DataAnnotations
Imports System.IO
Imports DevExpress.XtraLayout.Helpers
Imports DevExpress.XtraLayout
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.DXErrorProvider

Partial Public Class frmAddMargin

    Public Shared marginId As Integer = 0
    Public Sub New()
        InitializeComponent()

    End Sub

    Private Sub FillDestinations()
        Dim query As String = "SELECT * FROM Destination ORDER BY Destination;"
        Dim dt As New DataTable()
        dt = ExClass.QueryGet(query)
        luDestination.Properties.DataSource = Nothing
        luDestination.Properties.DataSource = dt
        luDestination.Properties.DisplayMember = "Destination"
        luDestination.Properties.ValueMember = "DestinationID"

    End Sub

    Private Sub FillTourOperators()
        Dim query As String = "SELECT * FROM TourOperator;"
        Dim dt As New DataTable()
        dt = ExClass.QueryGet(query)
        luTourOperator.Properties.DataSource = Nothing
        luTourOperator.Properties.DataSource = dt
        luTourOperator.Properties.DisplayMember = "TourOperator"
        luTourOperator.Properties.ValueMember = "TourOperatorID"

    End Sub

    Private Sub frmAddMargin_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.Control And e.KeyCode = Keys.S Then
            SaveMargin()
        ElseIf e.KeyCode = Keys.Escape Then
            CloseMargin()
        End If
    End Sub
    Private Sub frmAddDestination_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillDestinations()
        FillTourOperators()
        If marginId = 0 Then
            luDestination.EditValue = Nothing
            luTourOperator.EditValue = Nothing
            txtMarginFrom.EditValue = Nothing
            txtMarginTo.EditValue = Nothing
            txtDifferenceFrom.EditValue = Nothing
            txtDifferenceTo.EditValue = Nothing
            deEffectiveDate.EditValue = Today

            labelControl.Text = "Add Margin"
        Else
            labelControl.Text = "Edit Margin"
            RecallMargin(marginId)
        End If
    End Sub

    Private Sub RecallMargin(ByVal marginId As Integer)
        Dim margin As New Margin()
        margin.MarginId = marginId
        If margin.GetById() Then
            luDestination.EditValue = margin.DestinationId
            luTourOperator.EditValue = margin.TourOperatorId
            txtMarginFrom.EditValue = margin.MarginFrom.ToString
            txtMarginTo.EditValue = margin.MarginTo.ToString
            txtDifferenceFrom.EditValue = margin.DifferenceFrom.ToString
            txtDifferenceTo.EditValue = margin.DifferenceTo.ToString
            deEffectiveDate.EditValue = margin.EffectiveDate

        End If
    End Sub

    Private Sub windowsUIButtonPanelMain_ButtonClick(sender As Object, e As DevExpress.XtraBars.Docking2010.ButtonEventArgs) Handles windowsUIButtonPanelMain.ButtonClick
        If e.Button.Properties.Caption = "Save" Then
            SaveMargin()
        ElseIf e.Button.Properties.Caption = "Cancel" Then
            CloseMargin()
        End If

    End Sub

    Private Sub frmAddMargin_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        luDestination.Focus()
        luDestination.SelectAll()
    End Sub

    Private Sub CloseMargin()
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub
    Private Sub SaveMargin()
        If DxValidationProvider1.Validate() Then
            Dim margin As New Margin()
            margin.MarginId = marginId
            margin.DestinationId = luDestination.EditValue
            margin.TourOperatorId = luTourOperator.EditValue
            margin.MarginFrom = Val(txtMarginFrom.EditValue)
            margin.MarginTo = Val(txtMarginTo.EditValue)
            margin.DifferenceFrom = Val(txtDifferenceFrom.EditValue)
            margin.DifferenceTo = Val(txtDifferenceTo.EditValue)
            deEffectiveDate.RefreshEditValue()
            margin.EffectiveDate = deEffectiveDate.EditValue

            If margin.SaveMargin() Then
                Me.DialogResult = Windows.Forms.DialogResult.OK
                Me.Close()
            End If
        End If
    End Sub
End Class