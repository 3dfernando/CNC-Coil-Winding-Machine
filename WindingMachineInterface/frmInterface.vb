Public Class frmInterface
    Public Speed_Manual As String = "100"
    Public Speed_Automatic As Decimal = 300

    'Coil properties
    Public NTurns As Integer
    Public NLayers As Integer
    Public TurnsPerLayer As Integer

    'Coil properties current
    Public Current_TurnGlobal As Integer = 0
    Public Current_TurnInLayer As Integer = 0
    Public Current_Layer As Integer = 0




    Sub GetSerialPortNames()
        ' Show all available COM ports.
        cmbCOMPorts.Items.Clear()

        For Each sp As String In My.Computer.Ports.SerialPortNames
            cmbCOMPorts.Items.Add(sp)
        Next

        If cmbCOMPorts.Items.Count > 0 Then
            cmbCOMPorts.SelectedIndex = 0
        End If



    End Sub

    Sub SendSerialData(ByVal PortNumber As String, ByVal data As String)
        ' Send strings to a serial port.
        Try
            Using Port As IO.Ports.SerialPort =
            My.Computer.Ports.OpenSerialPort(PortNumber, 115200, IO.Ports.Parity.None, 8, IO.Ports.StopBits.One)
                Port.Handshake = IO.Ports.Handshake.XOnXOff

                Port.WriteLine(data)
            End Using
        Catch ex As Exception
            MsgBox("Error")
        End Try

    End Sub

    Function ReceiveSerialData(ByVal PortNumber As String) As String
        ' Receive strings from a serial port.
        Dim returnStr As String = ""

        Dim Port As IO.Ports.SerialPort = Nothing
        Try
            Port = My.Computer.Ports.OpenSerialPort(PortNumber, 115200, IO.Ports.Parity.None, 8, IO.Ports.StopBits.One)
            Port.ReadTimeout = 100
            Port.Handshake = IO.Ports.Handshake.XOnXOff
            Do
                Dim Incoming As String = Port.ReadLine()
                If Incoming Is Nothing Then
                    Exit Do
                Else
                    returnStr &= Incoming & vbCrLf
                End If
            Loop
        Catch ex As TimeoutException
            returnStr = "Error: Serial Port read timed out."
        Finally
            If Port IsNot Nothing Then Port.Close()
        End Try

        Return returnStr
    End Function

    Sub SendPreamble()
        'Sends the set of configuration commands
        SendSerialData(cmbCOMPorts.SelectedItem, "G91") 'Relative positions
        SendSerialData(cmbCOMPorts.SelectedItem, "M302 S0") 'Ignore extruder temperature

        Dim M92Text As String = "M92 X" & Trim(Str(txtXsteps.Value)) & " E" & Trim(Str(txtEsteps.Value))
        SendSerialData(cmbCOMPorts.SelectedItem, M92Text) 'Set steps per revolution for extruder
        SendSerialData(cmbCOMPorts.SelectedItem, "M500") 'Set steps per revolution
        SendSerialData(cmbCOMPorts.SelectedItem, "M501") 'Set steps per revolution

    End Sub

    Sub DoManualTurn(Turn As String)
        'Does a number of turns specified by the string
        SendPreamble()

        SendSerialData(cmbCOMPorts.SelectedItem, "G1 F" & Speed_Manual) '
        SendSerialData(cmbCOMPorts.SelectedItem, "G1 E" & Turn) '
    End Sub

    Sub DoManualXMove(mm As String)
        'Does a number of turns specified by the string
        SendPreamble()

        SendSerialData(cmbCOMPorts.SelectedItem, "G1 F" & Speed_Manual) '
        SendSerialData(cmbCOMPorts.SelectedItem, "G1 X" & mm) '
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetSerialPortNames()
    End Sub

    Private Sub cmdUpdate_Click(sender As Object, e As EventArgs) Handles cmdUpdate.Click
        GetSerialPortNames()
    End Sub

#Region "Turn buttons"
    Private Sub cmd_FullTurn_CW_Click(sender As Object, e As EventArgs) Handles cmd_FullTurn_CW.Click
        DoManualTurn("1")
    End Sub

    Private Sub cmd_HalfTurn_CW_Click(sender As Object, e As EventArgs) Handles cmd_HalfTurn_CW.Click
        DoManualTurn("0.5")
    End Sub

    Private Sub cmd_QuarterTurn_CW_Click(sender As Object, e As EventArgs) Handles cmd_QuarterTurn_CW.Click
        DoManualTurn("0.25")
    End Sub

    Private Sub cmd_FullTurn_CCW_Click(sender As Object, e As EventArgs) Handles cmd_FullTurn_CCW.Click
        DoManualTurn("-1")
    End Sub

    Private Sub cmd_HalfTurn_CCW_Click(sender As Object, e As EventArgs) Handles cmd_HalfTurn_CCW.Click
        DoManualTurn("-0.5")
    End Sub

    Private Sub cmd_QuarterTurn_CCW_Click(sender As Object, e As EventArgs) Handles cmd_QuarterTurn_CCW.Click
        DoManualTurn("-0.25")
    End Sub

#End Region

#Region "Traverse Motion"
    Private Sub cmd_1mmF_Click(sender As Object, e As EventArgs) Handles cmd_1mmF.Click
        DoManualXMove("1")
    End Sub

    Private Sub cmd_10mm_F_Click(sender As Object, e As EventArgs) Handles cmd_10mm_F.Click
        DoManualXMove("10")
    End Sub

    Private Sub cmd_1mmB_Click(sender As Object, e As EventArgs) Handles cmd_1mmB.Click
        DoManualXMove("-1")
    End Sub

    Private Sub cmd_10mmB_Click(sender As Object, e As EventArgs) Handles cmd_10mmB.Click
        DoManualXMove("-10")
    End Sub

    Private Sub cmdHome_Click(sender As Object, e As EventArgs) Handles cmdHome.Click
        SendPreamble()
        SendSerialData(cmbCOMPorts.SelectedItem, "G28 X")
    End Sub

#End Region

#Region "Update Coil Properties"
    Private Sub txtWidth_ValueChanged(sender As Object, e As EventArgs) Handles txtWidth.ValueChanged
        Update_Coil_Properties()
    End Sub

    Private Sub txtDepth_ValueChanged(sender As Object, e As EventArgs) Handles txtDepth.ValueChanged
        Update_Coil_Properties()
    End Sub

    Private Sub txtWireDia_ValueChanged(sender As Object, e As EventArgs) Handles txtWireDia.ValueChanged
        Update_Coil_Properties()
    End Sub

    Sub Update_Coil_Properties()
        'Uses the values filled to update n turns
        If txtWireDia.Value > 0 Then
            TurnsPerLayer = Math.Floor(txtWidth.Value / txtWireDia.Value)
            NLayers = Math.Floor(txtDepth.Value / txtWireDia.Value)

            NTurns = TurnsPerLayer * NLayers
            txtNTurns.Value = NTurns
        End If
    End Sub
#End Region



    Private Sub ExecuteCoil(sender As Object, e As EventArgs) Handles cmdExecuteCoil.Click
        '=========Executes a full coil=============

        'Gets coil turn number
        Update_Coil_Properties()

        'Gives max extruder and x axis speeds given their relationship
        Dim Speed_E_TurnsPerSecond As Decimal = Speed_Automatic / 60
        Dim Speed_X_mmPerSecond As Decimal = Speed_E_TurnsPerSecond * txtWireDia.Value

        Speed_E_TurnsPerSecond = Decimal.Round(Speed_E_TurnsPerSecond, 2)
        Speed_X_mmPerSecond = Decimal.Round(Speed_X_mmPerSecond, 2)

        Dim TimePerLayer As Decimal = TurnsPerLayer / Speed_E_TurnsPerSecond

        Dim E_Speed As String = Trim(Str(Speed_E_TurnsPerSecond))
        Dim X_Speed As String = Trim(Str(Speed_X_mmPerSecond))

        SendPreamble()
        SendSerialData(cmbCOMPorts.SelectedItem, "M203 E" & E_Speed & " X" & X_Speed)
        SendSerialData(cmbCOMPorts.SelectedItem, "M500")


        'Executes the coil
        Dim Command As String
        Current_Layer = 0
        For Current_Layer = 0 To (NLayers - 1)
            If chkCW_Winds.Checked Then
                Command = "G1 F" & Trim(Str(Speed_Automatic)) & " E" & Trim(Str(TurnsPerLayer)) & " X"
            Else
                Command = "G1 F" & Trim(Str(Speed_Automatic)) & " E-" & Trim(Str(TurnsPerLayer)) & " X"
            End If

            If ((Current_Layer Mod 2) = 0 Xor (Not chkX_Forward.Checked)) Then
                'Even layer, moves forward in first layer [zeroth layer]
                Command = Command & Trim(Str(txtWidth.Value))
            Else
                'Odd layer, moves backward in first layer [zeroth layer]
                Command = Command & "-" & Trim(Str(txtWidth.Value))
            End If

            SendSerialData(cmbCOMPorts.SelectedItem, "M203 E" & E_Speed & " X" & X_Speed)
            SendSerialData(cmbCOMPorts.SelectedItem, "M500")
            SendSerialData(cmbCOMPorts.SelectedItem, Command) 'Sends command

            'Updates progress
            Progress.Value = (Current_Layer / NLayers) * 100
            lblCurrentTurn.Text = "Current Turn: " & Trim(Str(Current_Layer * TurnsPerLayer))
            Application.DoEvents()

            Threading.Thread.Sleep(Int(TimePerLayer * 1000)) 'Waits till command is finished physically
            Threading.Thread.Sleep(200) 'Waits a little bit more
        Next


    End Sub

End Class
