Imports System.IO

'HTML & CSS Generator For Basic Webpages
'Developed by Justin Hedrick 8-7-17 > 8-*-17
'Copyright @DeadManDevelopment @HedrickDevelopmentSolutions 2017
'All Rights Reserved

Public Class Form1
    'Head Strings
    Public TitleHeader As String = "<title>Website Title Header</title>"
    Public CSSLinkHeader As String = "<link href=""./css/style.css"" type=""text/css"" rel=""stylesheet"">"
    Public KeywordsHeader As String = "<meta name=""keywords"" content=""Some Key Words To Define Site"">"
    Public DesctiptionHeader As String = "<meta name=""description"" content=""Description Of Website"">"
    Public AuthorHeader As String = "<meta name=""author"" content=""Author Of Website"">"
    Public HTTPEquivHeader As String = "<meta http-equiv=""refresh"" content=""Refresh Time in Seconds"">"
    Public ViewportHeader As String = "<meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">"
    Public CharsetHeader As String = "<meta charset=""UTF-8"">"

    'CSS Strings
    Public ArticleCSS As String = "article {display:block;}"
    Public BlockQuoteCSS As String = "blockquote {display:block;}"
    Public AsideCSS As String = "aside {display:block;}"
    Public MenuCSS As String = "menu {display:block;}"
    Public CaptionCSS As String = "caption {display:block;}"
    Public SectionCSS As String = "section {display:block;}"
    Public SummaryCSS As String = "summary {display:block;}"
    Public ButtonCSS As String = "button {display:block;}"
    Public ContainerCSS As String = "container {display:block;}"

    'HTML Strings


    'Working Directory & Sub Directories
    Public WorkingDirectory As String = "C:\Website"
    Public CSSDirectory As String = "\css"
    Public JSDirectory As String = "\js"
    Public ImagesDirectory As String = "\images"

    'Javascripts
    Public JQueryMinJs As String = My.Resources.jquery_min
    Public CloudflareMinJs As String = My.Resources.cloudflare_min
    Public BootstrapMinJs As String = My.Resources.bootstrap_min
    Public JQueryUIMinJs As String = My.Resources.jquery_ui_min
    Public JQueryUIToTopJS As String = My.Resources.jquery_ui_totop
    Public JQueryFlexsliderMinJS As String = My.Resources.jquery_flexslider_min
    Public JQueryIsotopeMinJS As String = My.Resources.jquery_isotope_min
    Public JQueryPrettyPhotoJs As String = My.Resources.jquery_prettyPhoto
    Public JQueryScrollTo As String = My.Resources.jquery_scrollto
    Public BootstrapJS As String = My.Resources.bootstrap_js
    Public JQuery As String = My.Resources.jquery

    'Cascading Style Sheets
    Public FontAwesomeCSS As String = My.Resources.font_awesome_min
    Public BootstrapCSS As String = My.Resources.bootstrap_css
    Public BootstrapMinCSS As String = My.Resources.bootstrap_min_css
    Public BootstrapThemeCSS As String = My.Resources.bootstrap_theme
    Public BootstrapThemeMinCSS As String = My.Resources.bootstrap_theme_min

    'Head Generator Settings Check
    Private Sub ReactorCheckBox18_CheckedChanged(sender As Object) Handles HeadTitleCheckbox.CheckedChanged
        If GenerateHeadCheckbox.Checked = True Then HeadTitleCheckbox.Checked = True Else HeadTitleCheckbox.Checked = False
    End Sub
    Private Sub CSSLinkCheckbox_CheckedChanged(sender As Object) Handles CSSLinkCheckbox.CheckedChanged
        If GenerateHeadCheckbox.Checked = True Then CSSLinkCheckbox.Checked = True Else CSSLinkCheckbox.Checked = False
    End Sub
    Private Sub CharsetHeaderCheckbox_CheckedChanged(sender As Object) Handles CharsetHeaderCheckbox.CheckedChanged
        If GenerateHeadCheckbox.Checked = True Then CharsetHeaderCheckbox.Checked = True Else CharsetHeaderCheckbox.Checked = False
    End Sub
    Private Sub ViewportHeaderCheckbox_CheckedChanged(sender As Object) Handles ViewportHeaderCheckbox.CheckedChanged
        If GenerateHeadCheckbox.Checked = True Then ViewportHeaderCheckbox.Checked = True Else ViewportHeaderCheckbox.Checked = False
    End Sub
    Private Sub AuthorHeaderCheckbox_CheckedChanged(sender As Object) Handles AuthorHeaderCheckbox.CheckedChanged
        If GenerateHeadCheckbox.Checked = True Then AuthorHeaderCheckbox.Checked = True Else AuthorHeaderCheckbox.Checked = False
    End Sub
    Private Sub DescriptionHeaderCheckbox_CheckedChanged(sender As Object) Handles DescriptionHeaderCheckbox.CheckedChanged
        If GenerateHeadCheckbox.Checked = True Then DescriptionHeaderCheckbox.Checked = True Else DescriptionHeaderCheckbox.Checked = False
    End Sub
    Private Sub KeywordsHeaderCheckbox_CheckedChanged(sender As Object) Handles KeywordsHeaderCheckbox.CheckedChanged
        If GenerateHeadCheckbox.Checked = True Then KeywordsHeaderCheckbox.Checked = True Else KeywordsHeaderCheckbox.Checked = False
    End Sub
    Private Sub HTTPEquivHeaderCheckbox_CheckedChanged(sender As Object) Handles HTTPEquivHeaderCheckbox.CheckedChanged
        If GenerateHeadCheckbox.Checked = True Then HTTPEquivHeaderCheckbox.Checked = True Else HTTPEquivHeaderCheckbox.Checked = False
    End Sub
    'If head is unchecked disable all head subchecks
    Private Sub GenerateHeadCheckbox_CheckedChanged(sender As Object) Handles GenerateHeadCheckbox.CheckedChanged
        If GenerateHeadCheckbox.Checked = False Then
            CSSLinkCheckbox.Checked = False
            HeadTitleCheckbox.Checked = False
            ViewportHeaderCheckbox.Checked = False
            AuthorHeaderCheckbox.Checked = False
            CharsetHeaderCheckbox.Checked = False
            KeywordsHeaderCheckbox.Checked = False
            DescriptionHeaderCheckbox.Checked = False
            HTTPEquivHeaderCheckbox.Checked = False
        End If
    End Sub

    'Generate HTML Button
    Private Sub BitdefenderButton1_Click(sender As Object, e As EventArgs) Handles GenerateHTML.Click
        'If header is enabled Generate Header here otherwise continue without header
        If GenerateHeadCheckbox.Checked = True Then 'Generate With Header
            'Begin HTML document
            RichTextBox1.Text = "<!Doctype html>" + Environment.NewLine + "<html>" + Environment.NewLine + "<head>" + Environment.NewLine
            'Insert Head Tags & Information
            If HeadTitleCheckbox.Checked = True Then RichTextBox1.Text += TitleHeader + Environment.NewLine
            If AuthorHeaderCheckbox.Checked = True Then RichTextBox1.Text += AuthorHeader + Environment.NewLine
            If DescriptionHeaderCheckbox.Checked = True Then RichTextBox1.Text += DesctiptionHeader + Environment.NewLine
            If KeywordsHeaderCheckbox.Checked = True Then RichTextBox1.Text += KeywordsHeader + Environment.NewLine
            If CharsetHeaderCheckbox.Checked = True Then RichTextBox1.Text += CharsetHeader + Environment.NewLine
            If ViewportHeaderCheckbox.Checked = True Then RichTextBox1.Text += ViewportHeader + Environment.NewLine
            If HTTPEquivHeaderCheckbox.Checked = True Then RichTextBox1.Text += HTTPEquivHeader + Environment.NewLine
            If CSSLinkCheckbox.Checked = True Then RichTextBox1.Text += CSSLinkHeader + Environment.NewLine
            'Close Head tag
            RichTextBox1.Text += "</head>" + Environment.NewLine
            'Open Body Tag
            RichTextBox1.Text += "<body>" + Environment.NewLine
            'Generate Header & Nav if enabled
            If GenerateBodyHeader.Checked = True And GenerateNavMenu.Checked = True Then RichTextBox1.Text += "<header>" + Environment.NewLine + "<nav>" + Environment.NewLine + "</nav>" + Environment.NewLine + "</header>" + Environment.NewLine
            'Generate Just header
            If GenerateBodyHeader.Checked = True And GenerateNavMenu.Checked = False Then RichTextBox1.Text += "<header>" + Environment.NewLine + "</header>" + Environment.NewLine
            'Generate Footer if enabled
            If GenerateFooterCheckbox.Checked = True Then RichTextBox1.Text += "<footer>" + Environment.NewLine + "</footer>"
            'Close body Tag & html tag
            RichTextBox1.Text += "</body>" + Environment.NewLine + "</html>" + Environment.NewLine
        ElseIf GenerateHeadCheckbox.Checked = False Then 'Generate without header
            'Begin HTML document
            RichTextBox1.Text = "<!Doctype html>" + Environment.NewLine + "<html>" + Environment.NewLine
            'Open Body Tag
            RichTextBox1.Text += "<body>" + Environment.NewLine
            'Generate Header & Nav if enabled
            If GenerateBodyHeader.Checked = True And GenerateNavMenu.Checked = True Then RichTextBox1.Text += "<header>" + Environment.NewLine + "<nav>" + Environment.NewLine + "</nav>" + Environment.NewLine + "</header>" + Environment.NewLine
            'Generate Just header
            If GenerateBodyHeader.Checked = True And GenerateNavMenu.Checked = False Then RichTextBox1.Text += "<header>" + Environment.NewLine + "</header>" + Environment.NewLine
            'Generate Footer if enabled
            If GenerateFooterCheckbox.Checked = True Then RichTextBox1.Text += "<footer>" + Environment.NewLine + "</footer>" + Environment.NewLine
            'Close body Tag & html tag
            RichTextBox1.Text += "</body>" + Environment.NewLine + "</html>" + Environment.NewLine
        End If
    End Sub

    'Reset Generated HTML Textbox, CSS textbox, Header checkbox
    Private Sub BitdefenderButton1_Click_1(sender As Object, e As EventArgs) Handles BitdefenderButton1.Click
        RichTextBox1.Text = ""
    End Sub
    Private Sub BitdefenderButton4_Click(sender As Object, e As EventArgs) Handles BitdefenderButton4.Click
        RichTextBox2.Text = ""
    End Sub

    'Custom check to check if head is enabled before generating used tags
    Private Sub ReactorCheckBox3_CheckedChanged(sender As Object) Handles GenerateNavMenu.CheckedChanged
        If GenerateBodyHeader.Checked = True Then GenerateNavMenu.Checked = True Else GenerateNavMenu.Checked = False
    End Sub

    'Save All Files Button
    Private Sub SaveAllFilesBtn_Click(sender As Object, e As EventArgs) Handles SaveAllFilesBtn.Click
        'Check if working directory exists
        If (Not System.IO.Directory.Exists(WorkingDirectory)) Then
            System.IO.Directory.CreateDirectory(WorkingDirectory)
        End If

        'Check if CSS folder exists in the Working Directory
        If (Not System.IO.Directory.Exists(WorkingDirectory + CSSDirectory)) Then
            System.IO.Directory.CreateDirectory(WorkingDirectory + CSSDirectory)
        End If

        'Check if js folder exists in the Working Directory
        If (Not System.IO.Directory.Exists(WorkingDirectory + JSDirectory)) Then
            System.IO.Directory.CreateDirectory(WorkingDirectory + JSDirectory)
        End If

        'Check if images folder exists in the Working Directory
        If (Not System.IO.Directory.Exists(WorkingDirectory + ImagesDirectory)) Then
            System.IO.Directory.CreateDirectory(WorkingDirectory + ImagesDirectory)
        End If
        Try
            My.Computer.FileSystem.WriteAllText(WorkingDirectory + "\index.html", RichTextBox1.Text, False)
            My.Computer.FileSystem.WriteAllText(WorkingDirectory + CSSDirectory + "\style.css", RichTextBox2.Text, False)
        Catch ex As Exception
        End Try
    End Sub

    'Set Working Directory Button
    Private Sub SetDirBtn_Click(sender As Object, e As EventArgs) Handles SetDirBtn.Click
        WorkingDirectory = TxtBox1.Text
    End Sub

    'Javascript Generation Control Systems
    Private Sub BitdefenderButton10_Click(sender As Object, e As EventArgs) Handles BitdefenderButton10.Click
        'Check if js folder exists in the Working Directory
        If (Not System.IO.Directory.Exists(WorkingDirectory + JSDirectory)) Then
            System.IO.Directory.CreateDirectory(WorkingDirectory + JSDirectory)
        End If
        Try
            My.Computer.FileSystem.WriteAllText(WorkingDirectory + JSDirectory + "\jquery.min.js", JQueryMinJs, False)
        Catch ex As Exception
        End Try
    End Sub
    Private Sub BitdefenderButton9_Click(sender As Object, e As EventArgs) Handles BitdefenderButton9.Click
        'Check if js folder exists in the Working Directory
        If (Not System.IO.Directory.Exists(WorkingDirectory + JSDirectory)) Then
            System.IO.Directory.CreateDirectory(WorkingDirectory + JSDirectory)
        End If
        Try
            My.Computer.FileSystem.WriteAllText(WorkingDirectory + JSDirectory + "\cloudflare.min.js", CloudflareMinJs, False)
        Catch ex As Exception
        End Try
    End Sub
    Private Sub BitdefenderButton8_Click(sender As Object, e As EventArgs) Handles BitdefenderButton8.Click
        'Check if js folder exists in the Working Directory
        If (Not System.IO.Directory.Exists(WorkingDirectory + JSDirectory)) Then
            System.IO.Directory.CreateDirectory(WorkingDirectory + JSDirectory)
        End If
        Try
            My.Computer.FileSystem.WriteAllText(WorkingDirectory + JSDirectory + "\bootstrap.min.js", BootstrapMinJs, False)
        Catch ex As Exception
        End Try
    End Sub
    Private Sub BitdefenderButton7_Click(sender As Object, e As EventArgs) Handles BitdefenderButton7.Click
        'Check if js folder exists in the Working Directory
        If (Not System.IO.Directory.Exists(WorkingDirectory + JSDirectory)) Then
            System.IO.Directory.CreateDirectory(WorkingDirectory + JSDirectory)
        End If
        Try
            My.Computer.FileSystem.WriteAllText(WorkingDirectory + JSDirectory + "\jquery.ui.min.js", JQueryUIMinJs, False)
        Catch ex As Exception
        End Try
    End Sub
    Private Sub BitdefenderButton6_Click(sender As Object, e As EventArgs) Handles BitdefenderButton6.Click
        'Check if js folder exists in the Working Directory
        If (Not System.IO.Directory.Exists(WorkingDirectory + JSDirectory)) Then
            System.IO.Directory.CreateDirectory(WorkingDirectory + JSDirectory)
        End If
        Try
            My.Computer.FileSystem.WriteAllText(WorkingDirectory + JSDirectory + "\jquery.ui.totop.js", JQueryUIToTopJS, False)
        Catch ex As Exception
        End Try
    End Sub
    Private Sub BitdefenderButton5_Click(sender As Object, e As EventArgs) Handles BitdefenderButton5.Click
        'Check if js folder exists in the Working Directory
        If (Not System.IO.Directory.Exists(WorkingDirectory + JSDirectory)) Then
            System.IO.Directory.CreateDirectory(WorkingDirectory + JSDirectory)
        End If
        Try
            My.Computer.FileSystem.WriteAllText(WorkingDirectory + JSDirectory + "\jquery.flexslider.min.js", JQueryFlexsliderMinJS, False)
        Catch ex As Exception
        End Try
    End Sub
    Private Sub BitdefenderButton3_Click(sender As Object, e As EventArgs) Handles BitdefenderButton3.Click
        'Check if js folder exists in the Working Directory
        If (Not System.IO.Directory.Exists(WorkingDirectory + JSDirectory)) Then
            System.IO.Directory.CreateDirectory(WorkingDirectory + JSDirectory)
        End If
        Try
            My.Computer.FileSystem.WriteAllText(WorkingDirectory + JSDirectory + "\jquery.isotope.min.js", JQueryIsotopeMinJS, False)
        Catch ex As Exception
        End Try
    End Sub
    Private Sub BitdefenderButton11_Click(sender As Object, e As EventArgs) Handles BitdefenderButton11.Click
        'Check if js folder exists in the Working Directory
        If (Not System.IO.Directory.Exists(WorkingDirectory + JSDirectory)) Then
            System.IO.Directory.CreateDirectory(WorkingDirectory + JSDirectory)
        End If
        Try
            My.Computer.FileSystem.WriteAllText(WorkingDirectory + JSDirectory + "\jquery.prettyphoto.min.js", JQueryPrettyPhotoJs, False)
        Catch ex As Exception
        End Try
    End Sub
    Private Sub BitdefenderButton12_Click(sender As Object, e As EventArgs) Handles BitdefenderButton12.Click
        'Check if js folder exists in the Working Directory
        If (Not System.IO.Directory.Exists(WorkingDirectory + JSDirectory)) Then
            System.IO.Directory.CreateDirectory(WorkingDirectory + JSDirectory)
        End If
        Try
            My.Computer.FileSystem.WriteAllText(WorkingDirectory + JSDirectory + "\jquery.scrollto.min.js", JQueryScrollTo, False)
        Catch ex As Exception
        End Try
    End Sub
    Private Sub BitdefenderButton14_Click(sender As Object, e As EventArgs) Handles BitdefenderButton14.Click
        'Check if js folder exists in the Working Directory
        If (Not System.IO.Directory.Exists(WorkingDirectory + JSDirectory)) Then
            System.IO.Directory.CreateDirectory(WorkingDirectory + JSDirectory)
        End If
        Try
            My.Computer.FileSystem.WriteAllText(WorkingDirectory + JSDirectory + "\bootstrap.js", BootstrapJS, False)
        Catch ex As Exception
        End Try
    End Sub
    Private Sub BitdefenderButton13_Click(sender As Object, e As EventArgs) Handles BitdefenderButton13.Click
        'Check if js folder exists in the Working Directory
        If (Not System.IO.Directory.Exists(WorkingDirectory + JSDirectory)) Then
            System.IO.Directory.CreateDirectory(WorkingDirectory + JSDirectory)
        End If
        Try
            My.Computer.FileSystem.WriteAllText(WorkingDirectory + JSDirectory + "\jquery.js", JQuery, False)
        Catch ex As Exception
        End Try
    End Sub

    'CSS Generation Control Systems
    Private Sub BitdefenderButton38_Click(sender As Object, e As EventArgs) Handles BitdefenderButton38.Click
        'Check if css folder exists in the Working Directory
        If (Not System.IO.Directory.Exists(WorkingDirectory + CSSDirectory)) Then
            System.IO.Directory.CreateDirectory(WorkingDirectory + CSSDirectory)
        End If
        Try
            My.Computer.FileSystem.WriteAllText(WorkingDirectory + CSSDirectory + "\fontawesome.min.css", FontAwesomeCSS, False)
        Catch ex As Exception
        End Try
    End Sub
    Private Sub BitdefenderButton37_Click(sender As Object, e As EventArgs) Handles BitdefenderButton37.Click
        'Check if css folder exists in the Working Directory
        If (Not System.IO.Directory.Exists(WorkingDirectory + CSSDirectory)) Then
            System.IO.Directory.CreateDirectory(WorkingDirectory + CSSDirectory)
        End If
        Try
            My.Computer.FileSystem.WriteAllText(WorkingDirectory + CSSDirectory + "\bootstrap.css", BootstrapCSS, False)
        Catch ex As Exception
        End Try
    End Sub
    Private Sub BitdefenderButton36_Click(sender As Object, e As EventArgs) Handles BitdefenderButton36.Click
        'Check if css folder exists in the Working Directory
        If (Not System.IO.Directory.Exists(WorkingDirectory + CSSDirectory)) Then
            System.IO.Directory.CreateDirectory(WorkingDirectory + CSSDirectory)
        End If
        Try
            My.Computer.FileSystem.WriteAllText(WorkingDirectory + CSSDirectory + "\bootstrap.min.css", BootstrapCSS, False)
        Catch ex As Exception
        End Try
    End Sub
    Private Sub BitdefenderButton35_Click(sender As Object, e As EventArgs) Handles BitdefenderButton35.Click
        'Check if css folder exists in the Working Directory
        If (Not System.IO.Directory.Exists(WorkingDirectory + CSSDirectory)) Then
            System.IO.Directory.CreateDirectory(WorkingDirectory + CSSDirectory)
        End If
        Try
            My.Computer.FileSystem.WriteAllText(WorkingDirectory + CSSDirectory + "\bootstrap.theme.css", BootstrapThemeCSS, False)
        Catch ex As Exception
        End Try
    End Sub
    Private Sub BitdefenderButton34_Click(sender As Object, e As EventArgs) Handles BitdefenderButton34.Click
        'Check if css folder exists in the Working Directory
        If (Not System.IO.Directory.Exists(WorkingDirectory + CSSDirectory)) Then
            System.IO.Directory.CreateDirectory(WorkingDirectory + CSSDirectory)
        End If
        Try
            My.Computer.FileSystem.WriteAllText(WorkingDirectory + CSSDirectory + "\bootstrap.theme.min.css", BootstrapThemeMinCSS, False)
        Catch ex As Exception
        End Try
    End Sub
End Class
