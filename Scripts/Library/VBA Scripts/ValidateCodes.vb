Sub DynamicProgram()
    Dim lastRow As Long
    Dim DataRange As Range
    Sheets("Sales Lines Coding").Select
    With ActiveSheet
        lastRow = .Cells(.Rows.Count, "A").End(xlUp).Row
        Set DataRange = .Range("A2:Z" & lastRow)
    End With
    
    DataRange.Columns(8).FormulaR1C1 = "=VLOOKUP(RC[-7],'Mapping - Sales GL Codes'!C1:C2,2,FALSE)"
    DataRange.Columns(9).FormulaR1C1 = "=VLOOKUP(RC[-7],'Mapping - Rev Centre'!C1:C2,2,FALSE)"
    DataRange.Columns(10).FormulaR1C1 = "=""Sales - ""&RC[-9]&"" - ""&RC[-8]"
    DataRange.Columns(11).FormulaR1C1 = "=-RC[-5]"
    DataRange.Columns(13).FormulaR1C1 = "=RC[-8]"
    DataRange.Columns(12).FormulaR1C1 = "=""Discount - ""&RC[-11]&"" - ""&RC[-10]"
    DataRange.Columns("H:M").FillDown
End Sub