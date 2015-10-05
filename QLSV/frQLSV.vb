Public Class frQLSV
    'Khai bao bien chi xuat db'
    Private _DBAccess As New DataBaseAccess
    Private _loading As Boolean = True

    'Dinh nghia thu tuc load data'
    Private Sub LoadDataCoBox()
        Dim SQlQueryLoad As String = "Select ClassID,ClassName from dbo.Class"
        Dim dTable As DataTable = _DBAccess.GetDataTable(SQlQueryLoad)
        Me.cb_class.DataSource = dTable
        Me.cb_class.ValueMember = "ClassID"
        Me.cb_class.DisplayMember = "ClassName"
    End Sub

    Private Sub LoadStudent(ClassID As String)
        Dim SQlQueryLoad As String = String.Format("Select StudentID,StudentName,Phone,Address,ClassID from dbo.Student where ClassID = '{0}'", ClassID)
        Dim dTable As DataTable = _DBAccess.GetDataTable(SQlQueryLoad)
        Me.DataGridView1.DataSource = dTable
        With Me.DataGridView1
            .Columns(0).HeaderText = "StudentID"
            .Columns(1).HeaderText = "StudentName"
            .Columns(2).HeaderText = "Phone"
            .Columns(3).HeaderText = "Address"
            .Columns(4).HeaderText = "ClassID"


        End With

    End Sub

    Private Sub frQLSV_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDataCoBox()
        LoadStudent(Me.cb_class.SelectedValue)
        _loading = False
    End Sub

    Private Sub cb_class_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_class.SelectedIndexChanged
        If Not _loading Then
            LoadStudent(Me.cb_class.SelectedValue)
        End If
    End Sub
End Class
