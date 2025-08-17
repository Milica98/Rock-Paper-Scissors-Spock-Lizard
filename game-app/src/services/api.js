const BASE_URL = "http://localhost:5158";

export async function getChoices() {
  const res = await fetch(`${BASE_URL}/choices`);
  if(res.status === 200)
    return res.json();
  else
    return null;
}

export async function getRandomChoice() {
  const res = await fetch(`${BASE_URL}/choice`);

  if(res.status === 200)
    return res.json();
  else
    return null;
}

export async function playRound(playerChoiceId) {
  const res = await fetch(`${BASE_URL}/play`, {
    method: "POST",
    headers: { "Content-Type": "application/json" },
    body: JSON.stringify({ player: playerChoiceId })
  });
  if(res.status === 200)
    return res.json();
  else
    return null;
}
