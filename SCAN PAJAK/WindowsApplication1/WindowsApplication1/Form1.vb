Imports System.Xml
Imports System.Net
Imports System.IO

Public Class Form1
    'create a temp file
    Dim path = IO.Path.GetTempPath()
    Dim fileName = Guid.NewGuid().ToString() + ".xml"
    Dim fullyQualifiedPath = IO.Path.Combine(path, fileName)



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click








        Dim request As HttpWebRequest
        Dim response As HttpWebResponse = Nothing
        Dim reader As StreamReader
        Dim result As String



        Try
            ' Create the web request  
            request = DirectCast(WebRequest.Create(TextBox1.Text), HttpWebRequest)

            ' Get response  
            response = DirectCast(request.GetResponse(), HttpWebResponse)

            ' Get the response stream into a reader  
            reader = New StreamReader(response.GetResponseStream())

            ' Read the whole contents and return as a string  
            result = reader.ReadToEnd()

        Finally
            If Not response Is Nothing Then response.Close()
        End Try


        Dim xmlDoc = New XmlDocument
        Dim xmlNodeNomorFaktur As Xml.XmlNode
        Dim xmlNodeNamaPengusahaKenaPajak As Xml.XmlNode
        Dim xmlNodeAlamatPengusahaKenaPajak As Xml.XmlNode
        Dim xmlNodeNPWPPengusahaKenaPajak As Xml.XmlNode



        Dim xmlNodeNomorFakturLawan As Xml.XmlNode
        Dim xmlNodeNamaPengusahaKenaPajakLawan As Xml.XmlNode
        Dim xmlNodeAlamatPengusahaKenaPajakLawan As Xml.XmlNode
        Dim xmlNodeNPWPPengusahaKenaPajakLawan As Xml.XmlNode


        Dim xmlNodeDPP As Xml.XmlNode
        Dim xmlNodePPN As Xml.XmlNode
        Dim xmlNodePPNBM As Xml.XmlNode







        xmlDoc.LoadXml(result)

        xmlNodeNomorFaktur = xmlDoc.SelectSingleNode("//" + "nomorFaktur")
        xmlNodeNamaPengusahaKenaPajak = xmlDoc.SelectSingleNode("//" + "namaPenjual")
        xmlNodeAlamatPengusahaKenaPajak = xmlDoc.SelectSingleNode("//" + "alamatPenjual")
        xmlNodeNPWPPengusahaKenaPajak = xmlDoc.SelectSingleNode("//" + "npwpPenjual")




        xmlNodeNamaPengusahaKenaPajakLawan = xmlDoc.SelectSingleNode("//" + "namaLawanTransaksi")
        xmlNodeAlamatPengusahaKenaPajakLawan = xmlDoc.SelectSingleNode("//" + "alamatLawanTransaksi")
        xmlNodeNPWPPengusahaKenaPajakLawan = xmlDoc.SelectSingleNode("//" + "npwpLawanTransaksi")

        xmlNodeDPP = xmlDoc.SelectSingleNode("//" + "jumlahDpp")
        xmlNodePPN = xmlDoc.SelectSingleNode("//" + "jumlahPpn")
        xmlNodePPNBM = xmlDoc.SelectSingleNode("//" + "jumlahPpnBm")

        If Not xmlNodeNomorFaktur Is Nothing Then
            txtNomorFakturPajak.Text = xmlNodeNomorFaktur.InnerText
        End If

        If Not xmlNodeNamaPengusahaKenaPajak Is Nothing Then
            txtNamaPengusahaKenaPajak.Text = xmlNodeNamaPengusahaKenaPajak.InnerText
        End If

        If Not xmlNodeAlamatPengusahaKenaPajak Is Nothing Then
            txtAlamatPengusahaKenaPajak.Text = xmlNodeAlamatPengusahaKenaPajak.InnerText
        End If

        If Not xmlNodeNPWPPengusahaKenaPajak Is Nothing Then
            txtNPWPPengusahaKenaPajak.Text = xmlNodeNPWPPengusahaKenaPajak.InnerText
        End If


        If Not xmlNodeNamaPengusahaKenaPajakLawan Is Nothing Then
            txtNamaLawan.Text = xmlNodeNamaPengusahaKenaPajakLawan.InnerText
        End If

        If Not xmlNodeAlamatPengusahaKenaPajakLawan Is Nothing Then
            txtAlamatLawan.Text = xmlNodeAlamatPengusahaKenaPajakLawan.InnerText
        End If

        If Not xmlNodeNPWPPengusahaKenaPajakLawan Is Nothing Then
            txtNpwpLawan.Text = xmlNodeNPWPPengusahaKenaPajakLawan.InnerText
        End If


        If Not xmlNodeDPP Is Nothing Then
            txtDPP.Text = xmlNodeDPP.InnerText
        End If

        If Not xmlNodePPN Is Nothing Then
            txtPPN.Text = xmlNodePPN.InnerText
        End If

        If Not xmlNodePPNBM Is Nothing Then
            txtPPNBM.Text = xmlNodePPNBM.InnerText
        End If


        'Dim readXML As XmlReader = XmlReader.Create(New StringReader(result))
        'While readXML.Read()
        '    Select Case readXML.NodeType
        '        Case XmlNodeType.Element
        '            ListBox1.Items.Add("<" + readXML.Name & ">")
        '            Exit Select
        '        Case XmlNodeType.Text
        '            ListBox1.Items.Add(readXML.Value)
        '            Exit Select
        '    End Select
        'End While




        'Dim statusColl As New Collection
        'Dim sUrl As String = TextBox1.Text
        'Dim statusElemList As XmlNodeList = xmlDoc.GetElementsByTagName("detailTransaksi")
        'For Each thisNode As XmlNode In statusElemList
        '    If (thisNode.Name = "detailTransaksi") Then
        '        Dim availElem As XmlNode = thisNode("detailTransaksi")
        '        statusColl.Add(availElem("nama").InnerText.ToString, "nama")
        '        statusColl.Add(availElem("hargaSatuan").InnerText.ToString, "hargaSatuan")
        '        statusColl.Add(availElem("jumlahBarang").InnerText.ToString, "jumlahBarang")
        '        statusColl.Add(availElem("hargaTotal").InnerText.ToString, "hargaTotal")
        '    End If
        'Next
        DataGridView1.ColumnCount = 9
        DataGridView1.Columns(0).Name = "Nama Barang"
        DataGridView1.Columns(1).Name = "Harga Satuan"
        DataGridView1.Columns(2).Name = "Jumlah Barang"
        DataGridView1.Columns(3).Name = "Harga Total"
        DataGridView1.Columns(4).Name = "Diskon"
        DataGridView1.Columns(5).Name = "DPP"
        DataGridView1.Columns(6).Name = "PPN"
        DataGridView1.Columns(7).Name = "Tarif PPNBM"
        DataGridView1.Columns(8).Name = "PPNBM"








        Dim dtTJupdate As New DataTable
        Dim xml_nodelist As XmlNodeList
        Dim xml_node As XmlNode
        Dim title As String
        Dim name As String

        dtTJupdate.Columns.Add(New DataColumn())
        dtTJupdate.Columns.Add(New DataColumn())

        'xmldoc = New XmlDocument()
        'xmldoc.Load(result)

        xml_nodelist = xmlDoc.SelectNodes("/resValidateFakturPm/detailTransaksi")

        For Each xml_node In xml_nodelist
            'Dim jobNode As XmlNode = xml_node.SelectSingleNode("nama")
            'Dim contactNode As XmlNode = xml_node.SelectSingleNode("hargaSatuan")

            Dim namaBarang As String = xmlDoc.SelectSingleNode("/resValidateFakturPm/detailTransaksi/nama").InnerText
            Dim hargaSatuan As String = xmlDoc.SelectSingleNode("/resValidateFakturPm/detailTransaksi/hargaSatuan").InnerText


            
            DataGridView1.Rows.Add(namaBarang, hargaSatuan)

        Next

        'DataGridView1.DataSource = dtTJupdate











        'Dim myxml As String
        'myxml = result
        'Dim ds As New DataSet()
        'ds.ReadXml(New System.IO.StringReader(myxml))
        'Dim DataGridView1 As New DataGridView()
        'DataGridView1.DataSource = ds
        'DataGridView1.DataMember = "item"
        'Me.Controls.Add(DataGridView1)








        'Dim doc = XDocument.Parse(result)

        ''txtNomorFakturPajak.Text = doc.Root.Attribute("nomorFaktur").Value

        ''Try



        'Dim xmlReader As New XmlTextReader(TextBox1.Text)
        'While xmlReader.Read()
        '    Select Case xmlReader.NodeType

        '        Case XmlNodeType.Element
        '            ListBox1.Items.Add("<" + xmlReader.Name & ">")
        '            Exit Select
        '        Case XmlNodeType.Text
        '            ListBox1.Items.Add(xmlReader.Value)
        '            Exit Select
        '        Case XmlNodeType.EndElement
        '            ListBox1.Items.Add("")
        '            Exit Select
        '    End Select
        'End While




        ''xmlFile = XmlReader.Create(reader.Read(), New XmlReaderSettings())

        'Dim ds As New DataSet
        'ds.ReadXml(reader.Read())
        'DataGridView1.DataSource = ds.Tables(0)









        '    Dim reader As XmlTextReader = New XmlTextReader(TextBox1.Text)
        '    'MsgBox("Authentnticated")

        '    Do While (reader.Read())
        '        Select Case reader.NodeType
        '            Case XmlNodeType.Element 'Display beginning of element.
        '                MsgBox("<" + reader.Name)
        '                If reader.HasAttributes Then 'If attributes exist
        '                    While reader.MoveToNextAttribute()
        '                        'Display attribute name and value.
        '                        'MsgBox(" {0}='{1}'", reader.Name, reader.Value)
        '                        txtHasil.Text = reader.Name
        '                    End While
        '                End If
        '                'MsgBox(">")
        '                txtHasil.Text = reader.Name
        '            Case XmlNodeType.Text 'Display the text in each element.
        '                'MsgBox(reader.Value)
        '                txtHasil.Text = reader.Name
        '            Case XmlNodeType.EndElement 'Display end of element.
        '                'MsgBox("</" + reader.Name)
        '                'MsgBox(">")
        '                txtHasil.Text = reader.Name
        '        End Select
        '    Loop
        '    Console.ReadLine()
        'Catch ex As Exception
        '    MsgBox(ex.ToString)
        'End Try



        ''download the file
        'Using client As New WebClient
        '    client.DownloadFile(TextBox1.Text, fullyQualifiedPath)
        'End Using

        ''show the file so we can see what we downloaded
        'Process.Start(fullyQualifiedPath)
    End Sub
End Class

