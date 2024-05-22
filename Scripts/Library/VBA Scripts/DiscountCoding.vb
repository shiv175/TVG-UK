Sub DiscountCoding()
    Dim lastRow As Long
    Dim DataRange As Range
    Sheets("Discount Coding").Select
    With ActiveSheet
        lastRow = .Cells(.Rows.Count, "A").End(xlUp).Row
        Set DataRange = .Range("A2:Z" & lastRow)
    End With
    
    DataRange.Columns(8).FormulaR1C1 = "=VLOOKUP(RC[-7],'Mapping - Discount'!C1:C2,2,FALSE)"
    DataRange.Columns(9).FormulaR1C1 = "=IF(RC[-1]=8252,1203,VLOOKUP(RC[-7],'Mapping - Rev Centre'!C1:C3,2,FALSE))"
    DataRange.Columns(10).FormulaR1C1 = "=VLOOKUP(RC[-8],'Mapping - Rev Centre'!C1:C3,3,FALSE)"
    'Accessing A Coulmn in RC
    DataRange.Columns(12).FormulaR1C1 = "=""Cost of Discount - ""&RC[-11]"
    DataRange.Columns(13).FormulaR1C1 = "=ROUND(VLOOKUP(RC[-11],'Discount COGS'!C1:C2,2,FALSE)*RC[-8],2)"
    DataRange.Columns(15).FormulaR1C1 = "7115"
    DataRange.Columns(16).FormulaR1C1 = "=VLOOKUP(RC[-14],'Mapping - Rev Centre'!C1:C3,2,FALSE)"
    DataRange.Columns(17).FormulaR1C1 = "=VLOOKUP(RC[-15],'Mapping - Rev Centre'!C1:C3,3,FALSE)"
    DataRange.Columns(19).FormulaR1C1 = "=""Cost of Discount - ""&RC[-18]"
    DataRange.Columns(20).FormulaR1C1 = "=-RC[-7]"
    DataRange.Columns("H:T").FillDown
End Sub