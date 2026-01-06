# 🧾 SmartReceipt.NET

[![.NET](https://img.shields.io/badge/.NET-10-blue)](https://dotnet.microsoft.com/)
[![License](https://img.shields.io/badge/License-MIT-green.svg)](https://opensource.org/licenses/MIT)
[![GitHub stars](https://img.shields.io/github/stars/codingXllama/SmartReceipt.NET)](https://github.com/codingXllama/SmartReceipt.NET/stargazers)

**SmartReceipt.NET** is a C# application designed to scan receipts and extract essential purchase information, helping users track expenses privately and efficiently.

## 📋 Table of Contents

- [🧾 SmartReceipt.NET](#-smartreceiptnet)
- [🚨 E - Issue](#-e---issue)
- [💡 S - Solution](#-s---solution)
  - [MVP Expectations](#mvp-expectations)
- [📈 P - Proposal / Plan / Payoff](#-p---proposal--plan--payoff)
  - [Plan (MVP)](#plan-mvp)
  - [Payoff](#payoff)
- [🏗️ Software Architecture Diagram](#-software-architecture-diagram)
- [📊 Class Diagram](#-class-diagram)
- [✅ Features](#-features)
- [🛠️ Tech Stack](#️-tech-stack)
- [🚀 Getting Started](#-getting-started)
  - [Prerequisites](#prerequisites)
  - [Run Locally](#run-locally)

## ✅ Features

- [x] Home page & receipt list pages
- [x] Upload Receipt
- [x] Review expenses
- [ ] Authentication (planned)

## 🚨 E - Issue

1. **Privacy Concerns**: Most receipt scanning apps collect user data and may share it with third parties, exposing users to unwanted advertising.
2. **Lack of Insights**: Many receipts accumulate without providing meaningful insight into daily expenses or spending habits.
3. **Price Comparison**: Users often lack clarity on item costs, making it difficult to find the best prices at different stores or markets.
4. **Spending Awareness**: People may not know which purchases are driven by necessity versus emotional spending.

## 💡 S - Solution

### MVP Expectations:
- [x] Users can upload images of receipts for processing
- [x] The application automatically identifies and displays:
  - Date of purchase
  - Total amount spent
  - Itemized list of purchased products with prices
- [x] Provides a clear, easy-to-read summary of expenses
- [x] Protects user privacy by ensuring that no personal information is collected or shared

## 📈 P - Proposal / Plan / Payoff

### Plan (MVP):
1. Accept receipt images as input
2. Extract the date, total, and itemized list from the image
3. Display the extracted information in the console or simple interface

### Payoff:
- Helps users understand and track their spending at a glance
- Serves as a foundation for future enhancements like reporting, analytics, or integrations

## 🏗️ Software Architecture Diagram

<img width="684" height="548" alt="SmartReceipt NET _ Receipt Scanning & Expense Analytics drawio" src="https://github.com/user-attachments/assets/7cc081eb-f5ea-4eee-9141-89abd756e1d7">

## 📊 Class Diagram

<img width="656" height="1014" alt="image" src="https://github.com/user-attachments/assets/22894050-81bb-4eab-a16f-75aaf4c7a733">

<!-- <img width="4370" height="1084" alt="smartReceiptApp-Class Diagram" src="https://github.com/user-attachments/assets/68568271-12d8-4eca-9535-ea0f4cf67525" /> -->

## 🛠️ Tech Stack

| Component | Technology |
|-----------|------------|
| Framework | .NET 10 |
| Web API | ASP.NET Core |
| Database | SQLite (EF Core) |
| UI | Blazor |
| API Testing | Swagger |

## 🚀 Getting Started

### Prerequisites
- .NET SDK 9 or later
- Git

### Run Locally
1. Clone the repository:
   ```bash
   git clone https://github.com/codingXllama/SmartReceipt.NET.git
   ```
2. Navigate to the project directory:
   ```bash
   cd "SmartReceipt.NET\Current\SmartReceipts.NET - ExpenseManager"
   ```
3. Restore dependencies:
   ```bash
   dotnet restore
   ```
4. Update the database:
   ```bash
   dotnet ef database update
   ```
5. Run the application:
   ```bash
   dotnet run
   ```

👉 **Access the app:**
- API & UI: [https://localhost:5170](https://localhost:5170)
- Swagger: [https://localhost:5170/swagger](https://localhost:5170/swagger)

---

*Made with ❤️ for better expense tracking.*




