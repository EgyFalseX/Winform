Public Class QueryBillFrm

    'SELECT BillID, SUM([Count] * [Cost]) AS  BillsPrice,
    '(SELECT BillDate FROM Bills WHERE BillsID = BillTypes.BillID) AS BillDate, 
    '(SELECT CusName FROM Customers WHERE CusID = (SELECT CusID FROM Bills WHERE BillsID = BillTypes.BillID)) AS CusName
    'FROM BillTypes
    'GROUP BY BillID


    Private Sub QueryBillFrm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim commandtext As String
        commandtext = "SELECT BillTypeID, BillID, TypeID, Count, Cost, " & _
            "(SELECT BillDate FROM Bills WHERE BillsID = BillTypes.BillsID) AS BillDate, " & _
            "(SELECT CusName FROM Customers WHERE CusID = (SELECT CusID FROM Bills WHERE BillsID = BillTypes.BillsID)) AS CusName"


        Dim ds As DataSet
        ds = CreateOLEDS("")
    End Sub
End Class