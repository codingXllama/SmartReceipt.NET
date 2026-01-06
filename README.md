# SmartReceipt.NET
🧾**SmartReceipt**.NET is a C# application designed to scan receipts and extract essential purchase information.

## Table of Contents

1. [SmartReceipt.NET](#smartreceiptnet)
2. [E - Issue](#-e---issue)
3. [S - Solution](#-s---solution)
    - [MVP Expectations](#mvp-expectations)
4. [P - Proposal / Plan / Payoff](#-p---proposal--plan--payoff)
    - [Plan (MVP)](#plan-mvp)
    - [Payoff](#payoff)
5. [Software Architecture Diagram](#-software-architecture-diagram)
6. [Class Diagram](#class-diagram)
7. [Features](#-features)


## ✅ Features
1. Home page & receipt list pages.
2. Upload Receipt
3. Review expenses
4. *Authentication

##  E - Issue

1. Most receipt scanning apps collect user data and may share it with third parties, exposing users to unwanted advertising.
2. Many receipts accumulate without providing meaningful insight into daily expenses or spending habits.
3. Users often lack clarity on item costs, making it difficult to find the best prices at different stores or markets.
4. People may not know which purchases are driven by necessity versus emotional spending.


## S - Solution

### MVP Expectations:
  1. Users can upload images of receipts for processing.
  2. The application automatically identifies and displays:
  3. Date of purchase
  4. Total amount spent
  5. Itemized list of purchased products with prices
  6. Provides a clear, easy-to-read summary of expenses.
  7. *Protects user privacy by ensuring that no personal information is collected or shared.


## P - Proposal / Plan / Payoff

### Plan (MVP):
1. Accept receipt images as input.
2. Extract the date, total, and itemized list from the image.
3. Display the extracted information in the console or simple interface.

### Payoff:
1. Helps users understand and track their spending at a glance.
2. Serves as a foundation for future enhancements like reporting, analytics, or integrations.


###  Software Architecture Diagram

<img width="684" height="548" alt="SmartReceipt NET _ Receipt Scanning   Expense Analytics drawio" src="https://github.com/user-attachments/assets/7cc081eb-f5ea-4eee-9141-89abd756e1d7" > 



### Class Diagram
## <img width="656" height="1014" alt="image" src="https://github.com/user-attachments/assets/22894050-81bb-4eab-a16f-75aaf4c7a733" />

<!-- <img width="4370" height="1084" alt="smartReceiptApp-Class Diagram" src="https://github.com/user-attachments/assets/68568271-12d8-4eca-9535-ea0f4cf67525" /> -->

## Tech Stack
1. .NET 10
2. ASP.NET Core Web API
3. SQLIte (EF Core)
4. Blazor (UI)
5. Swagger (API Testing)

## Getting Started

### Prerequisites
- .NET SDK 9 or later
- Git

### Run locally
git clone https://github.com/codingXllama/SmartReceipt.NET.git
cd "SmartReceipt.NET\Current\SmartReceipts.NET - ExpenseManager"
dotnet restore
dotnet ef database update
dotnet run

👉To Open:
1. API & UI: https://localhost:5170
2. Swagger: https://localhost:5170/swagger




