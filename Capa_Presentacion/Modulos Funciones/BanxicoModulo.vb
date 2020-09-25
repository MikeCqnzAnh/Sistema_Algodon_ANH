Imports System
Imports System.Runtime.Serialization
Imports System.Xml
Imports System.Xml.Serialization
Imports System.ServiceModel
Imports System.Net
Imports System.Runtime.Serialization.Json

Module ServiciosExternos
    <DataContract>
    Public Class Serie
        <DataMember(Name:="titulo")>
        Public Property Title As String
        <DataMember(Name:="idSerie")>
        Public Property IdSerie As String
        <DataMember(Name:="datos")>
        Public Property Data As DataSerie()
    End Class
    <DataContract>
    Public Class DataSerie
        <DataMember(Name:="fecha")>
        Public Property [Date] As String
        <DataMember(Name:="dato")>
        Public Property Data As String
    End Class
    <DataContract>
    Public Class SeriesResponse
        <DataMember(Name:="series")>
        Public Property series As Serie()
    End Class
    <DataContract>
    Public Class Response
        <DataMember(Name:="bmx")>
        Public Property seriesResponse As SeriesResponse
    End Class
    Dim BANXICO_FORMATO_FECHA As String = "yyyy-MM-dd"
    Dim BANXICO_HEADER_ITEMTOKEN As String = "Bmx-Token"
    Dim BANXICO_HEADER_FORMATACCEPTED As String = "application/json"
    Private Function ReadSerie(ByVal token As String, ByVal url As String) As Response
        Dim _result As Response = Nothing
        Dim BANXICO_URL As String = url

        Try
            System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12
            Dim _url As String = BANXICO_URL
            Dim _webRequest As HttpWebRequest = TryCast(WebRequest.Create(_url), HttpWebRequest)
            _webRequest.Timeout = 5000
            _webRequest.Accept = BANXICO_HEADER_FORMATACCEPTED
            _webRequest.Headers(BANXICO_HEADER_ITEMTOKEN) = token
            Dim _webResponse As HttpWebResponse = TryCast(_webRequest.GetResponse(), HttpWebResponse)
            If _webResponse.StatusCode <> HttpStatusCode.OK Then Throw New Exception(String.Format("Server error (HTTP {0}: {1}).", _webResponse.StatusCode, _webResponse.StatusDescription))
            Dim jsonSerializer As DataContractJsonSerializer = New DataContractJsonSerializer(GetType(Response))
            Dim objResponse As Object = jsonSerializer.ReadObject(_webResponse.GetResponseStream())
            _result = TryCast(objResponse, Response)
        Catch e As Exception
            MsgBox(e.Message)
        End Try
        Return _result
    End Function
    Public Function TipoDeCambioFIX(ByVal serie As String, ByVal fechainicio As DateTime, ByVal fechafin As DateTime, ByVal token As String, ByVal url As String) As String
        Dim _result As String = String.Empty
        Dim _strSerie As String = serie
        Dim _fechainicio As String = fechainicio.ToString(BANXICO_FORMATO_FECHA)
        Dim _fechafin As String = fechafin.ToString(BANXICO_FORMATO_FECHA)
        Dim _url As String = String.Empty

        _url = Replace(url, "%idSerie%", _strSerie)
        _url = Replace(_url, "%fechaIni%", _fechainicio)
        _url = Replace(_url, "%fechaFin%", _fechafin)
        Try
            Dim _responce As Response = ReadSerie(token, _url)
            If _responce IsNot Nothing Then
                If _responce.seriesResponse.series(0).Data.Count > 0 Then
                    _result = _responce.seriesResponse.series(0).Data(0).Data
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return _result
    End Function
End Module