# Pokemon Review App

The **Pokemon Review App** is an introductory project to familiarize yourself with ASP.NET Web API concepts and working with SQL databases. The app allows users to access and edit reviews of various Pokémon through a web-based API.

## Table of Contents

- [Installation](#installation)
- [Usage](#usage)
- [Configuration](#configuration)
- [Features](#features)
- [Contributing](#contributing)
- [License](#license)
- [Credits](#credits)
- [Contact Information](#contact-information)

## Installation

1. **Prerequisites**:
    - [.NET SDK](https://dotnet.microsoft.com/download) installed on your local machine.
    - [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) or another compatible SQL database.

2. **Clone the Repository**:
    ```bash
    git clone https://github.com/navdeep5/Pokemon_Review_App.git
    ```

3. **Set Up the Database**:
    - Create a new database using your preferred SQL database tool.
    - Import or create the required tables following the descriptions in the Models.

4. **Configure the App**:
    - Update the connection string in the `appsettings.json` file to point to your SQL database.
    - Customize other settings in the configuration file as necessary.

5. **Run the App**:
    ```bash
    dotnet run
    ```

The app should now be running on the default port, which is typically `http://localhost:5000`.

## Usage

- Once the app is running, you can interact with the API through Swagger.

## Configuration

- The primary configuration file for the application is `appsettings.json`.
- Update the `ConnectionStrings:DefaultConnection` value to match your SQL database connection.
- Customize other settings as needed based on your use case.

## Features

- **CRUD Operations**: Perform Create, Read, Update, and Delete operations on Pokémon reviews.
- **SQL Database Integration**: Utilize an SQL database to store and manage review data.
- **Authentication and Authorization**: Optional features that can be implemented in future iterations.

## Contributing

- Contributions are welcome! If you have any suggestions or improvements, please submit a pull request.

## License

- This project is licensed under the [MIT License](LICENSE). Feel free to use and modify the code as you wish.

## Credits

- This project was created as an educational exercise to explore ASP.NET Web API and SQL database integration.
- Any third-party libraries or resources are credited in the project.

## Contact Information

- For questions or feedback, feel free to [open an issue](#) or reach out..
