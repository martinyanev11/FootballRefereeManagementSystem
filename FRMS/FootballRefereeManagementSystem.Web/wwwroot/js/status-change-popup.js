function openStatusChangeDialog(event) {
    event.preventDefault(); // Prevents the default action of the link
    let confirmationDialog = document.getElementById("statusChangeMenu");
    confirmationDialog.style.display = "block";
}

function submitStatus(isConfirmed) {
    let confirmationDialog = document.getElementById("statusChangeMenu");
    confirmationDialog.style.display = "none";

    if (isConfirmed) {
        let statusChangeAction = document.getElementById("status");
        window.location.href = statusChangeAction.href;
    }
}