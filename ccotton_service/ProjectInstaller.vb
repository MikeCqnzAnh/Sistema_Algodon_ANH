Imports System.ComponentModel
Imports System.Configuration.Install
Imports System.ServiceProcess

<RunInstaller(True)>
Public Class ProjectInstaller
    Inherits Installer

    Private serviceProcessInstaller As ServiceProcessInstaller
    Private serviceInstaller As ServiceInstaller

    Public Sub New()
        serviceProcessInstaller = New ServiceProcessInstaller()
        serviceInstaller = New ServiceInstaller()

        ' Tipo de cuenta del servicio (puede ser LocalSystem, NetworkService, etc.)
        serviceProcessInstaller.Account = ServiceAccount.LocalSystem

        ' Configuración del servicio
        serviceInstaller.ServiceName = "ccotton_service"
        serviceInstaller.DisplayName = "Calcula Cotton Servidor de Licencias"
        serviceInstaller.Description = "Servicio que ejecuta procesos de Calcula Cotton"
        serviceInstaller.StartType = ServiceStartMode.Automatic

        ' Agregar instaladores a la colección
        Installers.Add(serviceProcessInstaller)
        Installers.Add(serviceInstaller)
    End Sub
End Class
