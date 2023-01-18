# Fuel Economy Log WPF
![GitHub last commit](https://img.shields.io/github/last-commit/PinKushin/FuelEconomyLogWPF?&logo=last-commit&style=plastic)
![GitHub top language](https://img.shields.io/github/languages/top/PinKushin/FuelEconomyLogWPF?style=plastic)
![GitHub code size in bytes](https://img.shields.io/github/languages/code-size/PinKushin/FuelEconomyLogWPF?style=plastic)
![GitHub Sponsors](https://img.shields.io/github/sponsors/PinKushin?style=plastic)
![GitHub issues](https://img.shields.io/github/issues/PinKushin/FuelEconomyLogWPF?style=plastic)
## Video Demo: URL HERE
## Description:
This Program was made by John Moore for CS50.  
It allows a user to input these, after they purchase gas:
- The date in DateTime format,
- The amount of gas bought,
- the miles driven on that amount,
- and the price.

The program then does a simple calculation of gallons of gas  
divided by the miles driven to find the miles per gallon of gas.  
It then saves that log to a csv file located in the users MyDocuments folder.  
The Program then updates the table that is visible on the home page.  
The user can then go to the graph page and see a graph of all their logs.  

I have been wanting to make this for a while to keep track and  
log my gas mileage over time. Was going to make it a website so  
that I could access it from anywhere, but would then have to buy hosting.  
That's not in my budget at the moment.

The code is arranged in a MVVC format because that is the standard for  
WPF applications. I chose MPF over windows forms for the ability to customize  
the appearance more easily, although that lead to having a more difficult time  
with the User's data because I had to learn about Data Binding. I still don't  
think I'm literate with it but it was a good learning experience.

I chose C# because I had some background with it before CS50, and it being a  
strongly typed language made user input verification easier than something like JS.  
I looked into C++ and wxWidgets as well, but felt learning a whole library like  
wxWidgets would take longer than I would like, and the performance advantage of running  
C++ over C# wasn't great enough, and my design skills definitely not good enough, to  
make a GUI application from scratch over using WPF and C#. It does have the downside  
of being a windows only application because of WPF, even though I'm using .NET Core  
which is cross-platform.

### File List
#### App.xaml & App.xaml.cs:  
This is the application. Interaction logic would go hear in a non MVVC app.  
I had no use for the .cs file, but it is coupled to the .xaml file which  
I do need to import custom ResourceDictionary sources. Which are used as  
themes to style the buttons and input boxes of the program. It also includes  
DataTemplates for every View(page, location) I need/want to display to the user.  
This application uses 3 views.

#### MainWindow.xaml and MainWindow.xaml.cs:  
This if the Window used to display all the Views. The .xaml contains the default  
styling such as font, font-size, icon, and window style, the replacement close,  
minimize, and maximize buttons that are needed because I removed the default windows  
title bar by using WindowStyle="None" in the window tag, the navigation RadioButtons  
for the user to change Views, and a ContentControl to display those Views.  
The .cs contains the logic for the close, minimize, and maximize buttons.

