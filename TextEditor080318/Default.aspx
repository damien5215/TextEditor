<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>

        body {
            /*background-color: #404040;*/
            background-image: url(w202.png);
        }

</style>
</head>
<body>

    <form id="form1" runat="server">
   

         <div style = "height: 455px; width: 966px; font-weight: bold; border-radius: 15px; border-style: solid; border-width:5px; border-color:black; padding: 20px; background-color: white; position: absolute; top:0px; bottom: 0px; left: 0px; right: 0px; margin: auto;">

        <!-- <br/> -->

        <asp:TextBox ID="TextBox1" runat="server" Height="170px" Width="475px" TextMode="MultiLine" BackColor="#000000" ForeColor="White"></asp:TextBox>
        <asp:TextBox ID="TextBox2" runat="server" Height="170px" TextMode="MultiLine" Width="475px" BackColor="#000000" ForeColor="White"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button4" runat="server" Text="Example 1" Width="150px" font-weight="bold" OnClick="Button4_Click" Font-Bold="True" BackColor="#999999"/>
        A short story about a cat.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button5" runat="server" Text="Example 2" Width="150px" OnClick="Button5_Click" Font-Bold="True" BackColor="#999999"/>
        A Sartre quote.<br />
        <br />
        <asp:Button ID="Button6" runat="server" Text="Example 3" Width="150px" OnClick="Button6_Click" Font-Bold="True" BackColor="#999999"/>
            A question (Use Slang Converter).&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button8" runat="server" Text="RESET" Width="150px" OnClick="Button8_Click" OnClientClick="resetColor();" Font-Bold="True" BackColor="#999999"/>
            <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Word Count" OnClick="Button1_Click" Width="150px" font-weight="bold" BackColor="#999999" Font-Bold="True" />
        Counts number of words, sentences and number of words in each sentence.<br/>
        <br/>
        <asp:Button ID="Button2" runat="server" Text="Slang Converter" OnClick="Button2_Click" Width="150px" BackColor="#999999" Font-Bold="True" Style="color:black;"  />
        Converts words to &quot;London Slang&quot; (dropped g&#39;s, &quot;with&quot; = &quot;wiv&quot;, &quot;...er&quot; = &quot;...a&quot;, etc).<br/>
        <br/>
        <asp:Button ID="Button3" runat="server" Text="Word Frequency" OnClick="Button3_Click" Width="150px" BackColor="#999999" Font-Bold="True"/>
        Calculates most frequently occuring word and displays number of times it appears in text.<br/>
        <br/>
            <asp:Button ID="Button7" runat="server" BackColor="#999999" Text="Search" Width="150px" OnClick="Button7_Click1" Font-Bold="True"/>
            Search for a word and return text with word highlighted.&nbsp;&nbsp;
            <asp:TextBox ID="TextBox3" runat="server" BackColor="Black" ForeColor="White"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button9" runat="server" BackColor="#999999" Text="Analyze Text" Width="150px" OnClick="Button9_Click" OnClientClick="inputColor();" Font-Bold="True"/>
            Finds out whether the text in the input box contains &quot;offensive&quot; language.<br/>
    
    </div>

    </form>

    <script src="externalJavascript.js"></script>

</body>
</html>