# Fuel Economy Log WPF
![GitHub last commit](https://img.shields.io/github/last-commit/PinKushin/FuelEconomyLogWPF?&logo=last-commit&style=plastic)
![GitHub top language](https://img.shields.io/github/languages/top/PinKushin/FuelEconomyLogWPF?style=plastic)
![GitHub code size in bytes](https://img.shields.io/github/languages/code-size/PinKushin/FuelEconomyLogWPF?style=plastic)
![GitHub Sponsors](https://img.shields.io/github/sponsors/PinKushin?style=plastic)
![GitHub issues](https://img.shields.io/github/issues/PinKushin/FuelEconomyLogWPF?style=plastic)
### Video Demo: URL HERE
### Description:
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

The code is arranged in a MVVM format because that is the standard for  
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

## File List
### App.xaml & App.xaml.cs:  
This is the application. Interaction logic would go hear in a non MVVC app.  
I had no use for the .cs file, but it is coupled to the .xaml file which  
I do need to import custom ResourceDictionary sources. Which are used as  
themes to style the buttons and input boxes of the program. It also includes  
DataTemplates for every View(page, location) I need/want to display to the user.  
This application uses 3 views.

### MainWindow.xaml and MainWindow.xaml.cs:  
This if the Window used to display all the Views. The .xaml contains the default  
styling such as font, font-size, icon, and window style, the replacement close,  
minimize, and maximize buttons that are needed because I removed the default windows  
title bar by using WindowStyle="None" in the window tag, the navigation RadioButtons  
for the user to change Views, and a ContentControl to display those Views.  
The .cs contains the logic for the close, minimize, and maximize buttons.

### Theme Folder:
This folder contains the Themes used to style the buttons and input fields  
Most of it is simple xaml. Only styling attributes go here.

### MVVM/Model Folder:
This folder contains the MpgLog model in MpgLog.cs. This is used to help validate  
user input, and hold data for the reading and writing of the csv file.  
There is also the MpgLogService which is used to initially create the csv  
file, read a csv file and bind it to the model, calculating Mpg as it does so,  
and return that model as a list to whatever calls ReadFile.

### MVVM/View Folder:
Views are what contain the content of the application, most of the heavy lifting  
is done here. Individual styling, text, the graph, and the table are done in these .xaml files.  
The HomeView.xaml.cs file contains the main logic needed get input data from the user,  
validate that input, and write it to a csv file. As well as the logic needed to read the csv  
file into the DataTable and update the view.  
The GraphView.xaml.cs file contains the logic needed to display the graph of the calculated Mpg.  
The AboutView.xaml.cs file is empty because the about page has no user interaction

### MVVM/ViewModel
Most ViewModels here are empty other than the MainViewViewModel.cs, which contains  
the DataBindings for every View, and MpgLogViewModel.cs, which contains it's data  
bindings.

### Core:
Core contains the classes needed to let the application selectively update elements  
instead of refreshing the whole page.

The font and img folders are self explanatory. This was a great learning experience  
and I've enjoyed the challenge of completing this course. This application in particular  
exposed me to the MVVM design model. I had some experience with MVC in ASP.NET, but  
using that short of design in a desktop application was new for me. If you made it this far  
# THANK YOU!
