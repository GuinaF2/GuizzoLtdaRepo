# 🚛 Guizzo Ltda - Transportation Management System

![.NET](https://img.shields.io/badge/.NET-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)
![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)
![MySQL](https://img.shields.io/badge/MySQL-000000?style=for-the-badge&logo=mysql&logoColor=white)
![Google Maps API](https://img.shields.io/badge/Google_Maps-4285F4?style=for-the-badge&logo=google-maps&logoColor=white)

> **A comprehensive Logistics & Transportation platform designed to optimize fleet management and route visualization.**

---

## 📖 About the Project

**Guizzo Ltda** is a robust management system developed to simulate real-world logistics operations. Moving beyond a simple academic exercise, this project tackles core business challenges such as role-based security, fleet tracking, and data integrity.

The application integrates with the **Google Maps API** to provide visual context for routes and locations, offering a complete dashboard for logistics managers.

---

## 📸 Screenshots

*(Add your project screenshots here to showcase the UI and the Map Integration)*

---

## 🚀 Key Features

* **🔐 Role-Based Access Control (RBAC):** Secure authentication system differentiating access levels between Administrators and standard Users.
* **🗺️ Google Maps Integration:** Real-time visualization of routes and locations directly within the application interface.
* **💾 Asset Management:** Complete system for uploading and managing fleet images/assets.
* **🛠️ Full CRUD Operations:** Optimized data handling for Vehicles, Drivers, and Routes using MySQL.

---

## 🏗️ Project Structure

The solution follows a structured architecture to ensure separation of concerns:

* `GuizzoLtda/` - Main application logic, Controllers, and Views.
* `Modelos/` - Data models and entities representing the database schema.
* `GuizzoLtda.sln` - Visual Studio Solution file.
* `bdguizzo.sql` - Database initialization script (Schema & Seed Data).

---

## 💻 Technologies Used

* **Core:** C# / .NET
* **Database:** MySQL
* **External APIs:** Google Maps API
* **IDE:** Visual Studio

---

## ⚡ Getting Started

Follow these steps to run the project locally:

### Prerequisites
* Visual Studio (2019 or later) with .NET workload installed.
* MySQL Server installed and running (local or remote).
* A valid **Google Maps API Key**.

### Installation

1.  **Clone the repository:**
    ```bash
    git clone [https://github.com/GuinaF2/GuizzoLtda.git](https://github.com/GuinaF2/GuizzoLtda.git)
    cd GuizzoLtda
    ```

2.  **Database Setup:**
    * Open your MySQL Workbench (or CLI).
    * Run the script `bdguizzo.sql` included in the root folder to create the database and tables.
    * *Tip: Check the connection string in `appsettings.json` (or `Web.config`) to match your local DB credentials (User/Password).*

3.  **🔑 API Configuration (Google Maps):**
    This project requires a valid Google Maps API Key to render the maps.
    * **Get an API Key:** Go to the [Google Cloud Console](https://console.cloud.google.com/), create a project, enable **Maps JavaScript API**, and generate a Key.
    * **Configure:** Open the solution in Visual Studio.
    * Navigate to the View where the map is rendered (e.g., `Views/Shared/_Layout.cshtml` or the specific View).
    * Find the script tag and replace `YOUR_API_KEY` with your actual key:
        ```html
        <script src="[https://maps.googleapis.com/maps/api/js?key=YOUR_API_KEY_HERE&callback=initMap](https://maps.googleapis.com/maps/api/js?key=YOUR_API_KEY_HERE&callback=initMap)" async defer></script>
        ```

4.  **Run:**
    * Open `GuizzoLtda.sln` in Visual Studio.
    * Press `F5` or click **Start** to build and launch the application.

---

## 🤝 Contact

**Guilherme Henrique** - Software Developer  
[LinkedIn](https://www.linkedin.com/in/guilherme-henrique-oli-dasilva/) | [GitHub](https://github.com/GuinaF2)
