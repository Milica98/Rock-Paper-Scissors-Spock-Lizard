@echo off

echo Checking frontend dependencies...
cd game-app
IF NOT EXIST node_modules (
    echo Installing npm dependencies...
    call npm install
    echo Npm dependencies Installed
)
cd ..

echo Starting the RPSLSGame Service...
start cmd /k "cd GameService/RPSLSGame && dotnet run"

echo Starting the game-app...
start cmd /k "cd game-app && npm start"

exit