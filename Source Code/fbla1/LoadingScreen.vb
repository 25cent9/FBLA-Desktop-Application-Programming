'Programmer: Innocent Niyibizi
'Date:  2-22-16
'Purpose: Create a splash screen that will load when the application is started
Public NotInheritable Class LoadingScreen


    Private Sub LoadingScreen_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Version.Text = System.String.Format(Version.Text, My.Application.Info.Version.Major, My.Application.Info.Version.Minor)

        'Copyright info
        Copyright.Text = My.Application.Info.Copyright
    End Sub
End Class
