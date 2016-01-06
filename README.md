# Webapp-using-C-
Program to get data from HTML web page and perform data updation and also show validation data error on entering wrong data. Main file is Default.aspx with default.aspx.cs code file in it.

To go to main file open webapplications2->webfrom1.aspx->webfrom.aspx.cs

This program can insert values to database and before excuting query it runs required field check and if find any data error shows a message and also it consist Expression validator which checks the right expression for Email and Date of birth.

benifit of using Required field validator over java script is , some times users doesn't allow run java script on there browser ,so when we use Required field validator every time we get only right data on server side.  

There is one problem in using Visual Studio community Edition 2015 , while using Expressioon and required field validatore , It shows error.
To get rid off this error you have to add few line s in web.config file under application tag <> 
<add key="ValidationSettings:UnobtrusiveValidationMode" value="None" />
then validation reqire field will work.

