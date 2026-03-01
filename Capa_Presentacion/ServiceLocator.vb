' Capa_Presentacion/ServiceLocator.vb
Imports System.Collections.Generic
Imports Capa_Negocio

Public Module ServiceLocator

    Private ReadOnly _registro As New Dictionary(Of Type, Func(Of Object))()
    Private ReadOnly _singletons As New Dictionary(Of Type, Object)()

    Public Sub Configurar()
        ' Servicios transient
        Registrar(Of ConfiguracionServicio)(Function() New ConfiguracionServicio())
        Registrar(Of LicenciaServicio)(Function() New LicenciaServicio())
        Registrar(Of AuthServicio)(Function() New AuthServicio())
        Registrar(Of NetworkDiscoveryServicio)(Function() New NetworkDiscoveryServicio())
    End Sub

    Public Sub Registrar(Of T)(fabrica As Func(Of T))
        _registro(GetType(T)) = Function() fabrica()
    End Sub

    Public Sub RegistrarSingleton(Of T)(fabrica As Func(Of T))
        _registro(GetType(T)) = Function()
                                    If Not _singletons.ContainsKey(GetType(T)) Then
                                        _singletons(GetType(T)) = fabrica()
                                    End If
                                    Return _singletons(GetType(T))
                                End Function
    End Sub

    Public Function Obtener(Of T)() As T
        Dim tipo As Type = GetType(T)
        If Not _registro.ContainsKey(tipo) Then
            Throw New InvalidOperationException(
                String.Format("Tipo no registrado: {0}", tipo.Name))
        End If
        Return CType(_registro(tipo)(), T)
    End Function

End Module