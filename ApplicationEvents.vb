Namespace My

    Partial Friend Class MyApplication
        Private WithEvents Domain As AppDomain = AppDomain.CurrentDomain
        Private Function DomainCheck(sender As Object, e As System.ResolveEventArgs) As System.Reflection.Assembly Handles Domain.AssemblyResolve
            If e.Name.Contains("AxInterop.WMPLib") Then
                Return System.Reflection.Assembly.Load(My.Resources.AxInterop_WMPLib)
            Else
                Return Nothing
            End If
        End Function
        Private Function IntCheck(sender As Object, e As System.ResolveEventArgs) As System.Reflection.Assembly Handles Domain.AssemblyResolve
            If e.Name.Contains("Interop.WMPLib") Then
                Return System.Reflection.Assembly.Load(My.Resources.Interop_WMPLib)
            Else
                Return Nothing
            End If
        End Function
    End Class
End Namespace
