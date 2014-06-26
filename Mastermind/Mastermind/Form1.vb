Public Class Form1
    Dim circles() As Array
    Dim crow1() As Object
    Dim crow2() As Object
    Dim crow3() As Object
    Dim crow4() As Object
    Dim crow5() As Object
    Dim crow6() As Object
    Dim crow7() As Object
    Dim crow8() As Object
    Dim crow9() As Object
    Dim crow10() As Object
    Dim row1() As Object
    Dim row2() As Object
    Dim row3() As Object
    Dim row4() As Object
    Dim row5() As Object
    Dim row6() As Object
    Dim row7() As Object
    Dim row8() As Object
    Dim row9() As Object
    Dim row10() As Object
    Dim n As Integer
    Dim colorrows() As Object
    Dim colorone As Boolean
    Dim colortwo As Boolean
    Dim colorthree As Boolean
    Dim colorfour As Boolean
    Dim colorfive As Boolean
    Dim humancolors() As Object
    Dim rand As New Random
    Dim number As Integer
    Dim arr As Array
    Dim colorstay1 As Boolean
    Dim colorstay2 As Boolean
    Dim colorstay3 As Boolean
    Dim colorstay4 As Boolean
    Dim c() As Boolean



    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        row1 = {h40, h39, h38, h37}
        row2 = {h36, h35, h34, h33}
        row3 = {h32, h31, h30, h29}
        row4 = {h28, h27, h26, h25}
        row5 = {h24, h23, h22, h21}
        row6 = {h20, h19, h18, h17}
        row7 = {h16, h15, h14, h13}
        row8 = {h12, h11, h10, h9}
        row9 = {h8, h7, h6, h5}
        row10 = {h4, h3, h2, h1}
        circles = {crow1, crow2, crow3, crow4, crow5, crow6, crow7, crow8, crow9, crow10}
        crow1 = {circle1, circle2, circle3, circle4}
        crow2 = {circle5, circle6, circle7, circle8}
        crow3 = {circle9, circle10, circle11, circle12}
        crow4 = {circle13, circle14, circle15, circle16}
        crow5 = {circle17, circle18, circle19, circle20}
        crow6 = {circle21, circle22, circle23, circle24}
        crow7 = {circle25, circle26, circle27, circle28}
        crow8 = {circle29, circle30, circle31, circle32}
        crow9 = {circle33, circle34, OvalShape1, circle36}
        crow10 = {circle37, circle38, circle39, circle40}
        c = {colorstay1, colorstay2, colorstay3, colorstay4}
        colorone = False
        colortwo = False
        colorthree = False
        colorfour = False
        colorfive = False
        colorstay1 = False
        colorstay2 = False
        colorstay3 = False
        colorstay4 = False
    End Sub

    Private Sub Color1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Color1.Click
        If colorone = False Then
            a1.BackColor = Color1.BackColor
            colorone = True
        ElseIf colortwo = False Then
            a2.BackColor = Color1.BackColor
            colortwo = True
        ElseIf colorthree = False Then
            a3.BackColor = Color1.BackColor
            colorthree = True
        ElseIf colorfour = False Then
            a4.BackColor = Color1.BackColor
            colorfour = True
        End If


    End Sub

    Private Sub Color2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Color2.Click
        If colorone = False Then
            a1.BackColor = Color2.BackColor
            colorone = True
        ElseIf colortwo = False Then
            a2.BackColor = Color2.BackColor
            colortwo = True
        ElseIf colorthree = False Then
            a3.BackColor = Color2.BackColor
            colorthree = True
        ElseIf colorfour = False Then
            a4.BackColor = Color2.BackColor
            colorfour = True
        End If

    End Sub

    Private Sub Color3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Color3.Click
        If colorone = False Then
            a1.BackColor = Color3.BackColor
            colorone = True
        ElseIf colortwo = False Then
            a2.BackColor = Color3.BackColor
            colortwo = True
        ElseIf colorthree = False Then
            a3.BackColor = Color3.BackColor
            colorthree = True
        ElseIf colorfour = False Then
            a4.BackColor = Color3.BackColor
            colorfour = True
        End If

    End Sub

    Private Sub Color4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Color4.Click
        If colorone = False Then
            a1.BackColor = Color4.BackColor
            colorone = True
        ElseIf colortwo = False Then
            a2.BackColor = Color4.BackColor
            colortwo = True
        ElseIf colorthree = False Then
            a3.BackColor = Color4.BackColor
            colorthree = True
        ElseIf colorfour = False Then
            a4.BackColor = Color4.BackColor
            colorfour = True
        End If

    End Sub
   
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        humancolors = {a1, a2, a3, a4}
        Timer1.Start()
        n += 1

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If n = 1 Then
            For i = 0 To row1.Length - 1
                    number = rand.Next(1, 6)
                If number = 1 Then
                    row1(i).backcolor = Color1.BackColor
                ElseIf number = 2 Then
                    row1(i).backcolor = Color2.BackColor
                ElseIf number = 3 Then
                    row1(i).backcolor = Color3.BackColor
                ElseIf number = 4 Then
                    row1(i).backcolor = Color4.BackColor
                ElseIf number = 5 Then
                    row1(i).backcolor = color5.BackColor
                End If
                Timer1.Stop()
                colorrows = {h37, h38, h39, h40}
                row1(i).visible = True
            Next
        End If


        checkright1()
        checkwin()

        If n = 2 Then
            For i = 0 To row2.Length - 1
                If row2(i).backcolor = Color.White Then
                    number = rand.Next(1, 6)
                    If number = 1 Then
                        row2(i).backcolor = Color1.BackColor
                    ElseIf number = 2 Then
                        row2(i).backcolor = Color2.BackColor
                    ElseIf number = 3 Then
                        row2(i).backcolor = Color3.BackColor
                    ElseIf number = 4 Then
                        row2(i).backcolor = Color4.BackColor
                    ElseIf number = 5 Then
                        row2(i).backcolor = color5.BackColor
                    End If
                End If

                Timer1.Stop()
                row2(i).visible = True
            Next
            checkright2()
            checkwin()

        End If


        If n = 3 Then
            For i = 0 To row3.Length - 1
                If row3(i).backcolor = Color.White Then
                    number = rand.Next(1, 6)
                    If number = 1 Then
                        row3(i).backcolor = Color1.BackColor
                    ElseIf number = 2 Then
                        row3(i).backcolor = Color2.BackColor
                    ElseIf number = 3 Then
                        row3(i).backcolor = Color3.BackColor
                    ElseIf number = 4 Then
                        row3(i).backcolor = Color4.BackColor
                    ElseIf number = 5 Then
                        row3(i).backcolor = color5.BackColor
                    End If
                End If

                Timer1.Stop()
                row3(i).visible = True
            Next

            checkright3()
            checkwin()
        End If
        If n = 4 Then
            For i = 0 To row3.Length - 1
                If row4(i).backcolor = Color.White Then
                    number = rand.Next(1, 6)
                    If number = 1 Then
                        row4(i).backcolor = Color1.BackColor
                    ElseIf number = 2 Then
                        row4(i).backcolor = Color2.BackColor
                    ElseIf number = 3 Then
                        row4(i).backcolor = Color3.BackColor
                    ElseIf number = 4 Then
                        row4(i).backcolor = Color4.BackColor
                    ElseIf number = 5 Then
                        row4(i).backcolor = color5.BackColor
                    End If
                End If
                Timer1.Stop()
                row4(i).visible = True
            Next

            checkright4()
            checkwin()
        End If

        If n = 5 Then
            For i = 0 To row3.Length - 1
                If row5(i).backcolor = Color.White Then
                    number = rand.Next(1, 6)
                    If number = 1 Then
                        row5(i).backcolor = Color1.BackColor
                    ElseIf number = 2 Then
                        row5(i).backcolor = Color2.BackColor
                    ElseIf number = 3 Then
                        row5(i).backcolor = Color3.BackColor
                    ElseIf number = 4 Then
                        row5(i).backcolor = Color4.BackColor
                    ElseIf number = 5 Then
                        row5(i).backcolor = color5.BackColor
                    End If
                End If
                Timer1.Stop()
                row5(i).visible = True
            Next

            checkright5()
            checkwin()
        End If
        If n = 6 Then
            For i = 0 To row3.Length - 1
                If row6(i).backcolor = Color.White Then
                    number = rand.Next(1, 6)
                    If number = 1 Then
                        row6(i).backcolor = Color1.BackColor
                    ElseIf number = 2 Then
                        row6(i).backcolor = Color2.BackColor
                    ElseIf number = 3 Then
                        row6(i).backcolor = Color3.BackColor
                    ElseIf number = 4 Then
                        row6(i).backcolor = Color4.BackColor
                    ElseIf number = 5 Then
                        row6(i).backcolor = color5.BackColor
                    End If
                End If
                Timer1.Stop()
                row6(i).visible = True
            Next

            checkright6()
            checkwin()
        End If
        If n = 7 Then
            For i = 0 To row3.Length - 1
                If row7(i).backcolor = Color.White Then
                    number = rand.Next(1, 6)
                    If number = 1 Then
                        row7(i).backcolor = Color1.BackColor
                    ElseIf number = 2 Then
                        row7(i).backcolor = Color2.BackColor
                    ElseIf number = 3 Then
                        row7(i).backcolor = Color3.BackColor
                    ElseIf number = 4 Then
                        row7(i).backcolor = Color4.BackColor
                    ElseIf number = 5 Then
                        row7(i).backcolor = color5.BackColor
                    End If
                End If
                Timer1.Stop()
                row7(i).visible = True
            Next

            checkright7()
            checkwin()
        End If
        If n = 8 Then
            For i = 0 To row3.Length - 1
                If row8(i).backcolor = Color.White Then
                    number = rand.Next(1, 6)
                    If number = 1 Then
                        row8(i).backcolor = Color1.BackColor
                    ElseIf number = 2 Then
                        row8(i).backcolor = Color2.BackColor
                    ElseIf number = 3 Then
                        row8(i).backcolor = Color3.BackColor
                    ElseIf number = 4 Then
                        row8(i).backcolor = Color4.BackColor
                    ElseIf number = 5 Then
                        row8(i).backcolor = color5.BackColor
                    End If
                End If
                Timer1.Stop()
                row8(i).visible = True
            Next

            checkright8()
            checkwin()
        End If
        If n = 9 Then
            For i = 0 To row3.Length - 1
                If row9(i).backcolor = Color.White Then
                    number = rand.Next(1, 6)
                    If number = 1 Then
                        row9(i).backcolor = Color1.BackColor
                    ElseIf number = 2 Then
                        row9(i).backcolor = Color2.BackColor
                    ElseIf number = 3 Then
                        row9(i).backcolor = Color3.BackColor
                    ElseIf number = 4 Then
                        row9(i).backcolor = Color4.BackColor
                    ElseIf number = 5 Then
                        row9(i).backcolor = color5.BackColor
                    End If
                End If
                Timer1.Stop()
                row9(i).visible = True
            Next

            checkright9()
            checkwin()
        End If
        If n = 10 Then
            For i = 0 To row3.Length - 1
                If row10(i).backcolor = Color.White Then
                    number = rand.Next(1, 6)
                    If number = 1 Then
                        row10(i).backcolor = Color1.BackColor
                    ElseIf number = 2 Then
                        row10(i).backcolor = Color2.BackColor
                    ElseIf number = 3 Then
                        row10(i).backcolor = Color3.BackColor
                    ElseIf number = 4 Then
                        row10(i).backcolor = Color4.BackColor
                    ElseIf number = 5 Then
                        row10(i).backcolor = color5.BackColor
                    End If
                End If
                Timer1.Stop()
                row10(i).visible = True
            Next

            checkright10()
            checkwin()
        End If



    End Sub

    Private Sub checkright1()
        If h37.BackColor = a1.BackColor Then
            circle1.BackColor = Color.Black
            h33.BackColor = a1.BackColor
            h29.BackColor = a1.BackColor
            h25.BackColor = a1.BackColor
            h21.BackColor = a1.BackColor
            h17.BackColor = a1.BackColor
            h13.BackColor = a1.BackColor
            h9.BackColor = a1.BackColor
            h5.BackColor = a1.BackColor
            h1.BackColor = a1.BackColor
        ElseIf h37.BackColor = a2.BackColor Or h37.BackColor = a3.BackColor Or h37.BackColor = a4.BackColor Then
            circle1.BackColor = Color.MediumPurple
        End If
        If h38.BackColor = a2.BackColor Then
            circle2.BackColor = Color.Black
            h34.BackColor = a2.BackColor
            h30.BackColor = a2.BackColor
            h26.BackColor = a2.BackColor
            h22.BackColor = a2.BackColor
            h18.BackColor = a2.BackColor
            h14.BackColor = a2.BackColor
            h10.BackColor = a2.BackColor
            h6.BackColor = a2.BackColor
            h2.BackColor = a2.BackColor
        ElseIf h38.BackColor = a1.BackColor Or h38.BackColor = a3.BackColor Or h38.BackColor = a4.BackColor Then
            circle2.BackColor = Color.MediumPurple
        End If
        If h39.BackColor = a3.BackColor Then
            circle3.BackColor = Color.Black
            h35.BackColor = a3.BackColor
            h31.BackColor = a3.BackColor
            h27.BackColor = a3.BackColor
            h23.BackColor = a3.BackColor
            h19.BackColor = a3.BackColor
            h15.BackColor = a3.BackColor
            h11.BackColor = a3.BackColor
            h7.BackColor = a3.BackColor
            h3.BackColor = a3.BackColor
        ElseIf h39.BackColor = a1.BackColor Or h39.BackColor = a2.BackColor Or h39.BackColor = a4.BackColor Then
            circle3.BackColor = Color.MediumPurple
        End If
        If h40.BackColor = a4.BackColor Then
            circle4.BackColor = Color.Black
            h36.BackColor = a4.BackColor
            h32.BackColor = a4.BackColor
            h28.BackColor = a4.BackColor
            h24.BackColor = a4.BackColor
            h20.BackColor = a4.BackColor
            h16.BackColor = a4.BackColor
            h12.BackColor = a4.BackColor
            h8.BackColor = a4.BackColor
            h4.BackColor = a4.BackColor
        ElseIf h40.BackColor = a1.BackColor Or h40.BackColor = a2.BackColor Or h40.BackColor = a3.BackColor Then
            circle4.BackColor = Color.MediumPurple
        End If


    End Sub

    Private Sub color5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles color5.Click
        If colorone = False Then
            a1.BackColor = color5.BackColor
            colorone = True
        ElseIf colortwo = False Then
            a2.BackColor = color5.BackColor
            colortwo = True
        ElseIf colorthree = False Then
            a3.BackColor = color5.BackColor
            colorthree = True
        ElseIf colorfour = False Then
            a4.BackColor = color5.BackColor
            colorfour = True
        End If
    End Sub

    Private Sub checkright2()
        If h33.BackColor = a1.BackColor Then
            circle7.BackColor = Color.Black
            h29.BackColor = a1.BackColor
            h25.BackColor = a1.BackColor
            h21.BackColor = a1.BackColor
            h17.BackColor = a1.BackColor
            h13.BackColor = a1.BackColor
            h9.BackColor = a1.BackColor
            h5.BackColor = a1.BackColor
            h1.BackColor = a1.BackColor
        ElseIf h33.BackColor = a2.BackColor Or h33.BackColor = a3.BackColor Or h33.BackColor = a4.BackColor Then
            circle7.BackColor = Color.MediumPurple
        End If
        If h34.BackColor = a2.BackColor Then
            circle8.BackColor = Color.Black
            h30.BackColor = a2.BackColor
            h26.BackColor = a2.BackColor
            h22.BackColor = a2.BackColor
            h18.BackColor = a2.BackColor
            h14.BackColor = a2.BackColor
            h10.BackColor = a2.BackColor
            h6.BackColor = a2.BackColor
            h2.BackColor = a2.BackColor
        ElseIf h34.BackColor = a1.BackColor Or h34.BackColor = a3.BackColor Or h34.BackColor = a4.BackColor Then
            circle8.BackColor = Color.MediumPurple
        End If
        If h35.BackColor = a3.BackColor Then
            circle5.BackColor = Color.Black
            h31.BackColor = a3.BackColor
            h27.BackColor = a3.BackColor
            h23.BackColor = a3.BackColor
            h19.BackColor = a3.BackColor
            h15.BackColor = a3.BackColor
            h11.BackColor = a3.BackColor
            h7.BackColor = a3.BackColor
            h3.BackColor = a3.BackColor
        ElseIf h35.BackColor = a1.BackColor Or h35.BackColor = a2.BackColor Or h35.BackColor = a4.BackColor Then
            circle5.BackColor = Color.MediumPurple
        End If
        If h36.BackColor = a4.BackColor Then
            circle6.BackColor = Color.Black
            h32.BackColor = a4.BackColor
            h28.BackColor = a4.BackColor
            h24.BackColor = a4.BackColor
            h20.BackColor = a4.BackColor
            h16.BackColor = a4.BackColor
            h12.BackColor = a4.BackColor
            h8.BackColor = a4.BackColor
            h4.BackColor = a4.BackColor
        ElseIf h36.BackColor = a1.BackColor Or h36.BackColor = a2.BackColor Or h36.BackColor = a3.BackColor Then
            circle6.BackColor = Color.MediumPurple
        End If
    End Sub
    Private Sub checkright3()
        If h29.BackColor = a1.BackColor Then
            circle11.BackColor = Color.Black
            h25.BackColor = a1.BackColor
            h21.BackColor = a1.BackColor
            h17.BackColor = a1.BackColor
            h13.BackColor = a1.BackColor
            h9.BackColor = a1.BackColor
            h5.BackColor = a1.BackColor
            h1.BackColor = a1.BackColor
        ElseIf h29.BackColor = a2.BackColor Or h29.BackColor = a3.BackColor Or h29.BackColor = a4.BackColor Then
            circle11.BackColor = Color.MediumPurple
        End If
        If h30.BackColor = a2.BackColor Then
            circle12.BackColor = Color.Black
            h26.BackColor = a2.BackColor
            h22.BackColor = a2.BackColor
            h18.BackColor = a2.BackColor
            h14.BackColor = a2.BackColor
            h10.BackColor = a2.BackColor
            h6.BackColor = a2.BackColor
            h2.BackColor = a2.BackColor
        ElseIf h30.BackColor = a1.BackColor Or h30.BackColor = a3.BackColor Or h30.BackColor = a4.BackColor Then
            circle12.BackColor = Color.MediumPurple
        End If
        If h31.BackColor = a3.BackColor Then
            circle9.BackColor = Color.Black
            h27.BackColor = a3.BackColor
            h23.BackColor = a3.BackColor
            h19.BackColor = a3.BackColor
            h15.BackColor = a3.BackColor
            h11.BackColor = a3.BackColor
            h7.BackColor = a3.BackColor
            h3.BackColor = a3.BackColor
        ElseIf h31.BackColor = a1.BackColor Or h31.BackColor = a2.BackColor Or h31.BackColor = a4.BackColor Then
            circle9.BackColor = Color.MediumPurple
        End If
        If h32.BackColor = a4.BackColor Then
            circle10.BackColor = Color.Black
            h28.BackColor = a4.BackColor
            h24.BackColor = a4.BackColor
            h20.BackColor = a4.BackColor
            h16.BackColor = a4.BackColor
            h12.BackColor = a4.BackColor
            h8.BackColor = a4.BackColor
            h4.BackColor = a4.BackColor
        ElseIf h32.BackColor = a1.BackColor Or h32.BackColor = a2.BackColor Or h32.BackColor = a3.BackColor Then
            circle10.BackColor = Color.MediumPurple
        End If
    End Sub
    Private Sub checkright4()
        If h25.BackColor = a1.BackColor Then
            circle15.BackColor = Color.Black
            h21.BackColor = a1.BackColor
            h17.BackColor = a1.BackColor
            h13.BackColor = a1.BackColor
            h9.BackColor = a1.BackColor
            h5.BackColor = a1.BackColor
            h1.BackColor = a1.BackColor
        ElseIf h25.BackColor = a2.BackColor Or h25.BackColor = a3.BackColor Or h25.BackColor = a4.BackColor Then
            circle15.BackColor = Color.MediumPurple
        End If
        If h26.BackColor = a2.BackColor Then
            circle16.BackColor = Color.Black
            h22.BackColor = a2.BackColor
            h18.BackColor = a2.BackColor
            h14.BackColor = a2.BackColor
            h10.BackColor = a2.BackColor
            h6.BackColor = a2.BackColor
            h2.BackColor = a2.BackColor
        ElseIf h26.BackColor = a1.BackColor Or h26.BackColor = a3.BackColor Or h26.BackColor = a4.BackColor Then
            circle16.BackColor = Color.MediumPurple
        End If
        If h27.BackColor = a3.BackColor Then
            circle13.BackColor = Color.Black
            h23.BackColor = a3.BackColor
            h19.BackColor = a3.BackColor
            h15.BackColor = a3.BackColor
            h11.BackColor = a3.BackColor
            h7.BackColor = a3.BackColor
            h3.BackColor = a3.BackColor
        ElseIf h27.BackColor = a1.BackColor Or h27.BackColor = a2.BackColor Or h27.BackColor = a4.BackColor Then
            circle13.BackColor = Color.MediumPurple
        End If
        If h28.BackColor = a4.BackColor Then
            circle14.BackColor = Color.Black
            h24.BackColor = a4.BackColor
            h20.BackColor = a4.BackColor
            h16.BackColor = a4.BackColor
            h12.BackColor = a4.BackColor
            h8.BackColor = a4.BackColor
            h4.BackColor = a4.BackColor
        ElseIf h28.BackColor = a1.BackColor Or h28.BackColor = a2.BackColor Or h28.BackColor = a3.BackColor Then
            circle14.BackColor = Color.MediumPurple
        End If
    End Sub
    Private Sub checkright5()
        If h21.BackColor = a1.BackColor Then
            circle19.BackColor = Color.Black
            h17.BackColor = a1.BackColor
            h13.BackColor = a1.BackColor
            h9.BackColor = a1.BackColor
            h5.BackColor = a1.BackColor
            h1.BackColor = a1.BackColor
        ElseIf h21.BackColor = a2.BackColor Or h21.BackColor = a3.BackColor Or h21.BackColor = a4.BackColor Then
            circle19.BackColor = Color.MediumPurple
        End If
        If h22.BackColor = a2.BackColor Then
            circle20.BackColor = Color.Black
            h18.BackColor = a2.BackColor
            h14.BackColor = a2.BackColor
            h10.BackColor = a2.BackColor
            h6.BackColor = a2.BackColor
            h2.BackColor = a2.BackColor
        ElseIf h22.BackColor = a1.BackColor Or h22.BackColor = a3.BackColor Or h22.BackColor = a4.BackColor Then
            circle20.BackColor = Color.MediumPurple
        End If
        If h23.BackColor = a3.BackColor Then
            circle17.BackColor = Color.Black
            h19.BackColor = a3.BackColor
            h15.BackColor = a3.BackColor
            h11.BackColor = a3.BackColor
            h7.BackColor = a3.BackColor
            h3.BackColor = a3.BackColor
        ElseIf h23.BackColor = a1.BackColor Or h23.BackColor = a2.BackColor Or h23.BackColor = a4.BackColor Then
            circle17.BackColor = Color.MediumPurple
        End If
        If h24.BackColor = a4.BackColor Then
            circle18.BackColor = Color.Black
            h20.BackColor = a4.BackColor
            h16.BackColor = a4.BackColor
            h12.BackColor = a4.BackColor
            h8.BackColor = a4.BackColor
            h4.BackColor = a4.BackColor
        ElseIf h24.BackColor = a1.BackColor Or h24.BackColor = a2.BackColor Or h24.BackColor = a3.BackColor Then
            circle18.BackColor = Color.MediumPurple
        End If
    End Sub
    Private Sub checkright6()
        If h17.BackColor = a1.BackColor Then
            circle23.BackColor = Color.Black
            h13.BackColor = a1.BackColor
            h9.BackColor = a1.BackColor
            h5.BackColor = a1.BackColor
            h1.BackColor = a1.BackColor
        ElseIf h17.BackColor = a2.BackColor Or h17.BackColor = a3.BackColor Or h17.BackColor = a4.BackColor Then
            circle23.BackColor = Color.MediumPurple
        End If
        If h18.BackColor = a2.BackColor Then
            circle24.BackColor = Color.Black
            h14.BackColor = a2.BackColor
            h10.BackColor = a2.BackColor
            h6.BackColor = a2.BackColor
            h2.BackColor = a2.BackColor
        ElseIf h18.BackColor = a1.BackColor Or h18.BackColor = a3.BackColor Or h18.BackColor = a4.BackColor Then
            circle24.BackColor = Color.MediumPurple
        End If
        If h19.BackColor = a3.BackColor Then
            circle21.BackColor = Color.Black
            h15.BackColor = a3.BackColor
            h11.BackColor = a3.BackColor
            h7.BackColor = a3.BackColor
            h3.BackColor = a3.BackColor
        ElseIf h19.BackColor = a1.BackColor Or h19.BackColor = a2.BackColor Or h19.BackColor = a4.BackColor Then
            circle21.BackColor = Color.MediumPurple
        End If
        If h20.BackColor = a4.BackColor Then
            circle22.BackColor = Color.Black
            h16.BackColor = a4.BackColor
            h12.BackColor = a4.BackColor
            h8.BackColor = a4.BackColor
            h4.BackColor = a4.BackColor
        ElseIf h20.BackColor = a1.BackColor Or h20.BackColor = a2.BackColor Or h20.BackColor = a3.BackColor Then
            circle22.BackColor = Color.MediumPurple
        End If
    End Sub
    Private Sub checkright7()
        If h13.BackColor = a1.BackColor Then
            circle27.BackColor = Color.Black
            h9.BackColor = a1.BackColor
            h5.BackColor = a1.BackColor
            h1.BackColor = a1.BackColor
        ElseIf h13.BackColor = a2.BackColor Or h13.BackColor = a3.BackColor Or h13.BackColor = a4.BackColor Then
            circle27.BackColor = Color.MediumPurple
        End If
        If h14.BackColor = a2.BackColor Then
            circle28.BackColor = Color.Black
            h14.BackColor = a2.BackColor
            h10.BackColor = a2.BackColor
            h6.BackColor = a2.BackColor
            h2.BackColor = a2.BackColor
        ElseIf h14.BackColor = a1.BackColor Or h14.BackColor = a3.BackColor Or h14.BackColor = a4.BackColor Then
            circle28.BackColor = Color.MediumPurple
        End If
        If h15.BackColor = a3.BackColor Then
            circle25.BackColor = Color.Black
            h11.BackColor = a3.BackColor
            h7.BackColor = a3.BackColor
            h3.BackColor = a3.BackColor
        ElseIf h15.BackColor = a1.BackColor Or h15.BackColor = a2.BackColor Or h15.BackColor = a4.BackColor Then
            circle25.BackColor = Color.MediumPurple
        End If
        If h16.BackColor = a4.BackColor Then
            circle26.BackColor = Color.Black
            h12.BackColor = a4.BackColor
            h8.BackColor = a4.BackColor
            h4.BackColor = a4.BackColor
        ElseIf h16.BackColor = a1.BackColor Or h16.BackColor = a2.BackColor Or h16.BackColor = a3.BackColor Then
            circle26.BackColor = Color.MediumPurple
        End If
    End Sub
    Private Sub checkright8()
        If h9.BackColor = a1.BackColor Then
            circle31.BackColor = Color.Black
            h5.BackColor = a1.BackColor
            h1.BackColor = a1.BackColor
        ElseIf h9.BackColor = a2.BackColor Or h9.BackColor = a3.BackColor Or h9.BackColor = a4.BackColor Then
            circle31.BackColor = Color.MediumPurple
        End If
        If h10.BackColor = a2.BackColor Then
            circle32.BackColor = Color.Black
            h6.BackColor = a2.BackColor
            h2.BackColor = a2.BackColor
        ElseIf h10.BackColor = a1.BackColor Or h10.BackColor = a3.BackColor Or h10.BackColor = a4.BackColor Then
            circle32.BackColor = Color.MediumPurple
        End If
        If h11.BackColor = a3.BackColor Then
            circle29.BackColor = Color.Black
            h7.BackColor = a3.BackColor
            h3.BackColor = a3.BackColor
        ElseIf h11.BackColor = a1.BackColor Or h11.BackColor = a2.BackColor Or h11.BackColor = a4.BackColor Then
            circle29.BackColor = Color.MediumPurple
        End If
        If h12.BackColor = a4.BackColor Then
            circle30.BackColor = Color.Black
            h8.BackColor = a4.BackColor
            h4.BackColor = a4.BackColor
        ElseIf h12.BackColor = a1.BackColor Or h12.BackColor = a2.BackColor Or h12.BackColor = a3.BackColor Then
            circle30.BackColor = Color.MediumPurple
        End If
    End Sub
    Private Sub checkright9()
        If h5.BackColor = a1.BackColor Then
            OvalShape1.BackColor = Color.Black
            h1.BackColor = a1.BackColor
        ElseIf h5.BackColor = a2.BackColor Or h5.BackColor = a3.BackColor Or h5.BackColor = a4.BackColor Then
            OvalShape1.BackColor = Color.MediumPurple
        End If
        If h6.BackColor = a2.BackColor Then
            circle36.BackColor = Color.Black
            h2.BackColor = a2.BackColor
        ElseIf h6.BackColor = a1.BackColor Or h6.BackColor = a3.BackColor Or h6.BackColor = a4.BackColor Then
            circle36.BackColor = Color.MediumPurple
        End If
        If h7.BackColor = a3.BackColor Then
            circle33.BackColor = Color.Black
            h3.BackColor = a3.BackColor
        ElseIf h7.BackColor = a1.BackColor Or h7.BackColor = a2.BackColor Or h7.BackColor = a4.BackColor Then
            circle33.BackColor = Color.MediumPurple
        End If
        If h8.BackColor = a4.BackColor Then
            circle34.BackColor = Color.Black
            h4.BackColor = a4.BackColor
        ElseIf h8.BackColor = a1.BackColor Or h8.BackColor = a2.BackColor Or h8.BackColor = a3.BackColor Then
            circle34.BackColor = Color.MediumPurple
        End If
    End Sub
    Private Sub checkright10()
        If h1.BackColor = a1.BackColor Then
            circle39.BackColor = Color.Black
        ElseIf h1.BackColor = a2.BackColor Or h1.BackColor = a3.BackColor Or h1.BackColor = a4.BackColor Then
            circle39.BackColor = Color.MediumPurple
        End If
        If h2.BackColor = a2.BackColor Then
            circle40.BackColor = Color.Black
        ElseIf h2.BackColor = a1.BackColor Or h2.BackColor = a3.BackColor Or h2.BackColor = a4.BackColor Then
            circle40.BackColor = Color.MediumPurple
        End If
        If h3.BackColor = a3.BackColor Then
            circle37.BackColor = Color.Black
        ElseIf h3.BackColor = a1.BackColor Or h3.BackColor = a2.BackColor Or h3.BackColor = a4.BackColor Then
            circle37.BackColor = Color.MediumPurple
        End If
        If h4.BackColor = a4.BackColor Then
            circle38.BackColor = Color.Black
        ElseIf h4.BackColor = a1.BackColor Or h4.BackColor = a2.BackColor Or h4.BackColor = a3.BackColor Then
            circle38.BackColor = Color.MediumPurple
        End If
    End Sub
    Private Sub checkwin()
        If circle1.BackColor = Color.Black And circle2.BackColor = Color.Black And circle3.BackColor = Color.Black And circle4.BackColor = Color.Black Then
            Button1.Enabled = False
            Label2.Text = "Game over"
        ElseIf circle5.BackColor = Color.Black And circle6.BackColor = Color.Black And circle7.BackColor = Color.Black And circle8.BackColor = Color.Black Then
            Button1.Enabled = False
            Label2.Text = "Game over"
        ElseIf circle9.BackColor = Color.Black And circle10.BackColor = Color.Black And circle11.BackColor = Color.Black And circle12.BackColor = Color.Black Then
            Button1.Enabled = False
            Label2.Text = "Game over"
        ElseIf circle13.BackColor = Color.Black And circle14.BackColor = Color.Black And circle15.BackColor = Color.Black And circle16.BackColor = Color.Black Then
            Button1.Enabled = False
            Label2.Text = "Game over"
        ElseIf circle17.BackColor = Color.Black And circle18.BackColor = Color.Black And circle19.BackColor = Color.Black And circle20.BackColor = Color.Black Then
            Button1.Enabled = False
            Label2.Text = "Game over"
        ElseIf circle21.BackColor = Color.Black And circle22.BackColor = Color.Black And circle23.BackColor = Color.Black And circle24.BackColor = Color.Black Then
            Button1.Enabled = False
            Label2.Text = "Game over"
        ElseIf circle25.BackColor = Color.Black And circle26.BackColor = Color.Black And circle27.BackColor = Color.Black And circle28.BackColor = Color.Black Then
            Button1.Enabled = False
            Label2.Text = "Game over"
        ElseIf circle29.BackColor = Color.Black And circle30.BackColor = Color.Black And circle31.BackColor = Color.Black And circle32.BackColor = Color.Black Then
            Button1.Enabled = False
            Label2.Text = "Game over"
        ElseIf circle33.BackColor = Color.Black And circle34.BackColor = Color.Black And OvalShape1.BackColor = Color.Black And circle36.BackColor = Color.Black Then
            Button1.Enabled = False
            Label2.Text = "Game over"
        ElseIf circle37.BackColor = Color.Black And circle38.BackColor = Color.Black And circle39.BackColor = Color.Black And circle40.BackColor = Color.Black Then
            Button1.Enabled = False
            Label2.Text = "Game over"

        End If


    End Sub
End Class
