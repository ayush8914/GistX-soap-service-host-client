<%@ Page Title="" Language="C#" MasterPageFile="~/GistMasterPage.Master" AutoEventWireup="true" CodeBehind="NewGist.aspx.cs" Inherits="GistXclient.WebForm4" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <!-- Place the first <script> tag in your HTML's <head> -->
<script src="https://cdn.tiny.cloud/1/13czfrocyz4rfobfogrtgdslkj7zlz2cm5cr5bvz741cassh/tinymce/6/tinymce.min.js" referrerpolicy="origin"></script>
    <style>

        .tb {
            margin: 0 auto;
            width: 800px;
            height: 350px;
            background-color: #0D1117;
            color:#0D1117 ;
            border: 1px solid #0D1117;
            border-radius: 5px;
            padding: 10px;   
        }
        .create-gist-button {
    background-color: #28a745; /* Green color */
    color: #ffffff; /* White text color */
    padding-bottom:10px;
    /* Adjust padding as needed */
    border: none;
    border-radius: 5px; /* Rounded corners */
    cursor: pointer;
    height:30px;
    margin-left : 700px;
}

.create-gist-button:hover {
    background-color: #218838; /* Darker green on hover */
}

    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<!-- Place the following <script> and <textarea> tags your HTML's <body> -->
<script>
    tinymce.init({
        selector: "textarea",
        width: 800,
        height: 350,
        toolbar: 'undo redo | bold italic | alignleft aligncenter alignright alignjustify | bullist numlist outdent indent | table | link image',
        plugins: 'link code save preview',
        menubar: false,
        toolbar: false,
        toolbar_mode: "floating",
        tinycomments_mode: "embedded",
        tinycomments_author: "Author name",
        content_style: "body { font-family:Helvetica,Arial,sans-serif; font-size:14px; background-color:#0D1117; color:white;}",
        statusbar: false,
        theme: 'silver',
        skin: 'oxide-dark',
        content_css: '/GistXclient/codebox.css',
    });
</script>

    <h1 style="color:aliceblue; font-family:Arial; font-size:25px; display:flex; justify-content:center;">
    Instantly share code, notes, and snippets.
    </h1>
   <input class="mt-4" type="text" id="title" placeholder="Title or FileName" style="margin: 0 310px; display:block; width: 800px; padding-left:20px;  height: 30px; border-radius: 5px; border: 1px solid #808080; background-color:#010409; color:white;" />

<div class="tb">
<textarea>
  Welcome to GistX.  Please enter your code here.
</textarea>
    <asp:Button ID="btnCreateGist" runat="server" Text="Create Gist"  CssClass="create-gist-button mt-3" />

</div>

</asp:Content>
