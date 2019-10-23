


Imports System
Imports System.Data
Imports System.Math
Imports System.Net
Imports System.IO
Imports System.Text
Imports System.Collections.Generic
Imports System.Web.Script
Imports System.Web.Script.Serialization


Module Module1

    Sub Main()
        Dim json As String = "{""description"": ""temp"",""metadata"": {}}"
        'Dim json As String = ""{""title"": ""Тестовый документ №2""}"


        Dim jssj As New JavaScriptSerializer()
        jssj.MaxJsonLength = Int32.MaxValue
        Dim dictj As Dictionary(Of String, Object) = jssj.Deserialize(Of Dictionary(Of String, Object))(json)

        Dim j2 As String = "Тестовый документ №2"
        dictj.Add("title", j2)

        Dim fp As String = "D:\mnmnt\80-385-0192.jpg"
        'dictj.Add("fileData", File.ReadAllBytes(fp))
        dictj.Add("fileData", Convert.ToBase64String(File.ReadAllBytes(fp))) '
        Dim json_data As String 'ok!!!!!
        json_data = jssj.Serialize(dictj).ToString
        Dim fi As File
        fi.WriteAllText("D:\mnmnt\files\auth\5.txt", json_data)

    End Sub

End Module
