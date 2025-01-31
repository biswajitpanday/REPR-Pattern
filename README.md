# REPR Pattern Implementation in .NET 8

This repository demonstrates the implementation of the REPR (Request-Endpoint-Response) pattern as an alternative to Minimal APIs and MVC, utilizing FastEndpoints in .NET 8. For More, please visit my Medium blog post: [Elevate Your .NET APIs with the REPR Pattern and FastEndpoints](https://medium.com/@biswajitpanday/elevate-your-net-apis-with-the-repr-pattern-and-fastendpoints-10c1b53e31b6).

## Table of Contents

- [Overview](#overview)
- [Features](#features)
- [Prerequisites](#prerequisites)
- [Installation](#installation)
- [Usage](#usage)
- [Architecture](#architecture)
- [Contributing](#contributing)
- [License](#license)
- [Acknowledgements](#acknowledgements)

## Overview

The REPR (Request-Endpoint-Response) pattern is a design approach that structures web API endpoints into three core components:
1. **Request**: Defines the structure of the incoming request.
2. **Endpoint**: Handles the request, processes the necessary logic, and interacts with services or databases.
3. **Response**: Defines the structure of the outgoing response.

This pattern streamlines development, improves code maintainability, and simplifies testing by structuring code around core API operations. For a detailed explanation, refer to the blog post: [Elevate Your .NET APIs with the REPR Pattern and FastEndpoints](https://medium.com/@biswajitpanday/elevate-your-net-apis-with-the-repr-pattern-and-fastendpoints-10c1b53e31b6).

## Features

- Implementation of the REPR pattern.
- Utilization of FastEndpoints for streamlined endpoint creation.
- Swagger documentation for easy API exploration.
- Example CRUD operations.

## Getting Started

## Prerequisites

- .NET SDK 8.0 or later.
- An IDE such as Visual Studio 2022 or Visual Studio Code.

### Installation

## Installation

1. **Clone the Repository**:

   ```bash
   git clone https://github.com/biswajitpanday/REPR-Pattern.git
   cd '.\REPR Pattern\REPR Pattern\'
   ```
   
2. Restore the dependencies:
   ```bash
   dotnet restore
   ```
   
3. Build the project:
   ```bash
   dotnet build
   ```

4. Run the Application:
   ```
   dotnet run
   ```
5. Access the Application:
   Open your browser and navigate to `http://localhost:<port>`
   
## Usage

1. Open your browser and navigate to http://localhost:{port}/swagger to explore the API using Swagger UI.
2. Test the API endpoints as described in the [blog post](https://medium.com/@biswajitpanday/elevate-your-net-apis-with-the-repr-pattern-and-fastendpoints-10c1b53e31b6).

## Architecture

The project follows the REPR pattern, structuring each endpoint into three components:

1. **Request**: Defines the data contract for the incoming request.
2. **Endpoint**: Contains the logic to process the request and interact with the necessary services or repositories.
3. **Response**: Defines the data contract for the outgoing response.

This approach promotes a clear separation of concerns, making the codebase more maintainable and testable.

## Contributing

Contributions are welcome! If you have suggestions for improvements or new features, please open an issue or submit a pull request. Ensure that your contributions align with the project's coding standards and include appropriate tests.

## License

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for details.

## Acknowledgements

Special thanks to Anderson Hansen for developing the project. Additionally, gratitude to the contributors of the FastEndpoints library and the authors of various articles on the REPR pattern for their valuable insights.
