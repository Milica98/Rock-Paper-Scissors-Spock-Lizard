import { useEffect, useState } from "react";
import { getChoices, playRound, getRandomChoice } from "../services/api";
import "./Game.css";

function Game() {
  const [choices, setChoices] = useState([]);
  const [loading, setLoading] = useState(false);
  const [playerChoice, setPlayerChoice] = useState(null);
  const [computerChoice, setComputerChoice] = useState(null);
  const [result, setResult] = useState(null);

  useEffect(() => {
    getChoices().then(setChoices);
  }, []);

  const onResult = (result) => {
    setPlayerChoice(choices[result.player - 1].name);
    setComputerChoice(choices[result.computer - 1].name);
    setResult(result.results);
  };

  const handlePlay = async (choiceId) => {
    setLoading(true);
    const result = await playRound(choiceId);
    if (!result) alert("Something went wrong: Unable to fetch the result");
    else onResult(result);
    setLoading(false);
  };

  const handleRandomPlay = async () => {
    setLoading(true);
    const randomChoice = await getRandomChoice();
    if (!randomChoice)
      alert("Something went wrong: Unable to fetch the random choice");
    else {
      const result = await playRound(randomChoice.id);
      if (!result) alert("Something went wrong: Unable to fetch the result");
      else onResult(result);
    }
    setLoading(false);
  };

  let resultLine = null;
  if (playerChoice && computerChoice && result) {
    resultLine = (
      <div className={"result " + result}>
        You played {playerChoice} &amp; the computer played {computerChoice}.{" "}
        <br />
        <div style={{ marginTop: "1rem" }}>{result.toUpperCase()}!</div>
      </div>
    );
  }

  let randomChoiceButton = null;
  if (choices && choices.length > 0) {
    randomChoiceButton = (
      <button onClick={handleRandomPlay} disabled={loading}>
        Random Choice
      </button>
    );
  }

  let gameBoard = null;
  if (!choices) {
    gameBoard = <div>Error loading choices. Please try again later.</div>;
  } else if (choices.length === 0) {
    gameBoard = <div>Loading choices...</div>;
  } else {
    gameBoard = (
      <div>
        <h2>Choose your weapon</h2>
        <div
          style={{
            display: "flex",
            gap: "1rem",
            justifyContent: "center",
            marginBottom: "1rem",
          }}
        >
          {choices.map((choice) => (
            <button
              key={choice.id}
              onClick={() => handlePlay(choice.id)}
              disabled={loading}
            >
              {choice.name}
            </button>
          ))}
        </div>
        {randomChoiceButton}
        {resultLine}
      </div>
    );
  }

  return gameBoard;
}

export default Game;
