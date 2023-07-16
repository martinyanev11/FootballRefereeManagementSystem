function showConfirmationDialog(event) {
    event.preventDefault();
    let confirmationDialog = document.getElementById("confirmationDialog");
    confirmationDialog.style.display = "block";
}

function submitForm(isConfirmed) {
    let confirmationDialog = document.getElementById("confirmationDialog");
    confirmationDialog.style.display = "none";

    if (isConfirmed) {
        document.getElementById("form").submit();
    }
}