document.addEventListener("DOMContentLoaded", function () {
    let currentRole = document.querySelector('#Role').value;
    let roleDropdown = document.querySelector(".dropdown-menu-start");
    let adminAlertDiv = document.querySelector("#adminAlert");

    roleDropdown.addEventListener("change", function () {
        let selectedRole = roleDropdown.value;
        if (selectedRole === "Администрация" && currentRole !== selectedRole) {
            adminAlertDiv.style.display = "block";
        } else {
            adminAlertDiv.style.display = "none";
        }
    });
});