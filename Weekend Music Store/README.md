# WeekendMusicStore

"Weekend Music Store", An E-Commerce Shop
Software Development-II project, Group-9 (2.1)

CSE 43, Ahsanullah University of Science and Technology

Developed by:
Saidur Rahman Sujon [190104049]
S.M. Raiyan Reza Rabab [190104039]
Asif Hridoy [190104047]
Ash Rafi [180104099]

Software tools:
JavaFX 
MySQL
SceneBuilder by Gluon
XAMPP by Apache Friends

Music: www.bensound.com

!!! INSTRUCTIONS !!!
1. Import the sql database to mysql
2. Remember to start the Apache & MySQL server in XAMPP before starting the application.
3. Execute the WeekendMusicStore.jar file from "../dist/WeekendMusicStore.jar"


![](RackMultipart20230708-1-o92odt_html_c263c4643f56509f.png)



## **Introduction**

An E-Commerce shop is a site for purchasing various products online. In other words, it is a virtual market. Common sites include Amazon, Daraaz, FoodPanda etc. Weekend Music Store (WMS) is a demo of such a site where users can browse through various products, customly modify and order them.

## **Motivation**

The four of us are very much interested in music. So, we decided to put this interest in our Software Dev. II project. We used our earned knowledge of Java, JavaFX, MySQL, and CSS to create an offline shopping store that sells music products and stores information in a database.

## **Project Description**

The aim of this project is to create a user-friendly software that works as a demo of an online store where users can create an account, log in and then browse through a wide catalog of intruments. WMS provides three categories of instruments: Strings (guitar, bass etc), Keys (keyboard, piano etc) and Percussions (drums, tabla etc).

There will be two types of accounts: user and admin. The user accounts are for customers, where once they log in, they will be redirected to the home page. The admin account log in will redirect to the admin panel. All the user and admin login info are stored in a MySQL database.

At the beginning of the program, there will be three welcome pages. In the third page, clicking the 'Next' button will take us to the login page.

![](https://github.com/SR-Sujon/University-Projects/blob/main/Weekend%20Music%20Store/WeekendMusicStore/imges/Image2.jpeg) 

_Fig: Welcome pages_

In the login page, there are two tabs. The 'Sign Up' tab will let us create a new account by adding email, username, password, and our address. When the email and password is in correct format, and the username is unique, registration will be successful, and the four data will be stored in database.

![](https://github.com/SR-Sujon/University-Projects/blob/main/Weekend%20Music%20Store/WeekendMusicStore/imges/Image6.jpeg)

_Fig: Signing up_

Using a pre-existing or a newly opened account, we can log in when the password and the username or email matches.

![](https://github.com/SR-Sujon/University-Projects/blob/main/Weekend%20Music%20Store/WeekendMusicStore/imges/Image7.jpeg)

_Fig: Signing in_

After signing in, the home page will appear, and users can browse through various instruments. On the left tab, a preview of a selected product will be shown, with its name, price, category, and type. On the top right, a label will show the username.

![](https://github.com/SR-Sujon/University-Projects/blob/main/Weekend%20Music%20Store/WeekendMusicStore/imges/Image8.jpeg)

_Fig: Home Page_

Once we find our desired product, we will press the 'Buy Now!' button, which will take us to a product description page. We can choose our desired color here too, using the 'Color' ChoiceBox.

![](https://github.com/SR-Sujon/University-Projects/blob/main/Weekend%20Music%20Store/WeekendMusicStore/imges/Image9.jpeg)

_Fig: Product Information page_

Now, when we press the 'Confirm' button, we will be taken to the payment page. We can select the amount and the subtotal price will show. On the right, we will provide out payment info: name, card no., exp date and PIN no., which will be in a password field. Then we press the 'Check Out' button, and a prompt window will say "Payment successful!". If the inputted info is wrong/empty, it will show "Please provide correct information".

![](https://github.com/SR-Sujon/University-Projects/blob/main/Weekend%20Music%20Store/WeekendMusicStore/imges/Image10.jpeg)

_Fig: Payment Information page_

After we purchase, the information will go to the database, all of which can be seen in the admin panel. To check the admin panel, we are to sign into an admin account.

After we do, this page will show. The dashboard shows the sales statistics, number of customers, total products in stock and the top sold products.

![](https://github.com/SR-Sujon/University-Projects/blob/main/Weekend%20Music%20Store/WeekendMusicStore/imges/Image11.jpeg)

_Fig: Admin Panel: Dashboard_

The inventory shows information of every product in stock. In the left panel, we can input information about any product. The button 'Add' adds that new item into the stock, button 'Delete' removes that item from stock, button 'Search' will show the item(s) we searched for, button 'Edit' edits the info, button 'Clear' empties the input fields and button 'Refresh' refreshes the whole page.

![](https://github.com/SR-Sujon/University-Projects/blob/main/Weekend%20Music%20Store/WeekendMusicStore/imges/Image12.jpeg)

_Fig: Admin Panel - Inventory_

The Sales panel shows info about the products sold. For example, after we purchased the 'Fender Stratocaster' earlier in the payment page, the product's name, ID, and paid amount will show, along with transaction ID and the buyer's other info. The 'Search' and 'Refresh' button will allow us to search for a specific sale and refresh the list, respectively.

![](https://github.com/SR-Sujon/University-Projects/blob/main/Weekend%20Music%20Store/WeekendMusicStore/imges/Image13.jpeg)

_Fig: Admin Panel - Sales_

The Users panel will show the list of customer accounts in WMS database. The admin can create a new user by clicking the 'Add' button, which will show a new user info page to create a new account. We use the 'Search', 'Delete', 'Update' and 'Refresh' buttons to search an account in the textField (which will show in the list), delete an account, edit a user info, and refresh the entire list, respectively.

![](https://github.com/SR-Sujon/University-Projects/blob/main/Weekend%20Music%20Store/WeekendMusicStore/imges/Image14.jpeg)

_Fig: Admin Panel - Users_

![](https://github.com/SR-Sujon/University-Projects/blob/main/Weekend%20Music%20Store/WeekendMusicStore/imges/Image15.jpeg)

_Fig: Admin Panel - New User Info_

As all the information in our Java project will be stored in a database, we have made four tables under a 'jarvis':

**Admins:** stores admin accounts and their information. It used during admin login.

**Users:** stores user accounts and their information. It is used during user login and in the 'Users' section in the admin panel.

**Inventory:** stores all the product information in stock. It is used in the 'Inventory' section in the admin panel.

**Payment:** stores all the information about sold products. It is used in the 'Sales' section in the admin panel.

![](https://github.com/SR-Sujon/University-Projects/blob/main/Weekend%20Music%20Store/WeekendMusicStore/imges/Image16.jpeg)

_Fig: Admin database_



## **Features**

Welcome pages, sign in page, registration (using email, username, password and address), sign out, admin and user accounts, Home page, product display using gridPane, product details (name, price, category and type), product preview (showing details), Product Info page, Payment page, amount picker, payment info (name, card no, exp date and PIN), admin panel, dashboard (sales stats), inventory (stock), sale info, user account info, search bar, buttons (add, delete, search, update, clear, refresh), MySQL databases.

## **Software Tools**

- **Java:** The coding language (JDK 1.8).
- **JavaFX:** The library we used to create our GUI's. Some libraries used are: EventHandler, FXMLLoader, ActionEvent, MouseEvent, ArrayList, ObservableList etc.
- **NetBeans 8.2:** Our IDE for coding.
- **Scene Builder:** Third-party software for manually creating GUI layout.
- **Xampp:** Software to connect to MySQL.
- **MySQL:** Our database.
- **SQL:** Coding language for our database.
- **STL:**

- **ArrayList\<\>:** A data structure of type class 'Product', to store all data of our products.
- **ObservableList\<\>:** A data structure of type 'users', to store all data of our users.
- mysql-connector-java-8.0.23.jar
- javafx.swing.jar
- javafx.media.jar
- javafx.graphics.jar
- javafx.fxml.jar
- javafx.controls.jar
- javafx.base.jar
- javafx-swt.jar

- **FXML:**

- Tab, TabPane, Button, TextField, PasswordField, TableView, GridPane, ScrollPane, ChoiceBox, DatePicker etc.

- **CSS:** Codes written to import into our FXML documents for specific designs.
- **DBConnection:** Class to connect to Java to database.
- **Controller:** Class to control the FXML files.

## **Conclusion**

We have tried to make our software as much as like mainstream online shops as possible. Maintaining 100% accuracy was not possible; there were a few limitations, and we faced many difficulties while making the project. However, we managed to add all the basic features, and the overall project was satisfactory.
