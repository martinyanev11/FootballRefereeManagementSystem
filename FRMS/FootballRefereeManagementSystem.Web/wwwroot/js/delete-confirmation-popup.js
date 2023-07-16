function openConfirmationDialog(event) {
    event.preventDefault(); // Prevents the default action of the link
    let confirmationDialog = document.getElementById("confirmationDialog");
    confirmationDialog.style.display = "block";
}

function submitForm(isConfirmed) {
    let confirmationDialog = document.getElementById("confirmationDialog");
    confirmationDialog.style.display = "none";

    if (isConfirmed) {
        let deleteLink = document.getElementById("deleteAction");
        window.location.href = deleteLink.href; // Trigger the "Delete" action by redirecting to the link's href
    }
}