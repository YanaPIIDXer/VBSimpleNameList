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

    ' 新規追加
    Public Shared Async Function AddNewPerson(lastName As String, firstName As String) As Task(Of Boolean)
        Dim result As Boolean = False
        Using client As New HttpClient()
            Dim jsonText As String = "{""first_name"":""" + firstName + """, ""last_name"":""" + lastName + """}"
            Dim requestContent As New StringContent(jsonText, System.Text.Encoding.UTF8, "application/json")

            Using response As HttpResponseMessage = Await client.PostAsync(ENDPOINT, requestContent)
                Dim responseBody As String = Await response.Content.ReadAsStringAsync()
                Dim responseObject As JObject = CType(DeserializeObject(responseBody), JObject)
                result = responseObject("result").ToObject(Of Boolean)
            End Using
        End Using
        Return result
    End Function

    ' 更新
    Public Shared Async Function PatchPerson(id As Integer, lastName As String, firstName As String) As Task(Of Boolean)
        Dim result As Boolean = False
        Using client As New HttpClient()
            Dim jsonText As String = "{""first_name"":""" + firstName + """, ""last_name"":""" + lastName + """}"
            Dim requestContent As New StringContent(jsonText, System.Text.Encoding.UTF8, "application/json")

            Using response As HttpResponseMessage = Await client.PatchAsync(String.Format(ENDPOINT + "/{0}", id), requestContent)
                Dim responseBody As String = Await response.Content.ReadAsStringAsync()
                Dim responseObject As JObject = CType(DeserializeObject(responseBody), JObject)
                result = responseObject("result").ToObject(Of Boolean)
            End Using
        End Using
        Return result
    End Function

    ' 削除
    Public Shared Async Function DeletePerson(id As Integer) As Task(Of Boolean)
        Dim result As Boolean = False
        Using client As New HttpClient()
            Using response As HttpResponseMessage = Await client.DeleteAsync(String.Format(ENDPOINT + "/{0}", id))
                Dim responseBody As String = Await response.Content.ReadAsStringAsync()
                Dim responseObject As JObject = CType(DeserializeObject(responseBody), JObject)
                result = responseObject("result").ToObject(Of Boolean)
            End Using
        End Using
        Return result
    End Function
End Class
