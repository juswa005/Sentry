# Sentry – RFID Attendance Monitoring System

Sentry is an **RFID-based attendance monitoring system** built using **Arduino Uno** and a **C# desktop application**.
The system allows users to scan RFID cards to automatically record **Time-In and Time-Out** into a database and display attendance records in a user-friendly interface.

This project aims to provide a **simple, efficient, and automated attendance tracking solution** for schools, organizations, or offices.

---

## Features

* 📡 **RFID Card Scanning** using Arduino Uno
* 🖥 **Desktop Application (C# / .NET)**
* 🗄 **SQL Server Database Integration**
* ⏱ **Automatic Time-In / Time-Out Logging**
* 📊 **Attendance Dashboard**
* 👥 **Resident/User Management**
* 🔄 **Real-time Serial Communication**
* 📅 **Attendance History Tracking**

---

## System Architecture

```
RFID Card
   │
   ▼
Arduino Uno + RFID Reader
   │ (Serial Communication)
   ▼
C# Desktop Application
   │
   ▼
SQL Server Database
```

---

## Technologies Used

* **Arduino Uno**
* **RFID Module (MFRC522)**
* **C# (.NET / WPF or WinForms)**
* **SQL Server LocalDB**
* **Serial Communication (COM Ports)**

---

## Hardware Requirements

* Arduino Uno
* MFRC522 RFID Reader
* RFID Cards / Tags
* USB Cable
* Computer running Windows

---

## Software Requirements

* Arduino IDE
* .NET Framework / .NET SDK
* Visual Studio
* SQL Server LocalDB

---

## Installation

### 1. Clone the Repository

```bash
git clone https://github.com/juswa005/Sentry.git
cd Sentry
```

---

### 2. Upload the Arduino Code

1. Open the Arduino IDE
2. Connect the **Arduino Uno**
3. Upload the RFID reader sketch included in the project

---

### 3. Setup the Database

1. Open the project in **Visual Studio**
2. Configure the connection string
3. Ensure the `.mdf` database file is correctly linked

Example connection string:

```
Data Source=(LocalDB)\MSSQLLocalDB;
AttachDbFilename=|DataDirectory|\Attendance.mdf;
Integrated Security=True
```

---

### 4. Run the Application

1. Build the project
2. Run the desktop application
3. Connect to the correct **COM port**
4. Start scanning RFID cards

---

## Usage

1. Launch the **Sentry Application**
2. Connect the RFID scanner
3. Scan an RFID card
4. The system automatically records:

   * User ID
   * Date
   * Time In / Time Out
5. View attendance records in the dashboard.

---

## Project Structure

```
Sentry
│
├── Arduino
│   └── RFID Reader Code
│
├── Desktop Application
│   ├── UI
│   ├── Database
│   └── Serial Communication
│
└── Database
    └── Attendance.mdf
```

---

## Future Improvements

* 📱 Mobile notification support
* ☁ Cloud database support
* 📊 Attendance analytics
* 🔐 User authentication
* 🧠 AI-based attendance insights

---

## Contributing

Contributions are welcome!

1. Fork the repository
2. Create a new branch
3. Commit your changes
4. Open a pull request

---

## License

This project is licensed under the **MIT License**.

---

## Author

**Amiel Josh Basug**

GitHub:
[https://github.com/juswa005](https://github.com/juswa005)

