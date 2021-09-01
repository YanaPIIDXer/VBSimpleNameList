Imports System.Net.Http
Imports Newtonsoft.Json.JsonConvert
Imports Newtonsoft.Json.Linq

Public Class BackendConnection
    ' エンドポイント
    Private Const ENDPOINT As String = "http://localhost/person"

    ' リストのフェッチ
    Public Shared Async Function FetchList() As Task(Of List(Of Person))
        Dim list As List(Of Person) = New List(Of Person)

        Using client As New HttpClient()
            Using response As HttpResponseMessage = Await client.GetAsync(ENDPOINT)
                Dim responseBody As String = Await response.Content.ReadAsStringAsync()
                Dim responseObject As JObject = CType(DeserializeObject(responseBody), JObject)
                Dim listObject As JArray = responseObject("list").ToObject(Of JArray)
                For Each person As JToken In listObject
                    Dim id As Integer = person("id").ToObject(Of Integer)
                    Dim lastName As String = person("last_name").ToObject(Of String)
                    Dim firstName As String = person("first_name").ToObject(Of String)
                    Dim newPerson As Person = New Person(id, lastName, firstName)
                    list.Add(newPerson)
                Next
            End Using
        End Using

        Return list
    End Function
End Class
