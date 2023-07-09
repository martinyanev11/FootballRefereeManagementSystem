function showConfirmationDialog(event) {
    event.preventDefault();
    var confirmationDialog = document.getElementById("confirmationDialog");
    confirmationDialog.style.display = "block";
}

function submitForm(isConfirmed) {
    var confirmationDialog = document.getElementById("confirmationDialog");
    confirmationDialog.style.display = "none";

    if (isConfirmed) {
        document.getElementById("form").submit();
    }
}