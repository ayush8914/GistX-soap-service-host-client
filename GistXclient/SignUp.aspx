<%@ Page Title="" Language="C#" MasterPageFile="~/GistMasterPage.Master" AutoEventWireup="true" CodeBehind="SignUp.aspx.cs" Inherits="GistXclient.WebForm3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .container {
            max-width: 400px;
            margin: 0 auto;
            font-family: 'Arial', sans-serif;   
        }

.form-group {
            margin-bottom: 1rem;
        }

.btn-primary {
            color: #fff;
            height:30px;
            background-color: #28a745;
            border-color: #28a745;
            margin-bottom:7px;
        }

.btn-primary:hover {
            color: #fff;
            background-color: #218838;
            border-color: #1e7e34;
        }

.btn-primary:focus {
            color: #fff;
            background-color: #218838;
            border-color: #1e7e34;
            box-shadow: 0 0 0 0.2rem rgba(40, 167, 69, 0.5);
            
        }

.btn-primary:active {
            color: #fff;
            background-color: #218838;
            border-color: #1e7e34;
        }

.btn-primary:active:focus {
            box-shadow: 0 0 0 0.2rem rgba(40, 167, 69, 0.5);
        }

.btn-primary:active:hover {
            color: #fff;
            background-color: #1e7e34;
            border-color: #1c7430;
        }

.btn-block {
            display: block;
            width: 100%;
        }

 .card {
            width: 296px;
            margin: auto;
            margin-top: 20px; /* Adjust margin-top for spacing */
            padding: 10px;
            border-radius: 10px;
            box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
            background-color: #161B22;
            border: 1px solid #505050;  
            color: #fff;    
        }

  .card1 {
            width: 296px;
            margin: auto;
            margin-top: 20px; /* Adjust margin-top for spacing */
            padding: 10px;
            border-radius: 10px;
            box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
            background-color: #0D1117;
            border: 1px solid #505050;  
            color: #fff;    
        }

 .input{
     background-color: #010409;
 }

 .label-custom{
     font-size : 14px;
     margin-right : 180px;
 }

.form-control{
        background-color: #0D1117;
        color: #fff;
        border: 1px solid #505050;
border-radius: 5px;
height:30px;
}

.form-control:focus {
background-color: #010409;
border: 1px solid blue;
border-radius: 5px;
color : #fff;   
}

.label1-custom{
font-size : 14px;
    margin-right : 200px;
}

    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<div class="text-center mt-3">
            <svg height="40" aria-hidden="true" viewBox="0 0 16 16" version="1.1" width="40" data-view-component="true" class="octicon octicon-mark-github v-align-middle color-fg-white">
    <path d="M8 0c4.42 0 8 3.58 8 8a8.013 8.013 0 0 1-5.45 7.59c-.4.08-.55-.17-.55-.38 0-.27.01-1.13.01-2.2 0-.75-.25-1.23-.54-1.48 1.78-.2 3.65-.88 3.65-3.95 0-.88-.31-1.59-.82-2.15.08-.2.36-1.02-.08-2.12 0 0-.67-.22-2.2.82-.64-.18-1.32-.27-2-.27-.68 0-1.36.09-2 .27-1.53-1.03-2.2-.82-2.2-.82-.44 1.1-.16 1.92-.08 2.12-.51.56-.82 1.28-.82 2.15 0 3.06 1.86 3.75 3.64 3.95-.23.2-.44.55-.51 1.07-.46.21-1.61.55-2.33-.66-.15-.24-.6-.83-1.23-.82-.67.01-.27.38.01.53.34.19.73.9.82 1.13.16.45.68 1.31 2.69.94 0 .67.01 1.3.01 1.49 0 .21-.15.45-.55.38A7.995 7.995 0 0 1 0 8c0-4.42 3.58-8 8-8Z"></path>
</svg>
    <h5 class="mt-4">Sign Up to GitsX</h5>
    <div class="card">
        
            <div class="form-group">
                <label class="label-custom" for="username">Username:</label>
                <input type="text" class="form-control" id="username" name="username" required>
            </div>
            <div class="form-group">
                <label class="label-custom" for="email"> email address:</label>
                <input type="text" class="form-control" id="email" name="email" required>
            </div>
            <div class="form-group">
                <label class="label1-custom" for="password">Password:</label>

                <input type="password" class="form-control" id="password" name="password" required>
            </div>
            <button type="submit" class="btn btn-primary">Sign in</button>
        
    </div>
    <div class="card1">
<p class="text-center">Already have an account? <a href="SignIn.aspx">Sign in</a></p>
</div>

</asp:Content>
