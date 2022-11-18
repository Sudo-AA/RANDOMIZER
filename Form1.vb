Public Class shuffler
    Dim names As List(Of String)




    Private Sub shuffler_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ListBox1.Items.Add("Canada")
        ListBox1.Items.Add("USA")
        ListBox1.Items.Add("UK")
        ListBox1.Items.Add("Japan")
        ListBox1.Items.Add("Russia")
        ListBox1.Items.Add("China")
        ListBox1.Items.Add("India")
    End Sub

    Private Sub btn_shuffler_Click(sender As Object, e As EventArgs) Handles btn_shuffler.Click

        'Dim rand As New Random
        'Dim index As Integer
        'Dim item As Object

        ''Display the items in random order.

        'Dim limiter As Integer = ListBox1.Items.Count - TextBox1.Text
        'While ListBox1.Items.Count > limiter ' << ----- SET LIMITS
        '    index = rand.Next(0, ListBox1.Items.Count)
        '    item = ListBox1.Items(index)
        '    'item deleter
        '    ListBox1.Items.RemoveAt(index)
        '    ListBox2.Items.Add(item)
        'End While
        'ListBox2.Items.Clear()
        Dim qty As Integer = TextBox1.Text
        Dim cou As Integer = 0
        Dim ls As List(Of String) = List_to_array(ListBox1)
        Dim ran As List(Of String) = Randomizer(ls, qty)
        While ran.Count > cou
            ListBox1.Items.Add(ran.Item(cou).ToString)
            cou = +1
        End While
    End Sub


    ' randomizer return list of winners by aaron 
    ' calling method 
    ' ex   Randomizer(<list of String>, Quantity) 
    Public Function Randomizer(ByVal list As List(Of String), ByVal qty As Integer) As List(Of String)
        Dim rand As New Random
        Dim index As Integer
        Dim namelist As New List(Of String)
        Dim limiter As Integer = list.Count - qty


        While list.Count > limiter ' << ----- SET LIMITS
            index = rand.Next(0, list.Count)
            namelist.Add(list.Item(index).ToString)
            'item deleter'
            list.RemoveAt(index)

        End While

        Return namelist

    End Function


    Public Function List_to_array(ByVal list As ListBox) As List(Of String)
        Dim lss As List(Of String) = New List(Of String)
        Dim counter As Integer = 0
        Dim it As Object
        While list.Items.Count > counter

            it = list.Items(counter)
            lss.Add(it)
            counter = +1
        End While
        Return lss
    End Function


End Class
