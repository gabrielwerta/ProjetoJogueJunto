function ponto(team) {
  const scoreA = document.getElementById("scoreA");
  const scoreB = document.getElementById("scoreB");

  if (team === "A") {
    scoreA.value = parseInt(scoreA.value) + 1;
  } else if (team === "B") {
    scoreB.value = parseInt(scoreB.value) + 1;
  }
}
