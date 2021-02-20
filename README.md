# BudgetTracker
BudgetTracker API

## Features
- [x] User can create multiple wallets
- [ ] Wallet have many transactions
- [ ] Transaction belong to a category of type (Revenue, Expense)

## API Endpoints

| Method | URI                    | Operation | Description                        |
| ------ | ---------------------- | --------- | ---------------------------------- |
| POST   | /api/wallets           | Create    | Add new wallet record              |
| PUT    | /api/wallets/{id}      | Update    | Update existing wallet record      |
| DELETE | /api/wallets/{id}      | Delete    | Delete existing wallet record      |
| GET    | /api/wallets           | Read      | Get all wallets records            |
| GET    | /api/wallets/{id}      | Read      | Get wallet record by ID            |
| POST   | /api/transactions      | Create    | Add new transaction record         |
| PUT    | /api/transactions/{id} | Update    | Update existing transaction record |
| DELETE | /api/transactions/{id} | Delete    | Delete transaction record          |
| GET    | /api/transactions      | Read      | Get all transactions records       |
| GET    | /api/transactions/{id} | Read      | Get transaction record by ID       |
| POST   | /api/categories        | Create    | Add new category record            |
| PUT    | /api/categories/{id}   | Update    | Update existing category record    |
| DELETE | /api/categories/{id}   | Delete    | Delete existing category record    |
| GET    | /api/categories        | Read      | Get all categories records         |
| GET    | /api/categories/{id}   | Read      | Get category record by ID          |
