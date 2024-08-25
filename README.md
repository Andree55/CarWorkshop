# CarWorkshop

## Project Description

**CarWorkshop** is a modern web application designed to efficiently manage an automotive workshop. The application allows for streamlined management of repair orders, vehicles, and general workshop operations. Built with ASP.NET Core MVC, the project offers a scalable framework for future enhancements and growth.

## Features

### 1. Repair Order Management
- Create, edit, and delete repair orders.
- Assign orders to specific vehicles.
- Track the status of repairs from vehicle intake to completion.

### 2. Vehicle Management
- Register customer vehicles, including detailed information such as make, model, license plate number, and year of production.
- Assign vehicles to corresponding repair orders.

### 3. User-Friendly Interface
- Simple and intuitive navigation through the application.
- Responsive design optimized for various devices, including mobile.

### 4. Main Navigation
- **Home**: Landing page with an overview and introductory information about the application.
- **About**: Provides detailed information about the application and its purpose.
- **Privacy**: Outlines the privacy policies and data protection measures implemented in the application.
- **Car Workshops**: Main section for managing and viewing details about different car workshops, including options to create new workshops and edit existing ones.

### 5. User Roles and Views

The **CarWorkshop** application supports three main user roles: **Owner**, **Moderator**, and **User**. Each role has specific access levels to ensure appropriate control and operation within the workshop.

#### 1. Owner
- Full access to all system features, including advanced administrative functions.
- **Key Features and Views**:
  - **Admin Panel**: Manage all aspects of the application, including user roles.
  - **Order Management**: Complete control over repair orders and assignment.
  - **Application Settings**: Configure system settings and external integrations.

#### 2. Moderator
- Access to manage repair orders and oversee workshop operations, with some restrictions on advanced settings.
- **Key Features and Views**:
  - **Order Management**: Create, edit, and track repair orders.
  - **Vehicle Overview**: Manage vehicle data related to repair orders.

#### 3. User
- Basic access focused on viewing assigned repair orders and their statuses.
- **Key Features and Views**:
  - **Order Overview**: View repair orders assigned to them.
  - **Vehicle Overview**: Browse related vehicle data without editing privileges.

## Sample Screenshots

Below are examples of the application screens:

- **Car Workshops**: A view displaying a list of all CarWorkshops.
  
  ![Order List](https://github.com/user-attachments/assets/891a8c15-89fb-437e-80e3-1595db4a911b)

- **Add CarWorkshop Form**: A view that allows adding a new CarWorkshop to the system.
  
  ![Add CarWorkshop](https://github.com/user-attachments/assets/cc830cd8-b5ac-4c0f-b2e6-4540a00ffd0e)

- **Edit CarWorkshop Form**: A view that allows editing a CarWorkshop in the system.
  
  ![Edit CarWorkshop](https://github.com/user-attachments/assets/6fe3860b-4afe-4edf-8356-5b1d55ed6dc6)

 ## Technologies and Tools

- **ASP.NET Core MVC**: The primary framework used for building the application.
- **Entity Framework Core**: Used for managing the database through object-relational mapping (ORM).
- **SQL Server**: Database for storing customer, vehicle, and order data.
- **Bootstrap**: CSS framework for creating a responsive, modern UI.
- **Git**: Version control for managing source code.
- **Visual Studio**: Development environment for implementing the application.

## Future Development

- **Notification System**: Implementing email notifications to inform customers about the progress of their repairs.
- **Expanded Reporting Module**: Adding more advanced data analysis features.
- **Payment System Integration**: Allowing customers to directly pay for orders through the application.

## Conclusion

The **CarWorkshop** project is a comprehensive web application designed to optimize the management processes of an automotive workshop. Developing this project provided valuable experience in working with ASP.NET Core MVC and creating complex business applications.
