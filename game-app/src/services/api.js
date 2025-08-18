import { config } from "../Constants";

export async function getChoices() {
  const res = await fetch(`${config.gameService.BASE_URL}/choices`).catch(
    () => null
  );

  if (res && res.status === 200) return res.json();
  else return null;
}

export async function getRandomChoice() {
  const res = await fetch(`${config.gameService.BASE_URL}/choice`).catch(
    () => null
  );

  if (res && res.status === 200) return res.json();
  else return null;
}

export async function playRound(playerChoiceId) {
  const res = await fetch(`${config.gameService.BASE_URL}/play`, {
    method: "POST",
    headers: { "Content-Type": "application/json" },
    body: JSON.stringify({ player: playerChoiceId }),
  }).catch(() => null);

  if (res && res.status === 200) return res.json();
  else return null;
}
