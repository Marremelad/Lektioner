// https://rickandmortyapi.com/api/character
const characterPicture = document.querySelector("#character-picture");
const characterName = document.querySelector("#character-name");
const generateCharacterButton = document.querySelector("#generate-character-button")

function displayCharacterInfo(character) {
    characterPicture.src = character.image;
    characterName.textContent = character.name
}

function getRandomCharacter(data) {
    const character = data.results[Math.floor(Math.random() * data.results.length)];
    displayCharacterInfo(character);
}

async function getRickAndMortyCharacter() {
    try {
        const response = await fetch("https://rickandmortyapi.com/api/character");
        const data = await response.json();
        getRandomCharacter(data);
    } catch (e) {
        console.log(e);
        console.log("Something went wrong :(");
    }
}

generateCharacterButton.addEventListener("click", () => {
    getRickAndMortyCharacter()
})
