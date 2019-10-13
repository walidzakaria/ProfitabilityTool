﻿Imports System.ComponentModel.DataAnnotations
Imports System.IO
Imports DevExpress.XtraLayout.Helpers
Imports DevExpress.XtraLayout
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.DXErrorProvider

Partial Public Class frmAddTourOperator

    Public Shared tourOperatorID As Integer = 0
    Public Sub New()
        InitializeComponent()

    End Sub

    Private Sub frmAddDestination_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.Control And e.KeyCode = Keys.S Then
            SaveTourOperator()
        ElseIf e.KeyCode = Keys.Escape Then
            CloseTourOperator()
        End If
    End Sub
    Private Sub frmAddTourOperator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If tourOperatorID = 0 Then
            txtTourOperator.EditValue = Nothing
            labelControl.Text = "Add Tour Operator"
        Else
            labelControl.Text = "Edit Tour Operator"
            RecallTourOperator(tourOperatorID)
        End If
    End Sub

    Private Sub RecallTourOperator(ByVal tourOperatorID As Integer)
        Dim tourOperator As New TourOperator()
        tourOperator.TourOperatorID = tourOperatorID

        If tourOperator.GetById() Then
            txtTourOperator.EditValue = tourOperator.TourOperator
        End If
    End Sub

    Private Sub windowsUIButtonPanelMain_ButtonClick(sender As Object, e As DevExpress.XtraBars.Docking2010.ButtonEventArgs) Handles windowsUIButtonPanelMain.ButtonClick
        If e.Button.Properties.Caption = "Save" Then
            SaveTourOperator()
        ElseIf e.Button.Properties.Caption = "Cancel" Then
            CloseTourOperator()
        End If

    End Sub

    Private Sub frmAddDestination_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        txtTourOperator.Focus()
        txtTourOperator.SelectAll()
    End Sub

    Private Sub CloseTourOperator()
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub
    Private Sub SaveTourOperator()
        If DxValidationProvider1.Validate() Then
            Dim tourOperator As New TourOperator()
            tourOperator.TourOperator = txtTourOperator.Text
            tourOperator.TourOperatorID = tourOperatorID
            If tourOperator.UniqueCode() Then
                If tourOperator.SaveTourOperator() Then
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                    Me.Close()
                End If
            Else
                MsgBox("Please enter a unique code")
            End If
        End If
    End Sub
End Class