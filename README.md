# INTEGRATION PROJECT #1

## Project: ATM Simulator

### Description

This project aims to develop an ATM simulator using C# that modernizes a previous version of the application. It incorporates a MySQL database and features a graphical user interface that connects various views and models. The goal is to demonstrate skills in analysis, design, object-oriented development, and testing.

### Objectives

The main objectives of this project are:

- Interpret specifications and conduct analysis.
- Develop the required logic for an object-oriented solution and make it available to clients.
- Utilize troubleshooting tools and error handling techniques.
- Validate the solution through testing.

### Technologies Used

- **Programming Language**: C#
- **Database**: MySQL
- **Development Approach**: Object-oriented
- **User Interface**: Simple interface design


### Functional Specifications

#### User Login

- Users must enter their **client code** and **PIN**.
- Display error messages for failed attempts; after 3 failed attempts, the account is locked.

#### Client Information

Each client maintains the following information:

- **Client Code** (unique)
- **First and Last Name**
- **Phone Number**
- **Email Address**
- **PIN** (4 digits)

#### Account Types

Each client can have multiple accounts, with at least one checking account. Account types include:

1. **Checking** (mandatory)
2. **Savings**
3. **Mortgage**
4. **Credit Line** (one per client)

#### Transactions

Clients can execute the following transactions:

- **Deposit** (into checking, savings, or mortgage account)
- **Withdrawal** (from checking or savings)
- **Transfer** (between accounts)
- **Bill Payment** (with a fee of $1.25 deducted from the checking account)

#### Transaction Conditions

- Withdrawal amounts must be multiples of $10.
- Maximum withdrawal amount: $1000.
- Transaction history must be saved.
- Clients can check their balance at any time.

#### ATM Management

The ATM must manage a cash amount, affecting only withdrawals. Only withdrawals influence the ATM's cash balance.

#### Administrator Access

An administrator can:

- Create clients and accounts.
- View transactions per account.
- Lock or unlock client access.
- Add money to the ATM (maximum $20,000).
- Shut down the ATM.
- Pay interest (1%) to savings accounts.
- Withdraw specified amounts from a mortgage account.
- Increase credit lines by 5%.