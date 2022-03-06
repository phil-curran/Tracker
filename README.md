# TRACKER

#### By: Phil Curran

Tracker is a 2-model MVC app built to track vendors and their orders, made with C# and .Net, for a fictional business.

## Technologies Used

* C#
* .NET 6.0
* Bulma.css

## Description

This 2-model MVC app allows you to create a list of vendors, then create and associate product orders for each respective vendor.  

The Vendor model contains the vendor's automatically assigned id#, name, and description.

The Order model contains an automatically assigned id#, title, description, price, date of order, and notes about the order.

## App Setup & Install Instructions:
* Clone the repo: git clone https://github.com/phil-curran/Tracker.git
* Change Directory into Tracker/Tracker
* Run to install packages: dotnet restore
* Run to build assets: dotnet build
* Run to launch: dotnet watch run

## App Test Setup & Run Instructions
* Change Directory into: Tracker/Tracker.Tests
* Run to install packages: dotnet restore
* Run to test: dotnet test

## Known Bugs
* ~/orders not yet listing all orders from all vendors [ in progress... ]
* Tests are a mixed bag at this point

## Contact
Get ahold of me at pecurran@hotmail.com for info or to help iterate!

## License
[MIT](https://choosealicense.com/licenses/mit/)
