# Rock-Paper-Scissors-Spock-Lizard

## Download & Setup

1. **Clone the repository:**
   ```
   git clone https://github.com/Milica98/Rock-Paper-Scissors-Spock-Lizard.git
   ```
2. **Install .NET SDK:**  
   Download and install [.NET SDK](https://dotnet.microsoft.com/download)

3. **Install Node.js & npm:**  
   Download and install [Node.js](https://nodejs.org/) (includes npm).

## Running the Application

1. **Start both backend and frontend by script:**  
   Double-click `RPSLSGame_Runner.cmd` or run it from the command line.

   This will:
   - Install frontend dependencies
   - Start the .NET backend
   - Start the React frontend
   - Open the app in your browser at [http://localhost:3000](http://localhost:3000)

2. **Start frontend manualy:**  
    - Open Command Prompt
    - Navigate to cloned Rock-Paper-Scissors-Spock-Lizard folder
    - Navigate to game-app folder
    - If dependencies in game-app are not installed (node_modules), run command `npm install`
    - Run command `npm start`

3. **Start backend manualy:**  
    - Open Command Prompt
    - Navigate to cloned Rock-Paper-Scissors-Spock-Lizard folder
    - Navigate to GameService\RPSLSGame
    - Run command `dotnet run`

## Notes

- Make sure ports 3000 (frontend) and your backend port are available.
