
Public Class Form1
    Dim SurvivalTinc, SerendipityPot, ApprenticeForm, MasterLetter, ScrollOfRefle, SerendipityPotCustom As Integer
    Dim GradeChanceNumber As Integer
    Dim CurrentGrade As Integer
    Dim Result As Integer
    Dim RandomNumber As Integer







    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        CurrentGrade = Convert.ToInt32(Label_Level.Text)


        If CurrentGrade = 24 Then
            MsgBox("Maximum reached")
        End If





        If CurrentGrade < 24 Then
            EditLevelButton.Enabled = False
            Button1.Enabled = False
            Result = 0
            CheckBox1.Enabled = False
            CheckBox5.Enabled = False
            CheckBox2.Enabled = False
            CheckBox3.Enabled = False
            CheckBox4.Enabled = False
            CheckBoxSereCustom.Enabled = False
            SereCustomTextBox.Enabled = False
            TextBoxGrade0.Enabled = False
            TextBoxGrade1.Enabled = False
            TextBoxGrade2.Enabled = False
            TextBoxGrade3.Enabled = False
            TextBoxGrade4.Enabled = False
            TextBoxGrade5.Enabled = False
            TextBoxGrade6.Enabled = False
            TextBoxGrade7.Enabled = False
            TextBoxGrade8.Enabled = False
            TextBoxGrade9.Enabled = False
            TextBoxGrade10.Enabled = False
            TextBoxGrade11.Enabled = False
            TextBoxGrade12.Enabled = False
            TextBoxGrade13.Enabled = False
            TextBoxGrade14.Enabled = False
            TextBoxGrade15.Enabled = False
            TextBoxGrade16.Enabled = False
            TextBoxGrade17.Enabled = False
            TextBoxGrade18.Enabled = False
            TextBoxGrade19.Enabled = False
            TextBoxGrade20.Enabled = False
            TextBoxGrade21.Enabled = False
            TextBoxGrade22.Enabled = False
            TextBoxGrade23.Enabled = False



            Randomize()
            RandomNumber = CInt(Int((100 * Rnd()) + 1))

            If CheckBox1.Checked Then
                SurvivalTinc = 1
            End If
            If CheckBox1.Checked = False Then
                SurvivalTinc = 0
            End If

            If CheckBox5.Checked Then
                SerendipityPot = 1
            End If
            If CheckBox5.Checked = False Then
                SerendipityPot = 0
            End If

            If CheckBoxSereCustom.Checked Then
                SerendipityPotCustom = 1
            End If
            If CheckBoxSereCustom.Checked = False Then
                SerendipityPotCustom = 0
            End If

            If CheckBox2.Checked Then
                ApprenticeForm = 1
            End If
            If CheckBox2.Checked = False Then
                ApprenticeForm = 0
            End If

            If CheckBox3.Checked Then
                MasterLetter = 1
            End If
            If CheckBox3.Checked = False Then
                MasterLetter = 0
            End If

            If CheckBox4.Checked Then
                ScrollOfRefle = 1
            End If
            If CheckBox4.Checked = False Then
                ScrollOfRefle = 0
            End If

            CurrentGrade = Convert.ToInt32(Label_Level.Text)



            ' Check Grades
            If CurrentGrade = 0 Then
                GradeChanceNumber = Convert.ToInt32(TextBoxGrade0.Text)
            End If
            If CurrentGrade = 1 Then
                GradeChanceNumber = Convert.ToInt32(TextBoxGrade1.Text)
            End If
            If CurrentGrade = 2 Then
                GradeChanceNumber = Convert.ToInt32(TextBoxGrade2.Text)
            End If
            If CurrentGrade = 3 Then
                GradeChanceNumber = Convert.ToInt32(TextBoxGrade3.Text)
            End If
            If CurrentGrade = 4 Then
                GradeChanceNumber = Convert.ToInt32(TextBoxGrade4.Text)
            End If
            If CurrentGrade = 5 Then
                GradeChanceNumber = Convert.ToInt32(TextBoxGrade5.Text)
            End If
            If CurrentGrade = 6 Then
                GradeChanceNumber = Convert.ToInt32(TextBoxGrade6.Text)
            End If
            If CurrentGrade = 7 Then
                GradeChanceNumber = Convert.ToInt32(TextBoxGrade7.Text)
            End If
            If CurrentGrade = 8 Then
                GradeChanceNumber = Convert.ToInt32(TextBoxGrade8.Text)
            End If
            If CurrentGrade = 9 Then
                GradeChanceNumber = Convert.ToInt32(TextBoxGrade9.Text)
            End If
            If CurrentGrade = 10 Then
                GradeChanceNumber = Convert.ToInt32(TextBoxGrade10.Text)
            End If
            If CurrentGrade = 11 Then
                GradeChanceNumber = Convert.ToInt32(TextBoxGrade11.Text)
            End If
            If CurrentGrade = 12 Then
                GradeChanceNumber = Convert.ToInt32(TextBoxGrade12.Text)
            End If
            If CurrentGrade = 13 Then
                GradeChanceNumber = Convert.ToInt32(TextBoxGrade13.Text)
            End If
            If CurrentGrade = 14 Then
                GradeChanceNumber = Convert.ToInt32(TextBoxGrade14.Text)
            End If
            If CurrentGrade = 15 Then
                GradeChanceNumber = Convert.ToInt32(TextBoxGrade15.Text)
            End If
            If CurrentGrade = 16 Then
                GradeChanceNumber = Convert.ToInt32(TextBoxGrade16.Text)
            End If
            If CurrentGrade = 17 Then
                GradeChanceNumber = Convert.ToInt32(TextBoxGrade17.Text)
            End If
            If CurrentGrade = 18 Then
                GradeChanceNumber = Convert.ToInt32(TextBoxGrade18.Text)
            End If
            If CurrentGrade = 19 Then
                GradeChanceNumber = Convert.ToInt32(TextBoxGrade19.Text)
            End If
            If CurrentGrade = 20 Then
                GradeChanceNumber = Convert.ToInt32(TextBoxGrade20.Text)
            End If
            If CurrentGrade = 21 Then
                GradeChanceNumber = Convert.ToInt32(TextBoxGrade21.Text)
            End If
            If CurrentGrade = 22 Then
                GradeChanceNumber = Convert.ToInt32(TextBoxGrade22.Text)
            End If
            If CurrentGrade = 23 Then
                GradeChanceNumber = Convert.ToInt32(TextBoxGrade23.Text)
            End If






            If SerendipityPot = 0 And SerendipityPotCustom = 0 And RandomNumber >= (100 - GradeChanceNumber) Then
                Result = 1 'Hat geklappt
            End If

            If SerendipityPot = 1 And RandomNumber >= (100 - (GradeChanceNumber * 2)) Then
                Result = 1 'Hat geklappt
            End If

            If SerendipityPotCustom = 1 And RandomNumber >= (100 - (GradeChanceNumber + GradeChanceNumber * (Convert.ToInt32(SereCustomTextBox.Text) / 100))) Then
                Result = 1 'Hat geklappt
            End If

            If CheckBox2.Checked = True Or CheckBox3.Checked = True Or CheckBox4.Checked = True Then
                Timer1.Start()
            Else
                MsgBox("Select a formula!")
                EditLevelButton.Enabled = True
                Button1.Enabled = True
                CheckBox1.Enabled = True
                CheckBox5.Enabled = True
                CheckBox2.Enabled = True
                CheckBox3.Enabled = True
                CheckBox4.Enabled = True
                TextBoxGrade0.Enabled = True
                TextBoxGrade1.Enabled = True
                TextBoxGrade2.Enabled = True
                TextBoxGrade3.Enabled = True
                TextBoxGrade4.Enabled = True
                TextBoxGrade5.Enabled = True
                TextBoxGrade6.Enabled = True
                TextBoxGrade7.Enabled = True
                TextBoxGrade8.Enabled = True
                TextBoxGrade9.Enabled = True
                TextBoxGrade10.Enabled = True
                TextBoxGrade11.Enabled = True
                TextBoxGrade12.Enabled = True
                TextBoxGrade13.Enabled = True
                TextBoxGrade14.Enabled = True
                TextBoxGrade15.Enabled = True
                TextBoxGrade16.Enabled = True
                TextBoxGrade17.Enabled = True
                TextBoxGrade18.Enabled = True
                TextBoxGrade19.Enabled = True
                TextBoxGrade20.Enabled = True
                TextBoxGrade21.Enabled = True
                TextBoxGrade22.Enabled = True
                TextBoxGrade23.Enabled = True
                CheckBoxSereCustom.Enabled = True
                SereCustomTextBox.Enabled = True
            End If


        End If




























    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick

        If CheckBoxDisLoading.Checked = False Then
            ProgressBar1.Increment(10)
        End If

        If CheckBoxDisLoading.Checked = True Then
            ProgressBar1.Increment(100)
        End If

        If ProgressBar1.Value = 100 Then
            Timer1.Stop()
            If Result = 1 And MasterLetter = 0 And ScrollOfRefle = 0 And ApprenticeForm = 1 Then
                Label_Level.Text = CStr((Convert.ToInt32(Label_Level.Text)) + 1)
                CurrentGrade = Convert.ToInt32(Label_Level.Text)
                If CurrentGrade < 0 Then
                    Label_Level.Text = 0
                End If
                If CurrentGrade > 24 Then
                    Label_Level.Text = 24
                End If
                RichTextBox1.Text = ("Last upgrade was successful" + Environment.NewLine + RichTextBox1.Text)
                If CheckBoxResultMsgBox.Checked = False Then
                    MsgBox("Success")
                End If
            End If
            If Result = 1 And MasterLetter = 1 And ScrollOfRefle = 0 And ApprenticeForm = 0 Then
                Label_Level.Text = CStr((Convert.ToInt32(Label_Level.Text)) + CInt(Int((3 * Rnd()) + 1)))
                CurrentGrade = Convert.ToInt32(Label_Level.Text)
                If CurrentGrade < 0 Then
                    Label_Level.Text = 0
                End If
                If CurrentGrade > 24 Then
                    Label_Level.Text = 24
                End If
                RichTextBox1.Text = ("Last upgrade was successful" + Environment.NewLine + RichTextBox1.Text)
                If CheckBoxResultMsgBox.Checked = False Then
                    MsgBox("Success")
                End If
            End If
            If MasterLetter = 0 And ScrollOfRefle = 1 And ApprenticeForm = 0 Then
                Label_Level.Text = CStr((Convert.ToInt32(Label_Level.Text)) - 1)
                CurrentGrade = Convert.ToInt32(Label_Level.Text)
                If CurrentGrade < 0 Then
                    Label_Level.Text = 0
                End If
                If CurrentGrade > 24 Then
                    Label_Level.Text = 24
                End If
                RichTextBox1.Text = ("Last upgrade was successful" + Environment.NewLine + RichTextBox1.Text)
                If CheckBoxResultMsgBox.Checked = False Then
                    MsgBox("Success")
                End If
            End If
            'Tincs
            If Result = 0 And ScrollOfRefle = 0 And SurvivalTinc = 1 And RandomNumber <= 50 Then
                Label_Level.Text = CStr((Convert.ToInt32(Label_Level.Text)) - 0)
                CurrentGrade = Convert.ToInt32(Label_Level.Text)
                If CurrentGrade < 0 Then
                    Label_Level.Text = 0
                End If
                If CurrentGrade > 24 Then
                    Label_Level.Text = 24
                End If
            End If
            If Result = 0 And ScrollOfRefle = 0 And SurvivalTinc = 1 And RandomNumber >= 50 Then
                Label_Level.Text = CStr((Convert.ToInt32(Label_Level.Text)) - 1)
                CurrentGrade = Convert.ToInt32(Label_Level.Text)
                If CurrentGrade < 0 Then
                    Label_Level.Text = 0
                End If
                If CurrentGrade > 24 Then
                    Label_Level.Text = 24
                End If
            End If
            If Result = 0 And ScrollOfRefle = 0 Then
                RichTextBox1.Text = ("Last upgrade was not successful" + Environment.NewLine + RichTextBox1.Text)
                If CheckBoxResultMsgBox.Checked = False Then
                    MsgBox("Fail")
                End If
            End If
            If Result = 0 And SurvivalTinc = 0 Then
                Label_Level.Text = 0
            End If



            ProgressBar1.Value = 0


            Result = 0
            EditLevelButton.Enabled = True
            Button1.Enabled = True
            CheckBox1.Enabled = True
            CheckBox5.Enabled = True
            CheckBox2.Enabled = True
            CheckBox3.Enabled = True
            CheckBox4.Enabled = True
            TextBoxGrade0.Enabled = True
            TextBoxGrade1.Enabled = True
            TextBoxGrade2.Enabled = True
            TextBoxGrade3.Enabled = True
            TextBoxGrade4.Enabled = True
            TextBoxGrade5.Enabled = True
            TextBoxGrade6.Enabled = True
            TextBoxGrade7.Enabled = True
            TextBoxGrade8.Enabled = True
            TextBoxGrade9.Enabled = True
            TextBoxGrade10.Enabled = True
            TextBoxGrade11.Enabled = True
            TextBoxGrade12.Enabled = True
            TextBoxGrade13.Enabled = True
            TextBoxGrade14.Enabled = True
            TextBoxGrade15.Enabled = True
            TextBoxGrade16.Enabled = True
            TextBoxGrade17.Enabled = True
            TextBoxGrade18.Enabled = True
            TextBoxGrade19.Enabled = True
            TextBoxGrade20.Enabled = True
            TextBoxGrade21.Enabled = True
            TextBoxGrade22.Enabled = True
            TextBoxGrade23.Enabled = True
            CheckBoxSereCustom.Enabled = True
            SereCustomTextBox.Enabled = True
        End If
    End Sub












    Private Sub CheckBox2_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox2.CheckedChanged
        CheckBox3.Checked = False
        CheckBox4.Checked = False

    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox3.CheckedChanged
        CheckBox2.Checked = False
        CheckBox4.Checked = False

    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox4.CheckedChanged
        CheckBox2.Checked = False
        CheckBox3.Checked = False

    End Sub






    Private Sub Timer2_Tick(sender As System.Object, e As System.EventArgs) Handles Timer2.Tick
        If CurrentGrade = 0 Then
            GradeChanceNumber = Convert.ToInt32(TextBoxGrade0.Text)
        End If
        If CurrentGrade = 1 Then
            GradeChanceNumber = Convert.ToInt32(TextBoxGrade1.Text)
        End If
        If CurrentGrade = 2 Then
            GradeChanceNumber = Convert.ToInt32(TextBoxGrade2.Text)
        End If
        If CurrentGrade = 3 Then
            GradeChanceNumber = Convert.ToInt32(TextBoxGrade3.Text)
        End If
        If CurrentGrade = 4 Then
            GradeChanceNumber = Convert.ToInt32(TextBoxGrade4.Text)
        End If
        If CurrentGrade = 5 Then
            GradeChanceNumber = Convert.ToInt32(TextBoxGrade5.Text)
        End If
        If CurrentGrade = 6 Then
            GradeChanceNumber = Convert.ToInt32(TextBoxGrade6.Text)
        End If
        If CurrentGrade = 7 Then
            GradeChanceNumber = Convert.ToInt32(TextBoxGrade7.Text)
        End If
        If CurrentGrade = 8 Then
            GradeChanceNumber = Convert.ToInt32(TextBoxGrade8.Text)
        End If
        If CurrentGrade = 9 Then
            GradeChanceNumber = Convert.ToInt32(TextBoxGrade9.Text)
        End If
        If CurrentGrade = 10 Then
            GradeChanceNumber = Convert.ToInt32(TextBoxGrade10.Text)
        End If
        If CurrentGrade = 11 Then
            GradeChanceNumber = Convert.ToInt32(TextBoxGrade11.Text)
        End If
        If CurrentGrade = 12 Then
            GradeChanceNumber = Convert.ToInt32(TextBoxGrade12.Text)
        End If
        If CurrentGrade = 13 Then
            GradeChanceNumber = Convert.ToInt32(TextBoxGrade13.Text)
        End If
        If CurrentGrade = 14 Then
            GradeChanceNumber = Convert.ToInt32(TextBoxGrade14.Text)
        End If
        If CurrentGrade = 15 Then
            GradeChanceNumber = Convert.ToInt32(TextBoxGrade15.Text)
        End If
        If CurrentGrade = 16 Then
            GradeChanceNumber = Convert.ToInt32(TextBoxGrade16.Text)
        End If
        If CurrentGrade = 17 Then
            GradeChanceNumber = Convert.ToInt32(TextBoxGrade17.Text)
        End If
        If CurrentGrade = 18 Then
            GradeChanceNumber = Convert.ToInt32(TextBoxGrade18.Text)
        End If
        If CurrentGrade = 19 Then
            GradeChanceNumber = Convert.ToInt32(TextBoxGrade19.Text)
        End If
        If CurrentGrade = 20 Then
            GradeChanceNumber = Convert.ToInt32(TextBoxGrade20.Text)
        End If
        If CurrentGrade = 21 Then
            GradeChanceNumber = Convert.ToInt32(TextBoxGrade21.Text)
        End If
        If CurrentGrade = 22 Then
            GradeChanceNumber = Convert.ToInt32(TextBoxGrade22.Text)
        End If
        If CurrentGrade = 23 Then
            GradeChanceNumber = Convert.ToInt32(TextBoxGrade23.Text)
        End If


        If SerendipityPot = 0 And SerendipityPotCustom = 0 Then
            TextBox1.Text = GradeChanceNumber
        End If

        If SerendipityPot = 1 And SerendipityPotCustom = 0 Then
            TextBox1.Text = GradeChanceNumber * 2
        End If

        If SerendipityPotCustom = 1 And SerendipityPot = 0 Then
            TextBox1.Text = GradeChanceNumber + (GradeChanceNumber * (Convert.ToInt32(SereCustomTextBox.Text) / 100))
        End If



    End Sub

    Private Sub CheckBox5_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox5.CheckedChanged
        CheckBoxSereCustom.Checked = False
        If CheckBox5.Checked Then
            SerendipityPot = 1
        End If
        If CheckBox5.Checked = False Then
            SerendipityPot = 0
        End If

        If CheckBoxSereCustom.Checked Then
            SerendipityPotCustom = 1
        End If
        If CheckBoxSereCustom.Checked = False Then
            SerendipityPotCustom = 0
        End If

        If CurrentGrade = 0 Then
            GradeChanceNumber = Convert.ToInt32(TextBoxGrade0.Text)
        End If
        If CurrentGrade = 1 Then
            GradeChanceNumber = Convert.ToInt32(TextBoxGrade1.Text)
        End If
        If CurrentGrade = 2 Then
            GradeChanceNumber = Convert.ToInt32(TextBoxGrade2.Text)
        End If
        If CurrentGrade = 3 Then
            GradeChanceNumber = Convert.ToInt32(TextBoxGrade3.Text)
        End If
        If CurrentGrade = 4 Then
            GradeChanceNumber = Convert.ToInt32(TextBoxGrade4.Text)
        End If
        If CurrentGrade = 5 Then
            GradeChanceNumber = Convert.ToInt32(TextBoxGrade5.Text)
        End If
        If CurrentGrade = 6 Then
            GradeChanceNumber = Convert.ToInt32(TextBoxGrade6.Text)
        End If
        If CurrentGrade = 7 Then
            GradeChanceNumber = Convert.ToInt32(TextBoxGrade7.Text)
        End If
        If CurrentGrade = 8 Then
            GradeChanceNumber = Convert.ToInt32(TextBoxGrade8.Text)
        End If
        If CurrentGrade = 9 Then
            GradeChanceNumber = Convert.ToInt32(TextBoxGrade9.Text)
        End If
        If CurrentGrade = 10 Then
            GradeChanceNumber = Convert.ToInt32(TextBoxGrade10.Text)
        End If
        If CurrentGrade = 11 Then
            GradeChanceNumber = Convert.ToInt32(TextBoxGrade11.Text)
        End If
        If CurrentGrade = 12 Then
            GradeChanceNumber = Convert.ToInt32(TextBoxGrade12.Text)
        End If
        If CurrentGrade = 13 Then
            GradeChanceNumber = Convert.ToInt32(TextBoxGrade13.Text)
        End If
        If CurrentGrade = 14 Then
            GradeChanceNumber = Convert.ToInt32(TextBoxGrade14.Text)
        End If
        If CurrentGrade = 15 Then
            GradeChanceNumber = Convert.ToInt32(TextBoxGrade15.Text)
        End If
        If CurrentGrade = 16 Then
            GradeChanceNumber = Convert.ToInt32(TextBoxGrade16.Text)
        End If
        If CurrentGrade = 17 Then
            GradeChanceNumber = Convert.ToInt32(TextBoxGrade17.Text)
        End If
        If CurrentGrade = 18 Then
            GradeChanceNumber = Convert.ToInt32(TextBoxGrade18.Text)
        End If
        If CurrentGrade = 19 Then
            GradeChanceNumber = Convert.ToInt32(TextBoxGrade19.Text)
        End If
        If CurrentGrade = 20 Then
            GradeChanceNumber = Convert.ToInt32(TextBoxGrade20.Text)
        End If
        If CurrentGrade = 21 Then
            GradeChanceNumber = Convert.ToInt32(TextBoxGrade21.Text)
        End If
        If CurrentGrade = 22 Then
            GradeChanceNumber = Convert.ToInt32(TextBoxGrade22.Text)
        End If
        If CurrentGrade = 23 Then
            GradeChanceNumber = Convert.ToInt32(TextBoxGrade23.Text)
        End If


        If SerendipityPot = 0 And SerendipityPotCustom = 0 Then
            TextBox1.Text = GradeChanceNumber
        End If

        If SerendipityPot = 1 And SerendipityPotCustom = 0 Then
            TextBox1.Text = GradeChanceNumber * 2
        End If

        If SerendipityPotCustom = 1 And SerendipityPot = 0 Then
            TextBox1.Text = GradeChanceNumber + (GradeChanceNumber * (Convert.ToInt32(SereCustomTextBox.Text) / 100))
        End If


    End Sub




    Private Sub CheckBoxSereCustom_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBoxSereCustom.CheckedChanged
        CheckBox5.Checked = False
        If CheckBox5.Checked Then
            SerendipityPot = 1
        End If
        If CheckBox5.Checked = False Then
            SerendipityPot = 0
        End If

        If CheckBoxSereCustom.Checked Then
            SerendipityPotCustom = 1
        End If
        If CheckBoxSereCustom.Checked = False Then
            SerendipityPotCustom = 0
        End If

        If CurrentGrade = 0 Then
            GradeChanceNumber = Convert.ToInt32(TextBoxGrade0.Text)
        End If
        If CurrentGrade = 1 Then
            GradeChanceNumber = Convert.ToInt32(TextBoxGrade1.Text)
        End If
        If CurrentGrade = 2 Then
            GradeChanceNumber = Convert.ToInt32(TextBoxGrade2.Text)
        End If
        If CurrentGrade = 3 Then
            GradeChanceNumber = Convert.ToInt32(TextBoxGrade3.Text)
        End If
        If CurrentGrade = 4 Then
            GradeChanceNumber = Convert.ToInt32(TextBoxGrade4.Text)
        End If
        If CurrentGrade = 5 Then
            GradeChanceNumber = Convert.ToInt32(TextBoxGrade5.Text)
        End If
        If CurrentGrade = 6 Then
            GradeChanceNumber = Convert.ToInt32(TextBoxGrade6.Text)
        End If
        If CurrentGrade = 7 Then
            GradeChanceNumber = Convert.ToInt32(TextBoxGrade7.Text)
        End If
        If CurrentGrade = 8 Then
            GradeChanceNumber = Convert.ToInt32(TextBoxGrade8.Text)
        End If
        If CurrentGrade = 9 Then
            GradeChanceNumber = Convert.ToInt32(TextBoxGrade9.Text)
        End If
        If CurrentGrade = 10 Then
            GradeChanceNumber = Convert.ToInt32(TextBoxGrade10.Text)
        End If
        If CurrentGrade = 11 Then
            GradeChanceNumber = Convert.ToInt32(TextBoxGrade11.Text)
        End If
        If CurrentGrade = 12 Then
            GradeChanceNumber = Convert.ToInt32(TextBoxGrade12.Text)
        End If
        If CurrentGrade = 13 Then
            GradeChanceNumber = Convert.ToInt32(TextBoxGrade13.Text)
        End If
        If CurrentGrade = 14 Then
            GradeChanceNumber = Convert.ToInt32(TextBoxGrade14.Text)
        End If
        If CurrentGrade = 15 Then
            GradeChanceNumber = Convert.ToInt32(TextBoxGrade15.Text)
        End If
        If CurrentGrade = 16 Then
            GradeChanceNumber = Convert.ToInt32(TextBoxGrade16.Text)
        End If
        If CurrentGrade = 17 Then
            GradeChanceNumber = Convert.ToInt32(TextBoxGrade17.Text)
        End If
        If CurrentGrade = 18 Then
            GradeChanceNumber = Convert.ToInt32(TextBoxGrade18.Text)
        End If
        If CurrentGrade = 19 Then
            GradeChanceNumber = Convert.ToInt32(TextBoxGrade19.Text)
        End If
        If CurrentGrade = 20 Then
            GradeChanceNumber = Convert.ToInt32(TextBoxGrade20.Text)
        End If
        If CurrentGrade = 21 Then
            GradeChanceNumber = Convert.ToInt32(TextBoxGrade21.Text)
        End If
        If CurrentGrade = 22 Then
            GradeChanceNumber = Convert.ToInt32(TextBoxGrade22.Text)
        End If
        If CurrentGrade = 23 Then
            GradeChanceNumber = Convert.ToInt32(TextBoxGrade23.Text)
        End If


        If SerendipityPot = 0 And SerendipityPotCustom = 0 Then
            TextBox1.Text = GradeChanceNumber
        End If

        If SerendipityPot = 1 And SerendipityPotCustom = 0 Then
            TextBox1.Text = GradeChanceNumber * 2
        End If

        If SerendipityPotCustom = 1 And SerendipityPot = 0 Then
            TextBox1.Text = GradeChanceNumber + (GradeChanceNumber * (Convert.ToInt32(SereCustomTextBox.Text) / 100))
        End If


    End Sub

























    Private Sub TextBoxGrade0_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBoxGrade0.KeyPress

        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub TextBoxGrade0_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBoxGrade0.TextChanged
        If TextBoxGrade0.Text.Length < 1 Then

            TextBoxGrade0.Text = 1
        End If
    End Sub



    Private Sub TextBoxGrade1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBoxGrade1.KeyPress

        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub TextBoxGrade1_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBoxGrade1.TextChanged
        If TextBoxGrade1.Text.Length < 1 Then

            TextBoxGrade1.Text = 1
        End If
    End Sub



    Private Sub TextBoxGrade2_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBoxGrade2.KeyPress

        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub TextBoxGrade2_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBoxGrade2.TextChanged
        If TextBoxGrade2.Text.Length < 1 Then

            TextBoxGrade2.Text = 1
        End If
    End Sub




    Private Sub TextBoxGrade3_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBoxGrade3.KeyPress

        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub TextBoxGrade3_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBoxGrade3.TextChanged
        If TextBoxGrade3.Text.Length < 1 Then

            TextBoxGrade3.Text = 1
        End If
    End Sub


    Private Sub TextBoxGrade4_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBoxGrade4.KeyPress

        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub TextBoxGrade4_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBoxGrade4.TextChanged
        If TextBoxGrade4.Text.Length < 1 Then

            TextBoxGrade4.Text = 1
        End If
    End Sub



    Private Sub TextBoxGrade5_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBoxGrade5.KeyPress

        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub TextBoxGrade5_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBoxGrade5.TextChanged
        If TextBoxGrade5.Text.Length < 1 Then

            TextBoxGrade5.Text = 1
        End If
    End Sub


    Private Sub TextBoxGrade6_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBoxGrade6.KeyPress

        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub TextBoxGrade6_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBoxGrade6.TextChanged
        If TextBoxGrade6.Text.Length < 1 Then

            TextBoxGrade6.Text = 1
        End If
    End Sub


    Private Sub TextBoxGrade7_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBoxGrade7.KeyPress

        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub TextBoxGrade7_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBoxGrade7.TextChanged
        If TextBoxGrade7.Text.Length < 1 Then

            TextBoxGrade7.Text = 1
        End If
    End Sub




    Private Sub TextBoxGrade8_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBoxGrade8.KeyPress

        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub TextBoxGrade8_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBoxGrade8.TextChanged
        If TextBoxGrade8.Text.Length < 1 Then

            TextBoxGrade8.Text = 1
        End If
    End Sub



    Private Sub TextBoxGrade9_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBoxGrade9.KeyPress

        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub TextBoxGrade9_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBoxGrade9.TextChanged
        If TextBoxGrade9.Text.Length < 1 Then

            TextBoxGrade9.Text = 1
        End If
    End Sub




    Private Sub TextBoxGrade10_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBoxGrade10.KeyPress

        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub TextBoxGrade10_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBoxGrade10.TextChanged
        If TextBoxGrade10.Text.Length < 1 Then

            TextBoxGrade10.Text = 1
        End If
    End Sub


    Private Sub TextBoxGrade11_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBoxGrade11.KeyPress

        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub TextBoxGrade11_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBoxGrade11.TextChanged
        If TextBoxGrade11.Text.Length < 1 Then

            TextBoxGrade11.Text = 1
        End If
    End Sub


    Private Sub TextBoxGrade12_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBoxGrade12.KeyPress

        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub TextBoxGrade12_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBoxGrade12.TextChanged
        If TextBoxGrade12.Text.Length < 1 Then

            TextBoxGrade12.Text = 1
        End If
    End Sub



    Private Sub TextBoxGrade13_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBoxGrade13.KeyPress

        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub TextBoxGrade13_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBoxGrade13.TextChanged
        If TextBoxGrade13.Text.Length < 1 Then

            TextBoxGrade13.Text = 1
        End If
    End Sub


    Private Sub TextBoxGrade14_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBoxGrade14.KeyPress

        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub TextBoxGrade14_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBoxGrade14.TextChanged
        If TextBoxGrade14.Text.Length < 1 Then

            TextBoxGrade14.Text = 1
        End If
    End Sub


    Private Sub TextBoxGrade15_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBoxGrade15.KeyPress

        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub TextBoxGrade15_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBoxGrade15.TextChanged
        If TextBoxGrade15.Text.Length < 1 Then

            TextBoxGrade15.Text = 1
        End If
    End Sub



    Private Sub TextBoxGrade16_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBoxGrade16.KeyPress

        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub TextBoxGrade16_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBoxGrade16.TextChanged
        If TextBoxGrade16.Text.Length < 1 Then

            TextBoxGrade16.Text = 1
        End If
    End Sub



    Private Sub TextBoxGrade17_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBoxGrade17.KeyPress

        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub TextBoxGrade17_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBoxGrade17.TextChanged
        If TextBoxGrade17.Text.Length < 1 Then

            TextBoxGrade17.Text = 1
        End If
    End Sub


    Private Sub TextBoxGrade18_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBoxGrade18.KeyPress

        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub TextBoxGrade18_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBoxGrade18.TextChanged
        If TextBoxGrade18.Text.Length < 1 Then

            TextBoxGrade18.Text = 1
        End If
    End Sub


    Private Sub TextBoxGrade19_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBoxGrade19.KeyPress

        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub TextBoxGrade19_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBoxGrade19.TextChanged
        If TextBoxGrade19.Text.Length < 1 Then

            TextBoxGrade19.Text = 1
        End If
    End Sub


    Private Sub TextBoxGrade20_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBoxGrade20.KeyPress

        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub TextBoxGrade20_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBoxGrade20.TextChanged
        If TextBoxGrade20.Text.Length < 1 Then

            TextBoxGrade20.Text = 1
        End If
    End Sub

    Private Sub TextBoxGrade21_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBoxGrade21.KeyPress

        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub TextBoxGrade21_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBoxGrade21.TextChanged
        If TextBoxGrade21.Text.Length < 1 Then

            TextBoxGrade21.Text = 1
        End If
    End Sub


    Private Sub TextBoxGrade22_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBoxGrade22.KeyPress

        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub TextBoxGrade22_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBoxGrade22.TextChanged
        If TextBoxGrade22.Text.Length < 1 Then

            TextBoxGrade22.Text = 1
        End If
    End Sub


    Private Sub TextBoxGrade23_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBoxGrade23.KeyPress

        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub TextBoxGrade23_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBoxGrade23.TextChanged
        If TextBoxGrade23.Text.Length < 1 Then

            TextBoxGrade23.Text = 1
        End If
    End Sub



    Private Sub SereCustomTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles SereCustomTextBox.KeyPress

        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub SereCustomTextBox_TextChanged(sender As System.Object, e As System.EventArgs) Handles SereCustomTextBox.TextChanged
        If SereCustomTextBox.Text.Length < 1 Then

            SereCustomTextBox.Text = 1
        End If
    End Sub










    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        SerendipityPot = 0
        SerendipityPotCustom = 0
    End Sub






    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        System.Diagnostics.Process.Start("https://www.youtube.com/channel/UC9AtpM68hXbTvnl1mBnVIJA")
    End Sub

    Private Sub EditLevelButton_Click(sender As System.Object, e As System.EventArgs) Handles EditLevelButton.Click
        Dim Valid As Boolean
        Dim EditableLevel As String
        EditableLevel = 0
        While Valid = False
            EditableLevel = InputBox("Change the current item level:")
            If IsNumeric(EditableLevel) And Not EditableLevel.Contains(".") And Not EditableLevel.Contains(",") Then
                Valid = True
            Else
                Valid = False
                'put a msgbox here if you like
            End If
        End While

        If Convert.ToInt32(Label_Level.Text) <= 24 And Convert.ToInt32(Label_Level.Text) >= 0 Then
            Label_Level.Text = EditableLevel
        End If

        If Convert.ToInt32(Label_Level.Text) < 0 Then
            Label_Level.Text = 0
        End If

        If Convert.ToInt32(Label_Level.Text) > 24 Then
            Label_Level.Text = 24
        End If

    End Sub










    

    Private Sub ButtonStartAutoUpgrade_Click(sender As System.Object, e As System.EventArgs) Handles ButtonStartAutoUpgrade.Click
        If CheckBox2.Checked = True Or CheckBox3.Checked = True Or CheckBox4.Checked = True Then
            TimerAuto.Start()
            ButtonStartAutoUpgrade.Enabled = False
            ButtonStopAutoUpgrade.Enabled = True
            CheckBoxResultMsgBox.Checked = True
            CheckBoxDisLoading.Checked = True
        Else
            MsgBox("Please select a formula")
        End If
    End Sub

    Private Sub ButtonStopAutoUpgrade_Click(sender As System.Object, e As System.EventArgs) Handles ButtonStopAutoUpgrade.Click
        TimerAuto.Stop()
        ButtonStartAutoUpgrade.Enabled = True
        ButtonStopAutoUpgrade.Enabled = False
    End Sub

 
    Private Sub TimerAuto_Tick(sender As System.Object, e As System.EventArgs) Handles TimerAuto.Tick
        Button1_Click(sender, e)
        TextBox2.Text = Label_Level.Text
    End Sub

    Private Sub GroupBox4_Enter(sender As System.Object, e As System.EventArgs) Handles GroupBox4.Enter

    End Sub
End Class
