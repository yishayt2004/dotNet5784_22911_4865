# Garage Management Software

## Overview
This project is our first venture into building a complex software application using C#. The Garage Management Software focuses on employee task management within a garage setting. We utilized XML files for data storage and implemented a three-layer architecture for organization and maintenance.

## Features
- **User Authentication**: Two types of users are supported:
  - Manager: Accessible with a password, has privileges to manage tasks, assign them to employees, and set task parameters such as times and urgency.
  - Employee: Accessible with an identity card, can update task details, add comments and deliverables, and change task statuses.

- **Task Management**: Users can create, assign, update, and track tasks. Tasks can have various levels of difficulty and dependencies, allowing for effective project planning and execution.

- **Gantt Chart Generation**: The application automatically generates Gantt charts to visualize task timelines and dependencies, aiding in project management and scheduling.

## Future Development
We believe that the project can be further developed to incorporate additional features and enhancements, making it even cooler and more convenient to use. Some potential areas for improvement include:
- Integration with other tools and platforms for seamless collaboration and workflow management.
- Enhancements to the user interface for improved usability and aesthetics.
- Implementation of additional functionality such as notifications, reporting, and analytics.
- Integration with cloud services for data storage and synchronization.
- Support for mobile platforms to enable access from anywhere, anytime.

## Project Structure
The solution is divided into multiple layers:  
- **PL (Presentation Layer)** – Handles the UI and user interactions.  
- **BL (Business Logic Layer)** – Contains the core logic of the application.  
- **DalFacade (Data Access Layer Facade)** – Interface between BL and data sources.  
- **DalList / DalXml (Data Access Layer Implementations)** – Different implementations for data storage.  

## Contributors
- Eitan Lattes
  - Email: [eitanlattes@gmail.com](mailto:eitanlattes@gmail.com)
  - GitHub: [EitanMchon](https://github.com/EitanMchon)
    
- Yishay Shlomo Tiram
  - Email: [ishayshlomotiram@gmail.com](mailto:ishayshlomotiram@gmail.com)
  - GitHub: [yishayt2004](https://github.com/yishayt2004)


## Usage
1. Clone the repository.
2. Open the project in your preferred C# development environment.
3. Build the solution.
4. Run the application.
5. Follow the prompts for user authentication and task management.

## Technologies Used
- C#
- XML
- LINQ (Language Integrated Query)
- Three-layer Architecture
- WPF (Windows Presentation Foundation)

## Requirements
- **.NET Framework** (Version X.X)  
- **Visual Studio**  
- **Windows OS**  

## Contributing
Feel free to submit issues or pull requests to improve the project.  

## License
This project is licensed under the **MIT License**.  
