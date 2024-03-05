

Public Class Partita
    'Dim Suono1 As New Media.SoundPlayer(My.Resources.Guns_N__Roses___04___Paradise_City)
    Dim f_suono As Integer = 1
    Dim flag_Match As Integer = 1

    Dim Carte(40) As PictureBox
    Dim Mano(3) As PictureBox
    Dim Manocp(3) As PictureBox
    Dim Retri(3) As PictureBox
    Dim G_Vinte(40) As PictureBox
    Dim Cpu_Vinte(40) As PictureBox

    'Indice carte vinte
    Dim I_gv As Integer = 1
    Dim I_cv As Integer = 1

    Dim J As Integer
    Dim Ind As Integer = 1
    Dim Turno As Integer = 1
    Dim fig, figcp As PictureBox
    Dim flag_time As Integer = 0
    Dim Punti_G As Integer = 0
    Dim Punti_cp As Integer = 0


    Dim Xa, Ya, Xb As Integer
    Const Yb As Integer = 12

    'Dimensione oggetti e distanze

    'lunghezza carta
    Const lung As Integer = 180

    'larghezza carta calcolata in proporzione alla lunghezza
    Dim larg As Integer = Int(lung / 1.88)

    'Spazio tra 2 carte
    Const spazio As Integer = 22

    'costante
    Const k As Single = 2.5

    'Ordinata Mano cpu
    Const Ycp As Integer = 40    '5

    'Ordinata Mano giocatore
    Const Ym As Integer = k * lung + Ycp

    'costante 2
    Const k2 As Single = 1.12

    'Spostamento carta selezionata
    Dim spost As Integer = Int((Ym - Ycp) / 2)


    'Ascisse mano giocatore/cpu
    Dim X As Integer = larg * 3.75
    '3.13



    'flag che segnala l'intervento dell'utente per continuare il gioco cpu
    Dim flag_utente As Boolean = False


    Sub Nascondi()
        Briscola.Visible = False
        PBmazzo.Visible = False
        C_vinte.Visible = False
        C_vintecpu.Visible = False

    End Sub

    Sub Appari()


        Briscola.Visible = True
        PBmazzo.Visible = True

    End Sub


    Sub Copia_proprietà(ByVal D As PictureBox, ByVal S As PictureBox)
        D.BackgroundImage = S.BackgroundImage
        D.Tag = S.Tag
        D.AccessibleDescription = S.AccessibleDescription
        D.BackgroundImageLayout = S.BackgroundImageLayout

    End Sub


    Sub Imposta_figure()
        'Denari
        Carte(1).BackgroundImage = My.Resources.assodenari
        Carte(2).BackgroundImage = My.Resources.duedenari
        Carte(3).BackgroundImage = My.Resources.tredenari
        Carte(4).BackgroundImage = My.Resources.quattrodenari
        Carte(5).BackgroundImage = My.Resources.cinquedenari
        Carte(6).BackgroundImage = My.Resources.seidenari
        Carte(7).BackgroundImage = My.Resources.settedenari
        Carte(8).BackgroundImage = My.Resources.fantedenari
        Carte(9).BackgroundImage = My.Resources.cavallodenari
        Carte(10).BackgroundImage = My.Resources.redenari

        'Coppe
        Carte(11).BackgroundImage = My.Resources.assecoppe
        Carte(12).BackgroundImage = My.Resources.duecoppe
        Carte(13).BackgroundImage = My.Resources.trecoppe
        Carte(14).BackgroundImage = My.Resources.quattrocoppe
        Carte(15).BackgroundImage = My.Resources.cinquecoppe
        Carte(16).BackgroundImage = My.Resources.seicoppe
        Carte(17).BackgroundImage = My.Resources.settecoppe
        Carte(18).BackgroundImage = My.Resources.fantecoppe
        Carte(19).BackgroundImage = My.Resources.cavallocoppe
        Carte(20).BackgroundImage = My.Resources.recoppe

        'Bastoni
        Carte(21).BackgroundImage = My.Resources.assobastoni
        Carte(22).BackgroundImage = My.Resources.duebastoni
        Carte(23).BackgroundImage = My.Resources.trebastoni
        Carte(24).BackgroundImage = My.Resources.quattrobastoni
        Carte(25).BackgroundImage = My.Resources.cinquebastoni
        Carte(26).BackgroundImage = My.Resources.seibastoni
        Carte(27).BackgroundImage = My.Resources.settebastoni
        Carte(28).BackgroundImage = My.Resources.fantebastoni
        Carte(29).BackgroundImage = My.Resources.cavallobastoni
        Carte(30).BackgroundImage = My.Resources.rebastoni

        'Spade
        Carte(31).BackgroundImage = My.Resources.assospade
        Carte(32).BackgroundImage = My.Resources.duespade
        Carte(33).BackgroundImage = My.Resources.trespade
        Carte(34).BackgroundImage = My.Resources.quattrospade
        Carte(35).BackgroundImage = My.Resources.cinquespade
        Carte(36).BackgroundImage = My.Resources.seispade
        Carte(37).BackgroundImage = My.Resources.settespade
        Carte(38).BackgroundImage = My.Resources.fantespade
        Carte(39).BackgroundImage = My.Resources.cavallospade
        Carte(40).BackgroundImage = My.Resources.respade


    End Sub






    Sub Crea_Carte()
        For I = 1 To 40
            Carte(I) = New PictureBox
            Carte(I).Visible = False

            Carte(I).BackgroundImageLayout = ImageLayout.Stretch
            If I < 11 Then
                Carte(I).AccessibleDescription = "denari"
            Else
                If I < 21 Then
                    Carte(I).AccessibleDescription = "coppe"
                Else
                    If I < 31 Then
                        Carte(I).AccessibleDescription = "bastoni"
                    Else
                        Carte(I).AccessibleDescription = "spade"
                    End If
                End If

            End If

            Me.Controls.Add(Carte(I))

            If (I - 1) Mod 10 = 0 Then
                Carte(I).Tag = 10
            End If
            If (I - 2) Mod 10 = 0 Then
                Carte(I).Tag = 1
            End If
            If (I - 3) Mod 10 = 0 Then
                Carte(I).Tag = 9
            End If
            If (I - 4) Mod 10 = 0 Then
                Carte(I).Tag = 2
            End If
            If (I - 5) Mod 10 = 0 Then
                Carte(I).Tag = 3
            End If
            If (I - 6) Mod 10 = 0 Then
                Carte(I).Tag = 4
            End If
            If (I - 7) Mod 10 = 0 Then
                Carte(I).Tag = 5
            End If
            If (I - 8) Mod 10 = 0 Then
                Carte(I).Tag = 6
            End If
            If (I - 9) Mod 10 = 0 Then
                Carte(I).Tag = 7
            End If
            If I Mod 10 = 0 Then
                Carte(I).Tag = 8
            End If
        Next
        Imposta_figure()

    End Sub

    Sub Crea_Mani()



        'Il rapporto reale tra la lunghezza della carta e la sua larghezza e' di 94/50=1.88
        'Creazioni carte mani

        For I = 1 To 3
            Mano(I) = New PictureBox
            Manocp(I) = New PictureBox
            Retri(I) = New PictureBox

            Mano(I).Size = New Size(larg, lung)
            Manocp(I).Size = New Size(larg, lung)
            Retri(I).Size = New Size(larg, lung)

            Mano(I).Visible = True
            Manocp(I).Visible = False
            Retri(I).Visible = True

            Mano(I).Cursor = Cursors.Hand


            Mano(I).Location = New Point(X + (I - 1) * Mano(I).Width + (I - 1) * spazio, Ym)
            Manocp(I).Location = New Point(X + (I - 1) * Manocp(I).Width + (I - 1) * spazio, Ycp)
            Retri(I).Location = New Point(X + (I - 1) * Manocp(I).Width + (I - 1) * spazio, Ycp)

            Retri(I).BackgroundImage = My.Resources.retro
            Retri(I).BackgroundImageLayout = ImageLayout.Stretch
            Me.Controls.Add(Mano(I))
            Me.Controls.Add(Manocp(I))
            Me.Controls.Add(Retri(I))
            If flag_Match <> 2 Then
                AddHandler Mano(I).Click, AddressOf fig_Click
            End If



        Next
        Briscola.Size = New Size(larg, lung)
        Briscola.Location = New Point(Mano(3).Location.X + spazio * 12, Ym - spost)
        PBmazzo.Size = New Size(lung, larg)

        PBmazzo.Location = New Point(Briscola.Location.X + ((Briscola.Width - PBmazzo.Width) * 0.5), Briscola.Location.Y + 1 / 3 * Briscola.Location.Y)
        PBmazzo.Cursor = Cursors.Hand


        C_vinte.Height = lung
        C_vintecpu.Height = lung
        C_vinte.Location = New Size(Mano(1).Location.X - 200, Mano(1).Location.Y)
        C_vintecpu.Location = New Size(Manocp(1).Location.X - 200, Manocp(1).Location.Y)

        Label1.Visible = True
        Label2.Visible = True


        Dai_Carte_Iniz()
        Lbd.Location = New Point(PBmazzo.Location.X, PBmazzo.Location.Y + 120)
        Lbd.Text = "Carte nel mazzo " & 40 - Ind + 1

    End Sub



    Sub Mischia_Carte()
        Dim ran, tot As Integer


        Dim cas As New Random
        Dim App As PictureBox

        tot = 40
        App = New PictureBox
        App.Visible = False
        Me.Controls.Add(App)

        For I = 1 To 40
            ran = cas.Next(1, 41)
            'Do
            'If I < 20 Then
            'Randomize()
            'numcas = Rnd()
            'If numcas > 0.5 And numcas < 0.75 Then
            'Randomize()

            'ran = 30 + CInt(Rnd() * 10 + 1)



            'Else
            'Randomize()



            'ran = CInt(Rnd() * tot + I)

            'End If
            'Else
            'Randomize()
            'ran = Int(Rnd() * tot + I)
            'End If
            '     System.Threading.Thread.Sleep(500) '1000 millisecondi = 1 second0
            'Loop While ran > 40 Or ran < I
            'ListBox1.Items.Add(ran & "  " & I)

            ' Lbox.Items.Add(Ind & " " & I)
            Copia_proprietà(App, Carte(ran))
            Copia_proprietà(Carte(ran), Carte(I))
            Copia_proprietà(Carte(I), App)



            'tot -= 1


            '  Stampa()



        Next


        '   Crea_Mazzo()

    End Sub


    Sub Pesca(ByVal carta As PictureBox)
        Copia_proprietà(carta, Carte(Ind))
        Ind += 1

    End Sub


    Sub Dai_Carte_Iniz()

        For I = 1 To 3
            Pesca(Mano(I))
            Pesca(Manocp(I))
        Next

        Pesca(Briscola)


    End Sub


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ' AxWindowsMediaPlayer1.URL = "C:\Documents and Settings\Diego\Documenti\Musica\Guns N' Roses\Guns N' Roses - 04 - Paradise City.Mp3"
        '     Suono1.Load()
        '    Suono1.PlaySync()

        Crea_Carte()
        Nascondi()
        ' Stampa()

    End Sub



    'Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Maz.Click
    '    Dim gioc1 As risorse_carte.Mano_g
    '    Dim cpu1 As risorse_carte.Mano_cp
    '    Dim trasf As risorse_carte.Trasferisci
    '    Dim m1 As New risorse_carte.Mazzo(496, 178, 70, 25)


    '    gioc1 = New risorse_carte.Mano_g(8, X, Ym + 120, larg, lung, risorse_carte.verso.su)
    '    cpu1 = New risorse_carte.Mano_cp(3, X, Ycp, larg, lung, risorse_carte.verso.giù)


    '    For Each picture In gioc1.Mano

    '        Me.Controls.Add(picture)

    '    Next


    '    For Each picture In cpu1.Mano


    '        Me.Controls.Add(picture)

    '    Next

    '    m1.Mischia()
    '    m1.Mischia()

    '    gioc1.Mano(0).Tag = 2
    '    For i = 0 To gioc1.Mano.Count - 1
    '        m1.Pesca(gioc1.Mano(i))
    '    Next


    '    cpu1.Carica_figure(Carte)
    '    cpu1.Copri_carte()

    '    For Each picture In cpu1.Retro


    '        Me.Controls.Add(picture)

    '    Next
    '    trasf = New risorse_carte.Trasferisci(gioc1.Mano, 50, risorse_carte.verso.su, 30)





    '    'Mischia_Carte()
    '    'Mischia_Carte()
    '    'Crea_Mani()

    '    'Appari()
    '    'Lb.Visible = False
    '    'Maz.Visible = False
    '    'Lbd.Visible = True

    'End Sub


    Function Aggiorna_Punti() As Integer
        Dim som As Integer = 0
        If fig.Tag > 5 Then
            If fig.Tag < 9 Then
                'La carta e' o fante, o cavallo o re

                som += fig.Tag - 4
            Else
                'La carta e' un tre o un asso
                som += fig.Tag + 1

            End If
        End If

        If figcp.Tag > 5 Then
            If figcp.Tag < 9 Then
                'La carta e' o fante, o cavallo o re

                som += figcp.Tag - 4
            Else
                'La carta e' un tre o un asso
                som += figcp.Tag + 1

            End If
        End If

        Return som

    End Function

    Sub Metti_vinte()
        If Turno = 1 Then


            G_Vinte(I_gv) = New PictureBox
            Copia_proprietà(G_Vinte(I_gv), fig)
            G_Vinte(I_gv).Size = New Size(larg, lung)

            G_Vinte(I_gv).Visible = False
            Me.Controls.Add(G_Vinte(I_gv))
            I_gv += 1

            G_Vinte(I_gv) = New PictureBox
            Copia_proprietà(G_Vinte(I_gv), figcp)
            G_Vinte(I_gv).Size = New Size(larg, lung)
            ' G_Vinte(I_gv).Location = New Size(G_Vinte(I_gv - 1).Location.X + 60, Ym - 130)
            G_Vinte(I_gv).Visible = False
            Me.Controls.Add(G_Vinte(I_gv))
            I_gv += 1
        Else
            Cpu_Vinte(I_cv) = New PictureBox
            Copia_proprietà(Cpu_Vinte(I_cv), figcp)
            Cpu_Vinte(I_cv).Size = New Size(larg, lung)
            ' Cpu_Vinte(I_gv).Location = New Size((I_gv - 1) * larg - 70, Ym - 130)
            Cpu_Vinte(I_cv).Visible = False
            Me.Controls.Add(Cpu_Vinte(I_cv))
            I_cv += 1

            Cpu_Vinte(I_cv) = New PictureBox
            Copia_proprietà(Cpu_Vinte(I_cv), fig)
            Cpu_Vinte(I_cv).Size = New Size(larg, lung)
            ' Cpu_Vinte(I_gv).Location = New Size((I_gv - 1) * larg - 70, Ym - 130)
            Cpu_Vinte(I_cv).Visible = False
            Me.Controls.Add(Cpu_Vinte(I_cv))
            I_cv += 1
        End If
    End Sub
    Public Sub Pause(ByVal Milliseconds As Integer)
        Dim dTimer As Date
        dTimer = Now.AddMilliseconds(Milliseconds)
        Do While dTimer > Now
            Application.DoEvents()
        Loop
    End Sub
    Sub Gestione_scelta()
        If Turno = 1 Then
            J = Brain_cpu()
            figcp = Manocp(J)
            Xb = figcp.Location.X
            figcp.Visible = True
            Pause(750)
            figcp.Location = New Point(fig.Location.X + larg + spazio, fig.Location.Y)
            Retri(J).Visible = False
        End If
        Turno = Carta_sup(fig, figcp)
        Metti_vinte()
        If Turno = 1 Then
            Punti_G += Aggiorna_Punti()
            Label2.Text = "G1: " & Punti_G & " p."
        Else
            Punti_cp += Aggiorna_Punti()
            Label1.Text = "Cpu: " & Punti_cp & " p."
        End If
        Pause(1000)
        '  Thread.Sleep(5000)
        'System.Threading.Thread.Sleep(2000) '1000 millisecondi = 1 second0
        '  Pause(10000)
        flag_time = 0
        Timer1.Enabled = True
    End Sub


    Sub Cpu1_vs_Cpu2()

        Dim fine As Integer
        Dim I1 As Integer
        Dim cont1 As Integer = 0
        Dim cont2 As Integer = 0

        flag_Match = 2
        flag_utente = False

        RemoveHandler PBmazzo.Click, AddressOf PBmazzo_Click
        For I = 1 To 3
            RemoveHandler Mano(I).Click, AddressOf fig_Click
        Next
        RemoveHandler C_vinte.MouseEnter, AddressOf C_vinte_MouseEnter
        RemoveHandler C_vinte.MouseLeave, AddressOf C_vinte_MouseLeave

        fine = Identifica_fine()


        'verifica se è presente qualche carta fuori posto, o da pescare



        While (fine = 0 And flag_utente = False)
            'Osserva se effettuare la prima mossa
            ' Do



            cont1 = 0
            If Ind < 40 Then
                For I = 1 To 3
                    If Mano(I).Visible = True And Mano(I).Location.Y = Ym Then
                        cont1 += 1
                    End If
                Next
            Else
                For I = 1 To 3
                    If Mano(I).Location.Y = Ym Then
                        cont1 += 1
                    End If
                Next

            End If

            'Loop While cont1 <> 3

            If cont1 = 3 Then




                I1 = Brain_utente()

                fig = Mano(I1)
                Xa = fig.Location.X
                Ya = fig.Location.Y

                Pause(1000)

                If Turno = 2 Then

                    fig.Location = New Point(figcp.Location.X - larg - spazio, figcp.Location.Y)
                Else

                    fig.Location = New Point(fig.Location.X, fig.Location.Y - spost)
                End If


                'La cpu risponde, viene visualizzato chi vince e si procede con la pesca
                Gestione_scelta()

                'Pescare le carte nel timer
                Pause(4000)

                fine = Identifica_fine()
            End If
        End While
        If flag_Match = 2 Then
            regame()
        End If

    End Sub
    Private Sub fig_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim cont As Integer = 0

        'Controllo se l'utente ha cliccato sul mazzo quando non era necessario

        If Ind < 40 Then
            For I = 1 To 3
                If Mano(I).Visible = True And Mano(I).Location.Y = Ym Then
                    cont += 1
                End If
            Next
        Else
            For I = 1 To 3
                If Mano(I).Location.Y = Ym Then
                    cont += 1
                End If
            Next

        End If

        If cont = 3 Then

            'Identificazione bottone premuto
            fig = CType(sender, PictureBox)
            Xa = fig.Location.X
            Ya = fig.Location.Y
            If Turno = 2 Then

                fig.Location = New Point(figcp.Location.X - larg - spazio, figcp.Location.Y)
            Else

                fig.Location = New Point(fig.Location.X, fig.Location.Y - spost)
            End If


            If Turno = 1 Then

                J = Brain_cpu()

                figcp = Manocp(J)
                Xb = figcp.Location.X
                figcp.Visible = True
                figcp.Location = New Point(fig.Location.X + larg + spazio, fig.Location.Y)

                Retri(J).Visible = False
            End If



            Turno = Carta_sup(fig, figcp)
            Metti_vinte()
            If Turno = 1 Then




                Punti_G += Aggiorna_Punti()
                Label2.Text = "G1: " & Punti_G & " p."
            Else
                Punti_cp += Aggiorna_Punti()
                Label1.Text = "Cpu: " & Punti_cp & " p."
            End If

            flag_time = 0
            Timer1.Enabled = True


        End If

    End Sub

    Function Brain_utente() As Integer

        Dim val_max As Integer = 11
        Dim val_min As Integer = 0

        Dim max As Integer = 0


        'Si analizza le possibili situazioni, quando l'utente deve rispondere
        If Turno = 2 Then

            'Se cpu ha tirato briscola, G1 tira la carta con meno valore
            If figcp.AccessibleDescription = Briscola.AccessibleDescription Then

                'Se la cpu ha tirato il 3 di briscola, G1 osserva se è presente un asso
                If figcp.Tag = 9 Then
                    For I = 1 To 3
                        If Mano(I).Visible = True And Mano(I).AccessibleDescription = Briscola.AccessibleDescription And Mano(I).Tag = 10 Then
                            max = I
                            Exit For
                        End If

                    Next
                End If
                If max = 0 Then



                    For I = 1 To 3
                        If Mano(I).Visible = True And Mano(I).AccessibleDescription <> Briscola.AccessibleDescription And Mano(I).Tag < val_max Then
                            val_max = Mano(I).Tag
                            max = I
                        End If
                    Next
                    'Se all'uscita ho max ancora a 0, nella sua mano G1 ha tutte briscole, deve tirare la briscola minore
                    If max = 0 Then
                        For I = 1 To 3
                            If Mano(I).Visible = True And Mano(I).Tag < val_max Then
                                val_max = Mano(I).Tag
                                max = I
                            End If
                        Next

                    End If
                    If Mano(max).Tag > 8 Then
                        'G1 sta per tirare una carta non briscola ma che è il tre o l'asso
                        'meglio osservare se è presente una briscola che non sia però un asso o un 3 o un re
                        For I = 1 To 3
                            If Mano(I).Visible = True And Mano(I).AccessibleDescription = Briscola.AccessibleDescription And Mano(I).Tag < 8 Then
                                max = I
                                Exit For
                            End If
                        Next

                    End If
                End If

            Else
                'La cpu non ha tirato briscola:
                'Osserva se e' presente tra le sue mani, una carta dello stesso seme 
                'e in tal caso sceglie quella con il valore più alto
                For I = 1 To 3
                    If Mano(I).Visible = True And Mano(I).AccessibleDescription = figcp.AccessibleDescription And Mano(I).Tag > figcp.Tag And Mano(I).Tag > val_min Then
                        max = I
                        val_min = Mano(I).Tag
                    End If
                Next

                If max = 0 Then
                    'Se G1 non ha tirato briscola e la Cpu non ha tra la sua mano, una carta per fare la "varza"
                    'Osservo se la carta tirata ha come valore dal re in sù

                    If figcp.Tag >= 8 Then
                        'controllo se sulla mano della cpu c'è una briscola e tiro quella più bassa
                        For I = 1 To 3
                            If Mano(I).Visible = True And Mano(I).AccessibleDescription = Briscola.AccessibleDescription And Mano(I).Tag < val_max Then
                                max = I
                                val_max = Mano(I).Tag
                            End If
                        Next
                        If max <> 0 Then
                            'se la carta giocata da G1 è il re
                            'se la briscola minore è l'asso o il tre,  gioco la carta non briscola minore
                            If ((Mano(max).Tag = 10 Or Mano(max).Tag = 9) And figcp.Tag = 8) Then



                                val_max = 11
                                For I = 1 To 3

                                    If Mano(I).Visible = True And Mano(I).Tag < val_max And Mano(I).AccessibleDescription <> Briscola.AccessibleDescription Then
                                        max = I
                                        val_max = Mano(I).Tag

                                    End If
                                Next
                            End If
                        Else
                            'se nella mano nn c'è una briscola tiro la carta più bassa

                            For I = 1 To 3
                                If Mano(I).Visible = True And Mano(I).Tag < val_max Then
                                    max = I
                                    val_max = Mano(I).Tag
                                End If

                            Next
                        End If

                    Else
                        'in questo punto G1 ha tirato una carta non briscola, inferiore al re

                        'se la carta tirata è un cavallo o una fante, osserva se è presente una biscola 
                        'con valore inferiore alla fante
                        If figcp.Tag = 6 Or figcp.Tag = 7 Then

                            For I = 1 To 3
                                If Mano(I).Visible = True And Mano(I).AccessibleDescription = Briscola.AccessibleDescription And Mano(I).Tag < 6 Then
                                    max = I
                                    Exit For
                                End If
                            Next
                            'tiro la carta  minore
                            If max = 0 Then
                                For I = 1 To 3
                                    If Mano(I).Visible = True And Mano(I).Tag < val_max Then
                                        max = I
                                        val_max = Mano(I).Tag

                                    End If
                                Next

                            End If


                        Else

                            'altrimenti la carta è inferiore alla fante e non briscola 
                            'tiro la carta non briscola minore
                            For I = 1 To 3
                                If Mano(I).Visible = True And Mano(I).AccessibleDescription <> Briscola.AccessibleDescription And Mano(I).Tag < val_max Then
                                    max = I
                                    val_max = Mano(I).Tag

                                End If
                            Next


                            'Se la carta non briscola minore è un tre o un asso tiro la briscola minore


                            'Bug avvenuto qui, l'utente aveva tirato 7 denari, che non è briscola
                            '  If Manocp(max).Tag > 8 Then

                            'Se l'utente ha 3 briscole, max è ancora uguale a 0, quindi tiro la briscola minore
                            If max = 0 Then
                                For I = 1 To 3
                                    If Mano(I).Visible = True And Mano(I).Tag < val_max Then
                                        max = I
                                        val_max = Mano(I).Tag

                                    End If
                                Next
                            Else

                                If Mano(max).Tag > 8 Then



                                    'scelgo la carta di seme briscola minore, ma che sia inferiore al re
                                    For I = 1 To 3
                                        If Mano(I).Visible = True And Mano(I).AccessibleDescription = Briscola.AccessibleDescription And Mano(I).Tag < val_max And Mano(I).Tag < 8 Then
                                            val_max = Mano(I).Tag
                                            max = I
                                        End If
                                    Next
                                End If



                            End If


                        End If






                    End If





                End If


            End If


        Else
            'E' la Cpu che deve tirare per primo, scegliendo la carta non briscola più bassa



            'altrimenti tiro la carta non briscola minore
            For I = 1 To 3
                If Mano(I).Visible = True And Mano(I).AccessibleDescription <> Briscola.AccessibleDescription And Mano(I).Tag < val_max Then
                    max = I
                    val_max = Mano(I).Tag

                End If
            Next

            If max = 0 Then
                'La cpu ha nella propria mano 3 briscole
                'Tiro la briscola minore
                For I = 1 To 3
                    If Mano(I).Visible = True And Mano(I).Tag < val_max Then
                        val_max = Mano(I).Tag
                        max = I
                    End If
                Next


            Else
                If Mano(max).Tag > 8 Then
                    ' se la carta minore e' un 3 o un asso, tiro se presente una briscola che sia minore del 3
                    For I = 1 To 3
                        If Mano(I).Visible = True And Mano(I).AccessibleDescription = Briscola.AccessibleDescription And Mano(I).Tag < 9 Then
                            max = I
                            Exit For
                        End If
                    Next

                End If



            End If


        End If





        ' Intelligenza Casuale
        '   Randomize()

        ' cas = Rnd()
        'If cas <= 0.33 Then
        'Return 1
        'Else
        'If cas <= 0.66 Then
        'Return 2
        'Else
        'Return 3
        'End If

        '        End If

        Return max





    End Function



    Function Brain_cpu() As Integer

        Dim val_max As Integer = 11
        Dim val_min As Integer = 0

        Dim max As Integer = 0


        'Si analizza le possibili situazioni, quando la cpu deve rispondere
        If Turno = 1 Then

            'Se G1 ha tirato briscola, la cpu tira la carta con meno valore
            If fig.AccessibleDescription = Briscola.AccessibleDescription Then

                'Se g1 ha tirato il 3 di briscola, la cpu osserva se è presente un asso
                If fig.Tag = 9 Then
                    For I = 1 To 3
                        If Retri(I).Visible = True And Manocp(I).AccessibleDescription = Briscola.AccessibleDescription And Manocp(I).Tag = 10 Then
                            max = I
                            Exit For
                        End If

                    Next
                End If
                If max = 0 Then



                    For I = 1 To 3
                        If Retri(I).Visible = True And Manocp(I).AccessibleDescription <> Briscola.AccessibleDescription And Manocp(I).Tag < val_max Then
                            val_max = Manocp(I).Tag
                            max = I
                        End If
                    Next
                    'Se all'uscita ho max ancora a 0, nella sua mano ha tutte briscole, deve tirare la briscola minore
                    If max = 0 Then
                        For I = 1 To 3
                            If Retri(I).Visible = True And Manocp(I).Tag < val_max Then
                                val_max = Manocp(I).Tag
                                max = I
                            End If
                        Next

                    End If
                    If Manocp(max).Tag > 8 Then
                        'La cpu sta per tirare una carta non briscola ma che è il tre o l'asso
                        'meglio osservare se è presente una briscola che non sia però un asso o un 3 o un re
                        For I = 1 To 3
                            If Retri(I).Visible = True And Manocp(I).AccessibleDescription = Briscola.AccessibleDescription And Manocp(I).Tag < 8 Then
                                max = I
                                Exit For
                            End If
                        Next

                    End If
                End If

            Else
                'La cpu non ha tirato briscola:
                'Osserva se e' presente tra le sue mani, una carta dello stesso seme 
                'e in tal caso sceglie quella con il valore più alto
                For I = 1 To 3
                    If Retri(I).Visible = True And Manocp(I).AccessibleDescription = fig.AccessibleDescription And Manocp(I).Tag > fig.Tag And Manocp(I).Tag > val_min Then
                        max = I
                        val_min = Manocp(I).Tag
                    End If
                Next

                If max = 0 Then
                    'Se G1 non ha tirato briscola e la Cpu non ha tra la sua mano, una carta per fare la "varza"
                    'Osservo se la carta tirata ha come valore dal re in sù

                    If fig.Tag >= 8 Then
                        'controllo se sulla mano della cpu c'è una briscola e tiro quella più bassa
                        For I = 1 To 3
                            If Retri(I).Visible = True And Manocp(I).AccessibleDescription = Briscola.AccessibleDescription And Manocp(I).Tag < val_max Then
                                max = I
                                val_max = Manocp(I).Tag
                            End If
                        Next
                        If max <> 0 Then
                            'se la carta giocata da G1 è il re
                            'se la briscola minore è l'asso o il tre,  gioco la carta non briscola minore
                            If ((Manocp(max).Tag = 10 Or Manocp(max).Tag = 9) And fig.Tag = 8) Then



                                val_max = 11
                                For I = 1 To 3

                                    If Retri(I).Visible = True And Manocp(I).Tag < val_max And Manocp(I).AccessibleDescription <> Briscola.AccessibleDescription Then
                                        max = I
                                        val_max = Manocp(I).Tag

                                    End If
                                Next
                            End If
                        Else
                            'se nella mano nn c'è una briscola tiro la carta più bassa

                            For I = 1 To 3
                                If Retri(I).Visible = True And Manocp(I).Tag < val_max Then
                                    max = I
                                    val_max = Manocp(I).Tag
                                End If

                            Next
                        End If

                    Else
                        'in questo punto G1 ha tirato una carta non briscola, inferiore al re

                        'se la carta tirata è un cavallo o una fante, osserva se è presente una biscola 
                        'con valore inferiore alla fante
                        If fig.Tag = 6 Or fig.Tag = 7 Then

                            For I = 1 To 3
                                If Retri(I).Visible = True And Manocp(I).AccessibleDescription = Briscola.AccessibleDescription And Manocp(I).Tag < 6 Then
                                    max = I
                                    Exit For
                                End If
                            Next
                            'tiro la carta  minore
                            If max = 0 Then
                                For I = 1 To 3
                                    If Retri(I).Visible = True And Manocp(I).Tag < val_max Then
                                        max = I
                                        val_max = Manocp(I).Tag

                                    End If
                                Next

                            End If


                        Else

                            'altrimenti la carta è inferiore alla fante e non briscola 
                            'tiro la carta non briscola minore
                            For I = 1 To 3
                                If Retri(I).Visible = True And Manocp(I).AccessibleDescription <> Briscola.AccessibleDescription And Manocp(I).Tag < val_max Then
                                    max = I
                                    val_max = Manocp(I).Tag

                                End If
                            Next


                            'Se la carta non briscola minore è un tre o un asso tiro la briscola minore


                            'Bug avvenuto qui, l'utente aveva tirato 7 denari, che non è briscola
                            '  If Manocp(max).Tag > 8 Then

                            'Se l'utente ha 3 briscole, max è ancora uguale a 0, quindi tiro la briscola minore
                            If max = 0 Then
                                For I = 1 To 3
                                    If Retri(I).Visible = True And Manocp(I).Tag < val_max Then
                                        max = I
                                        val_max = Manocp(I).Tag

                                    End If
                                Next
                            Else

                                If Manocp(max).Tag > 8 Then



                                    'scelgo la carta di seme briscola minore, ma che sia inferiore al re
                                    For I = 1 To 3
                                        If Retri(I).Visible = True And Manocp(I).AccessibleDescription = Briscola.AccessibleDescription And Manocp(I).Tag < val_max And Manocp(I).Tag < 8 Then
                                            val_max = Manocp(I).Tag
                                            max = I
                                        End If
                                    Next
                                End If



                            End If


                        End If






                    End If





                End If


            End If


        Else
            'E' la Cpu che deve tirare per primo, scegliendo la carta non briscola più bassa



            'altrimenti tiro la carta non briscola minore
            For I = 1 To 3
                If Retri(I).Visible = True And Manocp(I).AccessibleDescription <> Briscola.AccessibleDescription And Manocp(I).Tag < val_max Then
                    max = I
                    val_max = Manocp(I).Tag

                End If
            Next

            If max = 0 Then
                'La cpu ha nella propria mano 3 briscole
                'Tiro la briscola minore
                For I = 1 To 3
                    If Retri(I).Visible = True And Manocp(I).Tag < val_max Then
                        val_max = Manocp(I).Tag
                        max = I
                    End If
                Next


            Else
                If Manocp(max).Tag > 8 Then
                    ' se la carta minore e' un 3 o un asso, tiro se presente una briscola che sia minore del 3
                    For I = 1 To 3
                        If Retri(I).Visible = True And Manocp(I).AccessibleDescription = Briscola.AccessibleDescription And Manocp(I).Tag < 9 Then
                            max = I
                            Exit For
                        End If
                    Next

                End If



            End If


        End If





        ' Intelligenza Casuale
        '   Randomize()

        ' cas = Rnd()
        'If cas <= 0.33 Then
        'Return 1
        'Else
        'If cas <= 0.66 Then
        'Return 2
        'Else
        'Return 3
        'End If

        '        End If

        Return max

    End Function

    Function Carta_sup(ByVal C_G As PictureBox, ByVal C_Cp As PictureBox) As Integer
        If C_G.AccessibleDescription = Briscola.AccessibleDescription And C_Cp.AccessibleDescription <> Briscola.AccessibleDescription Then
            Return 1

        Else
            If C_G.AccessibleDescription <> Briscola.AccessibleDescription And C_Cp.AccessibleDescription = Briscola.AccessibleDescription Then
                Return 2

            Else
                If C_G.AccessibleDescription = C_Cp.AccessibleDescription Then
                    If C_G.Tag > C_Cp.Tag Then
                        Return 1
                    Else
                        Return 2

                    End If
                Else
                    If Turno = 1 Then
                        Return 1
                    Else
                        Return 2
                    End If
                End If

            End If

        End If
    End Function


    Private Sub PBmazzo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PBmazzo.Click
        Dim cont As Integer = 0
        For I = 1 To 3
            If Mano(I).Visible = True Then
                cont += 1
            End If
        Next

        If (Ind < 41) And (cont <> 3) Then
            If (Ind <> 40) Then


                If Turno = 1 Then
                    'Pesca giocatore
                    Pesca(fig)

                    fig.Location = New Point(Xa, Ya)
                    fig.Visible = True
                    'Pesca Cpu
                    Pesca(figcp)
                    Retri(J).Visible = True

                Else

                    'Pesca giocatore
                    Pesca(fig)
                    fig.Location = New Point(Xa, Ya)
                    fig.Visible = True





                End If

                ' Lbl1.Text = "Carte nel mazzo=" & 40 - Ind



            Else
                'Gestione ultima carta, in cui G1 pesca l'ultima carta e Cpu prende briscola
                'Il caso in cui la Cpu debba pescare l'ultima carta, verrà gestito nel timer
                Pesca(fig)
                PBmazzo.Visible = False


                fig.Location = New Point(Xa, Ya)
                fig.Visible = True


                Copia_proprietà(figcp, Briscola)
                Briscola.Visible = False

                figcp.Location = New Point(Xb, Yb)
                figcp.Visible = False
                Retri(J).Visible = True


            End If
            Lbd.Text = "Carte nel mazzo " & 40 - Ind + 1
            Ex1.BackgroundImage = Manocp(1).BackgroundImage
            Ex2.BackgroundImage = Manocp(2).BackgroundImage
            Ex3.BackgroundImage = Manocp(3).BackgroundImage

        End If

    End Sub

    Function Identifica_fine() As Integer
        Dim conta As Integer = 0

        For I = 1 To 3
            If Mano(I).Visible = False Then
                conta += 1
            End If
        Next

        If conta = 3 Then
            C_vinte.Visible = False
            C_vintecpu.Visible = False
            Lbd.Visible = False

            stampa_v()
            If Punti_cp > Punti_G Then   'Vince la cpu
                MsgBox("Vince la Cpu con " & Punti_cp & " punti", MsgBoxStyle.Exclamation, "Vincitore")
            Else
                If Punti_cp = Punti_G Then           'E' patta

                    MsgBox("E' patta!! G1 ha totalizzato gli stessi punti di Cpu", MsgBoxStyle.Exclamation, "Vincitore")
                Else

                    MsgBox("Vince G1 con " & Punti_G & " punti", MsgBoxStyle.Information, "Vincitore")
                End If



            End If
            Return 1
        Else
            Return 0
        End If



    End Function


    Sub stampa_v()

        For I = 1 To I_gv - 1

            If I = 1 Then
                G_Vinte(I).Location = New Point(20, Ym - 40)

            Else
                G_Vinte(I).Location = New Point(G_Vinte(I - 1).Location.X + 50, Ym - 40)
            End If
            G_Vinte(I).Visible = True



        Next

        For I = 1 To I_cv - 1
            If I = 1 Then
                Cpu_Vinte(I).Location = New Point(20, 30 + 140)

            Else
                Cpu_Vinte(I).Location = New Point(Cpu_Vinte(I - 1).Location.X + 50, 30 + 140)
            End If
            Cpu_Vinte(I).Visible = True


        Next
    End Sub




    Sub regame()
        'Inizializzo il testo dei punteggi
        Label1.Text = "Cpu: 0 p."
        Label2.Text = "G1: 0 p."

        'Azzero i punti 
        Punti_cp = 0
        Punti_G = 0

        'Inizializzo l'indice per la pesca
        Ind = 1

        'Tolgo la stampa delle carte vinte
        For I = 1 To I_gv - 1
            G_Vinte(I).Visible = False
        Next
        For I = 1 To I_cv - 1
            Cpu_Vinte(I).Visible = False
        Next

        'Inizializzo gli indici per le carte vinte
        I_cv = 1
        I_gv = 1

        'Imposto Turno a 1
        Turno = 1




        'Visulizzo la carta del mazzo e la briscola
        PBmazzo.Visible = True
        Briscola.Visible = True


        'Inizializzo lable delle carte nel mazzo
        Lbd.Visible = True
        Lbd.Text = "Carte nel mazzo 33"

        'Mischio le carte nel mazzo
        Mischia_Carte()
        Mischia_Carte()

        'Rendo visibili le carte da gioco sulla form

        For I = 1 To 3
            Mano(I).Visible = True
            Retri(I).Visible = True

            'Impoosto anche la location
            Mano(I).Location = New Point(X + (I - 1) * Mano(I).Width + (I - 1) * spazio, Ym)
            Manocp(I).Location = New Point(X + (I - 1) * Manocp(I).Width + (I - 1) * spazio, Ycp)
            Retri(I).Location = New Point(X + (I - 1) * Manocp(I).Width + (I - 1) * spazio, Ycp)
        Next
        'Vengolo date le prime carte
        'Se e' uguale a 0, significa che non è 


        Dai_Carte_Iniz()



    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        '  fig.Show()
        Dim fine As Integer

        If flag_time = 0 Then
            System.Threading.Thread.Sleep(1000) '1000 millisecondi = 1 second0

            flag_time += 1

        End If





        If Turno = 1 Then
            fig.Top += 20
            figcp.Top += 20



        Else
            fig.Top -= 20
            figcp.Top -= 20

        End If

        If (fig.Top <= Ycp) Or (fig.Top >= Ym) Then

            Timer1.Enabled = False
            fig.Visible = False
            figcp.Visible = False

            fig.Location = New Point(Xa, Ya)
            figcp.Location = New Point(Xb, Yb)

            fine = Identifica_fine()
            If Turno = 1 Then
                If fine = 1 Then
                    If MsgBox("Rematch?", MsgBoxStyle.YesNo, "Briscola") = MsgBoxResult.Yes Then
                        regame()
                    Else
                        Me.Close()
                    End If
                    Exit Sub
                Else
                    C_vinte.Visible = True

                    If flag_Match = 2 And Ind < 40 Then
                        Pause(500)

                        'Pesca giocatore
                        Pesca(fig)
                        Lbd.Text = "Carte nel mazzo " & 40 - Ind
                        fig.Location = New Point(Xa, Ya)
                        fig.Visible = True
                        'Pesca Cpu
                        Pesca(figcp)
                        Lbd.Text = "Carte nel mazzo " & 40 - Ind
                        Retri(J).Visible = True
                    Else
                        If Ind = 40 Then
                            'Gestione ultima carta, in cui G1 pesca l'ultima carta e Cpu prende briscola
                            'Il caso in cui la Cpu debba pescare l'ultima carta, verrà gestito nel timer
                            Pesca(fig)
                            PBmazzo.Visible = False


                            fig.Location = New Point(Xa, Ya)
                            fig.Visible = True


                            Copia_proprietà(figcp, Briscola)
                            Briscola.Visible = False

                            figcp.Location = New Point(Xb, Yb)
                            figcp.Visible = False
                            Retri(J).Visible = True

                        End If

                    End If
                End If


            Else
                If fine = 1 Then

                    If MsgBox("Rematch?", MsgBoxStyle.YesNo, "Briscola") = MsgBoxResult.Yes Then


                        regame()

                    Else
                        Me.Close()
                    End If
                    Exit Sub

                Else

                    C_vintecpu.Visible = True
                End If



                System.Threading.Thread.Sleep(500) '1000 millisecondi = 1 second0
                'La cpu pesca e scegli la carta da tirare
                'Pesca Cpu





                If Ind < 41 Then
                    'La Cpu pesca la carta nel mazzo
                    figcp.Location = New Point(Xb, Yb)
                    Pesca(figcp)
                    Lbd.Text = "Carte nel mazzo=" & 40 - Ind
                    If Ind = 41 Then

                        Lbd.Text = "Carte nel mazzo " & 40 - Ind + 1
                        PBmazzo.Visible = False
                        Briscola.Visible = False
                        Copia_proprietà(fig, Briscola)

                        fig.Location = New Point(Xa, Ya)
                        fig.Visible = True




                    End If

                    Retri(J).Visible = True

                Else
                    Retri(J).Visible = False

                End If





                J = Brain_cpu()





                figcp = Manocp(J)

                Xb = figcp.Location.X

                Retri(J).Visible = False
                figcp.Visible = True
                figcp.Location = New Point(Xb, Mano(J).Location.Y - spost)

                If flag_Match = 2 And Ind < 41 Then
                    Pause(500)


                    'Pesca giocatore
                    Pesca(fig)
                    Lbd.Text = "Carte nel mazzo=" & 40 - Ind
                    fig.Location = New Point(Xa, Ya)
                    fig.Visible = True







                End If

            End If
        End If




    End Sub





    Private Sub C_vinte_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C_vinte.MouseEnter
        Dim a As Integer = 0


        For p = 1 To 3
            If Mano(p).Location.Y = Ym Then
                a += 1
            End If
        Next
        If a = 3 Then

            For I = 1 To I_gv - 1

                If I = 1 Then
                    G_Vinte(I).Location = New Point(12, Ym - 195)

                Else
                    G_Vinte(I).Location = New Point(G_Vinte(I - 1).Location.X + 50, Ym - 195)
                End If
                G_Vinte(I).Visible = True



            Next

            PBmazzo.Visible = False
            Briscola.Visible = False
            Lbd.Visible = False
            If Turno = 2 Then
                figcp.Visible = False

            End If
        End If


    End Sub

    Private Sub C_vinte_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C_vinte.MouseLeave
        For I = 1 To I_gv - 1

            G_Vinte(I).Visible = False

        Next
        If Ind <> 41 Then
            PBmazzo.Visible = True
            Briscola.Visible = True
        End If

        Lbd.Visible = True
        If Turno = 2 Then
            figcp.Visible = True

        End If
    End Sub

    Private Sub AxWindowsMediaPlayer1_ModeChange(ByVal sender As Object, ByVal e As AxWMPLib._WMPOCXEvents_ModeChangeEvent)

    End Sub




   







    Private Sub EsciToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EsciToolStripMenuItem.Click
        'E' presente una partita in esecuzione che è quella dell'utente
        If Maz.Visible = False And flag_Match <> 2 Then
            Opz1.Visible = True
            Opz2.Visible = True
            Opz1.Text = "Riavvia"
            Opz2.Text = "Continua pc"
        Else


            If flag_Match = 2 Then
                'è in esecuzione una partita del pc 
                Opz1.Visible = True
                Opz2.Visible = True
                Opz1.Text = "Riavvia"
                Opz2.Text = "Continua utente"

            Else
                'è presente il mazzo di partenza, oppure

                Opz1.Text = "Avvia/Riavvia"
                Opz1.Visible = True
                Opz2.Visible = False
            End If

        End If
        flag_Match = 2

    End Sub

    Private Sub RematchToolStripMenuItem_BackColorChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles RematchToolStripMenuItem.BackColorChanged

    End Sub


    Private Sub RematchToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RematchToolStripMenuItem.Click


        AddHandler PBmazzo.Click, AddressOf PBmazzo_Click

        AddHandler C_vinte.MouseEnter, AddressOf C_vinte_MouseEnter
        AddHandler C_vinte.MouseLeave, AddressOf C_vinte_MouseLeave
        If Maz.Visible = True Then


            Mischia_Carte()
            Mischia_Carte()

            Crea_Mani()

            Appari()
            Lb.Visible = False
            Maz.Visible = False
            Lbd.Visible = True
        Else
            regame()
        End If

    End Sub


    Private Sub ToolStripLabel2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripLabel2.Click
        Dim sc As Integer
        Dim contaa As Integer = 0
        Dim tipo As String






        If flag_Match <> 2 And Maz.Visible = False Then

            For I = 1 To 3
                If Mano(I).Visible = True And Mano(I).Location.Y = Ym Then
                    contaa += 1
                End If
            Next

            If contaa = 3 Then
                sc = Brain_utente()
                If Mano(sc).Tag = 1 Then
                    tipo = "due"
                End If

                If Mano(sc).Tag = 2 Then
                    tipo = "quattro"
                End If

                If Mano(sc).Tag = 3 Then
                    tipo = "cinque"
                End If

                If Mano(sc).Tag = 4 Then
                    tipo = "sei"
                End If

                If Mano(sc).Tag = 5 Then
                    tipo = "sette"
                End If

                If Mano(sc).Tag = 6 Then
                    tipo = "fante"
                End If

                If Mano(sc).Tag = 7 Then
                    tipo = "cavallo"
                End If

                If Mano(sc).Tag = 8 Then
                    tipo = "re"
                End If


                If Mano(sc).Tag = 9 Then
                    tipo = "tre"
                End If

                If Mano(sc).Tag = 10 Then
                    tipo = "asso"
                End If


                MsgBox("Le consigliamo il " & tipo & " di " & Mano(sc).AccessibleDescription, MsgBoxStyle.Information, "aiuto")
            End If
        End If
    End Sub

    Private Sub Opz2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Opz2.Click
        If Opz2.Text = "Continua pc" Then
            Cpu1_vs_Cpu2()
        Else
            flag_Match = 1
            flag_utente = True
            AddHandler PBmazzo.Click, AddressOf PBmazzo_Click
            For I = 1 To 3
                AddHandler Mano(I).Click, AddressOf fig_Click
            Next
            AddHandler C_vinte.MouseEnter, AddressOf C_vinte_MouseEnter
            AddHandler C_vinte.MouseLeave, AddressOf C_vinte_MouseLeave
        End If

    End Sub

    Private Sub Opz1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Opz1.Click
        'C'è una partita in corso
        If C_vinte.Visible = True Or C_vintecpu.Visible = True Then

            regame()
        Else

            Mischia_Carte()
            Mischia_Carte()
            Crea_Mani()

            Appari()
            Lb.Visible = False
            Maz.Visible = False
            Lbd.Visible = True



        End If
        Cpu1_vs_Cpu2()
    End Sub

    Private Sub EsciToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EsciToolStripMenuItem1.Click
        Me.Close()
    End Sub

    Private Sub Maz_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Maz.Click
        AddHandler PBmazzo.Click, AddressOf PBmazzo_Click

        AddHandler C_vinte.MouseEnter, AddressOf C_vinte_MouseEnter
        AddHandler C_vinte.MouseLeave, AddressOf C_vinte_MouseLeave
        If Maz.Visible = True Then


            Mischia_Carte()
            Mischia_Carte()

            Crea_Mani()

            Appari()
            Lb.Visible = False
            Maz.Visible = False
            Lbd.Visible = True
        Else
            regame()
        End If

    End Sub


  
End Class
