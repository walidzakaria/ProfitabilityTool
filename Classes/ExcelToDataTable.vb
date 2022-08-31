Imports DocumentFormat.OpenXml.Packaging
Imports DocumentFormat.OpenXml.Spreadsheet

Public Class ExcelToDataTable
    Public Shared Function GetDatatable(path As String) As DataTable
        Dim dt As New DataTable()

        Using spreadSheetDocument As SpreadsheetDocument = SpreadsheetDocument.Open(path, False)
            Dim workbookPart As WorkbookPart = spreadSheetDocument.WorkbookPart
            Dim sheets As IEnumerable(Of Sheet) = spreadSheetDocument.WorkbookPart.Workbook.GetFirstChild(Of Sheets)().Elements(Of Sheet)()
            Dim relationshipId As String = sheets.First().Id.Value
            Dim worksheetPart As WorksheetPart = CType(spreadSheetDocument.WorkbookPart.GetPartById(relationshipId), WorksheetPart)
            Dim workSheet As Worksheet = worksheetPart.Worksheet
            Dim sheetData As SheetData = workSheet.GetFirstChild(Of SheetData)()
            Dim rows As IEnumerable(Of Row) = sheetData.Descendants(Of Row)()

            For Each cell As Cell In rows.ElementAt(0)
                Dim colName As String = GetCellValue(spreadSheetDocument, cell)
                If colName = "Status" AndAlso dt.Columns.Contains("Status") Then
                    If dt.Columns.Contains("BookingStatus") Then
                        colName = "CommentStatus"
                    Else
                        colName = "BookingStatus"
                    End If

                End If
                dt.Columns.Add(colName)
            Next

            For Each row As Row In rows
                Dim tempRow As DataRow = dt.NewRow()
                If row.RowIndex = "1" Then
                    Continue For
                End If


                For i As Integer = 0 To row.Descendants(Of Cell)().Count() - 1
                    tempRow(i) = GetCellValue(spreadSheetDocument, row.Descendants(Of Cell)().ElementAt(i))
                Next

                dt.Rows.Add(tempRow)
            Next
        End Using

        dt.Rows.RemoveAt(0)
        Return dt
    End Function

    Public Shared Function GetCellValue(ByVal document As SpreadsheetDocument, ByVal cell As Cell) As String
        Dim stringTablePart As SharedStringTablePart = document.WorkbookPart.SharedStringTablePart
        Dim value As String = cell.CellValue.InnerXml

        If cell.DataType IsNot Nothing AndAlso cell.DataType.Value = CellValues.SharedString Then
            Return stringTablePart.SharedStringTable.ChildElements(Int32.Parse(value)).InnerText
        Else
            Return value
        End If
    End Function

End Class
