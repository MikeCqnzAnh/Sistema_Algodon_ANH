Imports System.ServiceProcess

Namespace ccotton_services

    Module Program

        Sub Main(args() As String)
            ' Permite ejecutar en consola con argumento -console para depuración
            If args.Length > 0 AndAlso args(0).ToLower() = "-console" Then
                EjecutarEnConsola()
            Else
                Dim servicesToRun() As ServiceBase = {New CcottonService()}
                ServiceBase.Run(servicesToRun)
            End If
        End Sub

        ''' <summary>
        ''' Modo consola para depurar sin instalar el servicio.
        ''' Ejecutar: ccotton_services.exe -console
        ''' </summary>
        Private Sub EjecutarEnConsola()
            Console.Title = $"[DEBUG] ccotton_services"
            Console.ForegroundColor = ConsoleColor.Cyan
            Console.WriteLine("════════════════════════════════════════════")
            Console.WriteLine($"  {Constantes.NOMBRE_SISTEMA} - Modo consola")
            Console.WriteLine($"  Puerto UDP: {Constantes.PUERTO_DISCOVERY}")
            Console.WriteLine("  Presiona Ctrl+C para detener.")
            Console.WriteLine("════════════════════════════════════════════")
            Console.ResetColor()

            Dim svc As New CcottonService()

            ' Simular OnStart
            Dim mi As Reflection.MethodInfo =
                GetType(ServiceBase).GetMethod("OnStart",
                    Reflection.BindingFlags.Instance Or Reflection.BindingFlags.NonPublic)
            mi.Invoke(svc, New Object() {New String() {}})

            AddHandler Console.CancelKeyPress, Sub(sender, e)
                                                   e.Cancel = True
                                                   Console.WriteLine("Deteniendo...")
                                                   Dim miStop As Reflection.MethodInfo =
                                                       GetType(ServiceBase).GetMethod("OnStop",
                                                           Reflection.BindingFlags.Instance Or Reflection.BindingFlags.NonPublic)
                                                   miStop.Invoke(svc, Nothing)
                                               End Sub

            Console.ReadLine()
        End Sub

    End Module

End Namespace