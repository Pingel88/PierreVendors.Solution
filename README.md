## <div align="center">Pierre's Vendors</div>
#### <div align="center">📚 *Epicodus Week 9 C# Project 03/05/2021* </div> 
***<p align="center">By Mike Pingel***</p>   
<p align="center">
<br>

<img alt="C#" src="https://img.shields.io/badge/c%23%20-%23239120.svg?&style=for-the-badge&logo=c-sharp&logoColor=white"/>
<img alt="made with Bash" src="https://img.shields.io/badge/Made%20with-Bash-1f425f.svg"/>
</p>

___
### 📇 This project is not in a complete or portfolio ready state, and should not be considered as representation of professional work.
___
## 🚩 *Description*:    
### *An MVC application to manage vendors and orders at Pierre's Bakery. Upon being greeted with a splash page, the user can add new orders and vendors as well as view orders tied to individual vendors. This project utilizes GET and POST requests using MVC routes that follow RESTful conventions inside of controllers for each view.


## 🔧 *Setup/Installation instructions:*
#### 🌐 From the web:
* Go to the GitHub repository for this project: [https://github.com/Pingel88/PierreVendors.Solution.git](https://github.com/Pingel88/PierreVendors.Solution.git).
* At the top of the repository, click <img src="https://i.imgur.com/Ej9Dphm.png" alt="Code Button" height="20" align="center" /> then select "Download ZIP".

  <img src="https://i.imgur.com/tZKvGne.gif" alt="download zip gif" height="200"/>
* Unzip the file, navigate to the **'PierreVendors/Models'** folder to check code or to the **'PierreVendors.Tests/ModelTests'** folder to see tests.
#### ⚙️ From the terminal: 
* Clone my repository from GitHub using `git clone https://github.com/Pingel88/PierreVendors.Solution.git` in your terminal or GitBash
* Navigate to the downloaded folder using `cd` command
* Execute `code .` command in your terminal and it will open all source code in your code editor.    
⚠️ *Note: To run this project locally you will need to have .NET Core. You can check if you have .NET Core by running `dotnet --version` in the command line. If you do not have .NET Core please find more information and download [here](https://dotnet.microsoft.com/download/dotnet)*
### 📋 Specs:
<details>
<summary>🚥 Tests</summary>

| # | Behavior | Input |  Output | Complete |
| :------------- | :------------- | :------------- | :------------ | :-------------: |
| 01 | Creates a new instance of Order named newOrder| `new Order()` | newOrder | ✅ |
| 02 | Returns the instanced Order's Title property when given a string of "Bread" | `newOrder.Title` | "Bread" | ✅ |
| 03 | Returns the instanced Order's Description property when given a string of "10 loaves of bread" | `newOrder.Description` | "10 loaves of bread" | ✅ |
| 04 | Returns the instanced Order's Price property when given an integer of 50 | `newOrder.Price` | 50 | ✅ |
| 05 | Returns the instanced Order's Date property when given a string of "03/05/2021" | `newOrder.Date` | "03/05/2021" | ✅ |
| 06 | Returns an empty list when no instances Order are created | `Order.GetAll()` | { } | ✅ |
| 07 | Returns a list of all instances of Order when given Orders newOrderA and newOrderB | `Order.GetAll()` | { newOrderA, newOrderB } | ✅ |
| 08 | Returns the first instanced Order's Id property | `newOrder.Id` | 1 | ❌ |
| 09 | Returns the instanced Order's Id property based on its position in the list of all instances of Order when given Orders newOrderA and newOrderB | `newOrderB.Id` | 2 | ❌ |
| 10 | Returns the instanced Order when given Orders newOrderA and newOrderB | `Order.Find(2)` | newOrderB | ❌ |
| 11 | Creates a new instance of Vendor named newVendor | `new Vendor()` | newVendor | ❌ |
| 12 | Returns the instanced Vendor's Name property when given a string of "Brad's Butter Emporium" | `newVendor.Name` | "Brad's Butter Emporium" | ❌ |
| 13 | Returns the instanced Vendor's Description property when given a string of "Typically buys a lot of bread to butter" | `newVendor.Description` | "Typically buys a lot of bread to butter" | ❌ |
| 14 | Returns an empty list when no instances of Vendor are created | `Vendor.GetAll()` | { } | ❌ |
| 15 | Returns a list of all instances of Vendor when given Vendors newVendorA and newVendorB | `Vendor.GetAll()` | { newVendorA, newVendorB } | ❌ |
| 16 | Returns the first instanced Vendor's Id property | `newVendor.Id` | 1 | ❌ |
| 17 | Returns the instanced Vendor's Id property based on its position in the list of all instances of Vendor when given Vendors newVendorA and newVendorB | `newVendorB.Id` | 2 | ❌ |
| 18 | Returns the instanced Vendor when given Vendors newVendorA and newVendorB | `Vendor.Find(2)` | newVendorB | ❌ |
| 19 | Returns an empty list when no instances of Order are added to an instance of Vendor | `newVendor.Orders` | { } | ❌ |
| 20 | Returns a list of instances of Order that are added to an instance of Vendor when given newOrderA and newOrderB | `newVendor.Orders` | { newOrderA, newOrderB } | ❌ |
</details>



#### 🏁 Running Tests:
* To run MSTest, verify you are in the root project folder and enter `dotnet restore PierreVendors.Tests` in your terminal.
* You should now see **'obj'** folders in both the **'PierreVendors.Tests'** folder and **'PierreVendors'** folder.
* At this point you should be able to successfully run `dotnet test PierreVendors.Tests` to perform the tests.

####  🖥️ View website:
*A GitHub page is not available for this project. To view functionality in your terminal you need to navigate to the **'PierreVendors'** folder using `cd PierresVendors` then `dotnet run`.*

## 🛠️ *Technologies used:*
* C# 9
* .NET Core v5.0
* Razor
* MSTest
* REPL
* Git and GitHub

## 🐛 *Known bugs:*
  * No known bugs.

## 📬 Contact Information
#### For any questions *[email Mike Pingel](mailto:mdpingel+github@gmail.com?subject=[GitHub]Epicodus%20Project%20-%20PierreVendors.Solution)*



## 📘 *License and copyright:*

> ***© Michael Pingel, 2021***  
> ⚖️ *[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)*