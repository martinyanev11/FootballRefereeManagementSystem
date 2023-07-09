var counter = 5; // Start counter at 5 seconds

function updateCounter() {
    var counterElement = document.getElementById("counter");
    counterElement.innerText = counter;

    if (counter === 0) {
        window.location.href = '/Home/Index';
    } else {
        counter--;
        setTimeout(updateCounter, 1000); // 1000 milliseconds = 1 second
    }
}