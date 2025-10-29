

## Local Database Setup (SQLite)

The local database stores all local data for the **DayTradingApp**.
It includes tables such as `Stocks`, which contain example stock data (symbol, name, price, change, volume, etc.).

In future phases, the app will connect to a live data server and persist user-specific information like watchlists and favorites.
For now, SQLite provides a basic local database so everyone can test, browse, and experiment with data while developing the UI and logic.

---

### 1. Install DB Browser for SQLite

1. Go to [https://sqlitebrowser.org](https://sqlitebrowser.org)
2. Download and install the version for your operating system (Windows `.exe` installer is recommended).
3. Launch the app after installation.

---

### 2. Locate the Database File

The app may use one of these paths:

**Option A – Default (persistent local data storage)**

```
C:\Users\<your-username>\AppData\Local\DayTradingApp\trading.db
```

You can open this location quickly by pressing **Win + R**, typing:

```
%LocalAppData%\DayTradingApp
```
and pressing Enter.

**Option B – Debug build folder**

```
<repo-root>\DayTradingApp\bin\Debug\Data\trading.db
```

Make sure you are viewing the same file your app is connected to (check the `DatabaseHelper.cs` path).

---

### 3. Open the Database in DB Browser

1. Open DB Browser for SQLite.
2. Click **File → Open Database**.
3. Navigate to the correct `trading.db` file and click **Open**.

---

### 4. View or Edit Data

* Go to the **Browse Data** tab and select the `Stocks` table (or another table).
* Add or edit rows as needed.
* Click **Write Changes** to save any edits.

Note: Close the running app before editing to avoid “database locked” errors.

---

### 5. Run SQL Queries

* Switch to the **Execute SQL** tab.
* Example query:

  ```sql
  SELECT * FROM Stocks WHERE Sector = 'Technology';
  ```
* Press **Execute SQL** to run.

---

### 6. Export or Share the Database

If you want to share the latest database snapshot with teammates:

* Use **File → Export → Database to SQL file** and commit the `.sql` file.
* Do not commit the `.db` file directly unless the team agrees to keep it versioned (binary files are difficult to merge).

---

### 7. Troubleshooting

| Issue                        | Fix                                                          |
| ---------------------------- | ------------------------------------------------------------ |
| unable to open database file | Make sure the file exists and the folder path is valid       |
| Edits not appearing          | Confirm the app and DB Browser are using the same `.db` file |
| Database locked              | Close the app or stop debugging in Visual Studio             |
| Database not created         | Run the app once; it will auto-create the database           |

---


* [ ] Install DB Browser for SQLite
* [ ] Build and run the app once to generate the database
* [ ] Open the database in DB Browser
* [ ] Browse the `Stocks` table to verify contents
* [ ] Close the app before editing
* [ ] Export changes as `.sql` if sharing with others

---

**Optional:**
If the team later moves the database to a shared `Data` folder, the path will be:

```
<repo-root>\DayTradingApp\Data\trading.db
```

Update `DatabaseHelper.cs` accordingly and ensure the folder is included in source control.
