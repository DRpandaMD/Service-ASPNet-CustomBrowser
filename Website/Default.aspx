<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <p>
        <asp:Label ID="Label1" runat="server" Text="Please Enter a string for Encyrption:  "></asp:Label>
        <asp:TextBox ID="EncryptTextBox" runat="server"></asp:TextBox>
        <br />

    </p>
    <p>

        <asp:Button ID="EncryptionButton" runat="server" Text="Encrypt It!!" OnClick="EncryptionButton_Click" />

    </p>
    <p>

        <asp:Label ID="Label2" runat="server" Text="Encryption String looks like this:  "></asp:Label>

        <asp:Label ID="EncryptOutLabel" runat="server" Text=""></asp:Label>
        <br />
    </p>
    <p>

        <asp:Label ID="Label3" runat="server" Text="Decrypted it looks like this:"></asp:Label>

        <asp:Label ID="DecryptOutLabel" runat="server" Text=""></asp:Label>

    </p>
    <p>

        <asp:Label ID="Label4" runat="server" Text="Enter a Stock Symbol to get its quote:  "></asp:Label>

        <asp:TextBox ID="StockQuoteTextBox" runat="server"></asp:TextBox>

    </p>
    <p>

        <asp:Button ID="GetQuoteButton" runat="server" Text="GetQuote" OnClick="GetQuoteButton_Click" />

    </p>
    <p>

        <asp:Label ID="QuoteOutput" runat="server" Text=""></asp:Label> USD

    </p>

    
</asp:Content>
