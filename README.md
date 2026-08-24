# Day Trading App

A C# WinForms desktop application that lets users create an account, securely log in, and track stocks through a personalized watchlist. 
It combines a local database for fast offline browsing with a cloud backend for account/data sync.

## Overview

This app simulates the core experience of a day-trading platform: account creation, login, browsing a market report, viewing stock price history on a chart, and maintaining a personal watchlist of stocks to follow.

## Features

- **Account creation & login** (`LoginSignUp`, `AccountDetailsForm`)
- **Home dashboard** (`HomeView`) as the main landing screen after login
- **Market Report** (`MarketReport`) for browsing available stocks
- **Stock detail & charting** (`StockGraph`) to visualize price history for a selected stock
- **Personalized watchlist** (`watchlistControl`, `WatchlistModel`) so users can track specific stocks
- **Filtering** (`FilterForm`) to narrow down the stock list
- **Custom UI components**, including a custom scrollbar (`SimpleScrollBar`) and nav menu (`navMenu`)

## Architecture

```
models/         → StockModel, WatchlistModel, userModel
Components/     → Custom WinForms controls (watchlistControl, stockDetails, navMenu, etc.)
SupabaseClient.cs → Client wrapper for connecting to Supabase (cloud backend)
HomeView.cs     → Main application dashboard
StockGraph.cs   → Chart rendering for stock price history
```

## Tech Stack

- **C# / .NET Framework** — WinForms
- **SQLite** — local database for offline stock data (browsing/testing without a live connection)
- **Supabase** — cloud backend client, intended for persisting user accounts and watchlists across sessions

## Local Database Setup

The app uses a local SQLite database (`trading.db`) to store example stock data (symbol, name, price, change, volume, etc.) so the UI could be built and tested without a live connection.

1. Install [DB Browser for SQLite](https://sqlitebrowser.org)
2. Locate the database file, typically at:
   ```
   %LocalAppData%\DayTradingApp\trading.db
   ```
   (Press `Win + R`, paste the path above, and press Enter to jump there directly.)
3. Open `trading.db` in DB Browser to inspect or edit the local data.

## Getting Started

1. Clone the repository
2. Open `DayTradingApp.sln` in Visual Studio
3. Restore NuGet packages if prompted
4. Build and run (`F5`)

## Roadmap

Future phases connect the app to a live Supabase backend to persist user-specific data (accounts, watchlists, favorites) beyond the local SQLite store used during development.
