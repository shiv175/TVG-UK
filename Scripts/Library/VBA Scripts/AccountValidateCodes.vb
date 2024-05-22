Sub DynamicProgramAccounting()
    Dim lastRow As Long
    Dim DataRange As Range
    Sheets("Accounting").Select
    With ActiveSheet
        lastRow = .Cells(.Rows.Count, "A").End(xlUp).Row
        Set DataRange = .Range("A2:Z" & lastRow)
    End With
    
    DataRange.Columns(7).FormulaR1C1 = "=RC[-3]"
    DataRange.Columns(8).FormulaR1C1 = "=VLOOKUP(RC[-5],'Accounting Mapping'!C1:C2,2,FALSE)"
	DataRange.Columns(9).FormulaR1C1 = "D3000"
    DataRange.Columns(10).FormulaR1C1 = ""
    DataRange.Columns(11).FormulaR1C1 = "=""RC[-8]&"" - ""&RC[-6]"
    DataRange.Columns(12).FormulaR1C1 = "=RC[-6]"
    DataRange.Columns("G:L").FillDown
End Sub