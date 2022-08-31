Imports System.ComponentModel
Imports System.ComponentModel.DataAnnotations
Imports DevExpress.XtraBars
Imports DevExpress.XtraEditors

Partial Public Class FrmImportComment

    Public Sub New()
        InitializeComponent()

    End Sub

    Private Sub WindowsUIButtonPanelMain_ButtonClick(sender As Object, e As DevExpress.XtraBars.Docking2010.ButtonEventArgs) Handles windowsUIButtonPanel.ButtonClick
        Select Case e.Button.Properties.Caption
            Case "Cancel"
                Me.Close()
            Case "Import"
                Dim dt As DataTable = ParseText()
                gridControl.DataSource = dt
                gridView.BestFitColumns()
            Case "Save"
                SaveComments()

        End Select
    End Sub

    Private Function ParseText() As DataTable
        Dim result As New DataTable()
        Dim sourceText As String = ""
        Try
            sourceText = My.Computer.Clipboard.GetText()
        Catch ex As Exception

        End Try
        sourceText = sourceText.Trim.Replace(vbTab, "|")
        Dim txtBox As New TextBox With {
            .Text = sourceText
        }

        Dim lineArray() As String

        result.Columns.Add("Reference")
        result.Columns.Add("Status")
        result.Columns.Add("Section")
        result.Columns.Add("Comment")
        result.Columns.Add("Calculation")
        result.Columns.Add("Log")
        result.Columns.Add("Success")

        Dim lineText As String
        Dim formatError As Boolean = False
        Dim errorMessage As String = ""
        For x = 0 To txtBox.Lines.Count - 1
            Try
                lineText = txtBox.Lines(x) & "||"
                lineArray = Split(lineText, "|")
                result.Rows.Add(lineArray)
            Catch ex As Exception
                errorMessage = ex.ToString
                formatError = True
                Exit For
            End Try

        Next
        If formatError Then
            result = Nothing
            XtraMessageBox.Show(errorMessage)
        End If
        Return result
    End Function

    Private Sub FrmImportComment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        gridControl.DataSource = Nothing
    End Sub

    Private Sub SaveComments()
        Dim total As Integer
        total = gridView.RowCount
        Dim reference, status, section, comments, calculation, errors As String
        Dim validations As List(Of String)
        Dim bookingIds As List(Of Long)
        For x As Integer = 0 To total - 1
            gridView.FocusedRowHandle = x
            reference = ""
            status = ""
            section = ""
            comments = ""
            calculation = ""
            errors = ""
            If Not IsDBNull(gridView.GetRowCellValue(x, "Reference")) Then
                reference = gridView.GetRowCellValue(x, "Reference").ToString.Trim
            End If
            If Not IsDBNull(gridView.GetRowCellValue(x, "Status")) Then
                status = gridView.GetRowCellValue(x, "Status").ToString.ToUpper.Trim
            End If
            If Not IsDBNull(gridView.GetRowCellValue(x, "Comment")) Then
                comments = gridView.GetRowCellValue(x, "Comment").ToString
            End If
            If Not IsDBNull(gridView.GetRowCellValue(x, "Section")) Then
                section = gridView.GetRowCellValue(x, "Section").ToString.Trim
            End If
            If Not IsDBNull(gridView.GetRowCellValue(x, "Calculation")) Then
                calculation = gridView.GetRowCellValue(x, "Calculation").ToString
            End If
            bookingIds = New List(Of Long)
            validations = New List(Of String)
            If Comment.Validate(reference, status, section, comments, calculation, bookingIds, validations) Then
                For Each i In bookingIds
                    Dim newComment = New Comment()
                    newComment.Status = status
                    newComment.SectionID = CInt(Val(section))
                    newComment.Comment = comments
                    newComment.Calculation = CSng(Val(calculation.Replace(",", ".")))
                    If newComment.SaveMulti(bookingIds, errors, False) Then
                        gridView.SetRowCellValue(x, "Log", "")
                        gridView.SetRowCellValue(x, "Success", True)
                    Else
                        gridView.SetRowCellValue(x, "Log", errors)
                        gridView.SetRowCellValue(x, "Success", False)
                    End If
                Next
            Else
                gridView.SetRowCellValue(x, "Log", String.Join(" - ", validations))
                gridView.SetRowCellValue(x, "Success", False)
            End If
            LabelControl1.Text = $"{x + 1} done of {total}"
            Application.DoEvents()

        Next

    End Sub
End Class
