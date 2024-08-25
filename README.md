# CarWorkshop

## Project Description

**CarWorkshop** is a modern web application designed for managing an automotive workshop. The application facilitates efficient management of repair orders, customers, and vehicles, supporting the administrative processes of the workshop. The project was built using ASP.NET Core MVC, providing a robust framework that allows for future growth and scalability.

## Features

### 1. **Repair Order Management**
   - Create, edit, and delete repair orders.
   - Assign orders to customers and their vehicles.
   - Track the status of repairs from vehicle intake to completion.

### 2. **Customer Management**
   - Add, edit, and delete customer information.
   - Store contact details and repair history associated with the customer.
   - View a list of all workshop customers.

### 3. **Vehicle Management**
   - Register customer vehicles, including detailed information such as make, model, license plate number, and year of production.
   - Assign vehicles to corresponding repair orders.

### 4. **User-Friendly Interface**
   - A simple and intuitive interface that allows easy navigation through the application.
   - Responsive design enabling usage on various devices, including mobile.

### 5. User Views and Roles

The **CarWorkshop** application supports three main user roles: **Owner**, **Moderator**, and **User**. Each of these roles has different levels of access to the application’s features and views, ensuring appropriate control over workshop management and vehicle repair operations.

#### 1. Owner

The **Owner** role has the highest level of access within the **CarWorkshop** application. Users with this role have full control over all system features, including user management and advanced administrative functions.

##### Key Features and Views:

- **Admin Panel**: Full access to the admin panel, managing all aspects of the application.
- **User Management**: Add, edit, and delete users, and assign roles (Owner, Moderator, User).
- **Order Management**: View, edit, delete, and assign repair orders to users and moderators.
- **Application Module Management**: Configure application modules, including external integrations, system settings, and notification configurations.

#### 2. Moderator

The **Moderator** role has mid-level access, designed for users who handle the daily operations of the workshop. Moderators can manage repair orders and customers but do not have access to advanced system settings or user management.

##### Key Features and Views:

- **Order Management**: Create, edit, and manage repair orders, tracking repair progress.
- **Customer Management**: Add, edit, and delete customer information, and view repair history.
- **Vehicle Overview**: Browse and edit vehicle data assigned to repair orders.

#### 3. User

The **User** role has basic access, intended for workshop employees or customers using the application. Users have limited access to features, focusing on viewing repair orders and statuses.

##### Key Features and Views:

- **Order Overview**: View repair orders assigned to them and check repair statuses.
- **Vehicle Overview**: Browse vehicle data assigned to repair orders without editing.
- **Limited Customer View**: View basic customer information related to their orders.
- **Notifications**: Receive notifications about order progress and repairs.

#### Summary

The role-based access control in **CarWorkshop** ensures that each user has access to the features necessary for their responsibilities, making the application both secure and user-friendly.

## Technologies and Tools

- **ASP.NET Core MVC** - The main technology used to build the application, providing a solid foundation for creating web applications.
- **Entity Framework Core** - Used as an ORM to manage the database, facilitating easy object-relational mapping.
- **SQL Server** - The database used to store information about customers, vehicles, and orders.
- **Bootstrap** - A CSS framework that helped create a responsive and modern user interface.
- **Git** - Version control system used to manage the project’s source code.
- **Visual Studio** - The development environment used to implement the application.

## Sample Screenshots

Below are examples of the application screens:

- **Order List**: A view displaying a list of all repair orders.
  ![image](https://github.com/user-attachments/assets/891a8c15-89fb-437e-80e3-1595db4a911b)

- **Add CarWorkshop Form**: A view that allows adding a new CarWorkshop to the system.
  ![image](https://github.com/user-attachments/assets/cc830cd8-b5ac-4c0f-b2e6-4540a00ffd0e)

- **Edit CarWorkshop Form**: A view that allows editing a new CarWorkshop from the system.
![image](https://github.com/user-attachments/assets/6fe3860b-4afe-4edf-8356-5b1d55ed6dc6)

## Future Development

- **Notification System**: Implementing email notifications to inform customers about the progress of their repairs.
- **Expanded Reporting Module**: Adding more advanced data analysis features.
- **Payment System Integration**: Allowing customers to directly pay for orders through the application.

## Conclusion

The **CarWorkshop** project is a comprehensive web application designed to optimize the management processes of an automotive workshop. Developing this project provided valuable experience in working with ASP.NET Core MVC and creating complex business applications.
