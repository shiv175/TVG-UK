Sub SalesLineCoding()
    Dim lastRow As Long
    Dim DataRange As Range
    Sheets("Sales Lines Coding").Select
    With ActiveSheet
        lastRow = .Cells(.Rows.Count, "A").End(xlUp).Row
        Set DataRange = .Range("A2:Z" & lastRow)
    End With
    
    DataRange.Columns(8).FormulaR1C1 = "=IF(ISNUMBER(MATCH(RC[-6], 'Mapping - Rev Centre'!C1:C4, 0)), 2981, IFERROR(VLOOKUP(RC[-7], 'Mapping - Sales GL Codes'!C1:C2, 2, FALSE), ""Not Found""))"
    DataRange.Columns(9).FormulaR1C1 = "=VLOOKUP(RC[-7],'Mapping - Rev Centre'!C1:C2,2,FALSE)"
    DataRange.Columns(10).FormulaR1C1 = "=VLOOKUP(RC[-8],'Mapping - Rev Centre'!C1:C3,3,FALSE)"
    DataRange.Columns(12).FormulaR1C1 = "=""Sales - ""&RC[-11]&"" - ""&RC[-10]"
    DataRange.Columns(13).FormulaR1C1 = "=-RC[-9]"
    DataRange.Columns(14).FormulaR1C1 = "=RC[-7]"
    DataRange.Columns("H:N").FillDown
End Sub