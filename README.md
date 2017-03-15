# CaracasFruits
This is an exercise to test my skills
So this is an Asp.Net MVC 5 project, the DB is on SQL Server using EF as ORM with Code First Migration, for the desing and look I used Twitter Bootstrap.

There are 2 main features:

   - Create New Sale: the user is able to create a new sale selecting the fruit, quantity and amount, 
     and there can be more than 1 fruit per sale. For this I used Knockout.JS, so everything goes dynamically. To post the sale I 
     used an Ajax call. 

   - Sales Report: in this one the user can set a date range for the sales date, and I'm using MVC partial views to return the data.
     To get the data, I'm using a raw SQLCommand through EF DataContext in order to make it faster and easy to handle.
     The data consists in a Bootstrap table and a pie chart made with ChartJS.
     
--
Guillermo Oramas Ruiz. 
