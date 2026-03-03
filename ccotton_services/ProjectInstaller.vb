Imports System.ComponentModel
Imports System.ServiceProcess
Imports System.Configuration.Install

Namespace ccotton_services

    <RunInstaller(True)>
    Public Class ProjectInstaller
        Inherits Installer

        Private WithEvents serviceProcessInstaller As ServiceProcessInstaller
        Private WithEvents serviceInstaller As ServiceInstaller

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub InitializeComponent()
            serviceProcessInstaller = New ServiceProcessInstaller()
            serviceInstaller = New ServiceInstaller()

            ' Cuenta bajo la que corre el servicio
            serviceProcessInstaller.Account = ServiceAccount.LocalSystem
            serviceProcessInstaller.Password = Nothing
            serviceProcessInstaller.Username = Nothing

            ' Metadatos del servicio
            serviceInstaller.ServiceName = "ccotton_services"
            serviceInstaller.DisplayName = "Calcula Cotton - Discovery Service"
            serviceInstaller.Description =
                "Servicio de descubrimiento de red para Calcula Cotton. " &
                "Mantiene activo el puerto UDP " & PUERTO_DISCOVERY &
                " para que los clientes detecten el servidor automáticamente."
            serviceInstaller.StartType = ServiceStartMode.Automatic

            Installers.Add(serviceProcessInstaller)
            Installers.Add(serviceInstaller)
        End Sub

    End Class

End Namespace