Imports IniParser
Imports IniParser.Model

Public Class frmMain
    Dim configPath As String = My.Application.Info.DirectoryPath & "\Config\Config.ini"
    Dim parser As New FileIniDataParser
    Dim configData As IniData = parser.ReadFile(configPath)

    Private Sub btn_save_config_Click(sender As Object, e As EventArgs) Handles btn_save_config.Click
        If txt_cfg_ref.Text = "" Or txt_cfg_date.Text = "" Or txt_cfg_id.Text = "" Or txt_cfg_c_val.Text = "" Or txt_cfg_v_val.Text = "" Or txt_cfg_time_val.Text = "" Or txt_cfg_nbc.Text = "" Then
            MsgBox("Please fill all data!")
            Exit Sub
        End If


    End Sub

    Private Sub txt_cfg_date_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txt_cfg_date.MouseDoubleClick
        txt_cfg_date.Text = Date.Now.ToString
    End Sub
End Class
