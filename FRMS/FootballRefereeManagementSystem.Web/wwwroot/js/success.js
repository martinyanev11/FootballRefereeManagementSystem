// This fuction takes the innerText of HTML element with id = counter and starts a countdown.
// When time is done, it will redirect to home page
function updateCounter() {
    var counterElement = document.getElementById("counter");
    var counter = parseInt(counterElement.innerText);

    if (counter === 0) {
        window.location.href = '/Home/Index';
    } else {
        counter--;
        counterElement.innerText = counter;
        setTimeout(updateCounter, 1000); // 1000 milliseconds = 1 second
    }
}

// Start the countdown timer
updateCounter();