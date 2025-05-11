# FullStackApp

## Summary
FullStackApp is a full-stack web application consisting of a server-side API (`ServerApp`) and a client-side Blazor WebAssembly application (`ClientApp`). The application demonstrates a simple product listing feature where products are fetched from the server and displayed on the client.

### Features
- **ServerApp**: Provides an API endpoint (`/api/products`) to serve product data.
- **ClientApp**: Fetches product data from the server and displays it in a user-friendly interface.

## Changes Made
1. **Removed Unnecessary Code**:
   - Removed the Counter and Weather components from the client-side application as they were no longer needed.
   - Deleted associated files (`Counter.razor`, `Weather.razor`, and `weather.json`).

2. **Implemented Product Fetching**:
   - Added an API call in the `FetchProducts.razor` component to fetch product data from the server.
   - Refactored the code for better readability and maintainability by extracting the API call logic into a separate method.

3. **Error Handling**:
   - Added error handling in the `FetchProducts.razor` component to gracefully handle invalid API responses and timeouts.

4. **CORS Configuration**:
   - Configured CORS in the `ServerApp` to allow requests from the client origin (`http://localhost:5252`).

## How AI Helped
AI played a significant role in the development process by:
- **Code Refactoring**: Suggested improvements for code readability and maintainability.
- **Error Handling**: Added robust error handling mechanisms to ensure a smooth user experience.
- **CORS Configuration**: Identified and resolved CORS issues by adding the necessary middleware to the server.
- **File Cleanup**: Assisted in identifying and removing unused files and code.
- **Documentation**: Generated this README file to summarize the application and the changes made.

## How to Run
1. **Start the Server**:
   - Navigate to the `ServerApp` directory.
   - Run the server using `dotnet run`.

2. **Start the Client**:
   - Navigate to the `ClientApp` directory.
   - Run the client using `dotnet run`.

3. **Access the Application**:
   - Open a browser and navigate to `http://localhost:5252` to view the client application.

## Future Improvements
- Add authentication and authorization.
- Implement a database for persistent product storage.
- Enhance the UI with additional features and styling.
