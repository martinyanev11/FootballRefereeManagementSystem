document.addEventListener("DOMContentLoaded", function () {
    let currentRole = document.querySelector('#Role').value;
    let roleDropdown = document.querySelector(".dropdown-menu-start");
    let adminAlertDiv = document.querySelector("#adminRemoveAlert");

    if (currentRole === "Администрация") {
        roleDropdown.addEventListener("change", function () {
            let selectedRole = roleDropdown.value;
            if (selectedRole !== "Администрация") {
                adminAlertDiv.style.display = "block";
            } else {
                adminAlertDiv.style.display = "none";
            }
        });
    }
});