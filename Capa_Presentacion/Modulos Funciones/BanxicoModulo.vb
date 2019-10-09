Imports System
Imports System.Runtime.Serialization
Imports System.Xml
Imports System.Xml.Serialization
Imports System.ServiceModel
Imports System.Net

Namespace ServiciosExternos
    '<DataContractFormat>
    'Public Class Serie
    '    <DataMember(Name:="titulo")>
    '    Public Property Title As String
    '    <DataMember(Name:="idSerie")>
    '    Public Property IdSerie As String
    '    <DataMember(Name:="datos")>
    '    Public Property Data As DataSerie()
    'End Class
    '<DataContract>
    'Public Class DataSerie
    '    <DataMember(Name:="fecha")>
    '    Public Property Date As String
    '    <DataMember(Name:="dato")>
    '    Public Property Data As String
    'End Class
    '<DataContract>
    'Public Class SeriesResponse
    '    <DataMember(Name:="series")>
    '    Public Property series As Serie()
    'End Class
    '<DataContract>
    'Public Class Response
    '    <DataMember(Name:="bmx")>
    '    Public Property seriesResponse As SeriesResponse
    'End Class
    'Public Class Banxico
    '    Const BANXICO_MI_TOKEN As String = "284eefa83d5241ed83107a78b4c267188850652b17afded987a1f42a005b2499"
    '    Const BANXICO_URL As String = "https://www.banxico.org.mx/SieAPIRest/service/v1/series/SF43718"
    '    Const BANXICO_FORMATO_FECHA As String = "yyyy-MM-dd"
    '    Const BANXICO_HEADER_ITEMTOKEN As String = "e3980208bf01ec653aba9aee3c2d6f70f6ae8b066d2545e379b9e0ef92e9de25"
    '    Const BANXICO_HEADER_FORMATACCEPTED As String = "application/json"
    '    Const BANXICO_SERIE_TIPOCAMBIOFIX As String = "SF43718"
    '    Private Shared Function ReadSerie(ByVal serie As String) As Response
    '        Return ReadSerie(serie, DateTime.Now)
    '    End Function
    '    Private Shared Function ReadSerie(ByVal serie As String, ByVal fecha As DateTime) As Response
    '        Dim _result As Response = Nothing
    '        Dim _strSerie As String = serie
    '        Dim _fmtFecha As String = fecha.ToString(BANXICO_FORMATO_FECHA)

    '        Try
    '            Dim _url As String = String.Format(BANXICO_URL, _strSerie, _fmtFecha)
    '            Dim _webRequest As HttpWebRequest = TryCast(WebRequest.Create(_url), HttpWebRequest)
    '            _webRequest.Accept = BANXICO_HEADER_FORMATACCEPTED
    '            _webRequest.Headers(BANXICO_HEADER_ITEMTOKEN) = BANXICO_MI_TOKEN
    '            Dim _webResponse As HttpWebResponse = TryCast(_webRequest.GetResponse(), HttpWebResponse)
    '            If _webResponse.StatusCode IsNot HttpStatusCode.OK Then Throw New Exception(String.Format("Server error (HTTP {0}: {1}).", _webResponse.StatusCode, _webResponse.StatusDescription))
    '            Dim jsonSerializer As DataContractJsonSerializer = New DataContractJsonSerializer(GetType(Response))
    '            Dim objResponse As Object = jsonSerializer.ReadObject(_webResponse.GetResponseStream())
    '            _result = TryCast(objResponse, Response)
    '        Catch e As Exception
    '        End Try

    '        Return _result
    '    End Function
    '    Public Shared Function TipoDeCambioFIX() As String
    '        Dim _result As String = TipoDeCambioFIX(DateTime.Now)
    '        Return _result
    '    End Function
    '    Public Shared Function TipoDeCambioFIX(ByVal fecha As DateTime) As String
    '        Dim _result As String = String.Empty
    '        Dim _responce As Response = ReadSerie(BANXICO_SERIE_TIPOCAMBIOFIX, fecha)
    '        If _responce IsNot Nothing Then _result = _responce.seriesResponse.series(0).Data(0).Data
    '        Return _result
    '    End Function
    'End Class
End Namespace