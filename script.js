
function CheckPoints(points) {
    if (points === 7) {
        return "Congratulations, you got the max score!"
    }
}

let colors = ["Blue", "Red", "Green"];
let animals = ["Leopard", "Elephant", "Eagle"]
let earlyRiser = [true, false];

let points = 0;

let favoriteAnimal = animals[Math.floor(Math.random() * animals.length)];
let favoriteColor = colors[Math.floor(Math.random() * colors.length)];
let roseEarly = earlyRiser[Math.floor(Math.random() * earlyRiser.length)];

// let favoriteColor = "Blue";
// let favoriteAnimal = "Leopard";
// let roseEarly = true;

if (favoriteColor === "Blue") {
    points++
}

if (favoriteAnimal === "Leopard") {
    points++
}

if (roseEarly === true) {
    points++
}

if (favoriteColor === "Blue" && favoriteAnimal === "Leopard") {
    points += 3

    if (roseEarly === true) {
        points++
    }
}

let message = CheckPoints(points)

if (message) {
    document.getElementById("text").textContent = points
    document.getElementById("max-score").textContent = message
    document.getElementById("color").textContent = favoriteColor
    document.getElementById("animal").textContent = favoriteAnimal
    document.getElementById("early-riser").textContent = roseEarly
}
else {
    console.log(points)
    document.getElementById("text").textContent = points
    document.getElementById("color").textContent = favoriteColor
    document.getElementById("animal").textContent = favoriteAnimal
    document.getElementById("early-riser").textContent = roseEarly
}




