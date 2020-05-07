<%@ Page Title="Unit Converter" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="UnitConvertor._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div id ="instructions">
        <h1>Unit Converter</h1>
        
        <ol>
            <li>Enter number to be converted</li>
            <li>Select base unit</li>
            <li>Select conversion unit</li>
            <li>Click Enter</li>
        </ol>        
    </div>

    <div id="overallUnit">
        <p><h4>Measurement: 
        <asp:Label ID="Label1" runat="server" Text="Label" hidden="false"></asp:Label>
        </h4> 
            <asp:DropDownList ID="DropDownListMeasure" runat="server" autopostback="true" Height="30px" Width="130px" OnSelectedIndexChanged="DropDownListMeasure_SelectedIndexChanged">
                <asp:ListItem Selected="True">Select a Unit</asp:ListItem>
                <asp:ListItem>Length</asp:ListItem>
                <asp:ListItem>Mass</asp:ListItem>
                <asp:ListItem>Speed</asp:ListItem>
                <asp:ListItem>Temperature</asp:ListItem>
                <asp:ListItem>Time</asp:ListItem>
                <asp:ListItem>Volume</asp:ListItem>
            </asp:DropDownList></p>         
    </div>
          
    &nbsp;

    <div id="inputUnit">
        <p><asp:TextBox ID="TextBoxIn" runat="server" Width="200px" Font-Size="Medium" ></asp:TextBox>
            <asp:DropDownList ID="DropDownListIn" runat="server" AutoPostBack="true" Font-Size="Medium">
                
            </asp:DropDownList>            
            <asp:Label ID="Label2" runat="server" Text="Label" hidden ="false"></asp:Label>
        </p>       
    </div>

    

    <div id="to">        
        <h4>To</h4>        
    </div>

    

    <div id="outputUnit">
        <asp:TextBox ID="TextBoxOut" runat="server" Width="200px" Font-Size="Medium" ></asp:TextBox>
        <asp:DropDownList ID="DropDownListOut" runat="server" AutoPostBack="true" Font-Size="Medium">
            
        </asp:DropDownList>
        <asp:Label ID="Label3" runat="server" Text="Label" hidden ="false"></asp:Label>
    </div>
    
    &nbsp;

    <div id="clicker">
        <asp:Button ID="ButtonEnter" runat="server" Text="Enter" Font-Size="Medium" OnClick="ButtonEnter_Click" />

    </div>
    

</asp:Content>
