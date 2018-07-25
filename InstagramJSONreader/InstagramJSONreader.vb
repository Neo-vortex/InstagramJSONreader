Imports System.Net
Imports Newtonsoft.Json

Public Class InstagramJsonReader
    Private URI As String
    Private WebClient As WebClient
    Public Function GetInfo() As RootObject
        Try
            Dim JSON As String = WebClient.DownloadString(URI)
            Return JsonConvert.DeserializeObject(Of RootObject)(JSON)
        Catch ex As Exception
            Throw New Exception("InstagramJsonreader: " & ex.Message)
        End Try
    End Function

    Public Sub New(ByVal URI As String)
        Try
            WebClient = New WebClient
            Me.URI = URI
        Catch ex As Exception
            Throw New Exception("InstagramJsonreader: " & ex.Message)
        End Try
    End Sub
    Public Class User2
        Public Property Pk As String
        Public Property Username As String
        Public Property Full_name As String
        Public Property is_private As Boolean
        Public Property profile_pic_url As String
        Public Property profile_pic_id As String
        Public Property is_verified As Boolean
        Public Property has_anonymous_profile_picture As Boolean
        Public Property follower_count As Integer
        Public Property reel_auto_archive As String
        Public Property byline As String
        Public Property social_context As String
        Public Property search_social_context As String
        Public Property mutual_followers_count As Double
        Public Property following As Boolean
        Public Property outgoing_request As Boolean
        Public Property unseen_count As Integer?
        Public Property latest_reel_media As Integer?
    End Class

    Public Class User
        Public Property position As Integer
        Public Property user As User2
    End Class

    Public Class Hashtag2
        Public Property name As String
        Public Property id As Object
        Public Property media_count As Integer
    End Class

    Public Class Hashtag
        Public Property position As Integer
        Public Property hashtag As Hashtag2
    End Class

    Public Class RootObject
        Public Property users As List(Of User)
        Public Property places As List(Of Object)
        Public Property hashtags As List(Of Hashtag)
        Public Property has_more As Boolean
        Public Property rank_token As String
        Public Property clear_client_cache As Boolean
        Public Property status As String
    End Class

End Class
